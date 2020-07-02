using System.Collections.Generic;
using System.ComponentModel;

namespace FYK.Utils.FuelioClient
{
    internal class VehicleItem : OneRow
    {
        private string _icsv;

        [Description("Name")]
        public string Name { get; set; }

        [Description("Description")]
        public string Description { get; set; }

        [Description("DistUnit")]
        public int DistUnit { get; set; }

        [Description("FuelUnit")]
        public int FuelUnit { get; set; }

        [Description("ConsumptionUnit")]
        public int ConsumptionUnit { get; set; }

        [Description("ImportCSVDateFormat")]
        public string ImportCSVDateFormat { get { return _icsv; } set { _icsv = _importCSVDateFormat = value; } }

        [Description("VIN")]
        public string VIN { get; set; }

        [Description("Insurance")]
        public string Insurance { get; set; }

        [Description("Plate")]
        public string Plate { get; set; }

        [Description("Make")]
        public string Make { get; set; }
        
        [Description("Model")]
        public string Model { get; set; }

        [Description("Year")]
        public int Year { get; set; }

        [Description("TankCount")]
        public int TankCount { get; set; }

        [Description("Tank1Type")]
        public int Tank1Type { get; set; }

        [Description("Tank2Type")]
        public int Tank2Type { get; set; }

        [Description("Active")]
        public bool Active { get; set; }

        [Description("Tank1Capacity")]
        public decimal Tank1Capacity { get; set; }

        [Description("Tank2Capacity")]
        public decimal Tank2Capacity { get; set; }

        [Description("FuelUnitTank2")]
        public int FuelUnitTank2 { get; set; }

        [Description("FuelConsumptionTank2")]
        public int FuelConsumptionTank2 { get; set; }

        public VehicleItem() : base() { }
        public VehicleItem(Dictionary<string, PropertyMap> properties, List<PropertyMap> columns) : base(properties, columns) { }
        public override OneRow GetInstance()
        {
            return new VehicleItem(_properties, _columns);
        }

    }
}
