namespace FYP_RawData_To_Graph_Ver1._3
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.listBoxRead = new System.Windows.Forms.ListBox();
            this.GraphpictureBox = new System.Windows.Forms.PictureBox();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.TempLabel = new System.Windows.Forms.Label();
            this.RawDataLabel2 = new System.Windows.Forms.Label();
            this.RawDataLabel = new System.Windows.Forms.Label();
            this.MagLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.PlotgroupBox = new System.Windows.Forms.GroupBox();
            this.PPGinvertcheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScaledomainUpDown = new System.Windows.Forms.DomainUpDown();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlertcheckBox = new System.Windows.Forms.CheckBox();
            this.HRlabel = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDetected = new System.Windows.Forms.TextBox();
            this.textBoxLinesPlot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).BeginInit();
            this.PlotgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(21, 9);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(103, 32);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // listBoxRead
            // 
            this.listBoxRead.FormattingEnabled = true;
            this.listBoxRead.Location = new System.Drawing.Point(21, 73);
            this.listBoxRead.Name = "listBoxRead";
            this.listBoxRead.Size = new System.Drawing.Size(240, 407);
            this.listBoxRead.TabIndex = 1;
            // 
            // GraphpictureBox
            // 
            this.GraphpictureBox.BackColor = System.Drawing.Color.Black;
            this.GraphpictureBox.Location = new System.Drawing.Point(267, 73);
            this.GraphpictureBox.Name = "GraphpictureBox";
            this.GraphpictureBox.Size = new System.Drawing.Size(719, 276);
            this.GraphpictureBox.TabIndex = 47;
            this.GraphpictureBox.TabStop = false;
            this.GraphpictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphpictureBox_Paint);
            // 
            // EventListBox
            // 
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.Location = new System.Drawing.Point(992, 64);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.Size = new System.Drawing.Size(212, 407);
            this.EventListBox.TabIndex = 55;
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Location = new System.Drawing.Point(414, 410);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(34, 13);
            this.TempLabel.TabIndex = 62;
            this.TempLabel.Text = "Temp";
            // 
            // RawDataLabel2
            // 
            this.RawDataLabel2.AutoSize = true;
            this.RawDataLabel2.Location = new System.Drawing.Point(472, 386);
            this.RawDataLabel2.Name = "RawDataLabel2";
            this.RawDataLabel2.Size = new System.Drawing.Size(52, 13);
            this.RawDataLabel2.TabIndex = 61;
            this.RawDataLabel2.Text = "RawData";
            // 
            // RawDataLabel
            // 
            this.RawDataLabel.AutoSize = true;
            this.RawDataLabel.Location = new System.Drawing.Point(414, 386);
            this.RawDataLabel.Name = "RawDataLabel";
            this.RawDataLabel.Size = new System.Drawing.Size(52, 13);
            this.RawDataLabel.TabIndex = 60;
            this.RawDataLabel.Text = "RawData";
            // 
            // MagLabel
            // 
            this.MagLabel.AutoSize = true;
            this.MagLabel.Location = new System.Drawing.Point(474, 359);
            this.MagLabel.Name = "MagLabel";
            this.MagLabel.Size = new System.Drawing.Size(47, 13);
            this.MagLabel.TabIndex = 59;
            this.MagLabel.Text = "AccMag";
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(454, 359);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(14, 13);
            this.zLabel.TabIndex = 58;
            this.zLabel.Text = "Z";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(434, 359);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 57;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(414, 359);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 56;
            this.xLabel.Text = "X";
            // 
            // PlotgroupBox
            // 
            this.PlotgroupBox.Controls.Add(this.PPGinvertcheckBox);
            this.PlotgroupBox.Controls.Add(this.label2);
            this.PlotgroupBox.Controls.Add(this.ScaledomainUpDown);
            this.PlotgroupBox.Location = new System.Drawing.Point(279, 359);
            this.PlotgroupBox.Name = "PlotgroupBox";
            this.PlotgroupBox.Size = new System.Drawing.Size(115, 121);
            this.PlotgroupBox.TabIndex = 63;
            this.PlotgroupBox.TabStop = false;
            this.PlotgroupBox.Text = "Plot Option";
            // 
            // PPGinvertcheckBox
            // 
            this.PPGinvertcheckBox.AutoSize = true;
            this.PPGinvertcheckBox.Location = new System.Drawing.Point(6, 30);
            this.PPGinvertcheckBox.Name = "PPGinvertcheckBox";
            this.PPGinvertcheckBox.Size = new System.Drawing.Size(78, 17);
            this.PPGinvertcheckBox.TabIndex = 45;
            this.PPGinvertcheckBox.Text = "Invert PPG";
            this.PPGinvertcheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Scale:";
            // 
            // ScaledomainUpDown
            // 
            this.ScaledomainUpDown.Items.Add("1");
            this.ScaledomainUpDown.Items.Add("2");
            this.ScaledomainUpDown.Items.Add("3");
            this.ScaledomainUpDown.Items.Add("4");
            this.ScaledomainUpDown.Items.Add("5");
            this.ScaledomainUpDown.Items.Add("6");
            this.ScaledomainUpDown.Items.Add("7");
            this.ScaledomainUpDown.Items.Add("8");
            this.ScaledomainUpDown.Items.Add("9");
            this.ScaledomainUpDown.Items.Add("10");
            this.ScaledomainUpDown.Items.Add("11");
            this.ScaledomainUpDown.Items.Add("12");
            this.ScaledomainUpDown.Items.Add("13");
            this.ScaledomainUpDown.Items.Add("14");
            this.ScaledomainUpDown.Location = new System.Drawing.Point(48, 62);
            this.ScaledomainUpDown.Name = "ScaledomainUpDown";
            this.ScaledomainUpDown.ReadOnly = true;
            this.ScaledomainUpDown.Size = new System.Drawing.Size(36, 20);
            this.ScaledomainUpDown.TabIndex = 22;
            this.ScaledomainUpDown.Text = "1";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(267, 9);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(108, 32);
            this.buttonPlot.TabIndex = 64;
            this.buttonPlot.Text = "Plot Graph ";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(392, 47);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(159, 20);
            this.textBoxS.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Status:";
            // 
            // AlertcheckBox
            // 
            this.AlertcheckBox.AutoSize = true;
            this.AlertcheckBox.Location = new System.Drawing.Point(992, 477);
            this.AlertcheckBox.Name = "AlertcheckBox";
            this.AlertcheckBox.Size = new System.Drawing.Size(81, 17);
            this.AlertcheckBox.TabIndex = 67;
            this.AlertcheckBox.Text = "Alert Popup";
            this.AlertcheckBox.UseVisualStyleBackColor = true;
            // 
            // HRlabel
            // 
            this.HRlabel.AutoSize = true;
            this.HRlabel.Location = new System.Drawing.Point(414, 437);
            this.HRlabel.Name = "HRlabel";
            this.HRlabel.Size = new System.Drawing.Size(23, 13);
            this.HRlabel.TabIndex = 68;
            this.HRlabel.Text = "HR";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(21, 47);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(231, 20);
            this.textBoxLocation.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(576, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "No. of lines detected:";
            // 
            // textBoxDetected
            // 
            this.textBoxDetected.Location = new System.Drawing.Point(571, 47);
            this.textBoxDetected.Name = "textBoxDetected";
            this.textBoxDetected.Size = new System.Drawing.Size(159, 20);
            this.textBoxDetected.TabIndex = 71;
            // 
            // textBoxLinesPlot
            // 
            this.textBoxLinesPlot.Location = new System.Drawing.Point(764, 47);
            this.textBoxLinesPlot.Name = "textBoxLinesPlot";
            this.textBoxLinesPlot.Size = new System.Drawing.Size(159, 20);
            this.textBoxLinesPlot.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(760, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Enter no. of lines to plot:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLinesPlot);
            this.Controls.Add(this.textBoxDetected);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.HRlabel);
            this.Controls.Add(this.AlertcheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.PlotgroupBox);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.RawDataLabel2);
            this.Controls.Add(this.RawDataLabel);
            this.Controls.Add(this.MagLabel);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.EventListBox);
            this.Controls.Add(this.GraphpictureBox);
            this.Controls.Add(this.listBoxRead);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GraphpictureBox)).EndInit();
            this.PlotgroupBox.ResumeLayout(false);
            this.PlotgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ListBox listBoxRead;
        private System.Windows.Forms.PictureBox GraphpictureBox;
        private System.Windows.Forms.ListBox EventListBox;
        private System.Windows.Forms.Label TempLabel;
        private System.Windows.Forms.Label RawDataLabel2;
        private System.Windows.Forms.Label RawDataLabel;
        private System.Windows.Forms.Label MagLabel;
        private System.Windows.Forms.Label zLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.GroupBox PlotgroupBox;
        private System.Windows.Forms.CheckBox PPGinvertcheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown ScaledomainUpDown;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AlertcheckBox;
        private System.Windows.Forms.Label HRlabel;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDetected;
        private System.Windows.Forms.TextBox textBoxLinesPlot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

