namespace Hangman
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
            this.label_word = new System.Windows.Forms.Label();
            this.textBox_guess = new System.Windows.Forms.TextBox();
            this.Button_next = new System.Windows.Forms.Button();
            this.Button_start = new System.Windows.Forms.Button();
            this.Button_quit = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_word
            // 
            this.label_word.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_word.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_word.Location = new System.Drawing.Point(38, 19);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(350, 45);
            this.label_word.TabIndex = 0;
            this.label_word.Text = "Word";
            this.label_word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_guess
            // 
            this.textBox_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_guess.Location = new System.Drawing.Point(36, 85);
            this.textBox_guess.Name = "textBox_guess";
            this.textBox_guess.Size = new System.Drawing.Size(352, 38);
            this.textBox_guess.TabIndex = 1;
            this.textBox_guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_next
            // 
            this.Button_next.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_next.Enabled = false;
            this.Button_next.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_next.Location = new System.Drawing.Point(36, 141);
            this.Button_next.Name = "Button_next";
            this.Button_next.Size = new System.Drawing.Size(352, 49);
            this.Button_next.TabIndex = 2;
            this.Button_next.Text = "Next";
            this.Button_next.UseVisualStyleBackColor = false;
            this.Button_next.Click += new System.EventHandler(this.Button_next_Click);
            // 
            // Button_start
            // 
            this.Button_start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_start.Location = new System.Drawing.Point(36, 196);
            this.Button_start.Name = "Button_start";
            this.Button_start.Size = new System.Drawing.Size(352, 48);
            this.Button_start.TabIndex = 3;
            this.Button_start.Text = "Start";
            this.Button_start.UseVisualStyleBackColor = false;
            this.Button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // Button_quit
            // 
            this.Button_quit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Button_quit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_quit.Location = new System.Drawing.Point(36, 251);
            this.Button_quit.Name = "Button_quit";
            this.Button_quit.Size = new System.Drawing.Size(352, 48);
            this.Button_quit.TabIndex = 4;
            this.Button_quit.Text = "Quit";
            this.Button_quit.UseVisualStyleBackColor = false;
            this.Button_quit.Click += new System.EventHandler(this.Button_quit_Click);
            // 
            // label_result
            // 
            this.label_result.BackColor = System.Drawing.Color.Peru;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(38, 320);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(350, 45);
            this.label_result.TabIndex = 5;
            this.label_result.Text = "Result";
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(202, 370);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(24, 18);
            this.label_score.TabIndex = 6;
            this.label_score.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 397);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.Button_quit);
            this.Controls.Add(this.Button_start);
            this.Controls.Add(this.Button_next);
            this.Controls.Add(this.textBox_guess);
            this.Controls.Add(this.label_word);
            this.Name = "Form1";
            this.Text = "Hangman Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.TextBox textBox_guess;
        private System.Windows.Forms.Button Button_next;
        private System.Windows.Forms.Button Button_start;
        private System.Windows.Forms.Button Button_quit;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_score;
    }
}

