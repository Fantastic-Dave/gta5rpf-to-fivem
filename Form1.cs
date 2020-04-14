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

namespace GTA5_RPF_FiveM_Convertor
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        bool vmenuhelper = true;
        bool servercfghelper = true;
        public Form1()
        {
            InitializeComponent();
            Directory.CreateDirectory("cache");

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


        private void LogAppend(string text)
        {
            log.AppendText(text + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            }
            LogAppend("Welcome to RPF-FiveM Convertor!");
            LogAppend("GTA5Mods links must look like this: ");
            LogAppend("https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zip");
            LogAppend("Links must be DIRECT link else they won't download!");

        }

        private void gta5mods_tb_TextChanged(object sender, EventArgs e)
        {
            if (gta5mods_tb.Text.Contains("https://files.gta5-mods.com/") && checkGtaUtil())
            {
                gta5mods_status.ForeColor = Color.Green;
                gta5mods_status.Text = "OK";
                btnStart.Enabled = true;
            }
            else
            {
                gta5mods_status.ForeColor = Color.Red;
                gta5mods_status.Text = "ERROR";
                btnStart.Enabled = false;

            }
        }
        private void downloadFile(string url)
        {
            string file = System.IO.Path.GetFileName(url);
            WebClient cln = new WebClient();
            cln.DownloadFile(url, file);
        }

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




        private void hideshellcmd(string cmd)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + cmd;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void moveMeta(string resname)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*.meta";

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("Inflating " + resname + @"\" + item);
                File.Move(item, Path.Combine(resname, Path.GetFileName(item)));
            }
        }

        private void moveYft(string resname)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*.yft";

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("Inflating " + resname + @"\" + item);
                File.Move(item, Path.Combine(resname + "\\stream", Path.GetFileName(item)));
            }
        }

        private void delReplaceYft(string resname)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*.yft";

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("Deleting " + resname + @"\" + item + " ..., might be ReplacementYft");
                File.Delete(item);
            }
        }
        private void delReplaceYtd(string resname)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*.ytd";

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("Deleting " + resname + @"\" + item + " ..., might be ReplacementYTd");
                File.Delete(item);
            }
        }

        private void delReplaceMeta(string resname)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*.meta";

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("Deleting " + resname + @"\" + item + " ..., might be ReplacementMETA");
                File.Delete(item);
            }
        }

        private void moveYtd(string resname)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*.ytd";

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("Inflating " + resname + @"\" + item);
                File.Move(item, Path.Combine(resname + "\\stream", Path.GetFileName(item)));
                vmenuHelper(Path.GetFileName(item));
            }
        }

        private void rpfUnpack()
        {


            //Assume user types .txt into textbox
                string fileExtension3 = "*.rpf";

            string[] txtFiles = Directory.GetFiles("cache", fileExtension3, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("Unpacking " + item + "......");
                hideshellcmd(@"lib\gtautil\GTAUtil.exe extractarchive -i " + item + " -o " + @"cache\rpfunpack");
            }
        }

        private void shellcmd(string cmd)
        {
            string strCmdText = "/K " + cmd;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void vmenuHelper(string ytdcarname)
        {
            if(vmenuhelper && servercfghelper)
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
        


        private void btnStart_Click(object sender, EventArgs e)
        {

            if(vmenucheck.Checked == true)
            {

            }
            string resname = fivemresname_tb.Text;
            string archive = gta5mods_tb.Text.ToString();
            LogAppend("Setting up environment...");
            Directory.CreateDirectory("cache");
            Directory.CreateDirectory(resname);
            cfgHelper(resname);
            LogAppend("Created " + resname + " FiveM resource directory...");
            hideshellcmd("mkdir " + resname + @"\stream");
            File.WriteAllText(resname + @"\__resource.lua", reslua.Text);
            try
            {
                LogAppend("Fetching files...");
                downloadFile(archive);
            }
            catch (Exception ex)
            {
                LogAppend("Something failed!");
                LogAppend(ex.ToString());
            }
            LogAppend("Successfully fetched archive!");
            hideshellcmd(@"move *.rar .\cache\");
            hideshellcmd(@"move *.zip .\cache\");
            LogAppend("Unpacking archive using SharpCompress...");
            Thread.Sleep(500);
            universalCacheUnpack();
            Thread.Sleep(1500);
            LogAppend("Unpack finished!");
            delReplaceYft(resname);
            delReplaceYtd(resname);
            delReplaceMeta(resname);
            LogAppend("Stripping spaces...");
            Process.Start(@"cache\unpack");
            File.WriteAllText(@"cache\unpack\delspaces.bat", delspace.Text);
            Thread.Sleep(5200);
            LogAppend("Unpacking dlc.rpf w/ GTAUtils");
            rpfUnpack();
            LogAppend("Waiting 5s for RPF unpacking...");
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogAppend("Launching GTAUtil.exe with no arguments");
            shellcmd(@"lib\gtautil\GTAUtil.exe extractarchive test.rpf");
        }

        private void gta5path_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            shellcmd("echo test" + Environment.NewLine + "echo test3");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            string resname = fivemresname_tb.Text;
            moveMeta(resname);
            moveYft(resname);
            moveYtd(resname);
            LogAppend("Cleaning up...");
            try
            {
                Directory.Delete("cache", true);
            }
            catch (Exception)
            {

            }
            fivemresname_tb.Text = rnd.Next(2147483647).ToString();
            Application.Restart();
            Environment.Exit(0);

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
    }
}

