
namespace KolkoKrzyzyk
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
            this.label1 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(46, 68);
            this.a1.Margin = new System.Windows.Forms.Padding(2);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(94, 102);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.button_Click);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(145, 68);
            this.a2.Margin = new System.Windows.Forms.Padding(2);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(94, 102);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.button_Click);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(243, 68);
            this.a3.Margin = new System.Windows.Forms.Padding(2);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(94, 102);
            this.a3.TabIndex = 3;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.button_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(46, 175);
            this.b1.Margin = new System.Windows.Forms.Padding(2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(94, 102);
            this.b1.TabIndex = 4;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.button_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(145, 175);
            this.b2.Margin = new System.Windows.Forms.Padding(2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(94, 102);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.button_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(243, 175);
            this.b3.Margin = new System.Windows.Forms.Padding(2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(94, 102);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.button_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(46, 281);
            this.c1.Margin = new System.Windows.Forms.Padding(2);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(94, 102);
            this.c1.TabIndex = 7;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.button_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(145, 281);
            this.c2.Margin = new System.Windows.Forms.Padding(2);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(94, 102);
            this.c2.TabIndex = 8;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.button_Click);
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(243, 281);
            this.c3.Margin = new System.Windows.Forms.Padding(2);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(94, 102);
            this.c3.TabIndex = 9;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.button_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(46, 411);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(290, 28);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clean board";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.wyczysc);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 465);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button clear;
    }
}

