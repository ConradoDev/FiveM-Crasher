﻿using System;
using Process.NET;
using Process.NET.Memory;
using Process.NET.Patterns;
using FiveM.Utils;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FiveM.Game {
    class MemoryReader {

        //patterns
        internal static readonly IMemoryPattern WorldPTR =
        new DwordPattern("48 8B 05 ?? ?? ?? ?? 45 ?? ?? ?? ?? 48 8B 48 08 48 85 C9 74 07");

        internal static ProcessSharp process;
        internal static ExternalProcessMemory mem;

        public static Task GetAdresses() {
            process = new ProcessSharp(Utilities.BaseProc(), MemoryType.Remote);
            mem = new ExternalProcessMemory(process.Handle);

            bool b2189 = Utilities.BaseProc().ProcessName.Contains("b2189");

            //WorldPtr
            IntPtr addr = Find(process.ModuleFactory.MainModule.Name, MemoryReader.WorldPTR, process).ReadAddress;
            addr = addr + mem.Read<int>(addr + 3) + 7;
            IntPtr WorldPtr = mem.Read<IntPtr>(addr);
            Addresses.WorldPtr = WorldPtr;

            //LocalPlayer
            IntPtr LocalPlayer = mem.Read<IntPtr>(WorldPtr + 0x8);
            Addresses.LocalPlayer = LocalPlayer;

            //PlayerModel
            IntPtr v1 = mem.Read<IntPtr>(LocalPlayer + 0x50);
            IntPtr v2 = b2189 ? mem.Read<IntPtr>(v1 + 0x20) : mem.Read<IntPtr>(v1 + 0x40);
            IntPtr v3 = b2189 ? mem.Read<IntPtr>(v2 + 0x0) : mem.Read<IntPtr>(v2 + 0x8);
            IntPtr v4 = mem.Read<IntPtr>(v3 + 0x20);
            IntPtr PlayerModel = v4 + 0x18;
            Addresses.PlayerModel = PlayerModel;

            return Task.CompletedTask;
        }

        internal static PatternScanResult Find(string moduleName, IMemoryPattern pattern, ProcessSharp prcss) {
            var scanner = new PatternScanner(prcss[moduleName]);
            return scanner.Find(pattern);
        }
    }
}
