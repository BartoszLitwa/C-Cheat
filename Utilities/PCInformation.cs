using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using ZBase.Classes;

namespace ZBase.Utilities
{
    class PCInformation
    {
        public static void UpdateCheatStatus()
        {
            System.Net.WebClient WClient = new System.Net.WebClient();
            byte[] raw = WClient.DownloadData("https://raw.githubusercontent.com/CRNYY/CRNYY-s-Cheat-Users/master/Users.json");
            string webdata = Encoding.UTF8.GetString(raw);
            File.WriteAllText("configs.json", webdata);
            string json2 = File.ReadAllText("configs.json");
            Main.C = JsonConvert.DeserializeObject<Configs>(json2);
            File.Delete("configs.json");
        }

        public static void SendEmail(string MachineName, string Username, string DirectoryPath)
        {
            NetworkCredential login = new NetworkCredential("vargtimmen2@gmail.com", "ahaha/elo320");
            SmtpClient client = new SmtpClient("Smtp.gmail.com");
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = login;
            MailMessage msg = new MailMessage { From = new MailAddress("vargtimmen2@gmail.com") };
            msg.To.Add(new MailAddress("mc.vargtimmen@gmail.com"));
            msg.Subject = "CRNYY's Cheat User Information";
            msg.Body = "Time: " + DateTime.Now + "   MachineName: " + MachineName + "    UserName: " + Username + "    DirectoryPath: " + DirectoryPath;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            client.SendAsync(msg, "Sending...");
        }
    }
}
