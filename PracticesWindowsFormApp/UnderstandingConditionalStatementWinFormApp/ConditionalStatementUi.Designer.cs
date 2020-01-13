namespace UnderstandingConditionalStatementWinFormApp
{
    partial class ConditionalStatementUi
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
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.ShowPlanetNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planet Name";
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Items.AddRange(new object[] {
            "Planet",
            "Saturn",
            "Mars"});
            this.planetNameComboBox.Location = new System.Drawing.Point(263, 94);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(312, 24);
            this.planetNameComboBox.TabIndex = 1;
            this.planetNameComboBox.Text = "-Select-";
            // 
            // ShowPlanetNumberButton
            // 
            this.ShowPlanetNumberButton.Location = new System.Drawing.Point(306, 156);
            this.ShowPlanetNumberButton.Name = "ShowPlanetNumberButton";
            this.ShowPlanetNumberButton.Size = new System.Drawing.Size(236, 27);
            this.ShowPlanetNumberButton.TabIndex = 2;
            this.ShowPlanetNumberButton.Text = "Show Planet Number";
            this.ShowPlanetNumberButton.UseVisualStyleBackColor = true;
            this.ShowPlanetNumberButton.Click += new System.EventHandler(this.ShowPlanetNumberButton_Click);
            // 
            // ConditionalStatementUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowPlanetNumberButton);
            this.Controls.Add(this.planetNameComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ConditionalStatementUi";
            this.Text = "Conditional Statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox planetNameComboBox;
        private System.Windows.Forms.Button ShowPlanetNumberButton;
    }
}

