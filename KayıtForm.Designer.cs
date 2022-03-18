namespace AracTakip
{
    partial class KayıtForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beyazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeşilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başkaBirRenkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msmodu = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(159, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(159, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(159, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox3_MouseClick);
            this.textBox3.TabStopChanged += new System.EventHandler(this.TextBox3_TextChanged);
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kırmızıToolStripMenuItem,
            this.maviToolStripMenuItem,
            this.beyazToolStripMenuItem,
            this.yeşilToolStripMenuItem,
            this.turuncuToolStripMenuItem,
            this.morToolStripMenuItem,
            this.başkaBirRenkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 158);
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            this.kırmızıToolStripMenuItem.Click += new System.EventHandler(this.MorToolStripMenuItem_Click);
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.MorToolStripMenuItem_Click);
            // 
            // beyazToolStripMenuItem
            // 
            this.beyazToolStripMenuItem.Name = "beyazToolStripMenuItem";
            this.beyazToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.beyazToolStripMenuItem.Text = "Beyaz";
            this.beyazToolStripMenuItem.Click += new System.EventHandler(this.MorToolStripMenuItem_Click);
            // 
            // yeşilToolStripMenuItem
            // 
            this.yeşilToolStripMenuItem.Name = "yeşilToolStripMenuItem";
            this.yeşilToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.yeşilToolStripMenuItem.Text = "Yeşil";
            this.yeşilToolStripMenuItem.Click += new System.EventHandler(this.MorToolStripMenuItem_Click);
            // 
            // turuncuToolStripMenuItem
            // 
            this.turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            this.turuncuToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.turuncuToolStripMenuItem.Text = "Turuncu";
            this.turuncuToolStripMenuItem.Click += new System.EventHandler(this.MorToolStripMenuItem_Click);
            // 
            // morToolStripMenuItem
            // 
            this.morToolStripMenuItem.Name = "morToolStripMenuItem";
            this.morToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.morToolStripMenuItem.Text = "Mor";
            this.morToolStripMenuItem.Click += new System.EventHandler(this.MorToolStripMenuItem_Click);
            // 
            // başkaBirRenkToolStripMenuItem
            // 
            this.başkaBirRenkToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.başkaBirRenkToolStripMenuItem.Name = "başkaBirRenkToolStripMenuItem";
            this.başkaBirRenkToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.başkaBirRenkToolStripMenuItem.Text = "Başka Bir Renk";
            this.başkaBirRenkToolStripMenuItem.Click += new System.EventHandler(this.BaşkaBirRenkToolStripMenuItem_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(159, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plaka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Renk :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(53, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "--ARAÇ İŞLEMLERİ--                       ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // msmodu
            // 
            this.msmodu.BackColor = System.Drawing.Color.DimGray;
            this.msmodu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msmodu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.msmodu.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msmodu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.msmodu.Location = new System.Drawing.Point(132, 175);
            this.msmodu.Name = "msmodu";
            this.msmodu.Size = new System.Drawing.Size(91, 20);
            this.msmodu.TabIndex = 9;
            this.msmodu.Text = "Kaydet";
            this.msmodu.UseVisualStyleBackColor = false;
            this.msmodu.Click += new System.EventHandler(this.Msmodu_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(326, -2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 19);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // KayıtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(360, 218);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.msmodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayıtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayıtForm";
            this.Load += new System.EventHandler(this.KayıtForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button msmodu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beyazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeşilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başkaBirRenkToolStripMenuItem;
    }
}