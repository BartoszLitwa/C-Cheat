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
                OffsetUpdater.UpdateCheatStatus();
                OffsetUpdater.GetConfigFromFile();
                if (Main.C.MyCheat)
                { }
                if(!Main.C.MyCheat)
                {
                    Environment.Exit(1);
                }

                Thread.Sleep(10000);
            }
        }
    }
}
