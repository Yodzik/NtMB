namespace NtMB.View
{
    partial class MainFormView
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
            this.labelBotState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelConnectedProcesses = new System.Windows.Forms.Label();
            this.labelConnectedOtherBots = new System.Windows.Forms.Label();
            this.labelMessages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBotState
            // 
            this.labelBotState.AutoSize = true;
            this.labelBotState.Location = new System.Drawing.Point(12, 9);
            this.labelBotState.Name = "labelBotState";
            this.labelBotState.Size = new System.Drawing.Size(52, 13);
            this.labelBotState.TabIndex = 0;
            this.labelBotState.Text = "Bot state:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "<uninitialized>";
            // 
            // labelConnectedProcesses
            // 
            this.labelConnectedProcesses.AutoSize = true;
            this.labelConnectedProcesses.Location = new System.Drawing.Point(12, 32);
            this.labelConnectedProcesses.Name = "labelConnectedProcesses";
            this.labelConnectedProcesses.Size = new System.Drawing.Size(113, 13);
            this.labelConnectedProcesses.TabIndex = 2;
            this.labelConnectedProcesses.Text = "Connected processes:";
            // 
            // labelConnectedOtherBots
            // 
            this.labelConnectedOtherBots.AutoSize = true;
            this.labelConnectedOtherBots.Location = new System.Drawing.Point(10, 54);
            this.labelConnectedOtherBots.Name = "labelConnectedOtherBots";
            this.labelConnectedOtherBots.Size = new System.Drawing.Size(115, 13);
            this.labelConnectedOtherBots.TabIndex = 3;
            this.labelConnectedOtherBots.Text = "Connected  other bots:";
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Location = new System.Drawing.Point(10, 79);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(58, 13);
            this.labelMessages.TabIndex = 4;
            this.labelMessages.Text = "Messages:";
            // 
            // MainFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 570);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.labelConnectedOtherBots);
            this.Controls.Add(this.labelConnectedProcesses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBotState);
            this.Name = "MainFormView";
            this.Text = "NtMB-OFF <0,0>";
            this.Load += new System.EventHandler(this.MainFormView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBotState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConnectedProcesses;
        private System.Windows.Forms.Label labelConnectedOtherBots;
        private System.Windows.Forms.Label labelMessages;
    }
}

