namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.player1 = new System.Windows.Forms.TextBox();
            this.player2 = new System.Windows.Forms.TextBox();
            this.dot = new System.Windows.Forms.TextBox();
            this.dott = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.SystemColors.Window;
            this.player1.Enabled = false;
            this.player1.Location = new System.Drawing.Point(0, 200);
            this.player1.Margin = new System.Windows.Forms.Padding(0);
            this.player1.Multiline = true;
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(20, 100);
            this.player1.TabIndex = 0;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.SystemColors.Window;
            this.player2.Enabled = false;
            this.player2.Location = new System.Drawing.Point(465, 200);
            this.player2.Margin = new System.Windows.Forms.Padding(0);
            this.player2.Multiline = true;
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(20, 100);
            this.player2.TabIndex = 1;
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.SystemColors.Window;
            this.dot.Enabled = false;
            this.dot.Location = new System.Drawing.Point(222, 244);
            this.dot.Margin = new System.Windows.Forms.Padding(0);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(20, 20);
            this.dot.TabIndex = 2;
            this.dot.TextChanged += new System.EventHandler(this.dot_TextChanged);
            // 
            // dott
            // 
            this.dott.Enabled = true;
            this.dott.Interval = 300;
            this.dott.Tick += new System.EventHandler(this.dott_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score1.Location = new System.Drawing.Point(131, 44);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(44, 47);
            this.score1.TabIndex = 3;
            this.score1.Text = "0";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score2.Location = new System.Drawing.Point(309, 44);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(44, 47);
            this.score2.TabIndex = 4;
            this.score2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Name = "Form1";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.TextBox dot;
        private System.Windows.Forms.Timer dott;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
    }
}

