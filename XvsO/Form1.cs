using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

       


namespace XvsO
{
    public partial class Form1 : Form
    {
        int[,] array = new int[3, 3];
        int[] chekk = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        
        Random random = new Random();
        

        void chek()
        {
            if (chekk[1] == chekk[2] && chekk[2] == chekk[3] && chekk[1] != 0)
            {
                if (chekk[1] == 1)
                    MessageBox.Show("You win!");
                else
                    MessageBox.Show("You lose!");
            }

            else if (chekk[1] == chekk[4] && chekk[1] == chekk[7] && chekk[1] != 0)
            {
                if (chekk[1] == 1)
                    MessageBox.Show("You win!");
                else
                    MessageBox.Show("You lose!");

            }

            else if (chekk[1] == chekk[5] && chekk[1] == chekk[9] && chekk[1] != 0)
            {
                if (chekk[1] == 1)
                    MessageBox.Show("You win!");
                else
                    MessageBox.Show("You lose!");

            }


            else if (chekk[2] == chekk[5] && chekk[2] == chekk[8] && chekk[2] != 0)
            {
                if (chekk[2] == 1)
                    MessageBox.Show("You win!");
                else
                    MessageBox.Show("You lose!");

            }


            else if (chekk[3] == chekk[6] && chekk[3] == chekk[9] && chekk[3] != 0)
            {
                if (chekk[3] == 1)
                    MessageBox.Show("You are win!");
                else
                    MessageBox.Show("You lose!");

            }


            else if (chekk[3] == chekk[5] && chekk[5] == chekk[7] && chekk[3] != 0)
            {
                if (chekk[3] == 1)
                    MessageBox.Show("You win!");
                else
                    MessageBox.Show("You lose!");

            }


            else if (chekk[4] == chekk[5] && chekk[4] == chekk[6] && chekk[4] != 0)
            {
                if (chekk[4] == 1)
                    MessageBox.Show("You  win!");
                else
                    MessageBox.Show("You  lose!");

            }

            else if (chekk[7] == chekk[8] && chekk[8] == chekk[9] && chekk[7] != 0)
            {
                if (chekk[7] == 1)
                    MessageBox.Show("You win!");
                else
                    MessageBox.Show("You lose!");

            }
          
        }
        bool b = true;
        int k=0, j;
        void comp(int and)
        {
            for (int i = 0; i < 10; i++)
            {
                if (chekk[i] == 0)
                {
                    k++;
                    j = i;
                }
            }

            if (k == 1)
            {
                and = j;
 
            }
            else if (k == 0)
            {
                for (int i = 0; i < 10; i++)
                    chekk[i] = 0;
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";

                button4.Text = "";
                button5.Text = "";
                button6.Text = "";

                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                Random random = new Random();
                int beginner = random.Next(1, 100);

                if (beginner % 2 == 0)
                    comp(12);
 
            }
                if (and == 12)
                {

                    and = random.Next(1, 10);

                    while (true)
                    {

                        if (chekk[and] == 0)
                            break;

                        and = random.Next(1, 10);

                    }
                }
      


                if (and == 1)
                {
                    chekk[1] = 2;
                    button1.Text = "O";
                    b = false;
                }

                if (and==2)
                    {
                        chekk[2] = 2;
                        button2.Text = "O";
                        b = false;
                    }


                       if (and==3)
                        {
                            chekk[3] = 2;
                            button3.Text = "O";
                            b = false;
                        }

                
                       if (and == 4)
                           {
                                chekk[4] = 2;
                                button4.Text = "O";
                                b = false;
                            }
                
                      if (and == 5)
                       {
                           chekk[5] = 2;
                           button5.Text = "O";
                           b = false;
                       }
                if (and == 6)
                {
                    chekk[6] = 2;
                    button6.Text = "O";
                    b = false;
                }
                           
                 if (and == 7)
                {
                    chekk[7] = 2;
                    button7.Text = "O";
                    b = false;
                }

                 if (and == 8 )
                {
                           chekk[8] = 2;
                           button8.Text = "O";
                           b = false;
                 }

                 if (and == 9 )
                {
                    chekk[9] = 2;
                    button9.Text = "O";
                    b = false;
                }

                 chek();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            if (chekk[1] == 0)
            {
                chekk[1] = 1;
                button1.Text = "X";

                if (chekk[2] == 0)
                    comp(2);
                else if (chekk[4] == 0)
                    comp(4);
                else
                    comp(12);

                chek();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chekk[2] == 0)
            {
                chekk[2] = 1;
                button2.Text = "X";

                if (chekk[1] == 0)
                    comp(1);
                else if (chekk[5] == 0)
                    comp(5);
                else if (chekk[3] == 0)
                    comp(3);
                else
                    comp(12);
                chek();
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chekk[3] == 0)
            {
                chekk[3] = 1;
                button3.Text = "X";

                if (chekk[2] == 0)
                    comp(2);

                else if (chekk[6] == 0)
                    comp(6);
                else if (chekk[5] == 0)
                    comp(5);
                else
                    comp(12);
                chek();
                
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (chekk[6] == 0)
            {
                chekk[6] = 1;
                button6.Text = "X";


                if (chekk[3] == 0)
                    comp(3);

                else if (chekk[5] == 0)
                    comp(5);
                else if (chekk[9] == 0)
                    comp(9);
                else
                    comp(12);

                chek();
                
            }

          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (chekk[5] == 0)
            {
                chekk[5] = 1;
                button5.Text = "X";


                if (chekk[2] == 0)
                    comp(2);

                else if (chekk[6] == 0)
                    comp(6);
                else if (chekk[4] == 0)
                    comp(4);
                else if (chekk[8] == 0)
                    comp(8);
                else
                    comp(12);
                chek();
                
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chekk[4] == 0)
            {
                chekk[4] = 1;
                button4.Text = "X";


                if (chekk[1] == 0)
                    comp(1);

                else if (chekk[5] == 0)
                    comp(5);
                else if (chekk[7] == 0)
                    comp(7);
                else
                    comp(12);
                chek();
                
            }

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (chekk[9] == 0)
            {
                chekk[9] = 1;
                button9.Text = "X";

                if (chekk[6] == 0)
                    comp(6);

                else if (chekk[8] == 0)
                    comp(8);
                else if (chekk[5] == 0)
                    comp(5);
                else
                    comp(12);

                chek();
                
            }

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (chekk[8] == 0)
            {
                chekk[8] = 1;
                button8.Text = "X";


                if (chekk[5] == 0)
                    comp(5);

                else if (chekk[9] == 0)
                    comp(9);
                else if (chekk[7] == 0)
                    comp(7);
                else
                    comp(12);
                chek();
                
            }

        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (chekk[7] == 0)
            {
                chekk[7] = 1;
                button7.Text = "X";

                if (chekk[4] == 0)
                    comp(4);

                else if (chekk[5] == 0)
                    comp(5);
                else if (chekk[8] == 0)
                    comp(8);
                else
                    comp(12);
                chek();
                
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                chekk[i] = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            Random random = new Random();
            int beginner = random.Next(1, 100);

            if (beginner % 2 == 0)
                comp(12);
        }


    }
}
