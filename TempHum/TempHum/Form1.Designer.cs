namespace TempHum
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbHum = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmPorts = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbTemp = new System.Windows.Forms.ProgressBar();
            this.pbHum = new System.Windows.Forms.ProgressBar();
            this.btnConnectDis = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(26, 59);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(74, 13);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Температура";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Location = new System.Drawing.Point(26, 85);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(74, 13);
            this.lblHum.TabIndex = 1;
            this.lblHum.Text = "Ылғалдылық";
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(119, 56);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.ReadOnly = true;
            this.tbTemp.Size = new System.Drawing.Size(48, 20);
            this.tbTemp.TabIndex = 2;
            // 
            // tbHum
            // 
            this.tbHum.Location = new System.Drawing.Point(119, 82);
            this.tbHum.Name = "tbHum";
            this.tbHum.ReadOnly = true;
            this.tbHum.Size = new System.Drawing.Size(48, 20);
            this.tbHum.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmPorts});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // tmPorts
            // 
            this.tmPorts.Name = "tmPorts";
            this.tmPorts.Size = new System.Drawing.Size(152, 23);
            this.tmPorts.Text = "Порт";
            this.tmPorts.SelectedIndexChanged += new System.EventHandler(this.tmPorts_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(505, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Мәртебесі:";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 17);
            this.lblStatus.Text = "Қосылмаған";
            // 
            // pbTemp
            // 
            this.pbTemp.Location = new System.Drawing.Point(200, 49);
            this.pbTemp.Name = "pbTemp";
            this.pbTemp.Size = new System.Drawing.Size(144, 23);
            this.pbTemp.TabIndex = 6;
            // 
            // pbHum
            // 
            this.pbHum.Location = new System.Drawing.Point(200, 79);
            this.pbHum.Name = "pbHum";
            this.pbHum.Size = new System.Drawing.Size(144, 23);
            this.pbHum.TabIndex = 7;
            // 
            // btnConnectDis
            // 
            this.btnConnectDis.Location = new System.Drawing.Point(418, 49);
            this.btnConnectDis.Name = "btnConnectDis";
            this.btnConnectDis.Size = new System.Drawing.Size(75, 23);
            this.btnConnectDis.TabIndex = 8;
            this.btnConnectDis.Text = "Қосу";
            this.btnConnectDis.UseVisualStyleBackColor = true;
            this.btnConnectDis.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 262);
            this.Controls.Add(this.btnConnectDis);
            this.Controls.Add(this.pbHum);
            this.Controls.Add(this.pbTemp);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbHum);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.lblHum);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Automation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbHum;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tmPorts;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ProgressBar pbTemp;
        private System.Windows.Forms.ProgressBar pbHum;
        private System.Windows.Forms.Button btnConnectDis;
    }
}

