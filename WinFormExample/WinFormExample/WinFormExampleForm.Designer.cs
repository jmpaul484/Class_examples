namespace WinFormExample
{
    partial class WinFormExampleForm
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
            ExitButton = new Button();
            Submit = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(676, 404);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(112, 34);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += button1_Click;
            // 
            // Submit
            // 
            Submit.Location = new Point(549, 404);
            Submit.Name = "Submit";
            Submit.Size = new Size(112, 34);
            Submit.TabIndex = 1;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(431, 404);
            Clear.Name = "Clear";
            Clear.Size = new Size(112, 34);
            Clear.TabIndex = 2;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Clear);
            Controls.Add(Submit);
            Controls.Add(ExitButton);
            Name = "WinFormExampleForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button Submit;
        private Button Clear;
    }
}
