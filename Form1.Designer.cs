namespace GTA5_RPF_FiveM_Convertor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gta5mods_status = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.localrpf_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gta5mods_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gta5path_status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.vmenucheck = new System.Windows.Forms.CheckBox();
            this.fivemresname_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.reslua = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.delspace = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gta5mods_status);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.localrpf_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gta5mods_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RPF Selector";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(408, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "https://files.gta5-mods.com/uploads/XXXCARNAMEXXXX/XXXCARNAMEXXXX.zip";
            // 
            // gta5mods_status
            // 
            this.gta5mods_status.AutoSize = true;
            this.gta5mods_status.BackColor = System.Drawing.SystemColors.Control;
            this.gta5mods_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gta5mods_status.ForeColor = System.Drawing.Color.Crimson;
            this.gta5mods_status.Location = new System.Drawing.Point(366, 113);
            this.gta5mods_status.Name = "gta5mods_status";
            this.gta5mods_status.Size = new System.Drawing.Size(75, 16);
            this.gta5mods_status.TabIndex = 10;
            this.gta5mods_status.Text = "BAD LINK";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(369, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // localrpf_tb
            // 
            this.localrpf_tb.Enabled = false;
            this.localrpf_tb.Location = new System.Drawing.Point(12, 174);
            this.localrpf_tb.Name = "localrpf_tb";
            this.localrpf_tb.Size = new System.Drawing.Size(351, 22);
            this.localrpf_tb.TabIndex = 3;
            this.localrpf_tb.Text = "currently disabled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local RPF Path";
            // 
            // gta5mods_tb
            // 
            this.gta5mods_tb.BackColor = System.Drawing.SystemColors.Window;
            this.gta5mods_tb.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gta5mods_tb.Location = new System.Drawing.Point(9, 39);
            this.gta5mods_tb.Multiline = true;
            this.gta5mods_tb.Name = "gta5mods_tb";
            this.gta5mods_tb.Size = new System.Drawing.Size(351, 90);
            this.gta5mods_tb.TabIndex = 1;
            this.gta5mods_tb.TextChanged += new System.EventHandler(this.gta5mods_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GTA5Mods Link";
            // 
            // gta5path_status
            // 
            this.gta5path_status.AutoSize = true;
            this.gta5path_status.BackColor = System.Drawing.SystemColors.Control;
            this.gta5path_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gta5path_status.ForeColor = System.Drawing.Color.Crimson;
            this.gta5path_status.Location = new System.Drawing.Point(148, 12);
            this.gta5path_status.Name = "gta5path_status";
            this.gta5path_status.Size = new System.Drawing.Size(74, 16);
            this.gta5path_status.TabIndex = 9;
            this.gta5path_status.Text = "NOT SET";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "GTAUtil GTA5 PATH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.log);
            this.groupBox2.Location = new System.Drawing.Point(476, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 497);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(6, 21);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(591, 470);
            this.log.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.vmenucheck);
            this.groupBox3.Controls.Add(this.fivemresname_tb);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(458, 124);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resource";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 72);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(132, 20);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "use custom name";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(196, 37);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(178, 22);
            this.textBox6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Custom vehicle in-game name";
            // 
            // vmenucheck
            // 
            this.vmenucheck.AutoSize = true;
            this.vmenucheck.Checked = true;
            this.vmenucheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vmenucheck.Location = new System.Drawing.Point(12, 98);
            this.vmenucheck.Name = "vmenucheck";
            this.vmenucheck.Size = new System.Drawing.Size(373, 20);
            this.vmenucheck.TabIndex = 14;
            this.vmenucheck.Text = "vMenu / server.cfg helper (check directory after converting)\r\n";
            this.vmenucheck.UseVisualStyleBackColor = true;
            this.vmenucheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fivemresname_tb
            // 
            this.fivemresname_tb.Location = new System.Drawing.Point(12, 37);
            this.fivemresname_tb.Name = "fivemresname_tb";
            this.fivemresname_tb.Size = new System.Drawing.Size(178, 22);
            this.fivemresname_tb.TabIndex = 13;
            this.fivemresname_tb.Text = "default";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "FiveM Resource name";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 486);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // reslua
            // 
            this.reslua.Location = new System.Drawing.Point(516, 537);
            this.reslua.Multiline = true;
            this.reslua.Name = "reslua";
            this.reslua.Size = new System.Drawing.Size(557, 236);
            this.reslua.TabIndex = 10;
            this.reslua.Text = resources.GetString("reslua.Text");
            this.reslua.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "downloadonly";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // delspace
            // 
            this.delspace.Location = new System.Drawing.Point(41, 537);
            this.delspace.Multiline = true;
            this.delspace.Name = "delspace";
            this.delspace.Size = new System.Drawing.Size(469, 248);
            this.delspace.TabIndex = 12;
            this.delspace.Text = resources.GetString("delspace.Text");
            this.delspace.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(93, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(318, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "alpha build 528 | developed by: github.com/vscorpio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 517);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delspace);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reslua);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gta5path_status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GTA5 RPF to FiveM Addon Converter (v0.1a)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gta5mods_status;
        private System.Windows.Forms.Label gta5path_status;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localrpf_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gta5mods_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox vmenucheck;
        private System.Windows.Forms.TextBox fivemresname_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reslua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox delspace;
        private System.Windows.Forms.Label label7;
    }
}

