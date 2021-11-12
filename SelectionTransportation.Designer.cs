
namespace TransportationAgency
{
    partial class SelectionTransportation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransportComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeOfDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CostOfDeliveryTextBox = new System.Windows.Forms.TextBox();
            this.StatusProgressBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.RefuseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StartPointTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EndPointTextBox = new System.Windows.Forms.TextBox();
            this.TimeDeliveryTimer = new System.Windows.Forms.Timer(this.components);
            this.StopDeliveryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Транспортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Предлогаемый транспорт:";
            // 
            // TransportComboBox
            // 
            this.TransportComboBox.FormattingEnabled = true;
            this.TransportComboBox.Location = new System.Drawing.Point(267, 176);
            this.TransportComboBox.Name = "TransportComboBox";
            this.TransportComboBox.Size = new System.Drawing.Size(153, 23);
            this.TransportComboBox.TabIndex = 2;
            this.TransportComboBox.SelectedIndexChanged += new System.EventHandler(this.TransportComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Время доставки / ч:";
            // 
            // TimeOfDeliveryTextBox
            // 
            this.TimeOfDeliveryTextBox.Location = new System.Drawing.Point(267, 226);
            this.TimeOfDeliveryTextBox.Name = "TimeOfDeliveryTextBox";
            this.TimeOfDeliveryTextBox.ReadOnly = true;
            this.TimeOfDeliveryTextBox.Size = new System.Drawing.Size(153, 23);
            this.TimeOfDeliveryTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоимость транспортировки / руб:";
            // 
            // CostOfDeliveryTextBox
            // 
            this.CostOfDeliveryTextBox.Location = new System.Drawing.Point(267, 275);
            this.CostOfDeliveryTextBox.Name = "CostOfDeliveryTextBox";
            this.CostOfDeliveryTextBox.ReadOnly = true;
            this.CostOfDeliveryTextBox.Size = new System.Drawing.Size(153, 23);
            this.CostOfDeliveryTextBox.TabIndex = 6;
            // 
            // StatusProgressBar
            // 
            this.StatusProgressBar.Location = new System.Drawing.Point(498, 197);
            this.StatusProgressBar.Name = "StatusProgressBar";
            this.StatusProgressBar.Size = new System.Drawing.Size(257, 23);
            this.StatusProgressBar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статус доставки:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(60, 344);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(122, 23);
            this.SendButton.TabIndex = 9;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // RefuseButton
            // 
            this.RefuseButton.Location = new System.Drawing.Point(236, 344);
            this.RefuseButton.Name = "RefuseButton";
            this.RefuseButton.Size = new System.Drawing.Size(121, 23);
            this.RefuseButton.TabIndex = 10;
            this.RefuseButton.Text = "Отказаться";
            this.RefuseButton.UseVisualStyleBackColor = true;
            this.RefuseButton.Click += new System.EventHandler(this.RefuseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Откуда:";
            // 
            // StartPointTextBox
            // 
            this.StartPointTextBox.Location = new System.Drawing.Point(114, 105);
            this.StartPointTextBox.Multiline = true;
            this.StartPointTextBox.Name = "StartPointTextBox";
            this.StartPointTextBox.ReadOnly = true;
            this.StartPointTextBox.Size = new System.Drawing.Size(152, 23);
            this.StartPointTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Куда:";
            // 
            // EndPointTextBox
            // 
            this.EndPointTextBox.Location = new System.Drawing.Point(356, 105);
            this.EndPointTextBox.Name = "EndPointTextBox";
            this.EndPointTextBox.ReadOnly = true;
            this.EndPointTextBox.Size = new System.Drawing.Size(153, 23);
            this.EndPointTextBox.TabIndex = 14;
            // 
            // TimeDeliveryTimer
            // 
            this.TimeDeliveryTimer.Tick += new System.EventHandler(this.TimeDeliveryTimer_Tick);
            // 
            // StopDeliveryButton
            // 
            this.StopDeliveryButton.Location = new System.Drawing.Point(139, 397);
            this.StopDeliveryButton.Name = "StopDeliveryButton";
            this.StopDeliveryButton.Size = new System.Drawing.Size(122, 23);
            this.StopDeliveryButton.TabIndex = 15;
            this.StopDeliveryButton.Text = "Остановить";
            this.StopDeliveryButton.UseVisualStyleBackColor = true;
            this.StopDeliveryButton.Visible = false;
            this.StopDeliveryButton.Click += new System.EventHandler(this.StopDeliveryButton_Click);
            // 
            // SelectionTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopDeliveryButton);
            this.Controls.Add(this.EndPointTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StartPointTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RefuseButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StatusProgressBar);
            this.Controls.Add(this.CostOfDeliveryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeOfDeliveryTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TransportComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelectionTransportation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionTransportation";            
            this.Load += new System.EventHandler(this.SelectionTransportation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TransportComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TimeOfDeliveryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostOfDeliveryTextBox;
        private System.Windows.Forms.ProgressBar StatusProgressBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button RefuseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StartPointTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EndPointTextBox;
        private System.Windows.Forms.Timer TimeDeliveryTimer;
        private System.Windows.Forms.Button StopDeliveryButton;
    }
}