﻿using System;
using System.Runtime.InteropServices;

namespace FiveM.Modules {
    class NativeImport {

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetKeyState(int keyCode);

    }
}
