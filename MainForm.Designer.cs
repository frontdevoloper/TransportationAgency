
namespace TransportationAgency
{
    partial class MainForm
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
            this.GreetingTextLebel = new System.Windows.Forms.Label();
            this.UserMoneyAmountTextLebel = new System.Windows.Forms.Label();
            this.ReplenishmentButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.WeightOfCargoLebel = new System.Windows.Forms.Label();
            this.WeightOfCargoTextBox = new System.Windows.Forms.TextBox();
            this.StartingPointTransportationLebel = new System.Windows.Forms.Label();
            this.EndPointTransportationTextBox = new System.Windows.Forms.TextBox();
            this.StartingPointTransportationTextBox = new System.Windows.Forms.TextBox();
            this.EndPointTransportationLebel = new System.Windows.Forms.Label();
            this.AdditionalFeaturesCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceLebel = new System.Windows.Forms.Label();
            this.PriceComboBox = new System.Windows.Forms.ComboBox();
            this.TimeOfDeliveryLebel = new System.Windows.Forms.Label();
            this.TimeOfDeliveryComboBox = new System.Windows.Forms.ComboBox();
            this.CheckTransportationButton = new System.Windows.Forms.Button();
            this.AdditionalFeaturesgroupBox = new System.Windows.Forms.GroupBox();
            this.MessageLebel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpdateUserMoneyBtn = new System.Windows.Forms.Button();
            this.TransportSelectionButton = new System.Windows.Forms.Button();
            this.AdditionalFeaturesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // GreetingTextLebel
            // 
            this.GreetingTextLebel.AutoSize = true;
            this.GreetingTextLebel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GreetingTextLebel.Location = new System.Drawing.Point(261, 21);
            this.GreetingTextLebel.Name = "GreetingTextLebel";
            this.GreetingTextLebel.Size = new System.Drawing.Size(322, 47);
            this.GreetingTextLebel.TabIndex = 0;
            this.GreetingTextLebel.Text = "Добро пожаловть!";
            // 
            // UserMoneyAmountTextLebel
            // 
            this.UserMoneyAmountTextLebel.AutoSize = true;
            this.UserMoneyAmountTextLebel.Location = new System.Drawing.Point(677, 37);
            this.UserMoneyAmountTextLebel.Name = "UserMoneyAmountTextLebel";
            this.UserMoneyAmountTextLebel.Size = new System.Drawing.Size(38, 15);
            this.UserMoneyAmountTextLebel.TabIndex = 1;
            this.UserMoneyAmountTextLebel.Text = "label1";
            this.UserMoneyAmountTextLebel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReplenishmentButton
            // 
            this.ReplenishmentButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReplenishmentButton.Location = new System.Drawing.Point(721, 33);
            this.ReplenishmentButton.Name = "ReplenishmentButton";
            this.ReplenishmentButton.Size = new System.Drawing.Size(28, 23);
            this.ReplenishmentButton.TabIndex = 2;
            this.ReplenishmentButton.Text = "+";
            this.ReplenishmentButton.UseVisualStyleBackColor = true;
            this.ReplenishmentButton.Click += new System.EventHandler(this.ReplenishmentButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Подробная информация о компании";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // WeightOfCargoLebel
            // 
            this.WeightOfCargoLebel.AutoSize = true;
            this.WeightOfCargoLebel.Location = new System.Drawing.Point(74, 141);
            this.WeightOfCargoLebel.Name = "WeightOfCargoLebel";
            this.WeightOfCargoLebel.Size = new System.Drawing.Size(74, 15);
            this.WeightOfCargoLebel.TabIndex = 4;
            this.WeightOfCargoLebel.Text = "Масса груза";
            // 
            // WeightOfCargoTextBox
            // 
            this.WeightOfCargoTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.WeightOfCargoTextBox.Location = new System.Drawing.Point(154, 138);
            this.WeightOfCargoTextBox.Name = "WeightOfCargoTextBox";
            this.WeightOfCargoTextBox.Size = new System.Drawing.Size(168, 23);
            this.WeightOfCargoTextBox.TabIndex = 1;
            this.WeightOfCargoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WeightOfCargoTextBox_Validating);
            // 
            // StartingPointTransportationLebel
            // 
            this.StartingPointTransportationLebel.AutoSize = true;
            this.StartingPointTransportationLebel.Location = new System.Drawing.Point(74, 197);
            this.StartingPointTransportationLebel.Name = "StartingPointTransportationLebel";
            this.StartingPointTransportationLebel.Size = new System.Drawing.Size(45, 15);
            this.StartingPointTransportationLebel.TabIndex = 6;
            this.StartingPointTransportationLebel.Text = "Откуда";
            // 
            // EndPointTransportationTextBox
            // 
            this.EndPointTransportationTextBox.Location = new System.Drawing.Point(154, 244);
            this.EndPointTransportationTextBox.Name = "EndPointTransportationTextBox";
            this.EndPointTransportationTextBox.Size = new System.Drawing.Size(168, 23);
            this.EndPointTransportationTextBox.TabIndex = 3;
            this.EndPointTransportationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EndPointTransportationTextBox_Validating);
            // 
            // StartingPointTransportationTextBox
            // 
            this.StartingPointTransportationTextBox.Location = new System.Drawing.Point(154, 194);
            this.StartingPointTransportationTextBox.Name = "StartingPointTransportationTextBox";
            this.StartingPointTransportationTextBox.Size = new System.Drawing.Size(168, 23);
            this.StartingPointTransportationTextBox.TabIndex = 2;
            this.StartingPointTransportationTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.StartingPointTransportationTextBox_Validating);
            // 
            // EndPointTransportationLebel
            // 
            this.EndPointTransportationLebel.AutoSize = true;
            this.EndPointTransportationLebel.Location = new System.Drawing.Point(74, 247);
            this.EndPointTransportationLebel.Name = "EndPointTransportationLebel";
            this.EndPointTransportationLebel.Size = new System.Drawing.Size(32, 15);
            this.EndPointTransportationLebel.TabIndex = 9;
            this.EndPointTransportationLebel.Text = "Куда";
            // 
            // AdditionalFeaturesCheckBox
            // 
            this.AdditionalFeaturesCheckBox.AutoSize = true;
            this.AdditionalFeaturesCheckBox.Location = new System.Drawing.Point(486, 137);
            this.AdditionalFeaturesCheckBox.Name = "AdditionalFeaturesCheckBox";
            this.AdditionalFeaturesCheckBox.Size = new System.Drawing.Size(200, 19);
            this.AdditionalFeaturesCheckBox.TabIndex = 4;
            this.AdditionalFeaturesCheckBox.Text = "Дополнительные возможности";
            this.AdditionalFeaturesCheckBox.UseVisualStyleBackColor = true;
            this.AdditionalFeaturesCheckBox.CheckedChanged += new System.EventHandler(this.AdditionalFeaturesCheckBox_CheckedChanged);
            // 
            // PriceLebel
            // 
            this.PriceLebel.AutoSize = true;
            this.PriceLebel.Location = new System.Drawing.Point(9, 25);
            this.PriceLebel.Name = "PriceLebel";
            this.PriceLebel.Size = new System.Drawing.Size(35, 15);
            this.PriceLebel.TabIndex = 11;
            this.PriceLebel.Text = "Цена";
            // 
            // PriceComboBox
            // 
            this.PriceComboBox.FormattingEnabled = true;
            this.PriceComboBox.Location = new System.Drawing.Point(53, 22);
            this.PriceComboBox.Name = "PriceComboBox";
            this.PriceComboBox.Size = new System.Drawing.Size(190, 23);
            this.PriceComboBox.TabIndex = 12;
            // 
            // TimeOfDeliveryLebel
            // 
            this.TimeOfDeliveryLebel.AutoSize = true;
            this.TimeOfDeliveryLebel.Location = new System.Drawing.Point(9, 75);
            this.TimeOfDeliveryLebel.Name = "TimeOfDeliveryLebel";
            this.TimeOfDeliveryLebel.Size = new System.Drawing.Size(87, 15);
            this.TimeOfDeliveryLebel.TabIndex = 13;
            this.TimeOfDeliveryLebel.Text = "Срок доставки";
            // 
            // TimeOfDeliveryComboBox
            // 
            this.TimeOfDeliveryComboBox.FormattingEnabled = true;
            this.TimeOfDeliveryComboBox.Location = new System.Drawing.Point(102, 72);
            this.TimeOfDeliveryComboBox.Name = "TimeOfDeliveryComboBox";
            this.TimeOfDeliveryComboBox.Size = new System.Drawing.Size(190, 23);
            this.TimeOfDeliveryComboBox.TabIndex = 14;
            // 
            // CheckTransportationButton
            // 
            this.CheckTransportationButton.Location = new System.Drawing.Point(74, 333);
            this.CheckTransportationButton.Name = "CheckTransportationButton";
            this.CheckTransportationButton.Size = new System.Drawing.Size(248, 23);
            this.CheckTransportationButton.TabIndex = 5;
            this.CheckTransportationButton.Text = "Проверить возможность доставки";
            this.CheckTransportationButton.UseVisualStyleBackColor = true;
            this.CheckTransportationButton.Click += new System.EventHandler(this.CheckTransportationButton_Click);
            // 
            // AdditionalFeaturesgroupBox
            // 
            this.AdditionalFeaturesgroupBox.CausesValidation = false;
            this.AdditionalFeaturesgroupBox.Controls.Add(this.PriceComboBox);
            this.AdditionalFeaturesgroupBox.Controls.Add(this.PriceLebel);
            this.AdditionalFeaturesgroupBox.Controls.Add(this.TimeOfDeliveryComboBox);
            this.AdditionalFeaturesgroupBox.Controls.Add(this.TimeOfDeliveryLebel);
            this.AdditionalFeaturesgroupBox.Location = new System.Drawing.Point(486, 176);
            this.AdditionalFeaturesgroupBox.Name = "AdditionalFeaturesgroupBox";
            this.AdditionalFeaturesgroupBox.Size = new System.Drawing.Size(317, 126);
            this.AdditionalFeaturesgroupBox.TabIndex = 16;
            this.AdditionalFeaturesgroupBox.TabStop = false;
            this.AdditionalFeaturesgroupBox.Visible = false;
            // 
            // MessageLebel
            // 
            this.MessageLebel.AutoSize = true;
            this.MessageLebel.ForeColor = System.Drawing.Color.Black;
            this.MessageLebel.Location = new System.Drawing.Point(328, 141);
            this.MessageLebel.Name = "MessageLebel";
            this.MessageLebel.Size = new System.Drawing.Size(0, 15);
            this.MessageLebel.TabIndex = 17;
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "text";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip1.ToolTipTitle = "Ошибка";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // UpdateUserMoneyBtn
            // 
            this.UpdateUserMoneyBtn.Location = new System.Drawing.Point(755, 33);
            this.UpdateUserMoneyBtn.Name = "UpdateUserMoneyBtn";
            this.UpdateUserMoneyBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateUserMoneyBtn.TabIndex = 22;
            this.UpdateUserMoneyBtn.Text = "Обновить";
            this.UpdateUserMoneyBtn.UseVisualStyleBackColor = true;
            this.UpdateUserMoneyBtn.Click += new System.EventHandler(this.UpdateUserMoneyBtn_Click);
            // 
            // TransportSelectionButton
            // 
            this.TransportSelectionButton.Location = new System.Drawing.Point(375, 333);
            this.TransportSelectionButton.Name = "TransportSelectionButton";
            this.TransportSelectionButton.Size = new System.Drawing.Size(220, 23);
            this.TransportSelectionButton.TabIndex = 6;
            this.TransportSelectionButton.Text = "Подобрать доставку";
            this.TransportSelectionButton.UseVisualStyleBackColor = true;
            this.TransportSelectionButton.Visible = false;
            this.TransportSelectionButton.Click += new System.EventHandler(this.TransportSelectionButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 484);
            this.Controls.Add(this.TransportSelectionButton);
            this.Controls.Add(this.UpdateUserMoneyBtn);
            this.Controls.Add(this.MessageLebel);
            this.Controls.Add(this.AdditionalFeaturesgroupBox);
            this.Controls.Add(this.CheckTransportationButton);
            this.Controls.Add(this.AdditionalFeaturesCheckBox);
            this.Controls.Add(this.EndPointTransportationLebel);
            this.Controls.Add(this.StartingPointTransportationTextBox);
            this.Controls.Add(this.EndPointTransportationTextBox);
            this.Controls.Add(this.StartingPointTransportationLebel);
            this.Controls.Add(this.WeightOfCargoTextBox);
            this.Controls.Add(this.WeightOfCargoLebel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReplenishmentButton);
            this.Controls.Add(this.UserMoneyAmountTextLebel);
            this.Controls.Add(this.GreetingTextLebel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AdditionalFeaturesgroupBox.ResumeLayout(false);
            this.AdditionalFeaturesgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingTextLebel;
        private System.Windows.Forms.Label UserMoneyAmountTextLebel;
        private System.Windows.Forms.Button ReplenishmentButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WeightOfCargoLebel;
        private System.Windows.Forms.TextBox WeightOfCargoTextBox;
        private System.Windows.Forms.Label StartingPointTransportationLebel;
        private System.Windows.Forms.TextBox EndPointTransportationTextBox;
        private System.Windows.Forms.TextBox StartingPointTransportationTextBox;
        private System.Windows.Forms.Label EndPointTransportationLebel;
        private System.Windows.Forms.CheckBox AdditionalFeaturesCheckBox;
        private System.Windows.Forms.Label PriceLebel;
        private System.Windows.Forms.ComboBox PriceComboBox;
        private System.Windows.Forms.Label TimeOfDeliveryLebel;
        private System.Windows.Forms.ComboBox TimeOfDeliveryComboBox;
        private System.Windows.Forms.Button CheckTransportationButton;
        private System.Windows.Forms.GroupBox AdditionalFeaturesgroupBox;
        private System.Windows.Forms.Label MessageLebel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Button UpdateUserMoneyBtn;
        private System.Windows.Forms.Button TransportSelectionButton;
    }
}