namespace WindowsFormsApplication6
{
    partial class promo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(promo));
            this.button1 = new System.Windows.Forms.Button();
            this.code_txtbox = new System.Windows.Forms.TextBox();
            this.discount_txtbox = new System.Windows.Forms.TextBox();
            this.expire_data_txtbox = new System.Windows.Forms.TextBox();
            this.apply_data_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // code_txtbox
            // 
            this.code_txtbox.Location = new System.Drawing.Point(199, 207);
            this.code_txtbox.Name = "code_txtbox";
            this.code_txtbox.Size = new System.Drawing.Size(84, 20);
            this.code_txtbox.TabIndex = 2;
            // 
            // discount_txtbox
            // 
            this.discount_txtbox.Location = new System.Drawing.Point(12, 207);
            this.discount_txtbox.Name = "discount_txtbox";
            this.discount_txtbox.Size = new System.Drawing.Size(88, 20);
            this.discount_txtbox.TabIndex = 3;
            // 
            // expire_data_txtbox
            // 
            this.expire_data_txtbox.Location = new System.Drawing.Point(199, 47);
            this.expire_data_txtbox.Name = "expire_data_txtbox";
            this.expire_data_txtbox.Size = new System.Drawing.Size(84, 20);
            this.expire_data_txtbox.TabIndex = 4;
            // 
            // apply_data_txtbox
            // 
            this.apply_data_txtbox.Location = new System.Drawing.Point(12, 47);
            this.apply_data_txtbox.Name = "apply_data_txtbox";
            this.apply_data_txtbox.Size = new System.Drawing.Size(100, 20);
            this.apply_data_txtbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expire Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apply Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount Of Discount";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // promo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apply_data_txtbox);
            this.Controls.Add(this.expire_data_txtbox);
            this.Controls.Add(this.discount_txtbox);
            this.Controls.Add(this.code_txtbox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "promo";
            this.Text = "promo";
            this.Load += new System.EventHandler(this.promo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox code_txtbox;
        private System.Windows.Forms.TextBox discount_txtbox;
        private System.Windows.Forms.TextBox expire_data_txtbox;
        private System.Windows.Forms.TextBox apply_data_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}