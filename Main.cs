using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using System.Threading;
using System.Diagnostics;
using SharpCompress.Archives.SevenZip;

namespace GTA5_RPF_FiveM_Convertor
{
    public partial class Main : Form
    {

        // GLOBALS

        int currentQueue = 1;
        Random rnd = new Random();
        bool vmenuhelper = true;
        bool servercfghelper = true;


        public Main()
        {
            InitializeComponent();
            Directory.CreateDirectory("cache");

        }


        /// HELPER FUNCTIONS    
        ///  

        public void LogAppend(string text)
        {
            log.AppendText(text + Environment.NewLine);
            statusHandler(text);
        }


        private void shellcmd(string cmd)
        {
            string strCmdText = "/K " + cmd;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }


        async Task asyncfileDownload(string url)
        {
            string file = System.IO.Path.GetFileName(url);
            WebClient wb = new WebClient();
            await wb.DownloadFileTaskAsync(new Uri(url), file);
        }

        private void vmenuHelper(string ytdcarname)
        {
            if (vmenuhelper && servercfghelper)
            {
                using (StreamWriter w = File.AppendText("vmenu.txt"))
                {
                    w.WriteLine("        " + '"' + ytdcarname + '"' + ",");
                }
            }

        }

        private void cfgHelper(string servercfg)
        {
            if (vmenuhelper && servercfghelper)
            {
                using (StreamWriter w = File.AppendText("servercfg.txt"))
                {
                    w.WriteLine("ensure " + servercfg);
                }
            }
        }

        private void queueHandler(int current, int total)
        {
            tsQueue.Text = "Queue: " + current + "/" + total;
        }



        private bool checkGtaUtil()
        {
            string localFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!Directory.Exists(localFolder + @"\GTAUtil"))
            {
                return false;
            }
            return true;

        }

        private void cleanUp()
        {
            try
            {
                Directory.Delete("cache", true);
            }
            catch (Exception)
            {

            }
            fivemresname_tb.Text = rnd.Next(2147483647).ToString();
            statusHandler("Idle");
        }


        public void hideshellcmd(string cmd)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + cmd;
            process.StartInfo = startInfo;
            process.Start();
        }



        /// SHARPCOMPRESS FUNCTIONS
        /// 
        private void unZip(string target)
        {
            using (var archive = ZipArchive.Open(target))
            {
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                {
                    entry.WriteToDirectory("cache\\unpack", new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
                }
            }
        }

        private void unRar(string target)
        {
            using (var archive = RarArchive.Open(target))
            {
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                {
                    entry.WriteToDirectory("cache\\unpack", new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
                }
            }
        }

        private void unSeven(string target)
        {

            using (var archive = SevenZipArchive.Open(target))
            {
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                {
                    entry.WriteToDirectory("cache\\unpack", new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
                }
            }

        }



        /// UNPACKING
        /// 
        private void universalCacheUnpack()
        {
            string rarfileExtension = "*.rar";
            string[] rarFiles = Directory.GetFiles("cache", rarfileExtension, SearchOption.AllDirectories);

            foreach (var item in rarFiles)
            {
                unRar(Path.Combine("cache", Path.GetFileName(item)));
            }

            string zipfileExtension = "*.zip";
            string[] zipFiles = Directory.GetFiles("cache", zipfileExtension, SearchOption.AllDirectories);

            foreach (var item in zipFiles)
            {
                unZip(Path.Combine("cache", Path.GetFileName(item)));
            }

        }

        private void rpfUnpack()
        {
            string rpfExtension = "*.rpf";
            string[] rpfFiles = Directory.GetFiles("cache", rpfExtension, SearchOption.AllDirectories);
            foreach (var item in rpfFiles)
            {
                LogAppend("[GTAUtil] Unpacking " + item + "......");
                hideshellcmd(@"lib\gtautil\GTAUtil.exe extractarchive -i " + item + " -o " + @"cache\rpfunpack");
            }
        }


        // DELETE .YTD .YFT FILES IN CASE ARCHIVE ALSO CONTAINS REPLACEMENT FOR IN-GAME VEHICLES


        private void delReplacementLeftover(string resname, string type)
        {
            string fileExtension = "*." + type;
            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);
            foreach (var item in txtFiles)
            {
                LogAppend("[DEL] Deleting " + resname + @"\" + item + " ...");
                File.Delete(item);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1; // prevent random textbox focus
            LogAppend("CFG Helpers switched on");
            fivemresname_tb.Text = rnd.Next(2147483647).ToString();
            if (!checkGtaUtil())
            {
                MessageBox.Show("GTAUtil path is not set!");
            }
            else
            {
                gta5path_status.Text = "OK";
                gta5path_status.ForeColor = Color.Green;
                gtautilfix.Enabled = false;
            }
            LogAppend("Elysium: GTA5 RPF to FiveM Addon Converter");
            LogAppend("---------------");
            LogAppend("Developed by king^vickynescu");
            LogAppend("Discord: https://discord.gg/C4e4q6g");
            LogAppend("---------------");

            LogAppend("GTA5Mods links must look like this: ");
            LogAppend("https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zip");
            LogAppend("Links must be DIRECT link else they won't download!");

        }










        private void inflateFromCache(string resname, string type, bool isYtd, bool isYtf)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*." + type;

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("[MOVE] Inflating " + resname + @"\" + item);
                if(isYtd)
                {
                    File.Move(item, Path.Combine(resname + "\\stream", Path.GetFileName(item))); // put into stream folder inside resource name
                    vmenuHelper(Path.GetFileName(item));
                }
                else if (isYtf)
                {
                    File.Move(item, Path.Combine(resname + "\\stream", Path.GetFileName(item))); // put into stream folder inside resource name

                }
                else
                {
                    File.Move(item, Path.Combine(resname, Path.GetFileName(item)));
                }
            }
        }

       

       

        private async void btnStart_Click(object sender, EventArgs e)
        {
            tsBar.Maximum = queueList.Items.Count;
            tsBar.Value = 0;
            foreach (string currentItem in queueList.Items)
            {
                queueHandler(currentQueue, queueList.Items.Count);
                tsBar.Value++;
                await startConvert(currentItem);
                
            }
                
            
            //startConvert(gta5mods_tb.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close the cmd window and re-open application after correctly setting path and prompted for input!");
            LogAppend("Launching GTAUtil.exe with no arguments");
            shellcmd(@"lib\gtautil\GTAUtil.exe extractarchive test.rpf");
            Environment.Exit(0);

        }

        private void statusHandler(string status)
        {
            tsStatus.Text = "Status: " + status;
        }

        private void gta5path_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shellcmd(@"move .\cache\unpack\* .\cache\unpack\nospace");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(vmenucheck.Checked == true)
            {
                servercfghelper = true;
                vmenuhelper = true;
                LogAppend("CFG Helpers switched on");
            }
            else
            {
                servercfghelper = false;
                vmenuhelper = false;
                LogAppend("CFG Helpers switched off");
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (gta5mods_tb.Text.Contains("https://files.gta5-mods.com/") && checkGtaUtil() && !gta5mods_tb.Text.Contains("7z") && !gta5mods_tb.Text.Contains("XXXCARNAMEXXXX"))
            {
                gta5mods_status.ForeColor = Color.Green;
                gta5mods_status.Text = "OK";
                btnAddQueue.Enabled = true;

            }
            else
            {
                gta5mods_status.ForeColor = Color.Red;
                gta5mods_status.Text = "ERROR";
                btnAddQueue.Enabled = false;

            }
        }

        private void btnAddQueue_Click(object sender, EventArgs e)
        {
            LogAppend("Job added!");
            queueList.Items.Add(gta5mods_tb.Text);
            btnStart.Enabled = true;
            queueHandler(0, queueList.Items.Count);
            gta5mods_tb.Clear();
            gta5mods_tb.PlaceHolderText = "https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zipp";
            this.ActiveControl = label1;
        }

        public async Task startConvert(string link)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            LogAppend("[WORKER] Started resConvert async task...");
            LogAppend("[WORKER] Cleaning cache...");
            cleanUp();
            if (vmenucheck.Checked == true)
            {

            }
            string resname = fivemresname_tb.Text;
            string archive = gta5mods_tb.Text.ToString();
            LogAppend("[WORKER] Setting up environment...");
            Directory.CreateDirectory("cache");
            Directory.CreateDirectory(resname);
            Directory.CreateDirectory(@"cache\unpack");
            File.WriteAllText(@"cache\unpack\delspace.bat", delspace.Text);
            cfgHelper(resname);
            LogAppend("[WORKER] Created " + resname + " FiveM resource directory...");
            hideshellcmd("mkdir " + resname + @"\stream");
            File.WriteAllText(resname + @"\__resource.lua", reslua.Text);
            try
            {
                LogAppend("[WORKER] Checking link...OK");
                LogAppend("[ASYNCDL] Downloading archive...");
                await asyncfileDownload(link);
                LogAppend("[ASYNCDL] Successfully fetched archive!");
                hideshellcmd(@"move *.rar cache");
                hideshellcmd(@"move *.zip cache");
                hideshellcmd(@"move *.7z cache");
                LogAppend("[SharpCompress] Decompressing...");
                await Task.Delay(500);
                universalCacheUnpack();
                await Task.Delay(2500);
                LogAppend("[SharpCompress] Unpack finished!");
                delReplacementLeftover(resname, "yft");
                delReplacementLeftover(resname, "ytd");
                delReplacementLeftover(resname, "meta");
                LogAppend("[DELSPACE] Stripping space in resource name (gtalib bug) ...");
                hideshellcmd(@"cache\unpack\delspace.bat");
                await Task.Delay(2000);
                LogAppend("[WORKER] Searching for dlc.rpf...");
                rpfUnpack();
                LogAppend("[GTAUtil] Unpacking RPF...");
                await Task.Delay(5000);
                inflateFromCache(resname, "meta", false, false);
                inflateFromCache(resname, "yft", false, true);
                inflateFromCache(resname, "ytd", true, false);
                LogAppend("[WORKER] Cleaning up...");
                currentQueue += 1;
                cleanUp();
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                jobTime.Text = "| Last job took: " + elapsedMs + " ms";


            }
            catch (Exception ex)
            {
                LogAppend("[ERROR] An error occured. Stacktrace:");
                LogAppend(ex.ToString());
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            queueList.Items.Clear();
            btnStart.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for(int i=1; i<= 3; i++)
            {
                queueList.Items.Add("https://files.gta5-mods.com/uploads/1998-audi-s8-d2-us-6spd-add-on-replace-tuning-extras/15b8b3-1998%20Audi%20S8%20(D2)%20-%20v1.1.zip");
            }
        }
    }
}

