using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;

using Microsoft.VisualBasic.FileIO;

namespace FYK.Utils.FuelioClient
{
    internal class OneRow
    {
        //protected string _dataRow;
        protected static Dictionary<string, PropertyMap> _properties;
        public static List<PropertyMap> Columns;

        public OneRow()
        {
            _properties = new Dictionary<string, PropertyMap>();
            foreach (var pi in this.GetType().GetProperties())
            {
                var pname = pi.Name;
                var cname = "";
                var da = pi.GetCustomAttribute(typeof(DescriptionAttribute));
                if (da != null)
                    cname = ((DescriptionAttribute)da).Description;
                else
                    continue;
                var type = pi.PropertyType.Name;
                var pm = new PropertyMap(cname, pname, type, pi);
                _properties.Add(cname, pm);
            }
        }

        public static void LoadColumns(string row)
        {
            Columns = new List<PropertyMap>();
            var cols = GetParts(row);
            foreach (var c in cols)
            {
                if (_properties.ContainsKey(c))
                    Columns.Add(_properties[c]);
                else
                    throw new InvalidDataException($"Property for column '{c}' not found");
            }
        }
        protected static DateTime GetDateTime(string part)
        {
            DateTime dt;
            CultureInfo ci = CultureInfo.InvariantCulture;
            if (DateTime.TryParseExact(part, "yyyy-MM-dd HH:mm", ci, DateTimeStyles.None, out dt))
            {
                return dt;
            }
            else
                throw new FormatException($"Input part ${part} is not a valid DateTime");
        }
        protected static int GetInt(string part)
        {
            var pp = part.Split('.');
            return Convert.ToInt32(pp[0]);
        }
        protected static decimal GetDecimal(string part)
        {
            if (part != "")
                return Convert.ToDecimal(part.Replace('.', ','));
            else
                return 0.0M;
        }
        protected static bool GetBool(string part)
        {
            return part.Equals("1");
        }

        protected static string[] GetParts(string row)
        {
            TextFieldParser parser = new TextFieldParser(new StringReader(row))
            {
                HasFieldsEnclosedInQuotes = true
            };
            parser.SetDelimiters(",");

            var fields = parser.ReadFields();

            parser.Close();
            return fields;
        }

        public void ParseRow(string row)
        {
            var parts = GetParts(row);
            for (var i = 0; i < parts.Length; i++)
            {
                var pm = Columns[i];
                switch (pm.DataType)
                {
                    case "Decimal":
                        pm.PropertyInfo.SetValue(this, GetDecimal(parts[i]));
                        break;
                    case "Int32":
                        pm.PropertyInfo.SetValue(this, GetInt(parts[i]));
                        break;
                    case "DateTime":
                        pm.PropertyInfo.SetValue(this, GetDateTime(parts[i]));
                        break;
                    case "String":
                        pm.PropertyInfo.SetValue(this, parts[i]);
                        break;
                    case "Boolean":
                        pm.PropertyInfo.SetValue(this, GetBool(parts[i]));
                        break;
                    default:
                        throw new InvalidDataException($"Invalid data type '{pm.DataType}' for column '{pm.ColumnName}'");
                }
            }
        }

        public string GetColumnValue(string columnName)
        {

            if (!_properties.ContainsKey(columnName))
                throw new InvalidDataException($"Unknown column '{columnName}'");
            var pm = _properties[columnName];
            return pm.PropertyInfo.GetValue(this).ToString();
        }

        internal class PropertyMap
        {
            public string ColumnName { get; private set; }
            public string PropertyName { get; private set; }
            public string DataType { get; private set; }
            public PropertyInfo PropertyInfo { get; private set; }

            public PropertyMap(string columnName, string propertyName, string dataType, PropertyInfo propertyInfo)
            {
                ColumnName = columnName;
                PropertyName = propertyName;
                DataType = dataType;
                PropertyInfo = propertyInfo;
            }
        }
    }

}
