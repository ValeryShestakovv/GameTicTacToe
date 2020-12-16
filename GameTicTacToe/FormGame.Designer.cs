namespace GameTicTacToe
{
    partial class FormGame
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
            this.pictureboxCanvas = new System.Windows.Forms.PictureBox();
            this.textBoxGamer1 = new System.Windows.Forms.TextBox();
            this.textBoxGamer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResComputer = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxCanvas
            // 
            this.pictureboxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pictureboxCanvas.MaximumSize = new System.Drawing.Size(376, 376);
            this.pictureboxCanvas.MinimumSize = new System.Drawing.Size(376, 376);
            this.pictureboxCanvas.Name = "pictureboxCanvas";
            this.pictureboxCanvas.Size = new System.Drawing.Size(376, 376);
            this.pictureboxCanvas.TabIndex = 2;
            this.pictureboxCanvas.TabStop = false;
            this.pictureboxCanvas.Click += new System.EventHandler(this.pictureboxCanvas_Click);
            // 
            // textBoxGamer1
            // 
            this.textBoxGamer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGamer1.Location = new System.Drawing.Point(394, 35);
            this.textBoxGamer1.Name = "textBoxGamer1";
            this.textBoxGamer1.ReadOnly = true;
            this.textBoxGamer1.Size = new System.Drawing.Size(171, 26);
            this.textBoxGamer1.TabIndex = 3;
            // 
            // textBoxGamer2
            // 
            this.textBoxGamer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGamer2.Location = new System.Drawing.Point(573, 35);
            this.textBoxGamer2.Name = "textBoxGamer2";
            this.textBoxGamer2.ReadOnly = true;
            this.textBoxGamer2.Size = new System.Drawing.Size(171, 26);
            this.textBoxGamer2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(394, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Игрок 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(571, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Игрок 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(394, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Счет:";
            // 
            // labelResUser
            // 
            this.labelResUser.AutoSize = true;
            this.labelResUser.BackColor = System.Drawing.Color.Transparent;
            this.labelResUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResUser.Location = new System.Drawing.Point(457, 91);
            this.labelResUser.Name = "labelResUser";
            this.labelResUser.Size = new System.Drawing.Size(18, 20);
            this.labelResUser.TabIndex = 8;
            this.labelResUser.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(481, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // labelResComputer
            // 
            this.labelResComputer.AutoSize = true;
            this.labelResComputer.BackColor = System.Drawing.Color.Transparent;
            this.labelResComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResComputer.Location = new System.Drawing.Point(500, 91);
            this.labelResComputer.Name = "labelResComputer";
            this.labelResComputer.Size = new System.Drawing.Size(18, 20);
            this.labelResComputer.TabIndex = 10;
            this.labelResComputer.Text = "0";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(637, 340);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(155, 48);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameTicTacToe.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(804, 401);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelResComputer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelResUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGamer2);
            this.Controls.Add(this.textBoxGamer1);
            this.Controls.Add(this.pictureboxCanvas);
            this.Name = "FormGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureboxCanvas;
        private System.Windows.Forms.TextBox textBoxGamer1;
        private System.Windows.Forms.TextBox textBoxGamer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResComputer;
        private System.Windows.Forms.Button buttonExit;
    }
}

