﻿namespace Advent.Days
{
    partial class Day5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Day5));
            this.btnValidateNew = new System.Windows.Forms.Button();
            this.lblValid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidateNew
            // 
            this.btnValidateNew.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateNew.Location = new System.Drawing.Point(12, 238);
            this.btnValidateNew.Name = "btnValidateNew";
            this.btnValidateNew.Size = new System.Drawing.Size(287, 51);
            this.btnValidateNew.TabIndex = 13;
            this.btnValidateNew.Text = "Get Your Seat";
            this.btnValidateNew.UseVisualStyleBackColor = true;
            this.btnValidateNew.Click += new System.EventHandler(this.btnValidateNew_Click);
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid.Location = new System.Drawing.Point(180, 94);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(41, 26);
            this.lblValid.TabIndex = 12;
            this.lblValid.Text = "Test";
            this.lblValid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seat Number:";
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(12, 166);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(287, 51);
            this.btnValidate.TabIndex = 10;
            this.btnValidate.Text = "Get Highest";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(106, 26);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "Path to File:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 38);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(284, 20);
            this.txtPath.TabIndex = 8;
            // 
            // Day5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 321);
            this.Controls.Add(this.btnValidateNew);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Day5";
            this.Text = "Day5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidateNew;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtPath;
    }
}