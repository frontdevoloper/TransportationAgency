
namespace TransportationAgency
{
    partial class TransportationComplited
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
            this.NewCargoBtn = new System.Windows.Forms.Button();
            this.SstatisticsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш груз доставлен";
            // 
            // NewCargoBtn
            // 
            this.NewCargoBtn.Location = new System.Drawing.Point(75, 160);
            this.NewCargoBtn.Name = "NewCargoBtn";
            this.NewCargoBtn.Size = new System.Drawing.Size(336, 48);
            this.NewCargoBtn.TabIndex = 1;
            this.NewCargoBtn.Text = "Отправить новый груз";
            this.NewCargoBtn.UseVisualStyleBackColor = true;
            this.NewCargoBtn.Click += new System.EventHandler(this.NewCargoBtn_Click);
            // 
            // SstatisticsButton
            // 
            this.SstatisticsButton.Location = new System.Drawing.Point(75, 244);
            this.SstatisticsButton.Name = "SstatisticsButton";
            this.SstatisticsButton.Size = new System.Drawing.Size(336, 48);
            this.SstatisticsButton.TabIndex = 2;
            this.SstatisticsButton.Text = "Статистика доставки";
            this.SstatisticsButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(75, 328);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(336, 51);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TransportationComplited
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SstatisticsButton);
            this.Controls.Add(this.NewCargoBtn);
            this.Controls.Add(this.label1);
            this.Name = "TransportationComplited";
            this.Text = "TransportationComplited";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewCargoBtn;
        private System.Windows.Forms.Button SstatisticsButton;
        private System.Windows.Forms.Button ExitButton;
    }
}