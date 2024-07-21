using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class HighScoreTableForm : Form
    {
        public HighScoreTableForm()
        {
            InitializeComponent();
        }

        private void HighScoreTableForm_Load(object sender, EventArgs e)
        {
            var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location) + "TableResults";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.ReadLine() != null)
                    {
                        listBoxScores.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxScores.Items.Clear();
        }
    }
}