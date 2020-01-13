namespace PurchaseTicketWinFormsApp
{
    partial class PurchaseTicketUi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfTicketTextBox = new System.Windows.Forms.TextBox();
            this.TotalPriceButton = new System.Windows.Forms.Button();
            this.ShowDetailsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowDetailsButton);
            this.groupBox1.Controls.Add(this.TotalPriceButton);
            this.groupBox1.Controls.Add(this.numberOfTicketTextBox);
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(92, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Ticket";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(223, 59);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(250, 22);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // numberOfTicketTextBox
            // 
            this.numberOfTicketTextBox.Location = new System.Drawing.Point(371, 103);
            this.numberOfTicketTextBox.Name = "numberOfTicketTextBox";
            this.numberOfTicketTextBox.Size = new System.Drawing.Size(102, 22);
            this.numberOfTicketTextBox.TabIndex = 1;
            // 
            // TotalPriceButton
            // 
            this.TotalPriceButton.Location = new System.Drawing.Point(223, 173);
            this.TotalPriceButton.Name = "TotalPriceButton";
            this.TotalPriceButton.Size = new System.Drawing.Size(116, 25);
            this.TotalPriceButton.TabIndex = 2;
            this.TotalPriceButton.Text = "Total Price";
            this.TotalPriceButton.UseVisualStyleBackColor = true;
            this.TotalPriceButton.Click += new System.EventHandler(this.TotalPriceButton_Click);
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.Location = new System.Drawing.Point(355, 173);
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Size = new System.Drawing.Size(118, 25);
            this.ShowDetailsButton.TabIndex = 2;
            this.ShowDetailsButton.Text = "Show Details";
            this.ShowDetailsButton.UseVisualStyleBackColor = true;
            this.ShowDetailsButton.Click += new System.EventHandler(this.ShowDetailsButton_Click);
            // 
            // PurchaseTicketUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseTicketUi";
            this.Text = "Purchase Ticket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ShowDetailsButton;
        private System.Windows.Forms.Button TotalPriceButton;
        private System.Windows.Forms.TextBox numberOfTicketTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

