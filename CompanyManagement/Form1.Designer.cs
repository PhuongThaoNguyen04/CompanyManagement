namespace CompanyManagement
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
            this.btnParttime = new System.Windows.Forms.Button();
            this.btnGw = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParttime
            // 
            this.btnParttime.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParttime.Location = new System.Drawing.Point(136, 282);
            this.btnParttime.Name = "btnParttime";
            this.btnParttime.Size = new System.Drawing.Size(189, 59);
            this.btnParttime.TabIndex = 2;
            this.btnParttime.Text = "Part Time";
            this.btnParttime.UseVisualStyleBackColor = true;
            this.btnParttime.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGw
            // 
            this.btnGw.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGw.Location = new System.Drawing.Point(112, 173);
            this.btnGw.Name = "btnGw";
            this.btnGw.Size = new System.Drawing.Size(228, 59);
            this.btnGw.TabIndex = 1;
            this.btnGw.Text = "General Worker";
            this.btnGw.UseVisualStyleBackColor = true;
            this.btnGw.Click += new System.EventHandler(this.btnGw_Click);
            // 
            // btnManager
            // 
            this.btnManager.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Location = new System.Drawing.Point(136, 57);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(189, 59);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 463);
            this.Controls.Add(this.btnParttime);
            this.Controls.Add(this.btnGw);
            this.Controls.Add(this.btnManager);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParttime;
        private System.Windows.Forms.Button btnGw;
        private System.Windows.Forms.Button btnManager;
    }
}

