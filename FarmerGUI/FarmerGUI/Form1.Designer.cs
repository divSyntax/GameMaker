namespace FarmerGUI
{
    partial class FarmerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerGUI));
            this.farmer1 = new System.Windows.Forms.PictureBox();
            this.chicken2 = new System.Windows.Forms.PictureBox();
            this.fox = new System.Windows.Forms.PictureBox();
            this.grain = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.farmer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grain)).BeginInit();
            this.SuspendLayout();
            // 
            // farmer1
            // 
            this.farmer1.Image = ((System.Drawing.Image)(resources.GetObject("farmer1.Image")));
            this.farmer1.Location = new System.Drawing.Point(456, 252);
            this.farmer1.Name = "farmer1";
            this.farmer1.Size = new System.Drawing.Size(93, 192);
            this.farmer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.farmer1.TabIndex = 0;
            this.farmer1.TabStop = false;
            // 
            // chicken2
            // 
            this.chicken2.Image = ((System.Drawing.Image)(resources.GetObject("chicken2.Image")));
            this.chicken2.Location = new System.Drawing.Point(672, 276);
            this.chicken2.Name = "chicken2";
            this.chicken2.Size = new System.Drawing.Size(100, 118);
            this.chicken2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chicken2.TabIndex = 1;
            this.chicken2.TabStop = false;
            // 
            // fox
            // 
            this.fox.Image = ((System.Drawing.Image)(resources.GetObject("fox.Image")));
            this.fox.Location = new System.Drawing.Point(589, 423);
            this.fox.Name = "fox";
            this.fox.Size = new System.Drawing.Size(267, 209);
            this.fox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fox.TabIndex = 2;
            this.fox.TabStop = false;
            // 
            // grain
            // 
            this.grain.Image = ((System.Drawing.Image)(resources.GetObject("grain.Image")));
            this.grain.Location = new System.Drawing.Point(617, 43);
            this.grain.Name = "grain";
            this.grain.Size = new System.Drawing.Size(203, 189);
            this.grain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.grain.TabIndex = 3;
            this.grain.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(254, 586);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(162, 66);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(672, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(672, 400);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(672, 638);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // FarmerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 673);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grain);
            this.Controls.Add(this.fox);
            this.Controls.Add(this.chicken2);
            this.Controls.Add(this.farmer1);
            this.DoubleBuffered = true;
            this.Name = "FarmerGUI";
            this.Text = "FarmerGUI";
            this.Load += new System.EventHandler(this.FarmerGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.farmer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chicken2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox farmer1;
        private System.Windows.Forms.PictureBox chicken2;
        private System.Windows.Forms.PictureBox fox;
        private System.Windows.Forms.PictureBox grain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

