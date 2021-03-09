namespace Defibrillator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnAdatok = new System.Windows.Forms.Button();
            this.btnUjAdat = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.lbKiiras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "x koordináta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "y koordináta:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(215, 62);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(182, 34);
            this.tbX.TabIndex = 2;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(215, 124);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(182, 34);
            this.tbY.TabIndex = 3;
            // 
            // btnAdatok
            // 
            this.btnAdatok.Location = new System.Drawing.Point(170, 186);
            this.btnAdatok.Name = "btnAdatok";
            this.btnAdatok.Size = new System.Drawing.Size(209, 43);
            this.btnAdatok.TabIndex = 4;
            this.btnAdatok.Text = "Adatok lekérése";
            this.btnAdatok.UseVisualStyleBackColor = true;
            // 
            // btnUjAdat
            // 
            this.btnUjAdat.Location = new System.Drawing.Point(41, 684);
            this.btnUjAdat.Name = "btnUjAdat";
            this.btnUjAdat.Size = new System.Drawing.Size(242, 48);
            this.btnUjAdat.TabIndex = 5;
            this.btnUjAdat.Text = "Új adat megadása";
            this.btnUjAdat.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(392, 684);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(121, 48);
            this.btnKilepes.TabIndex = 6;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            // 
            // lbKiiras
            // 
            this.lbKiiras.FormattingEnabled = true;
            this.lbKiiras.ItemHeight = 29;
            this.lbKiiras.Location = new System.Drawing.Point(31, 251);
            this.lbKiiras.Name = "lbKiiras";
            this.lbKiiras.Size = new System.Drawing.Size(518, 410);
            this.lbKiiras.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.lbKiiras);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnUjAdat);
            this.Controls.Add(this.btnAdatok);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnAdatok;
        private System.Windows.Forms.Button btnUjAdat;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.ListBox lbKiiras;
    }
}

