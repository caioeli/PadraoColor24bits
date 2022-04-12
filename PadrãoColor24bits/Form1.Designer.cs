
namespace PadrãoColor24bits
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
            this.tbred = new System.Windows.Forms.TextBox();
            this.lblred = new System.Windows.Forms.Label();
            this.lblgreen = new System.Windows.Forms.Label();
            this.lblblue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbblue = new System.Windows.Forms.TextBox();
            this.tbgreen = new System.Windows.Forms.TextBox();
            this.hdbred = new System.Windows.Forms.HScrollBar();
            this.hsbblue = new System.Windows.Forms.HScrollBar();
            this.hsbgreen = new System.Windows.Forms.HScrollBar();
            this.lblcores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbred
            // 
            this.tbred.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbred.Location = new System.Drawing.Point(123, 105);
            this.tbred.Name = "tbred";
            this.tbred.Size = new System.Drawing.Size(50, 23);
            this.tbred.TabIndex = 4;
            this.tbred.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblred
            // 
            this.lblred.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblred.BackColor = System.Drawing.Color.Red;
            this.lblred.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblred.Location = new System.Drawing.Point(68, 105);
            this.lblred.Name = "lblred";
            this.lblred.Size = new System.Drawing.Size(43, 23);
            this.lblred.TabIndex = 0;
            // 
            // lblgreen
            // 
            this.lblgreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblgreen.Location = new System.Drawing.Point(68, 163);
            this.lblgreen.Name = "lblgreen";
            this.lblgreen.Size = new System.Drawing.Size(43, 23);
            this.lblgreen.TabIndex = 1;
            // 
            // lblblue
            // 
            this.lblblue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblblue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblblue.Location = new System.Drawing.Point(68, 220);
            this.lblblue.Name = "lblblue";
            this.lblblue.Size = new System.Drawing.Size(43, 23);
            this.lblblue.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vineta BT", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(171, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "RGB";
            // 
            // tbblue
            // 
            this.tbblue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbblue.Location = new System.Drawing.Point(123, 220);
            this.tbblue.Name = "tbblue";
            this.tbblue.Size = new System.Drawing.Size(50, 23);
            this.tbblue.TabIndex = 5;
            // 
            // tbgreen
            // 
            this.tbgreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbgreen.Location = new System.Drawing.Point(123, 163);
            this.tbgreen.Name = "tbgreen";
            this.tbgreen.Size = new System.Drawing.Size(50, 23);
            this.tbgreen.TabIndex = 6;
            this.tbgreen.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // hdbred
            // 
            this.hdbred.LargeChange = 1;
            this.hdbred.Location = new System.Drawing.Point(182, 108);
            this.hdbred.Maximum = 255;
            this.hdbred.Name = "hdbred";
            this.hdbred.Size = new System.Drawing.Size(223, 17);
            this.hdbred.TabIndex = 9;
            this.hdbred.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hdbred_Scroll);
            // 
            // hsbblue
            // 
            this.hsbblue.LargeChange = 1;
            this.hsbblue.Location = new System.Drawing.Point(182, 223);
            this.hsbblue.Maximum = 255;
            this.hsbblue.Name = "hsbblue";
            this.hsbblue.Size = new System.Drawing.Size(223, 17);
            this.hsbblue.TabIndex = 10;
            this.hsbblue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbblue_Scroll);
            // 
            // hsbgreen
            // 
            this.hsbgreen.LargeChange = 1;
            this.hsbgreen.Location = new System.Drawing.Point(182, 166);
            this.hsbgreen.Maximum = 255;
            this.hsbgreen.Name = "hsbgreen";
            this.hsbgreen.Size = new System.Drawing.Size(223, 17);
            this.hsbgreen.TabIndex = 11;
            this.hsbgreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbgreen_Scroll);
            // 
            // lblcores
            // 
            this.lblcores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcores.BackColor = System.Drawing.Color.White;
            this.lblcores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcores.Location = new System.Drawing.Point(68, 274);
            this.lblcores.Name = "lblcores";
            this.lblcores.Size = new System.Drawing.Size(337, 159);
            this.lblcores.TabIndex = 12;
            this.lblcores.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 475);
            this.Controls.Add(this.lblcores);
            this.Controls.Add(this.hsbgreen);
            this.Controls.Add(this.hsbblue);
            this.Controls.Add(this.hdbred);
            this.Controls.Add(this.tbgreen);
            this.Controls.Add(this.tbblue);
            this.Controls.Add(this.tbred);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblblue);
            this.Controls.Add(this.lblgreen);
            this.Controls.Add(this.lblred);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório de Cores.....";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblred;
        private System.Windows.Forms.Label lblgreen;
        private System.Windows.Forms.Label lblblue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbblue;
        private System.Windows.Forms.TextBox tbgreen;
        private System.Windows.Forms.HScrollBar hdbred;
        private System.Windows.Forms.HScrollBar hsbblue;
        private System.Windows.Forms.HScrollBar hsbgreen;
        private System.Windows.Forms.Label lblcores;
        public System.Windows.Forms.TextBox tbred;
    }
}

