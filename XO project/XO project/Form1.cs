using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_project
{
    public partial class Form1 : Form
    {
        int p = 0, yy = 0;
        int y1 = 0,y2=0;
       // int d = 0;
        Random x = new Random();
        int c = 1;
        int a1, a2, a3, a4, a5, a6, a7, a8, a9;
        void ch()
        {
            if (a1 + a2 + a3 == 3 || a4 + a5 + a6 == 3 || a7 + a8 + a9 == 3 || a1 + a4 + a7 == 3 || a2 + a5 + a8 == 3 || a3 + a6 + a9 == 3 || a1 + a5 + a9 == 3 || a3 + a5 + a7 == 3)
            {
                DialogResult n;
                n = MessageBox.Show("YOU LOSE       Do you like to play again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                p++;
                label4.Text = p.ToString();
                if (n == DialogResult.Yes)
                {
                    restart();
                }
                if (n == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (a1 + a2 + a3 == 15 || a4 + a5 + a6 == 15 || a7 + a8 + a9 == 15 || a1 + a4 + a7 == 15 || a2 + a5 + a8 == 15 || a3 + a6 + a9 == 15 || a1 + a5 + a9 == 15 || a3 + a5 + a7 == 15)
            {
                yy++;
                label2.Text = yy.ToString();
                DialogResult n;
                n = MessageBox.Show("YOU WIN       Do you like to play again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (n == DialogResult.Yes)
                {
                    restart();
                }
                if (n == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            if (a1 != 0 && a2 != 0 && a3 != 0 && a4 != 0 && a5 != 0 && a6 != 0 && a7 != 0 && 81 != 0 && a9 != 0)
            {
                DialogResult n;
                n = MessageBox.Show("DRAW       Do you like to play again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
                if (n == DialogResult.Yes)
                {
                    restart();
                }
                if (n == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        void pc1()
        {
            int b = 2;
            for (int i = 0; i <=50; i++)
            {
                b = x.Next(1, 10);
                if (b == 1 && a1 == 0 && a9 == 0)
                {
                    a1 = 1;
                    button1.Text = "X";
                    button1.Enabled = false;
                    break;
                }

                if (b == 2 && a2 == 0 && a8 == 0)
                {
                    a2 = 1;
                    button2.Text = "X";
                    button2.Enabled = false;
                    break;
                }

                if (b == 3 && a3 == 0 && a7 == 0)
                {
                    a3 = 1;
                    button3.Text = "X";
                    button3.Enabled = false;
                    break;
                }

                if (b == 4 && a4 == 0 && a6 == 0)
                {
                    a4 = 1;
                    button4.Text = "X";
                    button4.Enabled = false;
                    break;
                }

                if (b == 6 && a6 == 0 && a4 == 0)
                {
                    a6 = 1;
                    button6.Text = "X";
                    button6.Enabled = false;
                    break;
                }

                if (b == 7 && a7 == 0 && a3 == 0)
                {
                    a7 = 1;
                    button7.Text = "X";
                    button7.Enabled = false;
                    break;
                }

                if (b == 8 && a8 == 0 && a2 == 0)
                {
                    a8 = 1;
                    button8.Text = "X";
                    button8.Enabled = false;
                    break;
                }

                if (b == 9 && a9 == 0 && a1 == 0)
                {
                    a9 = 1;
                    button9.Text = "X";
                    button9.Enabled = false;
                    break;

                }



            }
        }


        void pc2()
        {
            int b = 2;
            for (int i = 0; i <= 30; i++)
            {
                b = x.Next(1, 10);
                if (b == 1 && a1 == 0)
                {
                    a1 = 1;
                    button1.Text = "X";
                    button1.Enabled = false;
                    break;
                }

                if (b == 2 && a2 == 0)
                {
                    a2 = 1;
                    button2.Text = "X";
                    button2.Enabled = false;
                    break;
                }

                if (b == 3 && a3 == 0)
                {
                    a3 = 1;
                    button3.Text = "X";
                    button3.Enabled = false;
                    break;
                }

                if (b == 4 && a4 == 0)
                {
                    a4 = 1;
                    button4.Text = "X";
                    button4.Enabled = false;
                    break;
                }

                if (b == 6 && a6 == 0)
                {
                    a6 = 1;
                    button6.Text = "X";
                    button6.Enabled = false;
                    break;
                }

                if (b == 7 && a7 == 0)
                {
                    a7 = 1;
                    button7.Text = "X";
                    button7.Enabled = false;
                    break;
                }

                if (b == 8 && a8 == 0)
                {
                    a8 = 1;
                    button8.Text = "X";
                    button8.Enabled = false;
                    break;
                }

                if (b == 9 && a9 == 0)
                {
                    a9 = 1;
                    button9.Text = "X";
                    button9.Enabled = false;
                    break;

                }



            }
        }


        void restart()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;


            button10.Enabled = false;
            button11.Enabled = true;
            button5.Text = "X";
            a5 = 1;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            a1 = 0; a2 = 0; a3 = 0; a4 = 0; a6 = 0; a7 = 0; a8 = 0; a9 = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            c = 1;
        }


        void you1()
        {
            if (a1 + a2 + a3 == 2)
            {
                y1++;
                if (a1 == 0)
                {
                    button1.Text = "X";
                    button1.Enabled = false;
                    a1 = 1;
                }
                if (a2 == 0)
                {
                    button2.Text = "X";
                    button2.Enabled = false;
                    a2 = 1;
                }
                if (a3 == 0)
                {
                    button3.Text = "X";
                    button3.Enabled = false;
                    a3 = 1;
                }
            }
            else
            {
                if (a4 + a5 + a6 == 2)
                {
                    y1++;
                    if (a4 == 0)
                    {
                        button4.Text = "X";
                        button4.Enabled = false;
                        a4 = 1;
                    }
                    if (a5 == 0)
                    {
                        button5.Text = "X";
                        button5.Enabled = false;
                        a5 = 1;
                    }
                    if (a6 == 0)
                    {
                        button6.Text = "X";
                        button6.Enabled = false;
                        a6 = 1;
                    }
                }
                else
                {
                    if (a7 + a8 + a9 == 2)
                    {
                        y1++;
                        if (a7 == 0)
                        {
                            button7.Text = "X";
                            button7.Enabled = false;
                            a7 = 1;
                        }
                        if (a8 == 0)
                        {
                            button8.Text = "X";
                            button8.Enabled = false;
                            a8 = 1;
                        }
                        if (a9 == 0)
                        {
                            button9.Text = "X";
                            button9.Enabled = false;
                            a9 = 1;
                        }
                    }
                    else
                    {
                        if (a1 + a4 + a7 == 2)
                        {
                            y1++;
                            if (a1 == 0)
                            {
                                button1.Text = "X";
                                button1.Enabled = false;
                                a1 = 1;
                            }
                            if (a4 == 0)
                            {
                                button4.Text = "X";
                                button4.Enabled = false;
                                a4 = 1;
                            }
                            if (a7 == 0)
                            {
                                button7.Text = "X";
                                button7.Enabled = false;
                                a7 = 1;
                            }
                        }
                        else
                        {
                            if (a2 + a5 + a8 == 2)
                            {
                                y1++;
                                if (a2 == 0)
                                {
                                    button2.Text = "X";
                                    button2.Enabled = false;
                                    a2 = 1;
                                }
                                if (a5 == 0)
                                {
                                    button5.Text = "X";
                                    button5.Enabled = false;
                                    a5 = 1;
                                }
                                if (a8 == 0)
                                {
                                    button8.Text = "X";
                                    button8.Enabled = false;
                                    a8 = 1;
                                }
                            }
                            else
                            {
                                if (a3 + a6 + a8 == 2)
                                {
                                    y1++;
                                    if (a3 == 0)
                                    {
                                        button3.Text = "X";
                                        button3.Enabled = false;
                                        a3 = 1;
                                    }
                                    if (a6 == 0)
                                    {
                                        button6.Text = "X";
                                        button6.Enabled = false;
                                        a6 = 1;
                                    }
                                    if (a9 == 0)
                                    {
                                        button9.Text = "X";
                                        button9.Enabled = false;
                                        a9 = 1;
                                    }
                                }
                                else
                                {
                                    if (a1 + a5 + a9 == 2)
                                    {
                                        y1++;
                                        if (a1 == 0)
                                        {
                                            button1.Text = "X";
                                            button1.Enabled = false;
                                            a1 = 1;
                                        }
                                        if (a5 == 0)
                                        {
                                            button5.Text = "X";
                                            button5.Enabled = false;
                                            a5 = 1;
                                        }
                                        if (a9 == 0)
                                        {
                                            button9.Text = "X";
                                            button9.Enabled = false;
                                            a9 = 1;
                                        }
                                    }
                                    else
                                    {
                                        if (a3 + a5 + a7 == 2)
                                        {
                                            y1++;
                                            if (a3 == 0)
                                            {
                                                button3.Text = "X";
                                                button3.Enabled = false;
                                                a3 = 1;
                                            }
                                            if (a5 == 0)
                                            {
                                                button5.Text = "X";
                                                button5.Enabled = false;
                                                a5 = 1;
                                            }
                                            if (a7 == 0)
                                            {
                                                button7.Text = "X";
                                                button7.Enabled = false;
                                                a7 = 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        void you2()
        {

            if (a1 + a2 + a3 == 10)
            {
                y2++;
                if (a1 == 0)
                {
                    button1.Text = "X";
                    button1.Enabled = false;
                    a1 = 1;
                }
                if (a2 == 0)
                {
                    button2.Text = "X";
                    button2.Enabled = false;
                    a2 = 1;
                }
                if (a3 == 0)
                {
                    button3.Text = "X";
                    button3.Enabled = false;
                    a3 = 1;
                }
            }
            else
            {
                if (a4 + a5 + a6 == 10)
                {
                    y2++;
                    if (a4 == 0)
                    {
                        button4.Text = "X";
                        button4.Enabled = false;
                        a4 = 1;
                    }
                    if (a5 == 0)
                    {
                        button5.Text = "X";
                        button5.Enabled = false;
                        a5 = 1;
                    }
                    if (a6 == 0)
                    {
                        button6.Text = "X";
                        button6.Enabled = false;
                        a6 = 1;
                    }
                }
                else
                {
                    if (a7 + a8 + a9 == 10)
                    {
                        y2++;
                        if (a7 == 0)
                        {
                            button7.Text = "X";
                            button7.Enabled = false;
                            a7 = 1;
                        }
                        if (a8 == 0)
                        {
                            button8.Text = "X";
                            button8.Enabled = false;
                            a8 = 1;
                        }
                        if (a9 == 0)
                        {
                            button9.Text = "X";
                            button9.Enabled = false;
                            a9 = 1;
                        }
                    }
                    else
                    {
                        if (a1 + a4 + a7 == 10)
                        {
                            y2++;
                            if (a1 == 0)
                            {
                                button1.Text = "X";
                                button1.Enabled = false;
                                a1 = 1;
                            }
                            if (a4 == 0)
                            {
                                button4.Text = "X";
                                button4.Enabled = false;
                                a4 = 1;
                            }
                            if (a7 == 0)
                            {
                                button7.Text = "X";
                                button7.Enabled = false;
                                a7 = 1;
                            }
                        }
                        else
                        {

                            if (a2 + a5 + a8 == 10)
                            {
                                y2++;
                                if (a2 == 0)
                                {
                                    button2.Text = "X";
                                    button2.Enabled = false;
                                    a2 = 1;
                                }
                                if (a5 == 0)
                                {
                                    button5.Text = "X";
                                    button5.Enabled = false;
                                    a5 = 1;
                                }
                                if (a8 == 0)
                                {
                                    button8.Text = "X";
                                    button8.Enabled = false;
                                    a8 = 1;
                                }
                            }
                            else
                            {
                                if (a3 + a6 + a9 == 10)
                                {
                                    y2++;
                                    if (a3 == 0)
                                    {
                                        button3.Text = "X";
                                        button3.Enabled = false;
                                        a3 = 1;
                                    }
                                    if (a6 == 0)
                                    {
                                        button6.Text = "X";
                                        button6.Enabled = false;
                                        a6 = 1;
                                    }
                                    if (a9 == 0)
                                    {
                                        button9.Text = "X";
                                        button9.Enabled = false;
                                        a9 = 1;
                                    }
                                }
                                else
                                {
                                    if (a1 + a5 + a9 == 10)
                                    {
                                        y2++;
                                        if (a1 == 0)
                                        {
                                            button1.Text = "X";
                                            button1.Enabled = false;
                                            a1 = 1;
                                        }
                                        if (a5 == 0)
                                        {
                                            button5.Text = "X";
                                            button5.Enabled = false;
                                            a5 = 1;
                                        }
                                        if (a9 == 0)
                                        {
                                            button9.Text = "X";
                                            button9.Enabled = false;
                                            a9 = 1;
                                        }
                                    }
                                    else
                                    {
                                        if (a3 + a5 + a7 == 10)
                                        {
                                            y2++;
                                            if (a3 == 0)
                                            {
                                                button3.Text = "X";
                                                button3.Enabled = false;
                                                a3 = 1;
                                            }
                                            if (a5 == 0)
                                            {
                                                button5.Text = "X";
                                                button5.Enabled = false;
                                                a5 = 1;
                                            }
                                            if (a7 == 0)
                                            {
                                                button7.Text = "X";
                                                button7.Enabled = false;
                                                a7 = 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

       // void dor()
     //   {
 //           d = 0;
   //         if (a1 == 0 && a3 == 0 && a6 == 0)
//            {
  //              button3.Text = "X";
    //            button3.Enabled = false;
      //          a3 = 1;
        //        d++;
          //  }
        
//            if (a1 == 0 && a3 == 0 && a4 == 0)
  //          {
    //            button1.Text = "X";
      //          button1.Enabled = false;
        //        a1 = 1;
          //      d++;
            //}

//            if (a7 == 0 && a6 == 0 && a9 == 0)
  //          {
    //            button9.Text = "X";
      //          button9.Enabled = false;
        //        a9 = 1;
          //      d++;
            //}

//            if (a4 == 0 && a9 == 0 && a7 == 0)
  //          {
    //            button7.Text = "X";
      //          button7.Enabled = false;
        //        a7 = 1;
          //      d++;
            //}
//
        //
        //
        //


//            if (a2 == 0 && a9 == 0 && a3 == 0)
  //          {
    //            button3.Text = "X";
      //          button3.Enabled = false;
        //        a3 = 1;
          //      d++;
            //}
        
//            if (a3 == 0 && a8 == 0 && a9 == 0)
  //          {
    //            button9.Text = "X";
      //          button9.Enabled = false;
        //        a9 = 1;
          //      d++;
            //}

//            if (a2 == 0 && a7 == 0 && a1 == 0)
  //          {
    //            button1.Text = "X";
      //          button1.Enabled = false;
        //        a1 = 1;
          //      d++;
            //}

//            if (a8 == 0 && a1 == 0 && a7 == 0)
  //          {
    //            button7.Text = "X";
      //          button7.Enabled = false;
        //        a7 = 1;
          //      d++;
            //}
      //  }

        void pr()
        {
            y1 = 0;
            y2 = 0;
            if (c <= 2)
            {
                ch();
                pc1();
                ch();
            }
            else
                if (c <= 6)
                {
                        ch();
                        you1();
                        ch();
                        if (y1 == 0)
                        {
                            ch();
                            you2();
                            ch();
                        }
                        if (y1 == 0&&y2==0)
                        {
                            ch();
                            pc2();
                            ch();
                        }
                    
                }




        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = true;
            button5.Text = "X";
            a5 = 1;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c++;
            button1.Text = "O";
            a1 = 5;
            button1.Enabled = false;
            pr();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c++;
            button2.Text = "O";
            a2 = 5;
            button2.Enabled = false;
            pr();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c++;
            button3.Text = "O";
            a3 = 5;
            button3.Enabled = false;
            pr();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c++;
            button4.Text = "O";
            a4 = 5;
            button4.Enabled = false;
            pr();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c++;
            button6.Text = "O";
            a6 = 5;
            button6.Enabled = false;
            pr();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c++;
            button7.Text = "O";
            a7 = 5;
            button7.Enabled = false;
            pr();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            c++;
            button8.Text = "O";
            a8 = 5;
            button8.Enabled = false;
            pr();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            c++;
            button9.Text = "O";
            a9 = 5;
            button9.Enabled = false;
            pr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
