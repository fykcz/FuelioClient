using System.Collections.Generic;
using System.ComponentModel;

namespace FYK.Utils.FuelioClient
{
    internal class StationItem : OneRow
    {
        [Description("NameBrand")]
        public string NameBrand { get; set; }
        [Description("Latitude")]
        public decimal Latitude { get; set; }
        [Description("Longitude")]
        public decimal Longitude { get; set; }
        [Description("StationID")]
        public int StationID { get; set; }
        [Description("Description")]
        public string Description { get; set; }
        [Description("CountryCode")]
        public string CountryCode { get; set; }

        public StationItem() : base() { }
        public StationItem(Dictionary<string, PropertyMap> properties, List<PropertyMap> columns) : base(properties, columns) { }
        public override OneRow GetInstance()
        {
            return new StationItem(_properties, _columns);
        }

    }
}
