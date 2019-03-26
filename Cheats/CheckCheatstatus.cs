using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZBase.Utilities;

namespace ZBase.Cheats
{
    class CheckCheatstatus
    {
        public static void Run()
        {
            while (true)
            {
                Thread.Sleep(60000);
                PCInformation.UpdateCheatStatus();
                if (Main.C.MyCheat)
                { break; }
                else
                {
                    Environment.Exit(1);
                }
            }
        }
    }
}
