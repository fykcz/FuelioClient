using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FYK.Utils.FuelioClient
{
    internal class FileData
    {
        private const string Vehicle = "Vehicle";
        private const string Log = "Log";
        private const string FavStations = "FavStations";

        public Dictionary<string, List<OneRow>> DataSets;

        public void LoadFile(string fileName)
        {
            DataSets = new Dictionary<string, List<OneRow>>();
            var file = new System.IO.StreamReader(fileName);
            var rx = new Regex("^\"## (.*)\"", RegexOptions.IgnoreCase);
            string line;
            var datasetName = "";
            OneRow columnsHolder = null;

            while ((line = file.ReadLine()) != null)
            {
                var m = rx.Match(line);
                if (m.Success)
                {
                    datasetName = m.Groups[1].Value;
                    DataSets.Add(datasetName,  new List<OneRow>());
                    var cols = file.ReadLine();
                    switch (datasetName)
                    {
                        case Vehicle:
                            columnsHolder = new VehicleItem();
                            break;
                        case Log:
                            columnsHolder = new LogItem();
                            break;
                        case FavStations:
                            columnsHolder = new StationItem();
                            break;
                        default:
                            datasetName = "";
                            columnsHolder = null;
                            continue;
                    }
                    columnsHolder.LoadColumns(cols);
                    continue;
                }
                if (columnsHolder != null)
                {
                    OneRow r = columnsHolder.GetInstance();
                    r.ParseRow(line);
                    DataSets[datasetName].Add(r);
                }
            }
            file.Close();
        }
    }
}
