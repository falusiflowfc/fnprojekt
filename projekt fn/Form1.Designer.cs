namespace projekt_fn
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AccessibleName = "lblQuestion";
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(318, 63);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Kérdések";
            // 
            // rbtnAnswer1
            // 
            this.rbtnAnswer1.AutoSize = true;
            this.rbtnAnswer1.Location = new System.Drawing.Point(321, 114);
            this.rbtnAnswer1.Name = "rbtnAnswer1";
            this.rbtnAnswer1.Size = new System.Drawing.Size(85, 17);
            this.rbtnAnswer1.TabIndex = 1;
            this.rbtnAnswer1.TabStop = true;
            this.rbtnAnswer1.Text = "radioButton1";
            this.rbtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer2
            // 
            this.rbtnAnswer2.AutoSize = true;
            this.rbtnAnswer2.Location = new System.Drawing.Point(321, 148);
            this.rbtnAnswer2.Name = "rbtnAnswer2";
            this.rbtnAnswer2.Size = new System.Drawing.Size(85, 17);
            this.rbtnAnswer2.TabIndex = 2;
            this.rbtnAnswer2.TabStop = true;
            this.rbtnAnswer2.Text = "radioButton2";
            this.rbtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer3
            // 
            this.rbtnAnswer3.AutoSize = true;
            this.rbtnAnswer3.Location = new System.Drawing.Point(321, 185);
            this.rbtnAnswer3.Name = "rbtnAnswer3";
            this.rbtnAnswer3.Size = new System.Drawing.Size(85, 17);
            this.rbtnAnswer3.TabIndex = 3;
            this.rbtnAnswer3.TabStop = true;
            this.rbtnAnswer3.Text = "radioButton3";
            this.rbtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbtnAnswer4
            // 
            this.rbtnAnswer4.AutoSize = true;
            this.rbtnAnswer4.Location = new System.Drawing.Point(321, 217);
            this.rbtnAnswer4.Name = "rbtnAnswer4";
            this.rbtnAnswer4.Size = new System.Drawing.Size(85, 17);
            this.rbtnAnswer4.TabIndex = 4;
            this.rbtnAnswer4.TabStop = true;
            this.rbtnAnswer4.Text = "radioButton4";
            this.rbtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleName = "btnNext";
            this.btnNext.Location = new System.Drawing.Point(391, 249);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Következő";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblScore
            // 
            this.lblScore.AccessibleName = "lblScore";
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(318, 254);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(57, 13);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Eredmény:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rbtnAnswer4);
            this.Controls.Add(this.rbtnAnswer3);
            this.Controls.Add(this.rbtnAnswer2);
            this.Controls.Add(this.rbtnAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbtnAnswer1;
        private System.Windows.Forms.RadioButton rbtnAnswer2;
        private System.Windows.Forms.RadioButton rbtnAnswer3;
        private System.Windows.Forms.RadioButton rbtnAnswer4;
        private System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Button btnNext;
    }
    }

