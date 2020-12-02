namespace Advent
{
    partial class Day1
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValues = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMultiplied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 25);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(284, 20);
            this.txtPath.TabIndex = 0;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(63, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path to File:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(196, 256);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 51);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(15, 81);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(284, 20);
            this.txtTarget.TabIndex = 3;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(12, 65);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(76, 13);
            this.lblTarget.TabIndex = 4;
            this.lblTarget.Text = "Desired Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Added Values:";
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Location = new System.Drawing.Point(118, 171);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(0, 13);
            this.lblValues.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Multiplied Values:";
            // 
            // lblMultiplied
            // 
            this.lblMultiplied.AutoSize = true;
            this.lblMultiplied.Location = new System.Drawing.Point(118, 221);
            this.lblMultiplied.Name = "lblMultiplied";
            this.lblMultiplied.Size = new System.Drawing.Size(0, 13);
            this.lblMultiplied.TabIndex = 8;
            // 
            // Day1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 319);
            this.Controls.Add(this.lblMultiplied);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Name = "Day1";
            this.Text = "Day 1 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMultiplied;
    }
}

