using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace FYK.Utils.FuelioClient
{
    internal class LogItem : OneRow
    {
        [Description("Data")]
        public DateTime Data { get; set; }

        [Description("Odo (km)")]
        public int Odo { get; set; }

        [Description("Fuel (litres)")]
        public decimal Fuel { get; set; }
        
        [Description("Full")]
        public bool Full { get; set; }
        
        [Description("Price (optional)")]
        public decimal Price { get; set; }

        [Description("l/100km (optional)")]
        public decimal LpHKm { get; set; }

        [Description("latitude (optional)")]
        public decimal Latitude { get; set; }

        [Description("longitude (optional)")]
        public decimal Longitude { get; set; }

        [Description("City (optional)")]
        public string City { get; set; }

        [Description("Notes (optional)")]
        public string Notes { get; set; }

        [Description("Missed")]
        public bool Missed { get; set; }

        [Description("TankNumber")]
        public int TankNumber { get; set; }

        [Description("FuelType")]
        public int FuelType { get; set; }

        [Description("VolumePrice")]
        public decimal VolumePrice { get; set; }

        [Description("StationID (optional)")]
        public int StationID { get; set; }

        [Description("ExcludeDistance")]
        public decimal ExcludeDistance { get; set; }

        [Description("UniqueId")]
        public int UniqueId { get; set; }

        [Description("TankCalc")]
        public decimal TankCalc { get; set; }

        public LogItem() : base() { }
        public LogItem(Dictionary<string, PropertyMap> properties, List<PropertyMap> columns) : base(properties, columns) { }

        public override OneRow GetInstance()
        {
            return new LogItem(_properties, _columns);
        }
    }
}
