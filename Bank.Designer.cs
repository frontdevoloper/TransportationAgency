
namespace TransportationAgency
{
    partial class Bank
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
            this.MoneyLebel = new System.Windows.Forms.Label();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.AddMoneyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лицевой счет";
            // 
            // MoneyLebel
            // 
            this.MoneyLebel.AutoSize = true;
            this.MoneyLebel.Location = new System.Drawing.Point(199, 137);
            this.MoneyLebel.Name = "MoneyLebel";
            this.MoneyLebel.Size = new System.Drawing.Size(45, 15);
            this.MoneyLebel.TabIndex = 1;
            this.MoneyLebel.Text = "Сумма";
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(250, 134);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(339, 23);
            this.MoneyTextBox.TabIndex = 2;
            this.MoneyTextBox.Text = "0";
            // 
            // AddMoneyBtn
            // 
            this.AddMoneyBtn.Location = new System.Drawing.Point(312, 201);
            this.AddMoneyBtn.Name = "AddMoneyBtn";
            this.AddMoneyBtn.Size = new System.Drawing.Size(216, 23);
            this.AddMoneyBtn.TabIndex = 3;
            this.AddMoneyBtn.Text = "Пополнить";
            this.AddMoneyBtn.UseVisualStyleBackColor = true;
            this.AddMoneyBtn.Click += new System.EventHandler(this.AddMoneyBtn_Click);
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.AddMoneyBtn);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.MoneyLebel);
            this.Controls.Add(this.label1);
            this.Name = "Bank";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Bank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MoneyLebel;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.Button AddMoneyBtn;
    }
}