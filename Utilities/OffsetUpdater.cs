
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZBase.Classes;

namespace ZBase.Utilities
{
    // hazedumper auto offset updater - veri cool
    public class OffsetUpdater
    {
        public static void GetOffsetsFromFile()
        {
            string json = File.ReadAllText("csgo.json");
            Main.O = JsonConvert.DeserializeObject<RootObject>(json);
        }
        public static void GetConfigFromFile()
        {
            Configs defaultConfigs = new Configs();

            string DefConfigs = JsonConvert.SerializeObject(defaultConfigs, Formatting.Indented);
            if (File.Exists("configs.json") == false)
            {
                File.WriteAllText("configs.json", DefConfigs);
            }
            string json2 = File.ReadAllText("configs.json");
            Main.C = JsonConvert.DeserializeObject<Configs>(json2);
        }

        public static void UpdateOffsets()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.json");
            string webData = Encoding.UTF8.GetString(raw);
            File.WriteAllText("csgo.json", webData);
            GetOffsetsFromFile();
        }
        public static void UpdateCheatStatus()
        {
            System.Net.WebClient WClient = new System.Net.WebClient();
            byte[] raw = WClient.DownloadData("https://raw.githubusercontent.com/CRNYY/CRNYY-s-Cheat-Users/master/Users.json");
            string webdata = Encoding.UTF8.GetString(raw);
            File.WriteAllText("configs.json", webdata);
        }
    }
}
