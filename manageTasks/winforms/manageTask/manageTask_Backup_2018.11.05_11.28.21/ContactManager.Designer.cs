namespace manageTask
{
    partial class ContactManager
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
            this.btn_send_message = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_send_message
            // 
            this.btn_send_message.Location = new System.Drawing.Point(558, 392);
            this.btn_send_message.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_message.Name = "btn_send_message";
            this.btn_send_message.Size = new System.Drawing.Size(100, 28);
            this.btn_send_message.TabIndex = 5;
            this.btn_send_message.Text = "Send";
            this.btn_send_message.UseVisualStyleBackColor = true;
            this.btn_send_message.Click += new System.EventHandler(this.btn_send_message_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(314, 57);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(134, 17);
            this.lbl_message.TabIndex = 4;
            this.lbl_message.Text = "Write your message";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(126, 128);
            this.richTextBoxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(549, 224);
            this.richTextBoxMessage.TabIndex = 3;
            this.richTextBoxMessage.Text = "";
            // 
            // ContactManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_send_message);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.richTextBoxMessage);
            this.Name = "ContactManager";
            this.Text = "ContactManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send_message;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
    }
}