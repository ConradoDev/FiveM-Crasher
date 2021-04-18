﻿using System;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using FiveM.Game;
using FiveM.Devices;
using FiveM.Utils;

namespace FiveM {
    public partial class Menu : MaterialForm {

        bool _ModelChanged;
        bool _HOOKED;

        long ACRatModel = 3283429734;
        long CurrentModel;

        Communication.Message msg = new Communication.Message();

        public Menu() {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple600, Primary.Purple800, Primary.Purple500, Accent.Purple700, TextShade.WHITE);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            AppendLog("Looking for FiveM Process...", Color.BlueViolet);
        }

        private void AppendLog(string str, Color color) {
            if(statusLabel.Text != "") {
                statusLabel.AppendText("\n");
            }

            statusLabel.SelectionStart = statusLabel.TextLength;
            statusLabel.SelectionLength = 0;
            statusLabel.SelectionFont = new Font("Roboto", 11, FontStyle.Bold);
            statusLabel.SelectionColor = color;
            statusLabel.AppendText($" [{DateTime.Now.ToString("HH:mm:ss")}]: {str}");
            statusLabel.SelectionColor = statusLabel.ForeColor;
        }

        private void helpBtn_Click(object sender, EventArgs e) {
            msg.ShowDialog();
        }

        private async void AntiFlood() {
            mutateBtn.Enabled = false;
            await Task.Delay(1000);
            mutateBtn.Enabled = true;
        }

        private void topMost_CheckedChanged(object sender, EventArgs e) {
            if(!topMost.Checked) {
                this.TopMost = false;
                return;
            }
            this.TopMost = true;
        }

        private void ChangeModel() {
            _ModelChanged = !_ModelChanged;

            if(Addresses.PlayerModel == IntPtr.Zero) {
                AppendLog("An error ocurred. Maybe you aren't in-game.", Color.IndianRed);
                return;
            }

            try {
                if(_ModelChanged) {
                    CurrentModel = MemoryReader.mem.Read<long>(Addresses.PlayerModel);
                    MemoryReader.mem.Write(Addresses.PlayerModel, ACRatModel);
                    AppendLog("Now you'll crash players if you jump near them.", Color.Orange);

                } else {
                    MemoryReader.mem.Write(Addresses.PlayerModel, CurrentModel);
                    AppendLog("Crasher disabled. Back to player model.", Color.CadetBlue);
                }
            } catch(Exception) { AppendLog("Sorry, an error ocurred.", Color.IndianRed); }
        }

        private void mutateBtn_Click(object sender, EventArgs e) {
            AntiFlood();
            ChangeModel();
        }

        //50ms
        private async void On_Tick(object sender, EventArgs e) {
            System.Diagnostics.Process p = Utilities.BaseProc();

            if(mutateBtn.Enabled && Keyboard.IsKeyDown(Keys.Insert) && p != null) {
                AntiFlood();
                ChangeModel();
            }

            if(p != null && !_HOOKED) {
                _HOOKED = !_HOOKED;
                Addresses.WorldPtr = IntPtr.Zero;
                Addresses.LocalPlayer = IntPtr.Zero;
                Addresses.PlayerModel = IntPtr.Zero;

                int _processid = p.Id;
                AppendLog($"FiveM Found! PID: {_processid}", Color.Green);

                //player model instanced?
                while(Addresses.PlayerModel == IntPtr.Zero) {
                    try {
                        await Task.Run(MemoryReader.GetAdresses);
                        AppendLog($"WorldPTR => 0x{Utilities.ToHex(Addresses.WorldPtr)}", Color.Olive);
                        mutateBtn.Enabled = true;
                    } catch(Exception) { }
                    await Task.Delay(10000);
                }              
            }   

            if(p == null && _HOOKED) {
                _HOOKED = !_HOOKED;
                mutateBtn.Enabled = false;
                AppendLog("Looking for FiveM Process...", Color.BlueViolet);
            }

            if(_HOOKED) {               
                try {
                    currModel.Text = MemoryReader.mem.Read<long>(Addresses.PlayerModel).ToString();
                } catch(Exception) { currModel.Text = "None"; }

            }
        }

        private void statusLabel_TextChanged(object sender, EventArgs e) {
            statusLabel.SelectionStart = statusLabel.Text.Length;
            statusLabel.ScrollToCaret();
        }

        private void materialButton1_Click(object sender, EventArgs e) {
            statusLabel.Clear();
        }

    }
}
