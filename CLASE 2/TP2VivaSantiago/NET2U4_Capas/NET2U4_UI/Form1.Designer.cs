namespace NET2U4_UI
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
            txtHolaMundo = new TextBox();
            btnHolaMundo = new Button();
            SuspendLayout();
            // 
            // txtHolaMundo
            // 
            txtHolaMundo.Location = new Point(12, 61);
            txtHolaMundo.Name = "txtHolaMundo";
            txtHolaMundo.Size = new Size(290, 23);
            txtHolaMundo.TabIndex = 0;
            // 
            // btnHolaMundo
            // 
            btnHolaMundo.Location = new Point(322, 61);
            btnHolaMundo.Name = "btnHolaMundo";
            btnHolaMundo.Size = new Size(75, 23);
            btnHolaMundo.TabIndex = 1;
            btnHolaMundo.Text = "Click";
            btnHolaMundo.UseVisualStyleBackColor = true;
            btnHolaMundo.Click += btnHolaMundo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 148);
            Controls.Add(btnHolaMundo);
            Controls.Add(txtHolaMundo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHolaMundo;
        private Button btnHolaMundo;
    }
}