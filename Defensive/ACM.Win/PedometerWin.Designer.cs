namespace ACM.Win
{
    partial class PedometerWin
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
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_StepGoalToday = new System.Windows.Forms.TextBox();
            this.txt_StepsToday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TodayStepResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(385, 12);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(193, 78);
            this.btn_Calculate.TabIndex = 0;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_StepGoalToday
            // 
            this.txt_StepGoalToday.Location = new System.Drawing.Point(188, 22);
            this.txt_StepGoalToday.Name = "txt_StepGoalToday";
            this.txt_StepGoalToday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_StepGoalToday.Size = new System.Drawing.Size(148, 22);
            this.txt_StepGoalToday.TabIndex = 1;
            this.txt_StepGoalToday.TextChanged += new System.EventHandler(this.txt_StepGoalToday_TextChanged);
            // 
            // txt_StepsToday
            // 
            this.txt_StepsToday.Location = new System.Drawing.Point(188, 50);
            this.txt_StepsToday.Name = "txt_StepsToday";
            this.txt_StepsToday.Size = new System.Drawing.Size(148, 22);
            this.txt_StepsToday.TabIndex = 2;
            this.txt_StepsToday.TextChanged += new System.EventHandler(this.txt_StepsToday_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Step Goal Today";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Steps Today";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_TodayStepResult
            // 
            this.lbl_TodayStepResult.AutoSize = true;
            this.lbl_TodayStepResult.Location = new System.Drawing.Point(382, 129);
            this.lbl_TodayStepResult.Name = "lbl_TodayStepResult";
            this.lbl_TodayStepResult.Size = new System.Drawing.Size(0, 17);
            this.lbl_TodayStepResult.TabIndex = 5;
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 244);
            this.Controls.Add(this.lbl_TodayStepResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_StepsToday);
            this.Controls.Add(this.txt_StepGoalToday);
            this.Controls.Add(this.btn_Calculate);
            this.Name = "PedometerWin";
            this.Text = "PedometerWin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_StepGoalToday;
        private System.Windows.Forms.TextBox txt_StepsToday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_TodayStepResult;
    }
}