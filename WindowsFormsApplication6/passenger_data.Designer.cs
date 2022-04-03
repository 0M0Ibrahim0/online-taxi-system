namespace WindowsFormsApplication6
{
    partial class passenger_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passenger_data));
            this.signup_passen_phone_label = new System.Windows.Forms.Label();
            this.pass_phone_txtbox = new System.Windows.Forms.TextBox();
            this.signup_passen_email_label = new System.Windows.Forms.Label();
            this.passen_name_label = new System.Windows.Forms.Label();
            this.pass_email_txtbox = new System.Windows.Forms.TextBox();
            this.pass_name_txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signup_passen_phone_label
            // 
            this.signup_passen_phone_label.AutoSize = true;
            this.signup_passen_phone_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_passen_phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_passen_phone_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup_passen_phone_label.Location = new System.Drawing.Point(37, 124);
            this.signup_passen_phone_label.Name = "signup_passen_phone_label";
            this.signup_passen_phone_label.Size = new System.Drawing.Size(49, 17);
            this.signup_passen_phone_label.TabIndex = 48;
            this.signup_passen_phone_label.Text = "Phone";
            // 
            // pass_phone_txtbox
            // 
            this.pass_phone_txtbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pass_phone_txtbox.Enabled = false;
            this.pass_phone_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_phone_txtbox.Location = new System.Drawing.Point(12, 148);
            this.pass_phone_txtbox.Name = "pass_phone_txtbox";
            this.pass_phone_txtbox.ReadOnly = true;
            this.pass_phone_txtbox.Size = new System.Drawing.Size(100, 19);
            this.pass_phone_txtbox.TabIndex = 47;
            // 
            // signup_passen_email_label
            // 
            this.signup_passen_email_label.AutoSize = true;
            this.signup_passen_email_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_passen_email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_passen_email_label.ForeColor = System.Drawing.SystemColors.Control;
            this.signup_passen_email_label.Location = new System.Drawing.Point(163, 34);
            this.signup_passen_email_label.Name = "signup_passen_email_label";
            this.signup_passen_email_label.Size = new System.Drawing.Size(47, 17);
            this.signup_passen_email_label.TabIndex = 46;
            this.signup_passen_email_label.Text = "E-Mail";
            // 
            // passen_name_label
            // 
            this.passen_name_label.AutoSize = true;
            this.passen_name_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passen_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passen_name_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passen_name_label.Location = new System.Drawing.Point(295, 124);
            this.passen_name_label.Name = "passen_name_label";
            this.passen_name_label.Size = new System.Drawing.Size(45, 17);
            this.passen_name_label.TabIndex = 45;
            this.passen_name_label.Text = "Name";
            // 
            // pass_email_txtbox
            // 
            this.pass_email_txtbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pass_email_txtbox.Enabled = false;
            this.pass_email_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_email_txtbox.Location = new System.Drawing.Point(123, 54);
            this.pass_email_txtbox.Name = "pass_email_txtbox";
            this.pass_email_txtbox.ReadOnly = true;
            this.pass_email_txtbox.Size = new System.Drawing.Size(129, 19);
            this.pass_email_txtbox.TabIndex = 44;
            this.pass_email_txtbox.TextChanged += new System.EventHandler(this.pass_email_txtbox_TextChanged);
            // 
            // pass_name_txtbox
            // 
            this.pass_name_txtbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pass_name_txtbox.Enabled = false;
            this.pass_name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_name_txtbox.Location = new System.Drawing.Point(259, 148);
            this.pass_name_txtbox.Name = "pass_name_txtbox";
            this.pass_name_txtbox.ReadOnly = true;
            this.pass_name_txtbox.Size = new System.Drawing.Size(109, 19);
            this.pass_name_txtbox.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passenger_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(371, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signup_passen_phone_label);
            this.Controls.Add(this.pass_phone_txtbox);
            this.Controls.Add(this.signup_passen_email_label);
            this.Controls.Add(this.passen_name_label);
            this.Controls.Add(this.pass_email_txtbox);
            this.Controls.Add(this.pass_name_txtbox);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "passenger_data";
            this.Text = "passenger_data";
            this.Load += new System.EventHandler(this.passenger_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signup_passen_phone_label;
        private System.Windows.Forms.TextBox pass_phone_txtbox;
        private System.Windows.Forms.Label signup_passen_email_label;
        private System.Windows.Forms.Label passen_name_label;
        private System.Windows.Forms.TextBox pass_email_txtbox;
        private System.Windows.Forms.TextBox pass_name_txtbox;
        private System.Windows.Forms.Button button1;
    }
}