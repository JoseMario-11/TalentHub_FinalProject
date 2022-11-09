
namespace TalentHub_Project
{
    partial class CryptedConversations
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
            this.lTitle = new System.Windows.Forms.Label();
            this.rTBRecruitInformation = new System.Windows.Forms.RichTextBox();
            this.rTBConversationsInformation = new System.Windows.Forms.RichTextBox();
            this.bShowConversations = new System.Windows.Forms.Button();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.rTBConversations = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Paradise", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(12, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(223, 44);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Conversaciones";
            // 
            // rTBRecruitInformation
            // 
            this.rTBRecruitInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rTBRecruitInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBRecruitInformation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBRecruitInformation.Location = new System.Drawing.Point(20, 56);
            this.rTBRecruitInformation.Name = "rTBRecruitInformation";
            this.rTBRecruitInformation.ReadOnly = true;
            this.rTBRecruitInformation.Size = new System.Drawing.Size(423, 88);
            this.rTBRecruitInformation.TabIndex = 1;
            this.rTBRecruitInformation.Text = "";
            // 
            // rTBConversationsInformation
            // 
            this.rTBConversationsInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rTBConversationsInformation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBConversationsInformation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBConversationsInformation.Location = new System.Drawing.Point(267, 9);
            this.rTBConversationsInformation.Name = "rTBConversationsInformation";
            this.rTBConversationsInformation.ReadOnly = true;
            this.rTBConversationsInformation.Size = new System.Drawing.Size(521, 41);
            this.rTBConversationsInformation.TabIndex = 3;
            this.rTBConversationsInformation.Text = "";
            // 
            // bShowConversations
            // 
            this.bShowConversations.Location = new System.Drawing.Point(627, 87);
            this.bShowConversations.Name = "bShowConversations";
            this.bShowConversations.Size = new System.Drawing.Size(92, 28);
            this.bShowConversations.TabIndex = 4;
            this.bShowConversations.Text = "Mostrar cartas";
            this.bShowConversations.UseVisualStyleBackColor = true;
            this.bShowConversations.Click += new System.EventHandler(this.bShowConversations_Click);
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(449, 92);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.PasswordChar = '*';
            this.tBPassword.Size = new System.Drawing.Size(172, 20);
            this.tBPassword.TabIndex = 5;
            // 
            // rTBConversations
            // 
            this.rTBConversations.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBConversations.Location = new System.Drawing.Point(12, 150);
            this.rTBConversations.Name = "rTBConversations";
            this.rTBConversations.ReadOnly = true;
            this.rTBConversations.Size = new System.Drawing.Size(776, 288);
            this.rTBConversations.TabIndex = 2;
            this.rTBConversations.Text = "";
            // 
            // CryptedConversations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.bShowConversations);
            this.Controls.Add(this.rTBConversationsInformation);
            this.Controls.Add(this.rTBConversations);
            this.Controls.Add(this.rTBRecruitInformation);
            this.Controls.Add(this.lTitle);
            this.Name = "CryptedConversations";
            this.Text = "CryptedConversations";
            this.Load += new System.EventHandler(this.CryptedConversations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.RichTextBox rTBRecruitInformation;
        private System.Windows.Forms.RichTextBox rTBConversationsInformation;
        private System.Windows.Forms.Button bShowConversations;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.RichTextBox rTBConversations;
    }
}