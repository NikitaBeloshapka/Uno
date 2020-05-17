using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphicUno game = new GraphicUno( new GraphicCardSet(panel1, 52),new Player("Nikita"),new Player("Misha"),panel1,panel2,panel3);
            game.RegisterHandler(Sho);
            game.Start();
        }
        private void Sho(string message)
        {
            MessageBox.Show(message);
        }
    }
}
