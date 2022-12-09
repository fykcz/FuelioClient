using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;

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
            StreamReader file = null;

            if (Path.GetExtension(fileName) == ".zip")
            {
                using (FileStream zipFile = File.OpenRead(fileName))
                {
                    using (var zipArchive = new ZipArchive(zipFile, ZipArchiveMode.Read))
                    {
                        var entryName = Path.GetFileNameWithoutExtension(fileName);
                        var haveEntry = false;
                        foreach (var z in zipArchive.Entries)
                        {
                            if (z.Name == entryName)
                            {
                                haveEntry = true;
                                break;
                            }
                        }
                        if (!haveEntry) return;
                        var zipEntry = zipArchive.GetEntry(entryName);
                        //var sr = new StreamReader(zipEntry.Open());
                        var txt = (new StreamReader(zipEntry.Open())).ReadToEnd();
                        byte[] byteArray = Encoding.ASCII.GetBytes(txt);
                        file = new StreamReader(new MemoryStream(byteArray));
                    }
                }
            }
            else
                file = new StreamReader(fileName);

            DataSets = new Dictionary<string, List<OneRow>>();
            //var file = new System.IO.StreamReader(fileName);
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
                    DataSets.Add(datasetName, new List<OneRow>());
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
