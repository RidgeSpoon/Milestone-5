namespace Mile_Stone_Inventory_Moving_List
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.butt1 = new System.Windows.Forms.Button();
            this.butt2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butt1
            // 
            this.butt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butt1.Location = new System.Drawing.Point(12, 12);
            this.butt1.Name = "butt1";
            this.butt1.Size = new System.Drawing.Size(359, 23);
            this.butt1.TabIndex = 0;
            this.butt1.Text = "Your Number Is?";
            this.butt1.UseVisualStyleBackColor = false;
            this.butt1.Click += new System.EventHandler(this.butt1_Click);
            // 
            // butt2
            // 
            this.butt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.butt2.Location = new System.Drawing.Point(12, 41);
            this.butt2.Name = "butt2";
            this.butt2.Size = new System.Drawing.Size(359, 23);
            this.butt2.TabIndex = 1;
            this.butt2.Text = "Go Back";
            this.butt2.UseVisualStyleBackColor = false;
            this.butt2.Click += new System.EventHandler(this.butt2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 74);
            this.Controls.Add(this.butt2);
            this.Controls.Add(this.butt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Guess Your Number";
            this.ResumeLayout(false);

        }

        #endregion

        private Button butt1;
        private Button butt2;
    }
}