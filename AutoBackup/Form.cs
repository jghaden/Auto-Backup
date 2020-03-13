using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup {
    public partial class Form : System.Windows.Forms.Form {

        private int _ticks;
        private int timeMins;
        private int countDownMins;
        private int countDownSecs;
        private string sourceFolderPath;
        private string backupFolderPath;
        private string oldBackup1;
        private string oldBackup2;
        private int exit = 0;

        public Form() {
            InitializeComponent();
            
            //countdownTextBox.Text = timerBox.Value.ToString();
        }

        private void openFolderButton_Click(object sender, EventArgs e) {
            //Selects the folder to backup
            folderBrowserDialog.Description = "Select the folder you wish to back up";
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                folderPathTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void backupButton_Click(object sender, EventArgs e) {
            //Selects the backup folder
            backupFolderDialog.Description = "Select the folder you wish to have the back up stored";
            if (backupFolderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                backupPathTextBox.Text = backupFolderDialog.SelectedPath;
            }
        }

        private void enableDisableButton_Click(object sender, EventArgs e) {
            //Enables or disables backup
            if (enableDisableButton.Text == "Enable") {
                if (folderPathTextBox.Text == "") {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("There must be a folder selected in order to back up");
                } 
                else if(backupPathTextBox.Text == "") {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("There must be a folder to back up to");
                } else {
                    this.Text = "AutoBackup (Running)";
                    notifyIcon.Text = "AutoBackup (Running)";
                    enableDisableButton.Text = "Disable";
                    enableDisableButton.ForeColor = Color.Red;
                    timeMins = Convert.ToInt32(Math.Round(timerBox.Value, 0));
                    countDownSecs = 60;
                    timer.Start();
                }
            } else {
                this.Text = "AutoBackup";
                notifyIcon.Text = "AutoBackup";
                enableDisableButton.Text = "Enable";
                enableDisableButton.ForeColor = Color.Green;
                timer.Stop();
                //_ticks = 0;
            }    
        }

        private void timer_Tick(object sender, EventArgs e) {
            //Runs the following code every 60000 ms or 1 minute (core of the program)
            if (countDownSecs > 0)
                countDownSecs--;
            else
                countDownSecs = 59;
            if (_ticks <= 0)
                countDownMins = timeMins - 1;
            else if (_ticks % 60 == 0) {
                countDownMins--;
                countdownTextBox.Text = "Test";
            }
            if(countDownSecs > 9)
                countdownTextBox.Text = countDownMins.ToString() + ":" + countDownSecs.ToString();
            else
                countdownTextBox.Text = countDownMins.ToString() + ":0" + countDownSecs.ToString();
            _ticks++;
            var time = DateTime.Now;
            string fTime = time.ToString("MM-dd-yyyy, hh.mm.ss tt");
            backupFolderPath = backupPathTextBox.Text + "\\(AutoBackup - " + fTime + ")";
            sourceFolderPath = folderPathTextBox.Text;
            if (_ticks >= timeMins * 60) {
                //If the selected path for the source and backup exist, the following code will run
                if (System.IO.Directory.Exists(sourceFolderPath)) {
                    System.IO.Directory.CreateDirectory(backupFolderPath);
                    //Copies every folder from the source to the new backup
                    foreach (string dirPath in Directory.GetDirectories(sourceFolderPath, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory((dirPath.Replace(sourceFolderPath, backupFolderPath)));
                    //Copies every file from the source to the new backup
                    foreach (string newPath in Directory.GetFiles(sourceFolderPath, "*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(sourceFolderPath, backupFolderPath), true);
                    lastBackupTextbox.Text = backupFolderPath;
                    //Stores 2 backups at a time and deletes the oldest one when a new backup is made
                    if (oldBackup2 != null) {
                        Directory.Delete(oldBackup1, true);
                        oldBackup1 = oldBackup2;
                    }
                    if (oldBackup1 == null)
                        oldBackup1 = backupFolderPath;
                    else
                        oldBackup2 = backupFolderPath;
                    notifyIcon.ShowBalloonTip(10);
                }
                _ticks = 0;
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e) {
            //Disables exiting the program and minimizes the program to the system tray
            if (exit != 1) {
                e.Cancel = true;
                this.Hide();
                notifyIcon.Visible = true;
                notifyMinimize.Visible = true;
                notifyMinimize.ShowBalloonTip(5);
                notifyMinimize.Visible = false;
            }
        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            //Enables exiting the program by clicking exit on the system tray context menu
            exit = 1;
            Application.Exit();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {

        }
    }
}
