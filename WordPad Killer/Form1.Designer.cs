namespace WordPad_Killer
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
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.FontLabel = new System.Windows.Forms.Label();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.FontComboBox = new System.Windows.Forms.ComboBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.FontStyleLabel = new System.Windows.Forms.Label();
            this.BoldButton = new System.Windows.Forms.Button();
            this.ItalicButton = new System.Windows.Forms.Button();
            this.UnderlineButton = new System.Windows.Forms.Button();
            this.AligmentLabel = new System.Windows.Forms.Label();
            this.LeftAlignButton = new System.Windows.Forms.Button();
            this.CenterAlignButton = new System.Windows.Forms.Button();
            this.RightAlignButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(1, 84);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(825, 360);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.Text = "";
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontLabel.Location = new System.Drawing.Point(48, 9);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(43, 21);
            this.FontLabel.TabIndex = 1;
            this.FontLabel.Text = "Font";
            // 
            // FontComboBox
            // 
            this.FontComboBox.FormattingEnabled = true;
            this.FontComboBox.Location = new System.Drawing.Point(12, 33);
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(113, 28);
            this.FontComboBox.TabIndex = 2;
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.Location = new System.Drawing.Point(170, 9);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(41, 21);
            this.SizeLabel.TabIndex = 1;
            this.SizeLabel.Text = "Size";
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(157, 33);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(63, 28);
            this.SizeComboBox.TabIndex = 2;
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // FontStyleLabel
            // 
            this.FontStyleLabel.AutoSize = true;
            this.FontStyleLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontStyleLabel.Location = new System.Drawing.Point(278, 9);
            this.FontStyleLabel.Name = "FontStyleLabel";
            this.FontStyleLabel.Size = new System.Drawing.Size(85, 21);
            this.FontStyleLabel.TabIndex = 1;
            this.FontStyleLabel.Text = "Font Style";
            // 
            // BoldButton
            // 
            this.BoldButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BoldButton.Location = new System.Drawing.Point(273, 33);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(26, 28);
            this.BoldButton.TabIndex = 3;
            this.BoldButton.Text = "B";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ItalicButton
            // 
            this.ItalicButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ItalicButton.Location = new System.Drawing.Point(305, 33);
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(26, 28);
            this.ItalicButton.TabIndex = 3;
            this.ItalicButton.Text = "I";
            this.ItalicButton.UseVisualStyleBackColor = true;
            this.ItalicButton.Click += new System.EventHandler(this.ItalicButton_Click);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.UnderlineButton.Location = new System.Drawing.Point(337, 33);
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(26, 28);
            this.UnderlineButton.TabIndex = 3;
            this.UnderlineButton.Text = "U";
            this.UnderlineButton.UseVisualStyleBackColor = true;
            this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
            // 
            // AligmentLabel
            // 
            this.AligmentLabel.AutoSize = true;
            this.AligmentLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AligmentLabel.Location = new System.Drawing.Point(431, 9);
            this.AligmentLabel.Name = "AligmentLabel";
            this.AligmentLabel.Size = new System.Drawing.Size(86, 21);
            this.AligmentLabel.TabIndex = 1;
            this.AligmentLabel.Text = "Alignment";
            // 
            // LeftAlignButton
            // 
            this.LeftAlignButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftAlignButton.Location = new System.Drawing.Point(427, 33);
            this.LeftAlignButton.Name = "LeftAlignButton";
            this.LeftAlignButton.Size = new System.Drawing.Size(26, 28);
            this.LeftAlignButton.TabIndex = 3;
            this.LeftAlignButton.Text = "L";
            this.LeftAlignButton.UseVisualStyleBackColor = true;
            this.LeftAlignButton.Click += new System.EventHandler(this.LeftAlignButton_Click);
            // 
            // CenterAlignButton
            // 
            this.CenterAlignButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CenterAlignButton.Location = new System.Drawing.Point(459, 33);
            this.CenterAlignButton.Name = "CenterAlignButton";
            this.CenterAlignButton.Size = new System.Drawing.Size(26, 28);
            this.CenterAlignButton.TabIndex = 3;
            this.CenterAlignButton.Text = "C";
            this.CenterAlignButton.UseVisualStyleBackColor = true;
            this.CenterAlignButton.Click += new System.EventHandler(this.CenterAlignButton_Click);
            // 
            // RightAlignButton
            // 
            this.RightAlignButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightAlignButton.Location = new System.Drawing.Point(491, 33);
            this.RightAlignButton.Name = "RightAlignButton";
            this.RightAlignButton.Size = new System.Drawing.Size(26, 28);
            this.RightAlignButton.TabIndex = 3;
            this.RightAlignButton.Text = "R";
            this.RightAlignButton.UseVisualStyleBackColor = true;
            this.RightAlignButton.Click += new System.EventHandler(this.RightAlignButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorLabel.Location = new System.Drawing.Point(572, 9);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(50, 21);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Color";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(544, 33);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(104, 28);
            this.ColorComboBox.TabIndex = 2;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(752, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(74, 30);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(752, 48);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 30);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.RightAlignButton);
            this.Controls.Add(this.UnderlineButton);
            this.Controls.Add(this.CenterAlignButton);
            this.Controls.Add(this.ItalicButton);
            this.Controls.Add(this.LeftAlignButton);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.SizeComboBox);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.FontComboBox);
            this.Controls.Add(this.AligmentLabel);
            this.Controls.Add(this.FontStyleLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.MainTextBox);
            this.Name = "Form1";
            this.Text = "WordPad Killer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MainTextBox;
        private Label FontLabel;
        private FontDialog FontDialog;
        private ComboBox FontComboBox;
        private Label SizeLabel;
        private ComboBox SizeComboBox;
        private Label FontStyleLabel;
        private Button BoldButton;
        private Button ItalicButton;
        private Button UnderlineButton;
        private Label AligmentLabel;
        private Button LeftAlignButton;
        private Button CenterAlignButton;
        private Button RightAlignButton;
        private Label ColorLabel;
        private ComboBox ColorComboBox;
        private Button LoadButton;
        private Button SaveButton;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}