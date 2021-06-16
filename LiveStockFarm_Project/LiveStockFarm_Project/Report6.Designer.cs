namespace LiveStockFarm_Project
{
    partial class Report6
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
            this.label6 = new System.Windows.Forms.Label();
            this.sheepprofit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.goatprofit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cowprofit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Sheeps Profitability :";
            // 
            // sheepprofit
            // 
            this.sheepprofit.Location = new System.Drawing.Point(807, 169);
            this.sheepprofit.Margin = new System.Windows.Forms.Padding(4);
            this.sheepprofit.Name = "sheepprofit";
            this.sheepprofit.ReadOnly = true;
            this.sheepprofit.Size = new System.Drawing.Size(156, 22);
            this.sheepprofit.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Goats Profitability : ";
            // 
            // goatprofit
            // 
            this.goatprofit.Location = new System.Drawing.Point(254, 229);
            this.goatprofit.Margin = new System.Windows.Forms.Padding(4);
            this.goatprofit.Name = "goatprofit";
            this.goatprofit.ReadOnly = true;
            this.goatprofit.Size = new System.Drawing.Size(156, 22);
            this.goatprofit.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cows Profitability : ";
            // 
            // cowprofit
            // 
            this.cowprofit.Location = new System.Drawing.Point(254, 169);
            this.cowprofit.Margin = new System.Windows.Forms.Padding(4);
            this.cowprofit.Name = "cowprofit";
            this.cowprofit.ReadOnly = true;
            this.cowprofit.Size = new System.Drawing.Size(156, 22);
            this.cowprofit.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Profitability of (Goats,Cows)\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(566, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 44);
            this.label3.TabIndex = 34;
            this.label3.Text = "Profitability of Sheep";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Report6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sheepprofit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.goatprofit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cowprofit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report6";
            this.Text = "Report6";
            this.Load += new System.EventHandler(this.Report6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sheepprofit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox goatprofit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cowprofit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}