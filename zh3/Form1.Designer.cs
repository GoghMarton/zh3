namespace zh3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserControl3 = new System.Windows.Forms.Button();
            this.UserControl2 = new System.Windows.Forms.Button();
            this.Usercontrol1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.UserControl3);
            this.panel1.Controls.Add(this.UserControl2);
            this.panel1.Controls.Add(this.Usercontrol1);
            this.panel1.Location = new System.Drawing.Point(28, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 627);
            this.panel1.TabIndex = 0;
            // 
            // UserControl3
            // 
            this.UserControl3.Location = new System.Drawing.Point(686, 27);
            this.UserControl3.Name = "UserControl3";
            this.UserControl3.Size = new System.Drawing.Size(272, 150);
            this.UserControl3.TabIndex = 2;
            this.UserControl3.Text = "UserControl3";
            this.UserControl3.UseVisualStyleBackColor = true;
            this.UserControl3.Click += new System.EventHandler(this.UserControl3_Click);
            // 
            // UserControl2
            // 
            this.UserControl2.Location = new System.Drawing.Point(375, 27);
            this.UserControl2.Name = "UserControl2";
            this.UserControl2.Size = new System.Drawing.Size(272, 150);
            this.UserControl2.TabIndex = 1;
            this.UserControl2.Text = "UserControl2";
            this.UserControl2.UseVisualStyleBackColor = true;
            this.UserControl2.Click += new System.EventHandler(this.UserControl2_Click);
            // 
            // Usercontrol1
            // 
            this.Usercontrol1.Location = new System.Drawing.Point(53, 27);
            this.Usercontrol1.Name = "Usercontrol1";
            this.Usercontrol1.Size = new System.Drawing.Size(272, 150);
            this.Usercontrol1.TabIndex = 0;
            this.Usercontrol1.Text = "UserControl1";
            this.Usercontrol1.UseVisualStyleBackColor = true;
            this.Usercontrol1.Click += new System.EventHandler(this.Usercontrol1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 835);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button UserControl3;
        private Button UserControl2;
        private Button Usercontrol1;
    }
}