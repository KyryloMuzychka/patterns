namespace Lab6_1
{
    partial class TVForm
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
            this.PrevChannelButton = new System.Windows.Forms.Button();
            this.NextChannelButton = new System.Windows.Forms.Button();
            this.ChannelNameLabel = new System.Windows.Forms.Label();
            this.TelecastNameLabel = new System.Windows.Forms.Label();
            this.NextTelecastButton = new System.Windows.Forms.Button();
            this.PrevTelecastButton = new System.Windows.Forms.Button();
            this.MoveToChannel = new System.Windows.Forms.Button();
            this.ChannelNumeric = new System.Windows.Forms.NumericUpDown();
            this.currentChannelLabel = new System.Windows.Forms.Label();
            this.telecastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentTelecastLabel = new System.Windows.Forms.Label();
            this.TelecastNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ChannelNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelecastNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PrevChannelButton
            // 
            this.PrevChannelButton.Location = new System.Drawing.Point(14, 87);
            this.PrevChannelButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrevChannelButton.Name = "PrevChannelButton";
            this.PrevChannelButton.Size = new System.Drawing.Size(132, 38);
            this.PrevChannelButton.TabIndex = 0;
            this.PrevChannelButton.Text = "Prev Channel";
            this.PrevChannelButton.UseVisualStyleBackColor = true;
            this.PrevChannelButton.Click += new System.EventHandler(this.PrevChannelButton_Click);
            // 
            // NextChannelButton
            // 
            this.NextChannelButton.Location = new System.Drawing.Point(180, 87);
            this.NextChannelButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextChannelButton.Name = "NextChannelButton";
            this.NextChannelButton.Size = new System.Drawing.Size(132, 38);
            this.NextChannelButton.TabIndex = 1;
            this.NextChannelButton.Text = "Next Channel";
            this.NextChannelButton.UseVisualStyleBackColor = true;
            this.NextChannelButton.Click += new System.EventHandler(this.NextChannelButton_Click);
            // 
            // ChannelNameLabel
            // 
            this.ChannelNameLabel.AutoSize = true;
            this.ChannelNameLabel.Location = new System.Drawing.Point(10, 54);
            this.ChannelNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChannelNameLabel.Name = "ChannelNameLabel";
            this.ChannelNameLabel.Size = new System.Drawing.Size(117, 20);
            this.ChannelNameLabel.TabIndex = 2;
            this.ChannelNameLabel.Text = "News Network";
            this.ChannelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TelecastNameLabel
            // 
            this.TelecastNameLabel.AutoSize = true;
            this.TelecastNameLabel.Location = new System.Drawing.Point(10, 181);
            this.TelecastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TelecastNameLabel.Name = "TelecastNameLabel";
            this.TelecastNameLabel.Size = new System.Drawing.Size(116, 20);
            this.TelecastNameLabel.TabIndex = 5;
            this.TelecastNameLabel.Text = "Morning News";
            this.TelecastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NextTelecastButton
            // 
            this.NextTelecastButton.Location = new System.Drawing.Point(183, 215);
            this.NextTelecastButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextTelecastButton.Name = "NextTelecastButton";
            this.NextTelecastButton.Size = new System.Drawing.Size(129, 38);
            this.NextTelecastButton.TabIndex = 4;
            this.NextTelecastButton.Text = "Next Telecast";
            this.NextTelecastButton.UseVisualStyleBackColor = true;
            this.NextTelecastButton.Click += new System.EventHandler(this.NextTelecastButton_Click);
            // 
            // PrevTelecastButton
            // 
            this.PrevTelecastButton.Location = new System.Drawing.Point(10, 215);
            this.PrevTelecastButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrevTelecastButton.Name = "PrevTelecastButton";
            this.PrevTelecastButton.Size = new System.Drawing.Size(132, 38);
            this.PrevTelecastButton.TabIndex = 3;
            this.PrevTelecastButton.Text = "Prev Telecast";
            this.PrevTelecastButton.UseVisualStyleBackColor = true;
            this.PrevTelecastButton.Click += new System.EventHandler(this.PrevTelecastButton_Click);
            // 
            // MoveToChannel
            // 
            this.MoveToChannel.Location = new System.Drawing.Point(10, 449);
            this.MoveToChannel.Margin = new System.Windows.Forms.Padding(4);
            this.MoveToChannel.Name = "MoveToChannel";
            this.MoveToChannel.Size = new System.Drawing.Size(298, 52);
            this.MoveToChannel.TabIndex = 6;
            this.MoveToChannel.Text = "Move to channel";
            this.MoveToChannel.UseVisualStyleBackColor = true;
            this.MoveToChannel.Click += new System.EventHandler(this.MoveToChannel_Click);
            // 
            // ChannelNumeric
            // 
            this.ChannelNumeric.Location = new System.Drawing.Point(10, 310);
            this.ChannelNumeric.Name = "ChannelNumeric";
            this.ChannelNumeric.Size = new System.Drawing.Size(302, 27);
            this.ChannelNumeric.TabIndex = 7;
            // 
            // currentChannelLabel
            // 
            this.currentChannelLabel.AutoSize = true;
            this.currentChannelLabel.Location = new System.Drawing.Point(10, 24);
            this.currentChannelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentChannelLabel.Name = "currentChannelLabel";
            this.currentChannelLabel.Size = new System.Drawing.Size(136, 20);
            this.currentChannelLabel.TabIndex = 8;
            this.currentChannelLabel.Text = "Current Channel:";
            // 
            // telecastLabel
            // 
            this.telecastLabel.AutoSize = true;
            this.telecastLabel.Location = new System.Drawing.Point(10, 147);
            this.telecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telecastLabel.Name = "telecastLabel";
            this.telecastLabel.Size = new System.Drawing.Size(78, 20);
            this.telecastLabel.TabIndex = 9;
            this.telecastLabel.Text = "Telecast:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current Channel:";
            // 
            // currentTelecastLabel
            // 
            this.currentTelecastLabel.AutoSize = true;
            this.currentTelecastLabel.Location = new System.Drawing.Point(10, 361);
            this.currentTelecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTelecastLabel.Name = "currentTelecastLabel";
            this.currentTelecastLabel.Size = new System.Drawing.Size(78, 20);
            this.currentTelecastLabel.TabIndex = 12;
            this.currentTelecastLabel.Text = "Telecast:";
            // 
            // TelecastNumeric
            // 
            this.TelecastNumeric.Enabled = false;
            this.TelecastNumeric.Location = new System.Drawing.Point(10, 396);
            this.TelecastNumeric.Name = "TelecastNumeric";
            this.TelecastNumeric.Size = new System.Drawing.Size(302, 27);
            this.TelecastNumeric.TabIndex = 11;
            // 
            // TVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 514);
            this.Controls.Add(this.currentTelecastLabel);
            this.Controls.Add(this.TelecastNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telecastLabel);
            this.Controls.Add(this.currentChannelLabel);
            this.Controls.Add(this.ChannelNumeric);
            this.Controls.Add(this.MoveToChannel);
            this.Controls.Add(this.TelecastNameLabel);
            this.Controls.Add(this.NextTelecastButton);
            this.Controls.Add(this.PrevTelecastButton);
            this.Controls.Add(this.ChannelNameLabel);
            this.Controls.Add(this.NextChannelButton);
            this.Controls.Add(this.PrevChannelButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TVForm";
            this.Text = "TV";
            ((System.ComponentModel.ISupportInitialize)(this.ChannelNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TelecastNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrevChannelButton;
        private System.Windows.Forms.Button NextChannelButton;
        private System.Windows.Forms.Label ChannelNameLabel;
        private System.Windows.Forms.Label TelecastNameLabel;
        private System.Windows.Forms.Button NextTelecastButton;
        private System.Windows.Forms.Button PrevTelecastButton;
        private System.Windows.Forms.Button MoveToChannel;
        private System.Windows.Forms.NumericUpDown ChannelNumeric;
        private System.Windows.Forms.Label currentChannelLabel;
        private System.Windows.Forms.Label telecastLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentTelecastLabel;
        private System.Windows.Forms.NumericUpDown TelecastNumeric;
    }
}

