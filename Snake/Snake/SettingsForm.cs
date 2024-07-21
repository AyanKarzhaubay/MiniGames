using System;
using System.Windows.Forms;

namespace Snake
{
    public partial class SettingsForm : Form
    {
        public const int w = 36, h = 36, s = 10;
        public SettingsForm()
        {
            InitializeComponent();
            textBoxWidth.Text = Settings.Width.ToString();
            textBoxHeight.Text = Settings.Height.ToString();
            textBoxSpeed.Text = Settings.Speed.ToString();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (textBoxWidth.Text != "" && textBoxHeight.Text != "" && textBoxSpeed.Text != "")
            {
                Settings.Width = Convert.ToInt32(textBoxWidth.Text);
                Settings.Height = Convert.ToInt32(textBoxHeight.Text);
                Settings.Speed = Convert.ToInt32(textBoxSpeed.Text);
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Error");
            }
            Close();
        }

        private void buttonSetDefSet_Click(object sender, EventArgs e)
        {
            textBoxWidth.Text = w.ToString();
            textBoxHeight.Text = h.ToString();
            textBoxSpeed.Text = s.ToString();
        }
    }
}
