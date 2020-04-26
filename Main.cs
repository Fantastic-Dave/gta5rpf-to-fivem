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
using System.Text.RegularExpressions;
using AutoUpdaterDotNET;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace GTA5_RPF_FiveM_Convertor
{

    public partial class Main : Form
    {


        // GLOBALS

        int currentQueue = 1;
        Random rnd = new Random();
        bool vmenuhelper = true;
        bool servercfghelper = true;
        string xmlTemplate;
        int convertFromFolder_resname;

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

            string sevenfileExtension = "*.7z";
            string[] sevenFiles = Directory.GetFiles("cache", sevenfileExtension, SearchOption.AllDirectories);

            foreach (var item in sevenFiles)
            {
                unSeven(Path.Combine("cache", Path.GetFileName(item)));
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


        // LOCAL FOLDER URL HASING HELPERS


        static Char[] s_Base32Char = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
            'y', 'z', '0', '1', '2', '3', '4', '5'};

        private static string ToBase32StringSuitableForDirName(byte[] buff)
        {
            StringBuilder sb = new StringBuilder();
            byte b0, b1, b2, b3, b4;
            int l, i;

            l = buff.Length;
            i = 0;

            // Create l chars using the last 5 bits of each byte.  
            // Consume 3 MSB bits 5 bytes at a time.

            do
            {
                b0 = (i < l) ? buff[i++] : (byte)0;
                b1 = (i < l) ? buff[i++] : (byte)0;
                b2 = (i < l) ? buff[i++] : (byte)0;
                b3 = (i < l) ? buff[i++] : (byte)0;
                b4 = (i < l) ? buff[i++] : (byte)0;

                // Consume the 5 Least significant bits of each byte
                sb.Append(s_Base32Char[b0 & 0x1F]);
                sb.Append(s_Base32Char[b1 & 0x1F]);
                sb.Append(s_Base32Char[b2 & 0x1F]);
                sb.Append(s_Base32Char[b3 & 0x1F]);
                sb.Append(s_Base32Char[b4 & 0x1F]);

                // Consume 3 MSB of b0, b1, MSB bits 6, 7 of b3, b4
                sb.Append(s_Base32Char[(
                    ((b0 & 0xE0) >> 5) |
                    ((b3 & 0x60) >> 2))]);

                sb.Append(s_Base32Char[(
                    ((b1 & 0xE0) >> 5) |
                    ((b4 & 0x60) >> 2))]);

                // Consume 3 MSB bits of b2, 1 MSB bit of b3, b4

                b2 >>= 5;

                if ((b3 & 0x80) != 0)
                    b2 |= 0x08;
                if ((b4 & 0x80) != 0)
                    b2 |= 0x10;

                sb.Append(s_Base32Char[b2]);

            } while (i < l);

            return sb.ToString();
        }

        public static string GetLocalAppDataUserConfigPathNoUserConfigFolder(string fullExePath)
        {
            //E.g.: fullExePath = @"C:\Program Files (x86)\MyExeFolder\MyProgram.exe"
            var localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var versionInfo = FileVersionInfo.GetVersionInfo(fullExePath);
            var companyName = versionInfo.CompanyName;
            var exeName = versionInfo.OriginalFilename;// or 'AppDomain.CurrentDomain.FriendlyName'

            var assemblyName = AssemblyName.GetAssemblyName(fullExePath);
            var version = assemblyName.Version.ToString();

            var uri = "file:///" + fullExePath; //or 'assemblyName.CodeBase' if vshost (you can check the 'FriendlyName')
            uri = uri.ToUpperInvariant();

            var ms = new MemoryStream();
            var bSer = new BinaryFormatter();
            bSer.Serialize(ms, uri);
            ms.Position = 0;
            var sha1 = new SHA1CryptoServiceProvider();
            var hash = sha1.ComputeHash(ms);
            var hashstring = ToBase32StringSuitableForDirName(hash);

            //<AppData Local User Path> + <Company Name> + <[ExeName]_[eid]_[Hash]> + <Version> + user.config
            var userConfigLocalAppDataPath = Path.Combine(localAppDataPath, "GTAUtil", companyName, exeName + "_Url_" + hashstring, version);

            return userConfigLocalAppDataPath;
        }

        public static string GetExeLocalAppDataUserConfigPath(string fullExePath)
        {
            //E.g.: fullExePath = @"C:\Program Files (x86)\MyExeFolder\MyProgram.exe"
            var localAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var versionInfo = FileVersionInfo.GetVersionInfo(fullExePath);
            var companyName = versionInfo.CompanyName;
            var exeName = versionInfo.OriginalFilename;// or 'AppDomain.CurrentDomain.FriendlyName'

            var assemblyName = AssemblyName.GetAssemblyName(fullExePath);
            var version = assemblyName.Version.ToString();

            var uri = "file:///" + fullExePath; //or 'assemblyName.CodeBase' if vshost (you can check the 'FriendlyName')
            uri = uri.ToUpperInvariant();

            var ms = new MemoryStream();
            var bSer = new BinaryFormatter();
            bSer.Serialize(ms, uri);
            ms.Position = 0;
            var sha1 = new SHA1CryptoServiceProvider();
            var hash = sha1.ComputeHash(ms);
            var hashstring = ToBase32StringSuitableForDirName(hash);

            //<AppData Local User Path> + <Company Name> + <[ExeName]_[eid]_[Hash]> + <Version> + user.config
            var userConfigLocalAppDataPath = Path.Combine(localAppDataPath, "GTAUtil", companyName, exeName + "_Url_" + hashstring, version, "user.config");

            return userConfigLocalAppDataPath;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int cachebust = rnd.Next(555);
            AutoUpdater.Start("https://gist.githubusercontent.com/vscorpio/e9f5b4e8fea80d323a665a12d12032d9/raw/autoupdater.xml?cachebust=" + cachebust);
            this.ActiveControl = label1; // prevent random textbox focus
            LogAppend("CFG Helpers switched on");
            fivemresname_tb.Text = rnd.Next(2147483647).ToString();
            LogAppend("Elysium: GTA5 RPF to FiveM Addon Converter");
            LogAppend("---------------");
            LogAppend("Developed by king^vickynescu");
            LogAppend("Discord support: https://discord.gg/C4e4q6g");
            LogAppend("---------------");

            LogAppend("GTA5Mods links must look like this: ");
            LogAppend("https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zip");
            LogAppend("Links must be DIRECT link else they won't download!");

        }

        private void fixTextureFile(string filePath)
        {
            LogAppend("[FIX4BYTE] Fixing " + filePath + "...");
            string content = File.ReadAllText(filePath, Encoding.Default);
            char[] array = content.ToCharArray();
            array[3] = '7';
            content = new string(array);
            File.WriteAllText(filePath, content, Encoding.Default);
        }


        private void inflateFromCache(string resname, string type, bool isYtd, bool isYtf)
        {
            //Assume user types .txt into textbox
            string fileExtension = "*." + type;

            string[] txtFiles = Directory.GetFiles("cache", fileExtension, SearchOption.AllDirectories);

            foreach (var item in txtFiles)
            {
                LogAppend("[MOVE] Inflating " + resname + @"\" + item);
                if (isYtd)
                {
                    fixTextureFile(item);
                    File.Move(item, Path.Combine(resname + "\\stream", Path.GetFileName(item))); // put into stream folder inside resource name
                    vmenuHelper(Path.GetFileName(item));

                }
                else if (isYtf)
                {
                    fixTextureFile(item);
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
                string abc = currentItem;
                Regex rx = new Regex(@"<(.*?)>");
                await startConvertFromLink(currentItem, rx.Match(currentItem).Groups[1].Value);


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
            if (vmenucheck.Checked == true)
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

        private void placeHolderTextBox1_TextChanged(object sender, EventArgs e) //!gta5mods_tb.Text.Contains("7z")
        {
            if (gta5mods_tb.Text.Contains("https://files.gta5-mods.com/") && !gta5mods_tb.Text.Contains("XXXCARNAMEXXXX"))
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
            queueList.Items.Add($"<{fivemresname_tb.Text}>" + gta5mods_tb.Text);
            btnStart.Enabled = true;
            queueHandler(0, queueList.Items.Count);
            gta5mods_tb.Clear();
            gta5mods_tb.PlaceHolderText = "https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zipp";
            this.ActiveControl = label1;
            fivemresname_tb.Text = rnd.Next(2147483647).ToString();
        }

        public async Task startConvertFromLink(string link, string resname)
        {
            Encoding utf8WithoutBom = new UTF8Encoding(false);

            Regex rx = new Regex(@"<(.*?)>");
            string filteredresname = rx.Match(link).Groups[1].Value;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            LogAppend("[WORKER] Started resConvert async task...");
            LogAppend("[WORKER] Cleaning cache...");
            cleanUp();
            if (vmenucheck.Checked == true)
            {


                string archive = gta5mods_tb.Text.ToString();
                LogAppend("[WORKER] Setting up environment...");
                Directory.CreateDirectory("cache");
                //Directory.CreateDirectory((rx.Match(resname).Groups[1].Value));
                Directory.CreateDirectory(@"cache\unpack");
                File.WriteAllText(@"cache\unpack\delspace.bat", delspace.Text);
                cfgHelper(filteredresname);
                LogAppend("[WORKER] Created " + filteredresname + " FiveM resource directory...");
                hideshellcmd("mkdir " + filteredresname + @"\stream");
                await Task.Delay(500);
                File.WriteAllText(filteredresname + @"\__resource.lua", reslua.Text, utf8WithoutBom);
                try
                {
                    LogAppend("[WORKER] Checking link...OK");
                    LogAppend("[ASYNCDL] Downloading archive...");
                    await asyncfileDownload(link.Replace($"<{resname}>", ""));
                    LogAppend("[ASYNCDL] Successfully fetched archive!");
                    hideshellcmd(@"move *.rar cache");
                    hideshellcmd(@"move *.zip cache");
                    hideshellcmd(@"move *.7z cache");
                    LogAppend("[SharpCompress] Decompressing...");
                    await Task.Delay(500);
                    universalCacheUnpack();
                    await Task.Delay(2500);
                    LogAppend("[SharpCompress] Unpack finished!");
                    delReplacementLeftover(filteredresname, "yft");
                    delReplacementLeftover(filteredresname, "ytd");
                    delReplacementLeftover(filteredresname, "meta");
                    LogAppend("[DELSPACE] Stripping space in resource name (gtalib bug) ...");
                    hideshellcmd(@"cache\unpack\delspace.bat");
                    await Task.Delay(2000);
                    LogAppend("[WORKER] Searching for dlc.rpf...");
                    rpfUnpack();
                    LogAppend("[GTAUtil] Unpacking RPF...");
                    await Task.Delay(5000);
                    inflateFromCache(filteredresname, "meta", false, false);
                    inflateFromCache(filteredresname, "yft", false, true);
                    inflateFromCache(filteredresname, "ytd", true, false);
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
        }

        public async Task startConvertFromFolder(string filteredresname)
        {
            convertFromFolder_resname = rnd.Next(555555);
            filteredresname = convertFromFolder_resname.ToString();
            Encoding utf8WithoutBom = new UTF8Encoding(false);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            LogAppend("[WORKER] Started resConvert async task...");
            if (vmenucheck.Checked == true)
            {

                string archive = gta5mods_tb.Text.ToString();
                LogAppend("[WORKER] Setting up environment...");
                Directory.CreateDirectory("cache");
                //Directory.CreateDirectory((rx.Match(resname).Groups[1].Value));
                Directory.CreateDirectory(@"cache\unpack");
                File.WriteAllText(@"cache\unpack\delspace.bat", delspace.Text);
                cfgHelper(filteredresname);
                LogAppend("[WORKER] Created " + filteredresname + " FiveM resource directory...");
                hideshellcmd("mkdir " + filteredresname + @"\stream");
                await Task.Delay(500);
                File.WriteAllText(filteredresname + @"\__resource.lua", reslua.Text, utf8WithoutBom);
                try
                {
                    LogAppend("[SharpCompress] Decompressing...");
                    await Task.Delay(500);
                    universalCacheUnpack();
                    await Task.Delay(2500);
                    LogAppend("[SharpCompress] Unpack finished!");
                    delReplacementLeftover(filteredresname, "yft");
                    delReplacementLeftover(filteredresname, "ytd");
                    delReplacementLeftover(filteredresname, "meta");
                    LogAppend("[DELSPACE] Stripping space in resource name (gtalib bug) ...");
                    hideshellcmd(@"cache\unpack\delspace.bat");
                    await Task.Delay(2000);
                    LogAppend("[WORKER] Searching for dlc.rpf...");
                    rpfUnpack();
                    LogAppend("[GTAUtil] Unpacking RPF...");
                    await Task.Delay(5000);
                    inflateFromCache(filteredresname, "meta", false, false);
                    inflateFromCache(filteredresname, "yft", false, true);
                    inflateFromCache(filteredresname, "ytd", true, false);
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
        }
        private void button4_Click(object sender, EventArgs e)
        {
            queueList.Items.Clear();
            btnStart.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                queueList.Items.Add("https://files.gta5-mods.com/uploads/1998-audi-s8-d2-us-6spd-add-on-replace-tuning-extras/15b8b3-1998%20Audi%20S8%20(D2)%20-%20v1.1.zip");
            }
        }

        async Task makeGtautilFolder(string gtaUtilTempFolder, string gtafolder)
        {
            xmlTemplate = $@"<?xml version=""1.0"" encoding=""utf-8""?>
<configuration>
    <configSections>
        <sectionGroup name=""userSettings"" type=""System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" >
            <section name=""GTAUtil.Settings"" type=""System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"" allowExeDefinition=""MachineToLocalUser"" requirePermission=""false"" />
        </sectionGroup>
    </configSections>
    <userSettings>
        <GTAUtil.Settings>
            <setting name=""GTAFolder"" serializeAs=""String"">
                <value>{gtafolder}</value>
            </setting>
        </GTAUtil.Settings>
    </userSettings>
</configuration>";


            try
            {
                Directory.CreateDirectory(GetLocalAppDataUserConfigPathNoUserConfigFolder(Path.Combine(Directory.GetCurrentDirectory(), @"lib\gtautil\GTAUtil.exe")));
                await Task.Delay(1000);
                //MessageBox.Show(gtaUtilTempFolder);
                File.WriteAllText(gtaUtilTempFolder, xmlTemplate, Encoding.Default);
            }
            catch
            {
                //error handling
            }


        }




        private async void button1_Click_1(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                gtaFolder_tb.Text = dialog.FileName;
                if (checkGtaFolder())
                {
                    await makeGtautilFolder(GetExeLocalAppDataUserConfigPath(Path.Combine(Directory.GetCurrentDirectory(), @"lib\gtautil\GTAUtil.exe")), dialog.FileName);
                    await makeGtautilFolder(GetExeLocalAppDataUserConfigPath(Path.Combine(Directory.GetCurrentDirectory(), @"lib\gtautil\GTAUtil.exe")), dialog.FileName);
                    btnConvertFromFolder.Enabled = true;
                    btnAddQueue.Enabled = true;
                    gta5path_status.Text = "OK";
                    gta5path_status.ForeColor = Color.Green;
                }
                else
                {
                    btnConvertFromFolder.Enabled = false;
                    btnAddQueue.Enabled = false;
                    gta5path_status.Text = "NOT SET";
                    gta5path_status.ForeColor = Color.Red;
                }
            }

        }

        private bool checkGtaFolder()
        {
            if (gtaFolder_tb.Text.Contains(@"\Grand Theft Auto V") && !gtaFolder_tb.Text.Contains(@"GTA5.exe"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            convertFromFolder_resname = rnd.Next(555555);
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string filepath = dialog.FileName;
                DirectoryInfo d = new DirectoryInfo(filepath);

                foreach (var file in d.GetFiles("*.zip"))
                {
                    Directory.CreateDirectory("cache");
                    LogAppend($"Found archive: {file.FullName}");
                    Directory.Move(file.FullName, @"cache\" + file.Name);
                    await startConvertFromFolder(convertFromFolder_resname.ToString());
                }
                foreach (var file in d.GetFiles("*.rar"))
                {
                    Directory.CreateDirectory("cache");
                    LogAppend($"Found archive: {file.FullName}");
                    Directory.Move(file.FullName, @"cache\" + file.Name);
                    await startConvertFromFolder(convertFromFolder_resname.ToString());
                }
                foreach (var file in d.GetFiles("*.zip"))
                {
                    Directory.CreateDirectory("cache");
                    LogAppend($"Found archive: {file.FullName}");
                    Directory.Move(file.FullName, @"cache\" + file.Name);
                    await startConvertFromFolder(convertFromFolder_resname.ToString());
                }

            }
            Task.Delay(1000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

