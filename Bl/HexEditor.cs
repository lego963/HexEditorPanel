using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bl
{
    public partial class HexEditor : UserControl
    {
        public string[][] HexData { get; set; }
        private int _x;
        private int _y;
        private string pattern;
        private Regex spellChecker;
        public HexEditor()
        {
            InitializeComponent();
            // ReSharper disable once LocalizableElement
            InputLbl.Text = "FF 11 22 AA AF EF\r\nAA EE E1\r\n11 22 33 58 72";
            HexData = Initialize().ToArray();
            EditorBtn.Enabled = false;
            EditorTxtBox.Enabled = false;
            pattern = @"[0-9A-F]{2}";
            spellChecker = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void EditorBtn_Click(object sender, EventArgs e)
        {
            if (spellChecker.IsMatch(EditorTxtBox.Text))
            {
                HexData[_y][_x] = EditorTxtBox.Text.ToUpper();
                UpdateLabel();
                EditorBtn.Enabled = false;
                EditorTxtBox.Enabled = false;
            }
            else
            {
                MessageBox.Show(@"pls check data", @"Hex checker");
            }
        }

        private void InputLbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //X = (int)(e.X / 22.25F);
            //Y = (int)(e.Y / 12.75F);
            _x = (int)(e.X / (InputLbl.Font.Size * 2.5F));
            _y = (int)(e.Y / (InputLbl.Font.Size * 1.545F));
            try
            {
                EditorTxtBox.Text = HexData[_y][_x];
                EditorBtn.Enabled = true;
                EditorTxtBox.Enabled = true;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(@"Pls click adequately, retard");
            }

        }

        private IEnumerable<string[]> Initialize()
        {
            return InputLbl.Text.Split('\r').Select(item => item.Trim()).Select(item => item.Split(' '));
            //return InputLbl.Text.Replace("\r\n", "|").Split('|').Select(item => item.Split(' '));
        }

        private void UpdateLabel()
        {
            InputLbl.Text = string.Empty;
            foreach (var item in HexData)
            {
                for (var i = 0; i < item.Length - 1; i++)
                {
                    InputLbl.Text += $@"{item[i]} ";
                }
                // ReSharper disable once LocalizableElement
                InputLbl.Text += $"{item[item.Length - 1]} \r\n";
            }
        }
    }
}
