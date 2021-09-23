
namespace GetImageLightShot
{
    partial class GetImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetImage));
            this.URL = new System.Windows.Forms.TextBox();
            this.Get = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.Label();
            this.numStart = new System.Windows.Forms.TextBox();
            this.numEnd = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(66, 82);
            this.URL.Name = "URL";
            this.URL.PlaceholderText = "https://prnt.sc/rc";
            this.URL.Size = new System.Drawing.Size(297, 23);
            this.URL.TabIndex = 0;
            this.URL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Get
            // 
            this.Get.Location = new System.Drawing.Point(66, 137);
            this.Get.Name = "Get";
            this.Get.Size = new System.Drawing.Size(589, 23);
            this.Get.TabIndex = 1;
            this.Get.Text = "Get";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.Click += new System.EventHandler(this.Get_Click);
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(66, 64);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(216, 15);
            this.address.TabIndex = 2;
            this.address.Text = "Image Url Without numbers (prnt.sc/rc)";
            // 
            // numStart
            // 
            this.numStart.Location = new System.Drawing.Point(385, 82);
            this.numStart.Name = "numStart";
            this.numStart.PlaceholderText = "1234";
            this.numStart.Size = new System.Drawing.Size(100, 23);
            this.numStart.TabIndex = 3;
            this.numStart.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // numEnd
            // 
            this.numEnd.Location = new System.Drawing.Point(555, 82);
            this.numEnd.Name = "numEnd";
            this.numEnd.PlaceholderText = "5678";
            this.numEnd.Size = new System.Drawing.Size(100, 23);
            this.numEnd.TabIndex = 4;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(385, 64);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(124, 15);
            this.start.TabIndex = 5;
            this.start.Text = "Numbers Start (4digit)";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(555, 61);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(79, 15);
            this.end.TabIndex = 6;
            this.end.Text = "Numbers End";
            // 
            // process
            // 
            this.process.AutoSize = true;
            this.process.Location = new System.Drawing.Point(362, 297);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(47, 15);
            this.process.TabIndex = 7;
            this.process.Text = "process";
            this.process.Visible = false;
            // 
            // GetImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.process);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.numEnd);
            this.Controls.Add(this.numStart);
            this.Controls.Add(this.address);
            this.Controls.Add(this.Get);
            this.Controls.Add(this.URL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetImage";
            this.Text = "LightShot Image Downloader (Alpha)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Button Get;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox numStart;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.TextBox numEnd;
        private System.Windows.Forms.Label process;
    }
}

