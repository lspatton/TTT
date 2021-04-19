using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HumanGameBtn_Click(object sender, EventArgs e)
        {
            var m = new PlayerGameForm();
            m.Show();
        }

        private void AiGameBtn_Click(object sender, EventArgs e)
        {
            var m = new AiGameForm();
            m.Show();
        }
    }
}
