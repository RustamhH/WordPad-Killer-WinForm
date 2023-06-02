using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordPad_Killer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                float size = Convert.ToSingle(SizeComboBox.SelectedItem);
                MainTextBox.SelectionFont = new($"{FontComboBox.SelectedItem}", size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void ColorComboBox_SelectedIndexChanged(object sender,EventArgs e)
        {
            MainTextBox.SelectionColor = Color.FromName(ColorComboBox.SelectedItem.ToString());
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(SizeComboBox.SelectedItem);
            MainTextBox.SelectionFont = new($"{FontComboBox.SelectedItem}",size,FontStyle.Bold);
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(SizeComboBox.SelectedItem);
            MainTextBox.SelectionFont = new($"{FontComboBox.SelectedItem}", size, FontStyle.Italic);
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            float size = Convert.ToSingle(SizeComboBox.SelectedItem);
            MainTextBox.SelectionFont = new($"{FontComboBox.SelectedItem}", size, FontStyle.Underline);
        }

        private void LeftAlignButton_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAlignButton_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void RightAlignButton_Click(object sender, EventArgs e)
        {
            MainTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            FontComboBox.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());
            SizeComboBox.Items.AddRange(new string[] { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72" });
            SizeComboBox.SelectedItem = "11";
            ColorComboBox.Items.AddRange(Enum.GetNames(typeof(KnownColor)));            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files|*.*|Text Files|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var str = File.ReadAllText(openFileDialog1.FileName);

                MainTextBox.Text = str;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All files|*.*|Text Files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, MainTextBox.Text);
            }
        }
    }
}