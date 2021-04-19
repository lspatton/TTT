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
    public partial class PlayerGameForm : Form
    {
        public PlayerGameForm()
        {
            InitializeComponent();

        }

        private void PlayerGameForm_Load(object sender, EventArgs e)
        {
            Game game = new Game();
            game.SwitchPlayer(1);
            Update();
        }

        private void Update()
        {
            
        }
    }
}
