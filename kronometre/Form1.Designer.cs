namespace kronometre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Again = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2ImageRadioButton1 = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.SuspendLayout();
            // 
            // Again
            // 
            this.Again.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(124)))), ((int)(((byte)(35)))));
            this.Again.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Again.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Again.Font = new System.Drawing.Font("Open Sans SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.Again.ForeColor = System.Drawing.Color.White;
            this.Again.Location = new System.Drawing.Point(249, 182);
            this.Again.Margin = new System.Windows.Forms.Padding(0);
            this.Again.Name = "Again";
            this.Again.Size = new System.Drawing.Size(216, 51);
            this.Again.TabIndex = 1;
            this.Again.Text = "Tekrar";
            this.Again.UseVisualStyleBackColor = false;
            this.Again.Click += new System.EventHandler(this.Again_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Open Sans SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(338, 35);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 52);
            this.button4.TabIndex = 6;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(124)))), ((int)(((byte)(35)))));
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Open Sans SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(23, 182);
            this.Start.Margin = new System.Windows.Forms.Padding(0);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(216, 51);
            this.Start.TabIndex = 7;
            this.Start.Text = "Başla";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(124)))), ((int)(((byte)(35)))));
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Open Sans SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(23, 242);
            this.Save.Margin = new System.Windows.Forms.Padding(0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(442, 51);
            this.Save.TabIndex = 8;
            this.Save.Text = "Kaydet";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Open Sans", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(23, 113);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(442, 52);
            this.label.TabIndex = 10;
            this.label.Text = "label";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Open Sans SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 42;
            this.listBox.Location = new System.Drawing.Point(23, 306);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(442, 172);
            this.listBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Open Sans SemiBold", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(23, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "GitHub";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2ImageRadioButton1
            // 
            this.guna2ImageRadioButton1.BackColor = System.Drawing.Color.White;
            this.guna2ImageRadioButton1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageRadioButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageRadioButton1.Image")));
            this.guna2ImageRadioButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageRadioButton1.ImageRotate = 0F;
            this.guna2ImageRadioButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageRadioButton1.Location = new System.Drawing.Point(40, 39);
            this.guna2ImageRadioButton1.Name = "guna2ImageRadioButton1";
            this.guna2ImageRadioButton1.Size = new System.Drawing.Size(43, 44);
            this.guna2ImageRadioButton1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(489, 500);
            this.Controls.Add(this.guna2ImageRadioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Again);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Again;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2ImageRadioButton guna2ImageRadioButton1;
    }
}

