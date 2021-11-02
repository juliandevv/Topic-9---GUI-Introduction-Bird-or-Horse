namespace Topic_9___GUI_Introduction_Assignment
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
            this.btnBird = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHorse = new System.Windows.Forms.Button();
            this.imgHorse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHorse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBird
            // 
            this.btnBird.AccessibleName = "btnShowImg";
            this.btnBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBird.Location = new System.Drawing.Point(271, 99);
            this.btnBird.Name = "btnBird";
            this.btnBird.Size = new System.Drawing.Size(80, 31);
            this.btnBird.TabIndex = 0;
            this.btnBird.Text = "Bird";
            this.btnBird.UseVisualStyleBackColor = true;
            this.btnBird.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblHello";
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(300, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bird or Horse?";
            this.label1.UseMnemonic = false;
            // 
            // btnHorse
            // 
            this.btnHorse.Location = new System.Drawing.Point(420, 99);
            this.btnHorse.Name = "btnHorse";
            this.btnHorse.Size = new System.Drawing.Size(75, 31);
            this.btnHorse.TabIndex = 3;
            this.btnHorse.Text = "Horse";
            this.btnHorse.UseVisualStyleBackColor = true;
            this.btnHorse.Click += new System.EventHandler(this.btnHorse_Click);
            // 
            // imgHorse
            // 
            this.imgHorse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgHorse.Location = new System.Drawing.Point(270, 146);
            this.imgHorse.Name = "imgHorse";
            this.imgHorse.Size = new System.Drawing.Size(225, 194);
            this.imgHorse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHorse.TabIndex = 4;
            this.imgHorse.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgHorse);
            this.Controls.Add(this.btnHorse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBird);
            this.Name = "Form1";
            this.Text = "Bird";
            ((System.ComponentModel.ISupportInitialize)(this.imgHorse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHorse;
        private System.Windows.Forms.PictureBox imgHorse;
    }
}

