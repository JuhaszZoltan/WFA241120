namespace WFA241120
{
    partial class FrmAkasztofa
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
            pbAkasztofa = new PictureBox();
            label1 = new Label();
            lblEddigiTippek = new Label();
            tbxTipp = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbAkasztofa).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pbAkasztofa.BackColor = Color.YellowGreen;
            pbAkasztofa.Location = new Point(19, 19);
            pbAkasztofa.Margin = new Padding(10);
            pbAkasztofa.Name = "pictureBox1";
            pbAkasztofa.Size = new Size(300, 400);
            pbAkasztofa.TabIndex = 0;
            pbAkasztofa.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.SeaShell;
            label1.Font = new Font("Courier New", 20F, FontStyle.Bold);
            label1.Location = new Point(339, 19);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(634, 152);
            label1.TabIndex = 1;
            label1.Text = "A _ _ A   A   _ A   A _ A _ _";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            lblEddigiTippek.BackColor = Color.SeaShell;
            lblEddigiTippek.Font = new Font("Courier New", 20F, FontStyle.Bold);
            lblEddigiTippek.Location = new Point(339, 191);
            lblEddigiTippek.Margin = new Padding(10);
            lblEddigiTippek.Name = "label2";
            lblEddigiTippek.Size = new Size(634, 104);
            lblEddigiTippek.TabIndex = 1;
            lblEddigiTippek.Text = "G, E, C, D, ";
            lblEddigiTippek.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            tbxTipp.Font = new Font("Courier New", 40F);
            tbxTipp.Location = new Point(594, 329);
            tbxTipp.Name = "textBox1";
            tbxTipp.Size = new Size(100, 68);
            tbxTipp.TabIndex = 2;
            tbxTipp.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 446);
            Controls.Add(tbxTipp);
            Controls.Add(lblEddigiTippek);
            Controls.Add(label1);
            Controls.Add(pbAkasztofa);
            Name = "Form1";
            Text = "Akasztófa";
            ((System.ComponentModel.ISupportInitialize)pbAkasztofa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAkasztofa;
        private Label label1;
        private Label lblEddigiTippek;
        private TextBox tbxTipp;
    }
}
