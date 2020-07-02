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
                            new VehicleItem();
                            VehicleItem.LoadColumns(cols);
                            break;
                        case Log:
                            new LogItem();
                            LogItem.LoadColumns(cols);
                            break;
                        case FavStations:
                            new StationItem();
                            StationItem.LoadColumns(cols);
                            break;
                        default:
                            datasetName = "";
                            break;
                    }
                    continue;
                }
                OneRow r;
                switch (datasetName)
                {
                    case Vehicle:
                        r = new VehicleItem();
                        break;
                    case Log:
                        r = new LogItem();
                        break;
                    case FavStations:
                        r = new StationItem();
                        break;
                    default:
                        continue;
                }
                r.ParseRow(line);
                DataSets[datasetName].Add(r);
            }
            file.Close();
        }
    }
}
