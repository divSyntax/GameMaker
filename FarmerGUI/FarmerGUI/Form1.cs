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
            backGround();
        }

        private void FarmerGUI_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Farmer farmer = new Farmer();
            var rbuttons = new List<CheckBox> {grainSouth,chickenSouth,foxSouth };
            var lbuttons = new List<CheckBox> { chickenNorth, grainNorth, foxNorth };
            int x = farmer1.Location.X;
            int y = fox.Location.X;
            int z = grain.Location.X;
            int a = chicken2.Location.X;



            farmer1.Location = new Point(x - 50);

         

      


            if (x <= 0 && chickenSouth.Checked)
            {
               
                chicken2.Location = new Point(36,86);
                grainSouth.Checked = false; 
                foxSouth.Checked = false;
                chicken2.Left = -50;
                farmer1.Left = 0;
                chicken2.Left = 0;
                //farmer1.Location = new Point(252 ,456);
          

            }else
            if(x <= 0 && grainSouth.Checked)
            {
                grain.Location = new Point(12,351);
                chickenSouth.Checked = false;
                foxSouth.Checked = false;
                grain.Left = -50;
                farmer1.Left = 0;
                 grain.Left = 0;
               // farmer1.Location = new Point(252, 456);
           
            }else

            if (x <= 0 && foxSouth.Checked)
            {
                fox.Location = new Point(12,540);
                grainSouth.Checked = false;
                chickenSouth.Checked = false;
                fox.Left = -50;
                farmer1.Left = 0;
                fox.Left = 0;
                //farmer1.Location = new Point(252, 456);
             
            }

            if(chicken2.Left == 0 && grain.Left == 0 && fox.Left == 0)
            {
                Win();
                MessageBox.Show("Congradulations, YOU WIN!!");
                this.Controls.Clear();
                this.InitializeComponent();
            }

            if (grain.Left == 0 && fox.Left != 0 && chicken2.Left != 0 && x == 0)
            {
                Eat();
                MessageBox.Show("Fox ate the chicken!");
                this.Controls.Clear();
                this.InitializeComponent();
           
            }

            if (chicken2.Left <= 0 && grain.Left <= 0 && x >= 0)
            {
                playSimpleSound();
                MessageBox.Show("Chicken ate grain!");
                this.Controls.Clear();
                this.InitializeComponent();
            }
            if (fox.Left == 0 && chicken2.Left == 0 && grain.Left != 0)
            {

                Eat();
                MessageBox.Show("Fox ate the chicken!");
                this.Controls.Clear();
                this.InitializeComponent();
            }

            if(fox.Left == 0 && chicken2.Left != 0 && grain.Left != 0)
            {
                playSimpleSound();
                MessageBox.Show("Chicken ate grain!");
                this.Controls.Clear();
                this.InitializeComponent();
            }



            //reset controls
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


            //farmer1.Location = new Point(x + 50);
            //chicken2.Location = new Point(a + 40);
       
            if (x <= 600 && chickenNorth.Checked)
            {

                chicken2.Left = +50;
                grainNorth.Checked = false;
                foxNorth.Checked = false;
                chicken2.Location = new Point(672,276);
      
                farmer1.Left = 0;
        
                farmer1.Location = new Point(456, 252);

            }else if(x <= 600 && grainNorth.Checked)
            {
                chickenNorth.Checked = false;
                foxNorth.Checked = false;
                grain.Location = new Point(617, 43);
       
                farmer1.Left = 0;

                farmer1.Location = new Point(456, 252);

            }else if(x <= 600 && foxNorth.Checked)
            {
                chickenNorth.Checked = false;
                grainNorth.Checked = false;
                fox.Location = new Point(589,423);
  
                farmer1.Left = 0;

                farmer1.Location = new Point(456, 252);
           
            }
        }

        private void playSimpleSound()
        {
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"C:\Users\DivSyntax\Downloads\chickeating.wav");
            simpleSound.Play();
        }
        private void backGround()
        {
         
                System.Media.SoundPlayer bck = new System.Media.SoundPlayer(@"C:\Users\DivSyntax\Pictures\farmv.wav");
            bck.PlayLooping();//sound stops playing after the eating sounds begin!

        }

        private void Eat()
        {
            System.Media.SoundPlayer eat = new System.Media.SoundPlayer(@"C:\Users\DivSyntax\Pictures\eat.wav");
            eat.Play();

        }

        private void Win()
        {
            System.Media.SoundPlayer win = new System.Media.SoundPlayer(@"C:\Users\DivSyntax\Downloads\win.wav");
            win.Play();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            int x = farmer1.Location.X;
            farmer1.Location = new Point(456, 252);
         
            if (x == 456)
            {
                farmer1.Location = new Point(166);
            }else
            {
                
            }
        }
    }
}
