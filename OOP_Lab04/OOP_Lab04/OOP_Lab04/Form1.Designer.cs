namespace OOP_Lab04
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button0 = new System.Windows.Forms.Button();
            this.buttonNot = new System.Windows.Forms.Button();
            this.buttonOR = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GetResultButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.RigthOperation = new System.Windows.Forms.Label();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.LeftOperandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(68, 225);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(75, 34);
            this.button0.TabIndex = 3;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonNot
            // 
            this.buttonNot.Location = new System.Drawing.Point(126, 317);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(75, 38);
            this.buttonNot.TabIndex = 4;
            this.buttonNot.Text = "NOT";
            this.buttonNot.UseVisualStyleBackColor = true;
            this.buttonNot.Click += new System.EventHandler(this.buttonNot_Click);
            // 
            // buttonOR
            // 
            this.buttonOR.Location = new System.Drawing.Point(231, 317);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(75, 38);
            this.buttonOR.TabIndex = 5;
            this.buttonOR.Text = "OR";
            this.buttonOR.UseVisualStyleBackColor = true;
            this.buttonOR.Click += new System.EventHandler(this.buttonOR_Click);
            // 
            // buttonAnd
            // 
            this.buttonAnd.Location = new System.Drawing.Point(24, 317);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(75, 38);
            this.buttonAnd.TabIndex = 7;
            this.buttonAnd.Text = "AND";
            this.buttonAnd.UseVisualStyleBackColor = true;
            this.buttonAnd.Click += new System.EventHandler(this.buttonAnd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetResultButton
            // 
            this.GetResultButton.Location = new System.Drawing.Point(127, 389);
            this.GetResultButton.Name = "GetResultButton";
            this.GetResultButton.Size = new System.Drawing.Size(179, 38);
            this.GetResultButton.TabIndex = 9;
            this.GetResultButton.Text = "=";
            this.GetResultButton.UseVisualStyleBackColor = true;
            this.GetResultButton.Click += new System.EventHandler(this.GetResultButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(24, 389);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 38);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ResultLabel.Location = new System.Drawing.Point(24, 147);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(282, 43);
            this.ResultLabel.TabIndex = 11;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // RigthOperation
            // 
            this.RigthOperation.BackColor = System.Drawing.Color.MediumTurquoise;
            this.RigthOperation.Location = new System.Drawing.Point(24, 113);
            this.RigthOperation.Name = "RigthOperation";
            this.RigthOperation.Size = new System.Drawing.Size(282, 34);
            this.RigthOperation.TabIndex = 12;
            this.RigthOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OperationLabel
            // 
            this.OperationLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.OperationLabel.Location = new System.Drawing.Point(24, 77);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(282, 36);
            this.OperationLabel.TabIndex = 13;
            this.OperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LeftOperandLabel
            // 
            this.LeftOperandLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LeftOperandLabel.Location = new System.Drawing.Point(24, 42);
            this.LeftOperandLabel.Name = "LeftOperandLabel";
            this.LeftOperandLabel.Size = new System.Drawing.Size(282, 36);
            this.LeftOperandLabel.TabIndex = 14;
            this.LeftOperandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.LeftOperandLabel);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.RigthOperation);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GetResultButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAnd);
            this.Controls.Add(this.buttonOR);
            this.Controls.Add(this.buttonNot);
            this.Controls.Add(this.button0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonNot;
        private System.Windows.Forms.Button buttonOR;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GetResultButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label RigthOperation;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.Label LeftOperandLabel;
    }
}

