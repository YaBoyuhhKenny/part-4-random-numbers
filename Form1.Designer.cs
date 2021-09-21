namespace part_4_random_numbers
{
    partial class Form1
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnInt = new System.Windows.Forms.Button();
            this.dblBtn = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.minUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(176, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a min and max value";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(12, 37);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(62, 16);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(12, 64);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(66, 16);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Maximum";
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(15, 107);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(81, 23);
            this.btnInt.TabIndex = 5;
            this.btnInt.Text = "get int";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // dblBtn
            // 
            this.dblBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblBtn.Location = new System.Drawing.Point(102, 107);
            this.dblBtn.Name = "dblBtn";
            this.dblBtn.Size = new System.Drawing.Size(92, 23);
            this.dblBtn.TabIndex = 6;
            this.dblBtn.Text = "get double";
            this.dblBtn.UseVisualStyleBackColor = true;
            this.dblBtn.Click += new System.EventHandler(this.dblBtn_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(48, 145);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 7;
            // 
            // minUpDown
            // 
            this.minUpDown.Location = new System.Drawing.Point(78, 38);
            this.minUpDown.Name = "minUpDown";
            this.minUpDown.Size = new System.Drawing.Size(41, 20);
            this.minUpDown.TabIndex = 8;
            // 
            // maxUpDown
            // 
            this.maxUpDown.Location = new System.Drawing.Point(78, 64);
            this.maxUpDown.Name = "maxUpDown";
            this.maxUpDown.Size = new System.Drawing.Size(41, 20);
            this.maxUpDown.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(236, 183);
            this.Controls.Add(this.maxUpDown);
            this.Controls.Add(this.minUpDown);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.dblBtn);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Form1";
            this.Text = "Random numbers";
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button dblBtn;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.NumericUpDown minUpDown;
        private System.Windows.Forms.NumericUpDown maxUpDown;
    }
}

