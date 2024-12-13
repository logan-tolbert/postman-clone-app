namespace PostmanCloneUI
{
    partial class Dashboard
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
            responseWindow = new TextBox();
            formHeader = new Label();
            requestLabel = new Label();
            requestField = new TextBox();
            requestButton = new Button();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            responseLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // responseWindow
            // 
            responseWindow.BackColor = Color.FromArgb(27, 27, 50);
            responseWindow.Location = new Point(50, 358);
            responseWindow.Multiline = true;
            responseWindow.Name = "responseWindow";
            responseWindow.ReadOnly = true;
            responseWindow.Size = new Size(1608, 415);
            responseWindow.TabIndex = 0;
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 26F);
            formHeader.ForeColor = Color.White;
            formHeader.Location = new Point(704, 31);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(317, 60);
            formHeader.TabIndex = 1;
            formHeader.Text = "Postman Clone";
            formHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // requestLabel
            // 
            requestLabel.AutoSize = true;
            requestLabel.ForeColor = Color.White;
            requestLabel.Location = new Point(50, 183);
            requestLabel.Name = "requestLabel";
            requestLabel.Size = new Size(132, 41);
            requestLabel.TabIndex = 2;
            requestLabel.Text = "Request:";
            requestLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // requestField
            // 
            requestField.BackColor = Color.FromArgb(27, 27, 50);
            requestField.Font = new Font("Segoe UI", 18F);
            requestField.Location = new Point(186, 183);
            requestField.Margin = new Padding(10);
            requestField.MinimumSize = new Size(0, 50);
            requestField.Name = "requestField";
            requestField.PlaceholderText = "Enter URL";
            requestField.Size = new Size(1147, 50);
            requestField.TabIndex = 3;
            // 
            // requestButton
            // 
            requestButton.BackColor = Color.FromArgb(90, 1, 167);
            requestButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            requestButton.ForeColor = Color.White;
            requestButton.Location = new Point(1368, 172);
            requestButton.Name = "requestButton";
            requestButton.Size = new Size(276, 63);
            requestButton.TabIndex = 4;
            requestButton.Text = "Send";
            requestButton.UseVisualStyleBackColor = false;
            requestButton.Click += requestButton_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 804);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1723, 38);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Segoe UI", 14F);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(78, 32);
            statusLabel.Text = "Ready";
            // 
            // responseLabel
            // 
            responseLabel.AutoSize = true;
            responseLabel.ForeColor = Color.White;
            responseLabel.Location = new Point(50, 297);
            responseLabel.Name = "responseLabel";
            responseLabel.Size = new Size(146, 41);
            responseLabel.TabIndex = 6;
            responseLabel.Text = "Response";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 35);
            ClientSize = new Size(1723, 842);
            Controls.Add(responseLabel);
            Controls.Add(statusStrip);
            Controls.Add(requestButton);
            Controls.Add(requestField);
            Controls.Add(requestLabel);
            Controls.Add(formHeader);
            Controls.Add(responseWindow);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone";
            WindowState = FormWindowState.Minimized;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox responseWindow;
        private Label formHeader;
        private Label requestLabel;
        private TextBox requestField;
        private Button requestButton;
        private StatusStrip statusStrip;
        private Label responseLabel;
        private ToolStripStatusLabel statusLabel;
    }
}
