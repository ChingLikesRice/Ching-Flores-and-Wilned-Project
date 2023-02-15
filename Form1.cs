using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace riddle_game__wilned__gavin_ching__gabriel_flores_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("welcome to our riddle game! To begin you must select a dificulty on the right hand side and press begin, type your answer in the text box( it's only one word for all of them and lowercase) and then press enter. a message box while appear and tell you if you're right or wrong, get it wrong three times and the program shuts down :) Goooood luck!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void helpbtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("welcome to our riddle game! To begin you must select a dificulty on the right hand side and press begin, type your answer in the text box( it's only one word for all of them and lowercase) and then press enter. a message box while appear and tell you if you're right or wrong, get it wrong three times and the program shuts down :) Goooood luck!");
        }
    }
}
