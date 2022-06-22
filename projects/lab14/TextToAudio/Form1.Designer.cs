namespace TextToAudio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveAudio = new System.Windows.Forms.Button();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnLoadAudio = new System.Windows.Forms.Button();
            this.btnLoadText = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoadText);
            this.panel1.Controls.Add(this.btnLoadAudio);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSaveText);
            this.panel1.Controls.Add(this.btnSaveAudio);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(477, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 437);
            this.panel1.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(152, 40);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(477, 437);
            this.textBox1.TabIndex = 1;
            // 
            // btnSaveAudio
            // 
            this.btnSaveAudio.Location = new System.Drawing.Point(6, 150);
            this.btnSaveAudio.Name = "btnSaveAudio";
            this.btnSaveAudio.Size = new System.Drawing.Size(152, 40);
            this.btnSaveAudio.TabIndex = 2;
            this.btnSaveAudio.Text = "Save Audio";
            this.btnSaveAudio.UseVisualStyleBackColor = true;
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(6, 242);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(152, 40);
            this.btnSaveText.TabIndex = 3;
            this.btnSaveText.Text = "Save Text";
            this.btnSaveText.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(152, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(6, 334);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(152, 40);
            this.btnOptions.TabIndex = 5;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(6, 58);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(152, 40);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop Playback";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnLoadAudio
            // 
            this.btnLoadAudio.Location = new System.Drawing.Point(6, 196);
            this.btnLoadAudio.Name = "btnLoadAudio";
            this.btnLoadAudio.Size = new System.Drawing.Size(152, 40);
            this.btnLoadAudio.TabIndex = 7;
            this.btnLoadAudio.Text = "Load Audio";
            this.btnLoadAudio.UseVisualStyleBackColor = true;
            // 
            // btnLoadText
            // 
            this.btnLoadText.Location = new System.Drawing.Point(6, 288);
            this.btnLoadText.Name = "btnLoadText";
            this.btnLoadText.Size = new System.Drawing.Size(152, 40);
            this.btnLoadText.TabIndex = 8;
            this.btnLoadText.Text = "Load Text";
            this.btnLoadText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 437);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.Button btnSaveAudio;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnLoadText;
        private System.Windows.Forms.Button btnLoadAudio;
    }
}

