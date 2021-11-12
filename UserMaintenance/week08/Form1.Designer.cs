
namespace week08
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.Carbutton = new System.Windows.Forms.Button();
            this.Ballbutton = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 129);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(981, 334);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // Carbutton
            // 
            this.Carbutton.Location = new System.Drawing.Point(133, 12);
            this.Carbutton.Name = "Carbutton";
            this.Carbutton.Size = new System.Drawing.Size(75, 23);
            this.Carbutton.TabIndex = 1;
            this.Carbutton.Text = "CAR";
            this.Carbutton.UseVisualStyleBackColor = true;
            this.Carbutton.Click += new System.EventHandler(this.Carbutton_Click);
            // 
            // Ballbutton
            // 
            this.Ballbutton.Location = new System.Drawing.Point(227, 12);
            this.Ballbutton.Name = "Ballbutton";
            this.Ballbutton.Size = new System.Drawing.Size(75, 23);
            this.Ballbutton.TabIndex = 2;
            this.Ballbutton.Text = "BALL";
            this.Ballbutton.UseVisualStyleBackColor = true;
            this.Ballbutton.Click += new System.EventHandler(this.Ballbutton_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(12, 9);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming next:";
            // 
            // btnBallColor
            // 
            this.btnBallColor.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBallColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBallColor.Location = new System.Drawing.Point(227, 41);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(75, 23);
            this.btnBallColor.TabIndex = 4;
            this.btnBallColor.UseVisualStyleBackColor = false;
            this.btnBallColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 499);
            this.Controls.Add(this.btnBallColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.Ballbutton);
            this.Controls.Add(this.Carbutton);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Timer createTimer;
        public System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button Carbutton;
        private System.Windows.Forms.Button Ballbutton;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnBallColor;
    }
}

