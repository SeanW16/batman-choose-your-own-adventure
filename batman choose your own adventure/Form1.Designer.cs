namespace batman_choose_your_own_adventure
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.option3Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(271, 235);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(205, 35);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Batman";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(277, 336);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(199, 51);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.Transparent;
            this.option2Button.FlatAppearance.BorderSize = 3;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.ForeColor = System.Drawing.Color.White;
            this.option2Button.Location = new System.Drawing.Point(79, 360);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(138, 51);
            this.option2Button.TabIndex = 2;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Visible = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Transparent;
            this.option1Button.FlatAppearance.BorderSize = 3;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.ForeColor = System.Drawing.Color.White;
            this.option1Button.Location = new System.Drawing.Point(260, 360);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(138, 51);
            this.option1Button.TabIndex = 3;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Visible = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(33, 274);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 15);
            this.outputLabel.TabIndex = 5;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.Black;
            this.questionLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(33, 322);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 15);
            this.questionLabel.TabIndex = 6;
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.Transparent;
            this.option3Button.FlatAppearance.BorderSize = 3;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.ForeColor = System.Drawing.Color.White;
            this.option3Button.Location = new System.Drawing.Point(459, 360);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(138, 51);
            this.option3Button.TabIndex = 7;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Visible = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::batman_choose_your_own_adventure.Properties.Resources.Batcycle;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::batman_choose_your_own_adventure.Properties.Resources.startWallpaper;
            this.ClientSize = new System.Drawing.Size(744, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

