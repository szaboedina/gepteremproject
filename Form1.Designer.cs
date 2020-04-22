namespace GepteremProjekt
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mentes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elore = new System.Windows.Forms.Button();
            this.vissza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(249, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 426);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // mentes
            // 
            this.mentes.BackColor = System.Drawing.Color.Transparent;
            this.mentes.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mentes.Location = new System.Drawing.Point(86, 337);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(75, 75);
            this.mentes.TabIndex = 4;
            this.mentes.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 178);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // elore
            // 
            this.elore.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.elore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elore.Location = new System.Drawing.Point(193, 206);
            this.elore.Name = "elore";
            this.elore.Size = new System.Drawing.Size(50, 50);
            this.elore.TabIndex = 1;
            this.elore.UseVisualStyleBackColor = true;
            this.elore.Click += new System.EventHandler(this.Elore_Click);
            // 
            // vissza
            // 
            this.vissza.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.vissza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vissza.Location = new System.Drawing.Point(0, 206);
            this.vissza.Name = "vissza";
            this.vissza.Size = new System.Drawing.Size(50, 50);
            this.vissza.TabIndex = 0;
            this.vissza.UseVisualStyleBackColor = true;
            this.vissza.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.elore);
            this.Controls.Add(this.vissza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vissza;
        private System.Windows.Forms.Button elore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button mentes;
    }
}

