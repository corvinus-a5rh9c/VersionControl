
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
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(1, 43);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(799, 334);
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
            this.Carbutton.Location = new System.Drawing.Point(120, 386);
            this.Carbutton.Name = "Carbutton";
            this.Carbutton.Size = new System.Drawing.Size(75, 23);
            this.Carbutton.TabIndex = 1;
            this.Carbutton.Text = "CAR";
            this.Carbutton.UseVisualStyleBackColor = true;
            this.Carbutton.Click += new System.EventHandler(this.Carbutton_Click);
            // 
            // Ballbutton
            // 
            this.Ballbutton.Location = new System.Drawing.Point(218, 386);
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
            this.lblNext.Location = new System.Drawing.Point(13, 389);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming next:";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.OrangeRed;
            this.btnColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColor.Location = new System.Drawing.Point(369, 389);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColor);
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
        private System.Windows.Forms.Button btnColor;
    }
}

