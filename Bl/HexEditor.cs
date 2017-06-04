using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bl
{
    public partial class HexEditor : UserControl
    {
        private readonly string[][] _hexData;
        public int X { get; private set; }
        public int Y { get; private set; }
        public HexEditor()
        {
            InitializeComponent();
            // ReSharper disable once LocalizableElement
            InputLbl.Text = "FF 11 22 AA AF EF\r\nAA EE E1\r\n11 22 33 58 72";
            _hexData = Initialize().ToArray();
            EditorBtn.Enabled = false;
            EditorTxtBox.Enabled = false;
        }

        private void EditorBtn_Click(object sender, EventArgs e)
        {
            _hexData[Y][X] = EditorTxtBox.Text;
            UpdateLabel();
            EditorBtn.Enabled = false;
            EditorTxtBox.Enabled = false;
        }

        private void InputLbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            X = (int)(e.X / 22.25F);
            Y = (int)(e.Y / 12.75F);
            try
            {
                EditorTxtBox.Text = _hexData[Y][X];
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
            return InputLbl.Text.Replace("\r\n", "|").Split('|').Select(item => item.Split(' '));
        }

        private void UpdateLabel()
        {
            InputLbl.Text = string.Empty;
            foreach (var item in _hexData)
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
