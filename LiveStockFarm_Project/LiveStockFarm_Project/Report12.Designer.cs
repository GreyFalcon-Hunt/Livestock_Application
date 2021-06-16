namespace LiveStockFarm_Project
{
    partial class Report12
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
            this.income = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.expenses = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.profitability = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jersy Cow Profitability";
            // 
            // income
            // 
            this.income.Location = new System.Drawing.Point(480, 118);
            this.income.Margin = new System.Windows.Forms.Padding(4);
            this.income.Name = "income";
            this.income.ReadOnly = true;
            this.income.Size = new System.Drawing.Size(156, 22);
            this.income.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(292, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total Income : ";
            // 
            // expenses
            // 
            this.expenses.Location = new System.Drawing.Point(480, 183);
            this.expenses.Margin = new System.Windows.Forms.Padding(4);
            this.expenses.Name = "expenses";
            this.expenses.ReadOnly = true;
            this.expenses.Size = new System.Drawing.Size(156, 22);
            this.expenses.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(273, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total Expenses: ";
            // 
            // profitability
            // 
            this.profitability.Location = new System.Drawing.Point(480, 252);
            this.profitability.Margin = new System.Windows.Forms.Padding(4);
            this.profitability.Name = "profitability";
            this.profitability.ReadOnly = true;
            this.profitability.Size = new System.Drawing.Size(156, 22);
            this.profitability.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(178, 252);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Total Profitability / Loose : ";
            // 
            // Report12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 340);
            this.Controls.Add(this.expenses);
            this.Controls.Add(this.income);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.profitability);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Report12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report12";
            this.Load += new System.EventHandler(this.Report12_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.TextBox expenses;
        private System.Windows.Forms.TextBox profitability;
        private System.Windows.Forms.Label label15;
    }
}