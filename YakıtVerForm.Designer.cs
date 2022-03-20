namespace AracTakip
{
    partial class YakıtVerForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tutar = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.msmodu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.parabirimi = new System.Windows.Forms.TextBox();
            this.plaka = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(91, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "--YAKIT VER--                       ";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(326, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 19);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tutar :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plaka :";
            // 
            // tutar
            // 
            this.tutar.BackColor = System.Drawing.SystemColors.InfoText;
            this.tutar.ForeColor = System.Drawing.SystemColors.Window;
            this.tutar.Location = new System.Drawing.Point(167, 112);
            this.tutar.Name = "tutar";
            this.tutar.Size = new System.Drawing.Size(80, 20);
            this.tutar.TabIndex = 12;
            this.tutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tarih :";
            // 
            // msmodu
            // 
            this.msmodu.BackColor = System.Drawing.Color.DimGray;
            this.msmodu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.msmodu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.msmodu.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msmodu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.msmodu.Location = new System.Drawing.Point(133, 175);
            this.msmodu.Name = "msmodu";
            this.msmodu.Size = new System.Drawing.Size(91, 20);
            this.msmodu.TabIndex = 17;
            this.msmodu.Text = "Kaydet";
            this.msmodu.UseVisualStyleBackColor = false;
            this.msmodu.Click += new System.EventHandler(this.Msmodu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // parabirimi
            // 
            this.parabirimi.BackColor = System.Drawing.SystemColors.InfoText;
            this.parabirimi.Enabled = false;
            this.parabirimi.ForeColor = System.Drawing.SystemColors.Window;
            this.parabirimi.Location = new System.Drawing.Point(245, 112);
            this.parabirimi.Name = "parabirimi";
            this.parabirimi.Size = new System.Drawing.Size(22, 20);
            this.parabirimi.TabIndex = 18;
            this.parabirimi.Text = "TL";
            this.parabirimi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plaka
            // 
            this.plaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.plaka.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plaka.ForeColor = System.Drawing.SystemColors.Info;
            this.plaka.FormattingEnabled = true;
            this.plaka.Location = new System.Drawing.Point(167, 85);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(100, 21);
            this.plaka.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // YakıtVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(360, 218);
            this.Controls.Add(this.plaka);
            this.Controls.Add(this.parabirimi);
            this.Controls.Add(this.msmodu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tutar);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YakıtVerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YakıtVerForm";
            this.Load += new System.EventHandler(this.YakıtVerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tutar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button msmodu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox parabirimi;
        private System.Windows.Forms.ComboBox plaka;
        private System.Windows.Forms.Timer timer1;
    }
}