namespace TestPortal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionLabel = new Label();
            radioButtonA = new RadioButton();
            radioButtonB = new RadioButton();
            radioButtonC = new RadioButton();
            radioButtonD = new RadioButton();
            nextButton = new Button();
            previousButton = new Button();
            groupBox1 = new GroupBox();
            questionNumberLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.Location = new Point(123, 9);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(516, 100);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "label1";
            // 
            // radioButtonA
            // 
            radioButtonA.AutoSize = true;
            radioButtonA.Location = new Point(6, 22);
            radioButtonA.Name = "radioButtonA";
            radioButtonA.Size = new Size(94, 19);
            radioButtonA.TabIndex = 1;
            radioButtonA.TabStop = true;
            radioButtonA.Text = "radioButton1";
            radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            radioButtonB.AutoSize = true;
            radioButtonB.Location = new Point(6, 47);
            radioButtonB.Name = "radioButtonB";
            radioButtonB.Size = new Size(94, 19);
            radioButtonB.TabIndex = 2;
            radioButtonB.TabStop = true;
            radioButtonB.Text = "radioButton1";
            radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            radioButtonC.AutoSize = true;
            radioButtonC.Location = new Point(6, 72);
            radioButtonC.Name = "radioButtonC";
            radioButtonC.Size = new Size(94, 19);
            radioButtonC.TabIndex = 3;
            radioButtonC.TabStop = true;
            radioButtonC.Text = "radioButton1";
            radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            radioButtonD.AutoSize = true;
            radioButtonD.Location = new Point(6, 97);
            radioButtonD.Name = "radioButtonD";
            radioButtonD.Size = new Size(94, 19);
            radioButtonD.TabIndex = 4;
            radioButtonD.TabStop = true;
            radioButtonD.Text = "radioButton1";
            radioButtonD.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(589, 206);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(110, 47);
            nextButton.TabIndex = 5;
            nextButton.Text = "next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.Location = new Point(452, 206);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(110, 47);
            previousButton.TabIndex = 6;
            previousButton.Text = "prev";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonA);
            groupBox1.Controls.Add(radioButtonB);
            groupBox1.Controls.Add(radioButtonC);
            groupBox1.Controls.Add(radioButtonD);
            groupBox1.Location = new Point(42, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 126);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            questionNumberLabel.Location = new Point(216, 343);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(332, 56);
            questionNumberLabel.TabIndex = 8;
            questionNumberLabel.Text = "Pytanie 0/1";
            questionNumberLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(questionNumberLabel);
            Controls.Add(groupBox1);
            Controls.Add(previousButton);
            Controls.Add(nextButton);
            Controls.Add(questionLabel);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label questionLabel;
        private RadioButton radioButtonA;
        private RadioButton radioButtonB;
        private RadioButton radioButtonC;
        private RadioButton radioButtonD;
        private Button nextButton;
        private Button previousButton;
        private GroupBox groupBox1;
        private Label questionNumberLabel;
    }
}