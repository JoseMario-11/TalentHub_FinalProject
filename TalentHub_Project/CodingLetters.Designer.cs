
namespace TalentHub_Project
{
    partial class CodingLetters
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
            this.label2 = new System.Windows.Forms.Label();
            this.bDecodingLetters = new System.Windows.Forms.Button();
            this.rTBLettersCoding = new System.Windows.Forms.RichTextBox();
            this.rTBLettersDecoding = new System.Windows.Forms.RichTextBox();
            this.lRecruitInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cartas comprimidas";
            // 
            // bDecodingLetters
            // 
            this.bDecodingLetters.Location = new System.Drawing.Point(387, 57);
            this.bDecodingLetters.Name = "bDecodingLetters";
            this.bDecodingLetters.Size = new System.Drawing.Size(135, 23);
            this.bDecodingLetters.TabIndex = 9;
            this.bDecodingLetters.Text = "Mostrar cartas";
            this.bDecodingLetters.UseVisualStyleBackColor = true;
            this.bDecodingLetters.Click += new System.EventHandler(this.bDecodingLetters_Click);
            // 
            // rTBLettersCoding
            // 
            this.rTBLettersCoding.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBLettersCoding.Location = new System.Drawing.Point(15, 83);
            this.rTBLettersCoding.Name = "rTBLettersCoding";
            this.rTBLettersCoding.ReadOnly = true;
            this.rTBLettersCoding.Size = new System.Drawing.Size(288, 235);
            this.rTBLettersCoding.TabIndex = 11;
            this.rTBLettersCoding.Text = "";
            // 
            // rTBLettersDecoding
            // 
            this.rTBLettersDecoding.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBLettersDecoding.Location = new System.Drawing.Point(309, 83);
            this.rTBLettersDecoding.Name = "rTBLettersDecoding";
            this.rTBLettersDecoding.ReadOnly = true;
            this.rTBLettersDecoding.Size = new System.Drawing.Size(291, 235);
            this.rTBLettersDecoding.TabIndex = 12;
            this.rTBLettersDecoding.Text = "";
            this.rTBLettersDecoding.Visible = false;
            // 
            // lRecruitInformation
            // 
            this.lRecruitInformation.AutoSize = true;
            this.lRecruitInformation.BackColor = System.Drawing.Color.White;
            this.lRecruitInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecruitInformation.Location = new System.Drawing.Point(232, 9);
            this.lRecruitInformation.Name = "lRecruitInformation";
            this.lRecruitInformation.Size = new System.Drawing.Size(138, 20);
            this.lRecruitInformation.TabIndex = 13;
            this.lRecruitInformation.Text = "Nombre Recluta";
            this.lRecruitInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CodingLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(608, 330);
            this.Controls.Add(this.lRecruitInformation);
            this.Controls.Add(this.rTBLettersDecoding);
            this.Controls.Add(this.rTBLettersCoding);
            this.Controls.Add(this.bDecodingLetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CodingLetters";
            this.Text = "CodingLetters";
            this.Load += new System.EventHandler(this.CodingLetters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDecodingLetters;
        private System.Windows.Forms.RichTextBox rTBLettersCoding;
        private System.Windows.Forms.RichTextBox rTBLettersDecoding;
        private System.Windows.Forms.Label lRecruitInformation;
    }
}