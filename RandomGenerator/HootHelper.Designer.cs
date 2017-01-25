namespace RandomGenerator
{
    partial class Main
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
            this.Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.generateNum = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.saveTo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.generateMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeInterval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rradio = new System.Windows.Forms.RadioButton();
            this.sradio = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Browse.Location = new System.Drawing.Point(349, 10);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.saveTo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Content File Location:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // generateNum
            // 
            this.generateNum.Location = new System.Drawing.Point(126, 37);
            this.generateNum.Name = "generateNum";
            this.generateNum.Size = new System.Drawing.Size(40, 20);
            this.generateNum.TabIndex = 3;
            this.generateNum.TextChanged += new System.EventHandler(this.generateNum_TextChanged);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(65, 41);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(54, 13);
            this.Count.TabIndex = 4;
            this.Count.Text = "Generate:";
            this.Count.Click += new System.EventHandler(this.label2_Click);
            // 
            // generate
            // 
            this.generate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.generate.Location = new System.Drawing.Point(187, 198);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 5;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // saveTo
            // 
            this.saveTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveTo.Location = new System.Drawing.Point(350, 83);
            this.saveTo.Name = "saveTo";
            this.saveTo.Size = new System.Drawing.Size(75, 23);
            this.saveTo.TabIndex = 7;
            this.saveTo.Text = "Save To";
            this.saveTo.UseVisualStyleBackColor = true;
            this.saveTo.Click += new System.EventHandler(this.saveTo_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Save Location:";
            // 
            // fileLocation
            // 
            this.fileLocation.Location = new System.Drawing.Point(126, 11);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(219, 20);
            this.fileLocation.TabIndex = 9;
            this.fileLocation.TextChanged += new System.EventHandler(this.fileLocation_TextChanged);
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(126, 85);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.Size = new System.Drawing.Size(218, 20);
            this.saveLocation.TabIndex = 10;
            this.saveLocation.TextChanged += new System.EventHandler(this.saveLocation_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "out of";
            // 
            // generateMax
            // 
            this.generateMax.Location = new System.Drawing.Point(303, 38);
            this.generateMax.Name = "generateMax";
            this.generateMax.Size = new System.Drawing.Size(41, 20);
            this.generateMax.TabIndex = 12;
            this.generateMax.TextChanged += new System.EventHandler(this.generateMax_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "(Max: 350)";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "ddd,MMMM dd yyyy  HH:mm tt";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(126, 112);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "(24-hour Clock)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Start Date/Time:";
            // 
            // timeInterval
            // 
            this.timeInterval.Location = new System.Drawing.Point(126, 138);
            this.timeInterval.Name = "timeInterval";
            this.timeInterval.Size = new System.Drawing.Size(41, 20);
            this.timeInterval.TabIndex = 17;
            this.timeInterval.TextChanged += new System.EventHandler(this.timeInterval_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Time Interval:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "(Mins)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // rradio
            // 
            this.rradio.AutoSize = true;
            this.rradio.Location = new System.Drawing.Point(280, 64);
            this.rradio.Name = "rradio";
            this.rradio.Size = new System.Drawing.Size(65, 17);
            this.rradio.TabIndex = 20;
            this.rradio.TabStop = true;
            this.rradio.Text = "Random";
            this.rradio.UseVisualStyleBackColor = true;
            this.rradio.CheckedChanged += new System.EventHandler(this.rradio_CheckedChanged);
            // 
            // sradio
            // 
            this.sradio.AutoSize = true;
            this.sradio.Location = new System.Drawing.Point(126, 65);
            this.sradio.Name = "sradio";
            this.sradio.Size = new System.Drawing.Size(75, 17);
            this.sradio.TabIndex = 21;
            this.sradio.TabStop = true;
            this.sradio.Text = "Sequential";
            this.sradio.UseVisualStyleBackColor = true;
            this.sradio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "File Name:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // filename
            // 
            this.filename.Location = new System.Drawing.Point(126, 164);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(219, 20);
            this.filename.TabIndex = 23;
            this.filename.TextChanged += new System.EventHandler(this.filename_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = ".csv";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(441, 236);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sradio);
            this.Controls.Add(this.rradio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timeInterval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.generateMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveTo);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.generateNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Browse);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hootsuite Helper v1.5";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox generateNum;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button saveTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileLocation;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox generateMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton sradio;
        private System.Windows.Forms.RadioButton rradio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label label10;
    }
}

