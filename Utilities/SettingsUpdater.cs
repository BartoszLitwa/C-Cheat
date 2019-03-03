using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZBase.Classes;

namespace ZBase.Utilities
{
    class SettingsUpdater
    {
        public static void GetSettingsFromFileLegit()
        {
            Settings deafaultSettings = new Settings();

            string DefSettings = JsonConvert.SerializeObject(deafaultSettings, Formatting.Indented);
            if (File.Exists("SettingsLegit.json") == false)
            {
                File.WriteAllText("SettingsLegit.json", DefSettings);
            }
            string json = File.ReadAllText("SettingsLegit.json");
            Main.S = JsonConvert.DeserializeObject<Settings>(json);
        }
        public static void GetSettingsFromFileRage()
        {
            Settings deafaultSettings = new Settings();

            string DefSettings = JsonConvert.SerializeObject(deafaultSettings, Formatting.Indented);
            if (File.Exists("SettingsRage.json") == false)
            {
                File.WriteAllText("SettingsRage.json", DefSettings);
            }
            string json2 = File.ReadAllText("SettingsRage.json");
            Main.S = JsonConvert.DeserializeObject<Settings>(json2);
        }
        public static void SaveSettingsLegit(Settings set)
        {
            string settings = JsonConvert.SerializeObject(set, Formatting.Indented);
            File.WriteAllText("SettingsLegit.json", settings);
        }
        public static void SaveSettingsRage(Settings set)
        {
            string settings = JsonConvert.SerializeObject(set, Formatting.Indented);
            File.WriteAllText("SettingsRage.json", settings);
        }
    }
}
