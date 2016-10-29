using FarmerGameApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerGUI
{
    public partial class FarmerGUI : Form
    {

      
    

        public FarmerGUI()
        {
            InitializeComponent();
        }

        private void FarmerGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Farmer farmer = new Farmer();
            var rbuttons = new List<CheckBox> {checkBox1,checkBox2,checkBox3 };
            var lbuttons = new List<CheckBox> { checkBox4, checkBox5, checkBox6 };
            int x = farmer1.Location.X;
            int y = fox.Location.X;
            int z = grain.Location.X;
            int a = chicken2.Location.X;



            farmer1.Location = new Point(x - 50);

         

      


            if (x <= 0 && checkBox2.Checked)
            {
                //farmer1.Visible = false;
                chicken2.Location = new Point(36,86);
                checkBox1.Checked = false; 
                checkBox3.Checked = false;
                chicken2.Left = -50;
                farmer1.Left = 0;
                chicken2.Left = 0;
                farmer1.Location = new Point(252 ,456);
                //this.InitializeComponent();
                MessageBox.Show("go bck for rest.");

            }else
            if(x <= 0 && checkBox1.Checked)
            {
                grain.Location = new Point(14,451);
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                grain.Left = -50;
                farmer1.Left = 0;
                 grain.Left = 0;
                farmer1.Location = new Point(252, 456);
                //this.InitializeComponent();
                MessageBox.Show("go bck for rest.");
            }else

            if (x <= 0 && checkBox3.Checked)
            {
                fox.Location = new Point(36,420);
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                fox.Left = -50;
                farmer1.Left = 0;
                fox.Left = 0;
                farmer1.Location = new Point(252, 456);
                //this.InitializeComponent();
                MessageBox.Show("go bck for rest.");
            }else

            if(chicken2.Left == 0 && grain.Left == 0 && fox.Left == 0)
            {
                MessageBox.Show("YOU WIN!!");
            }

         

            //this.Controls.Clear();

            //this.InitializeComponent();


        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            int x = farmer1.Location.X;
            int y = fox.Location.X;
            int z = grain.Location.X;
            int a = chicken2.Location.X;


            farmer1.Location = new Point(x + 50);
            //chicken2.Location = new Point(a + 40);
            if (x >= 600 && checkBox4.Checked)
            {
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                chicken2.Location = new Point(672,276);
                //chicken2.Left = + 50;
                farmer1.Left = 0;
               // chicken2.Left = 0;
                farmer1.Location = new Point(252, 456);
                MessageBox.Show("Home!");
            }else if(x >= 600 && checkBox5.Checked)
            {
                checkBox4.Checked = false;
                checkBox6.Checked = false;
                grain.Location = new Point(617, 43);
                //chicken2.Left = + 50;
                farmer1.Left = 0;
                // chicken2.Left = 0;
                farmer1.Location = new Point(252, 456);
                MessageBox.Show("Home!");
            }else if(x >= 600 && checkBox6.Checked)
            {
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                fox.Location = new Point(589,423);
                //chicken2.Left = + 50;
                farmer1.Left = 0;
                // chicken2.Left = 0;
                farmer1.Location = new Point(252, 456);
                MessageBox.Show("Home!");
            }
        }

     
    }
}
