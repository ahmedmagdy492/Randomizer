namespace Randomizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnMyThings = new System.Windows.Forms.Button();
            this.btnRandomizer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.BtnMyThings);
            this.flowLayoutPanel1.Controls.Add(this.btnRandomizer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(650, 332);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnMyThings
            // 
            this.BtnMyThings.BackColor = System.Drawing.Color.Navy;
            this.BtnMyThings.FlatAppearance.BorderSize = 0;
            this.BtnMyThings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMyThings.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnMyThings.ForeColor = System.Drawing.Color.White;
            this.BtnMyThings.Location = new System.Drawing.Point(336, 23);
            this.BtnMyThings.Name = "BtnMyThings";
            this.BtnMyThings.Size = new System.Drawing.Size(271, 111);
            this.BtnMyThings.TabIndex = 1;
            this.BtnMyThings.Text = "اشيائي (F2)";
            this.BtnMyThings.UseVisualStyleBackColor = false;
            this.BtnMyThings.Click += new System.EventHandler(this.BtnMyThings_Click);
            // 
            // btnRandomizer
            // 
            this.btnRandomizer.BackColor = System.Drawing.Color.Navy;
            this.btnRandomizer.FlatAppearance.BorderSize = 0;
            this.btnRandomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomizer.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRandomizer.ForeColor = System.Drawing.Color.White;
            this.btnRandomizer.Location = new System.Drawing.Point(59, 23);
            this.btnRandomizer.Name = "btnRandomizer";
            this.btnRandomizer.Size = new System.Drawing.Size(271, 111);
            this.btnRandomizer.TabIndex = 2;
            this.btnRandomizer.Text = "اختيار عشوائي ع الطاير (F1)";
            this.btnRandomizer.UseVisualStyleBackColor = false;
            this.btnRandomizer.Click += new System.EventHandler(this.btnRandomizer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 332);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسية";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnMyThings;
        private System.Windows.Forms.Button btnRandomizer;
    }
}
