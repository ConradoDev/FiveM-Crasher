﻿using System;
using System.Collections.Generic;

namespace FiveM.Utils {
    class Utilities {

        private static System.Diagnostics.Process p;
        private static HashSet<string> ProcList = new HashSet<string>();

        public static System.Diagnostics.Process BaseProc() {
            ReadProcs();
            return p;
        }

        public static string ToHex(IntPtr d) {
            return d.ToString("X");
        }

        private static void ReadProcs() {
            //1604
            ProcList.Add("FiveM_GTAProcess");

            //2189
            ProcList.Add("FiveM_b2189_GTAProcess");

            var procs = System.Diagnostics.Process.GetProcesses();
            foreach(System.Diagnostics.Process prc in procs) {
                if(ProcList.Contains(prc.ProcessName)) {
                    p = prc;
                    return;
                }
                p = null;
            }

        }

    }

}
