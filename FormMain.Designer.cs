namespace XPControl
{
    partial class FormMain
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
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.pnlPitch = new System.Windows.Forms.Panel();
            this.tkbPitch = new System.Windows.Forms.TrackBar();
            this.lblPitch = new System.Windows.Forms.Label();
            this.pnlRoll = new System.Windows.Forms.Panel();
            this.tkbRoll = new System.Windows.Forms.TrackBar();
            this.lblRoll = new System.Windows.Forms.Label();
            this.pnlHeading = new System.Windows.Forms.Panel();
            this.tkbHeading = new System.Windows.Forms.TrackBar();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlPort = new System.Windows.Forms.Panel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCommand = new System.Windows.Forms.Panel();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.pnlConfig.SuspendLayout();
            this.pnlPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPitch)).BeginInit();
            this.pnlRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRoll)).BeginInit();
            this.pnlHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbHeading)).BeginInit();
            this.pnlPort.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.pnlPitch);
            this.pnlConfig.Controls.Add(this.pnlRoll);
            this.pnlConfig.Controls.Add(this.pnlHeading);
            this.pnlConfig.Controls.Add(this.pnlPort);
            this.pnlConfig.Controls.Add(this.pnlAddress);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfig.Location = new System.Drawing.Point(5, 5);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(374, 150);
            this.pnlConfig.TabIndex = 0;
            // 
            // pnlPitch
            // 
            this.pnlPitch.Controls.Add(this.tkbPitch);
            this.pnlPitch.Controls.Add(this.lblPitch);
            this.pnlPitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPitch.Location = new System.Drawing.Point(0, 120);
            this.pnlPitch.Name = "pnlPitch";
            this.pnlPitch.Size = new System.Drawing.Size(374, 30);
            this.pnlPitch.TabIndex = 4;
            // 
            // tkbPitch
            // 
            this.tkbPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tkbPitch.Location = new System.Drawing.Point(150, 0);
            this.tkbPitch.Maximum = 100;
            this.tkbPitch.Name = "tkbPitch";
            this.tkbPitch.Size = new System.Drawing.Size(224, 30);
            this.tkbPitch.SmallChange = 10;
            this.tkbPitch.TabIndex = 2;
            this.tkbPitch.TickFrequency = 10;
            this.tkbPitch.Value = 75;
            this.tkbPitch.Scroll += new System.EventHandler(this.tkbPitch_Scroll);
            // 
            // lblPitch
            // 
            this.lblPitch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPitch.Location = new System.Drawing.Point(0, 0);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(150, 30);
            this.lblPitch.TabIndex = 1;
            this.lblPitch.Text = "Pitch:";
            this.lblPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlRoll
            // 
            this.pnlRoll.Controls.Add(this.tkbRoll);
            this.pnlRoll.Controls.Add(this.lblRoll);
            this.pnlRoll.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRoll.Location = new System.Drawing.Point(0, 90);
            this.pnlRoll.Name = "pnlRoll";
            this.pnlRoll.Size = new System.Drawing.Size(374, 30);
            this.pnlRoll.TabIndex = 3;
            // 
            // tkbRoll
            // 
            this.tkbRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tkbRoll.Location = new System.Drawing.Point(150, 0);
            this.tkbRoll.Maximum = 100;
            this.tkbRoll.Name = "tkbRoll";
            this.tkbRoll.Size = new System.Drawing.Size(224, 30);
            this.tkbRoll.SmallChange = 10;
            this.tkbRoll.TabIndex = 2;
            this.tkbRoll.TickFrequency = 10;
            this.tkbRoll.Value = 75;
            this.tkbRoll.Scroll += new System.EventHandler(this.tkbRoll_Scroll);
            // 
            // lblRoll
            // 
            this.lblRoll.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRoll.Location = new System.Drawing.Point(0, 0);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(150, 30);
            this.lblRoll.TabIndex = 1;
            this.lblRoll.Text = "Roll:";
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlHeading
            // 
            this.pnlHeading.Controls.Add(this.tkbHeading);
            this.pnlHeading.Controls.Add(this.lblHeading);
            this.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeading.Location = new System.Drawing.Point(0, 60);
            this.pnlHeading.Name = "pnlHeading";
            this.pnlHeading.Size = new System.Drawing.Size(374, 30);
            this.pnlHeading.TabIndex = 2;
            // 
            // tkbHeading
            // 
            this.tkbHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tkbHeading.Location = new System.Drawing.Point(150, 0);
            this.tkbHeading.Maximum = 100;
            this.tkbHeading.Name = "tkbHeading";
            this.tkbHeading.Size = new System.Drawing.Size(224, 30);
            this.tkbHeading.SmallChange = 10;
            this.tkbHeading.TabIndex = 2;
            this.tkbHeading.TickFrequency = 10;
            this.tkbHeading.Value = 75;
            this.tkbHeading.Scroll += new System.EventHandler(this.tkbHeading_Scroll);
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(150, 30);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Heading:";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPort
            // 
            this.pnlPort.Controls.Add(this.txtPort);
            this.pnlPort.Controls.Add(this.lblPort);
            this.pnlPort.Controls.Add(this.panel2);
            this.pnlPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPort.Location = new System.Drawing.Point(0, 30);
            this.pnlPort.Name = "pnlPort";
            this.pnlPort.Size = new System.Drawing.Size(374, 30);
            this.pnlPort.TabIndex = 1;
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPort.Location = new System.Drawing.Point(150, 0);
            this.txtPort.Multiline = true;
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(224, 25);
            this.txtPort.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPort.Location = new System.Drawing.Point(0, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(150, 25);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port:";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 5);
            this.panel2.TabIndex = 3;
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Controls.Add(this.lblAddress);
            this.pnlAddress.Controls.Add(this.panel1);
            this.pnlAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddress.Location = new System.Drawing.Point(0, 0);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(374, 30);
            this.pnlAddress.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(150, 0);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(224, 25);
            this.txtAddress.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(150, 25);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address IP:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 5);
            this.panel1.TabIndex = 2;
            // 
            // pnlCommand
            // 
            this.pnlCommand.Controls.Add(this.btnActive);
            this.pnlCommand.Controls.Add(this.btnDeactivate);
            this.pnlCommand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCommand.Location = new System.Drawing.Point(5, 176);
            this.pnlCommand.Name = "pnlCommand";
            this.pnlCommand.Size = new System.Drawing.Size(374, 30);
            this.pnlCommand.TabIndex = 1;
            // 
            // btnActive
            // 
            this.btnActive.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActive.Location = new System.Drawing.Point(224, 0);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(75, 30);
            this.btnActive.TabIndex = 0;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeactivate.Location = new System.Drawing.Point(299, 0);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(75, 30);
            this.btnDeactivate.TabIndex = 1;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Visible = false;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.pnlCommand);
            this.Controls.Add(this.pnlConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XPControl";
            this.pnlConfig.ResumeLayout(false);
            this.pnlPitch.ResumeLayout(false);
            this.pnlPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbPitch)).EndInit();
            this.pnlRoll.ResumeLayout(false);
            this.pnlRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbRoll)).EndInit();
            this.pnlHeading.ResumeLayout(false);
            this.pnlHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbHeading)).EndInit();
            this.pnlPort.ResumeLayout(false);
            this.pnlPort.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlCommand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Panel pnlHeading;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TrackBar tkbHeading;
        private System.Windows.Forms.Panel pnlRoll;
        private System.Windows.Forms.TrackBar tkbRoll;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Panel pnlPitch;
        private System.Windows.Forms.TrackBar tkbPitch;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Panel pnlCommand;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

