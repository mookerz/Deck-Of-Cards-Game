using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeckOfCardsGame
{
    public partial class PlayGround : Form
    {
        public PlayGround()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            Console.WriteLine(r.Next(2));
            Console.WriteLine(r.Next(2));
            Console.WriteLine(r.Next(2));
            Console.WriteLine(r.Next(2));
            Console.WriteLine(r.Next(2));
        }
    }
}
