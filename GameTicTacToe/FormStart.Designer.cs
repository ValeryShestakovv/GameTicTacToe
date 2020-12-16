namespace GameTicTacToe
{
    partial class FormStart
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
            this.textboxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.radiobuttonCross = new System.Windows.Forms.RadioButton();
            this.radiobuttonZero = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(24, 72);
            this.textboxName.Margin = new System.Windows.Forms.Padding(6);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(380, 29);
            this.textboxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваши имя";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(226, 203);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(178, 46);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(24, 203);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(178, 46);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // radiobuttonCross
            // 
            this.radiobuttonCross.AutoSize = true;
            this.radiobuttonCross.BackColor = System.Drawing.Color.Transparent;
            this.radiobuttonCross.Location = new System.Drawing.Point(226, 125);
            this.radiobuttonCross.Name = "radiobuttonCross";
            this.radiobuttonCross.Size = new System.Drawing.Size(113, 28);
            this.radiobuttonCross.TabIndex = 4;
            this.radiobuttonCross.TabStop = true;
            this.radiobuttonCross.Text = "Крестики";
            this.radiobuttonCross.UseVisualStyleBackColor = false;
            // 
            // radiobuttonZero
            // 
            this.radiobuttonZero.AutoSize = true;
            this.radiobuttonZero.BackColor = System.Drawing.Color.Transparent;
            this.radiobuttonZero.Location = new System.Drawing.Point(226, 153);
            this.radiobuttonZero.Name = "radiobuttonZero";
            this.radiobuttonZero.Size = new System.Drawing.Size(93, 28);
            this.radiobuttonZero.TabIndex = 5;
            this.radiobuttonZero.TabStop = true;
            this.radiobuttonZero.Text = "Нолики";
            this.radiobuttonZero.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(94, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ваш выбор";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTicTacToe.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radiobuttonZero);
            this.Controls.Add(this.radiobuttonCross);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "FormStart";
            this.Text = "Старт игры !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radiobuttonCross;
        private System.Windows.Forms.RadioButton radiobuttonZero;
        private System.Windows.Forms.Label label2;
    }
}