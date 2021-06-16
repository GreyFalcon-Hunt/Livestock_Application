namespace LiveStockFarm_Project
{
    partial class Report3
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
            this.label3 = new System.Windows.Forms.Label();
            this.totaltax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalgoats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totaljcows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalcows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Total Tax Per Month : ";
            // 
            // totaltax
            // 
            this.totaltax.Location = new System.Drawing.Point(590, 211);
            this.totaltax.Margin = new System.Windows.Forms.Padding(4);
            this.totaltax.Name = "totaltax";
            this.totaltax.ReadOnly = true;
            this.totaltax.Size = new System.Drawing.Size(156, 22);
            this.totaltax.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(834, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Goat  : ";
            // 
            // totalgoats
            // 
            this.totalgoats.Location = new System.Drawing.Point(946, 121);
            this.totalgoats.Margin = new System.Windows.Forms.Padding(4);
            this.totalgoats.Name = "totalgoats";
            this.totalgoats.ReadOnly = true;
            this.totalgoats.Size = new System.Drawing.Size(156, 22);
            this.totalgoats.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Jersy Cow  : ";
            // 
            // totaljcows
            // 
            this.totaljcows.Location = new System.Drawing.Point(590, 121);
            this.totaljcows.Margin = new System.Windows.Forms.Padding(4);
            this.totaljcows.Name = "totaljcows";
            this.totaljcows.ReadOnly = true;
            this.totaljcows.Size = new System.Drawing.Size(156, 22);
            this.totaljcows.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Cows  : ";
            // 
            // totalcows
            // 
            this.totalcows.Location = new System.Drawing.Point(214, 124);
            this.totalcows.Margin = new System.Windows.Forms.Padding(4);
            this.totalcows.Name = "totalcows";
            this.totalcows.ReadOnly = true;
            this.totalcows.Size = new System.Drawing.Size(156, 22);
            this.totalcows.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 44);
            this.label1.TabIndex = 68;
            this.label1.Text = "Total tax payed to Government";
            // 
            // Report3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totaltax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalgoats);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totaljcows);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalcows);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report3";
            this.Text = "Report3";
            this.Load += new System.EventHandler(this.Report3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totaltax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalgoats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totaljcows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalcows;
        private System.Windows.Forms.Label label1;
    }
}