namespace YılanOyunu
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
            components = new System.ComponentModel.Container();
            pnlMain = new Panel();
            lblSkor = new Label();
            lbl = new Label();
            tmrOyun = new System.Windows.Forms.Timer(components);
            lblOncekiSkor = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Black;
            pnlMain.Location = new Point(12, 61);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(600, 600);
            pnlMain.TabIndex = 0;
            pnlMain.Paint += pnlMain_Paint;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.BackColor = Color.Transparent;
            lblSkor.Font = new Font("Courier New", 16F);
            lblSkor.ForeColor = Color.AliceBlue;
            lblSkor.Location = new Point(550, 16);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(61, 30);
            lblSkor.TabIndex = 1;
            lblSkor.Text = "000";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Transparent;
            lbl.Font = new Font("Segoe UI", 16F);
            lbl.ForeColor = Color.AliceBlue;
            lbl.Location = new Point(475, 9);
            lbl.Name = "lbl";
            lbl.Size = new Size(82, 37);
            lbl.TabIndex = 2;
            lbl.Text = "Skor :";
            // 
            // tmrOyun
            // 
            tmrOyun.Interval = 500;
            tmrOyun.Tick += tmrOyun_Tick;
            // 
            // lblOncekiSkor
            // 
            lblOncekiSkor.AutoSize = true;
            lblOncekiSkor.BackColor = Color.Transparent;
            lblOncekiSkor.Font = new Font("Courier New", 16F);
            lblOncekiSkor.ForeColor = Color.AliceBlue;
            lblOncekiSkor.Location = new Point(233, 16);
            lblOncekiSkor.Name = "lblOncekiSkor";
            lblOncekiSkor.Size = new Size(61, 30);
            lblOncekiSkor.TabIndex = 3;
            lblOncekiSkor.Text = "000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 4;
            label1.Text = "Önceki Skorunuz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(12, 674);
            label2.Name = "label2";
            label2.Size = new Size(497, 20);
            label2.TabIndex = 5;
            label2.Text = "Herhangi yön tuşuna basarak oyunu başlatın ve yön tuşlarıyla kontrol edin.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.yilan;
            ClientSize = new Size(629, 731);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblOncekiSkor);
            Controls.Add(lbl);
            Controls.Add(lblSkor);
            Controls.Add(pnlMain);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yılan Oyunu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private Label lblSkor;
        private Label lbl;
        private System.Windows.Forms.Timer tmrOyun;
        private Label lblOncekiSkor;
        private Label label1;
        private Label label2;
    }
}
