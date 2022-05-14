
namespace WinFormsApp1
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
            this.button_00 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_player = new System.Windows.Forms.Label();
            this.button_01 = new System.Windows.Forms.Button();
            this.button_02 = new System.Windows.Forms.Button();
            this.button_11 = new System.Windows.Forms.Button();
            this.button_21 = new System.Windows.Forms.Button();
            this.button_12 = new System.Windows.Forms.Button();
            this.button_22 = new System.Windows.Forms.Button();
            this.button_10 = new System.Windows.Forms.Button();
            this.button_20 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbx_history = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_00
            // 
            this.button_00.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_00.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_00.Location = new System.Drawing.Point(13, 38);
            this.button_00.Name = "button_00";
            this.button_00.Size = new System.Drawing.Size(154, 125);
            this.button_00.TabIndex = 0;
            this.button_00.UseVisualStyleBackColor = true;
            this.button_00.Click += new System.EventHandler(this.button_00_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.Location = new System.Drawing.Point(674, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(60, 30);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Turn:";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // lbl_player
            // 
            this.lbl_player.AutoSize = true;
            this.lbl_player.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_player.Location = new System.Drawing.Point(727, 2);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(46, 47);
            this.lbl_player.TabIndex = 2;
            this.lbl_player.Text = "O";
            // 
            // button_01
            // 
            this.button_01.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_01.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_01.Location = new System.Drawing.Point(195, 38);
            this.button_01.Name = "button_01";
            this.button_01.Size = new System.Drawing.Size(154, 125);
            this.button_01.TabIndex = 3;
            this.button_01.UseVisualStyleBackColor = true;
            this.button_01.Click += new System.EventHandler(this.button_01_Click);
            // 
            // button_02
            // 
            this.button_02.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_02.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_02.Location = new System.Drawing.Point(378, 38);
            this.button_02.Name = "button_02";
            this.button_02.Size = new System.Drawing.Size(154, 125);
            this.button_02.TabIndex = 4;
            this.button_02.UseVisualStyleBackColor = true;
            this.button_02.Click += new System.EventHandler(this.button_02_Click);
            // 
            // button_11
            // 
            this.button_11.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_11.Location = new System.Drawing.Point(195, 169);
            this.button_11.Name = "button_11";
            this.button_11.Size = new System.Drawing.Size(154, 125);
            this.button_11.TabIndex = 5;
            this.button_11.UseVisualStyleBackColor = true;
            this.button_11.Click += new System.EventHandler(this.button_11_Click);
            // 
            // button_21
            // 
            this.button_21.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_21.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_21.Location = new System.Drawing.Point(195, 300);
            this.button_21.Name = "button_21";
            this.button_21.Size = new System.Drawing.Size(154, 125);
            this.button_21.TabIndex = 6;
            this.button_21.UseVisualStyleBackColor = true;
            this.button_21.Click += new System.EventHandler(this.button_21_Click);
            // 
            // button_12
            // 
            this.button_12.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_12.Location = new System.Drawing.Point(378, 169);
            this.button_12.Name = "button_12";
            this.button_12.Size = new System.Drawing.Size(154, 125);
            this.button_12.TabIndex = 7;
            this.button_12.UseVisualStyleBackColor = true;
            this.button_12.Click += new System.EventHandler(this.button_12_Click);
            // 
            // button_22
            // 
            this.button_22.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_22.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_22.Location = new System.Drawing.Point(378, 300);
            this.button_22.Name = "button_22";
            this.button_22.Size = new System.Drawing.Size(154, 125);
            this.button_22.TabIndex = 8;
            this.button_22.UseVisualStyleBackColor = true;
            this.button_22.Click += new System.EventHandler(this.button_22_Click);
            // 
            // button_10
            // 
            this.button_10.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_10.Location = new System.Drawing.Point(13, 169);
            this.button_10.Name = "button_10";
            this.button_10.Size = new System.Drawing.Size(154, 125);
            this.button_10.TabIndex = 9;
            this.button_10.UseVisualStyleBackColor = true;
            this.button_10.Click += new System.EventHandler(this.button_10_Click);
            // 
            // button_20
            // 
            this.button_20.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_20.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_20.Location = new System.Drawing.Point(13, 300);
            this.button_20.Name = "button_20";
            this.button_20.Size = new System.Drawing.Size(154, 125);
            this.button_20.TabIndex = 10;
            this.button_20.UseVisualStyleBackColor = true;
            this.button_20.Click += new System.EventHandler(this.button_20_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(602, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbx_history
            // 
            this.lbx_history.FormattingEnabled = true;
            this.lbx_history.ItemHeight = 15;
            this.lbx_history.Location = new System.Drawing.Point(602, 65);
            this.lbx_history.Name = "lbx_history";
            this.lbx_history.Size = new System.Drawing.Size(171, 304);
            this.lbx_history.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(779, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbx_history);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_20);
            this.Controls.Add(this.button_10);
            this.Controls.Add(this.button_22);
            this.Controls.Add(this.button_12);
            this.Controls.Add(this.button_21);
            this.Controls.Add(this.button_11);
            this.Controls.Add(this.button_02);
            this.Controls.Add(this.button_01);
            this.Controls.Add(this.lbl_player);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button_00);
            this.Name = "Form1";
            this.Text = "14.05.22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_00;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Button button_01;
        private System.Windows.Forms.Button button_02;
        private System.Windows.Forms.Button button_11;
        private System.Windows.Forms.Button button_21;
        private System.Windows.Forms.Button button_12;
        private System.Windows.Forms.Button button_22;
        private System.Windows.Forms.Button button_10;
        private System.Windows.Forms.Button button_20;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbx_history;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

