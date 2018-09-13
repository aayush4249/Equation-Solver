using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Cpt
{
  
    /* Aayush Sheth
     * Mr. Moniaga
     * CPT: MathSci Help3U1
     * Purpose: to help users solve various physics formulae, chemistry processes, and mathematical equations*/
    public partial class frmCpt : Form
    {   // variables
        double power, work, time,radius,area;
        public frmCpt()
        {
            InitializeComponent();
            //Disables all textboxes and buttons, keeps all labels blank
            //Labels
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "";
            lblexplain3.Text = "";
            lblextra.Text = "";
            lblMass1.Text = "";
            lblMass2.Text = "";
            lblexplain2.Text = "";
            lblexplain3.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = false;
            txt1.Text = "";
            txt2.Enabled = false;
            txt2.Text = "";
            txt3.Enabled = false;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = false;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
        }

        // exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes the program
            MessageBox.Show("SCRUB");
            this.Close();
        }  

        // user guide
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Displays the user help instructions
            StreamReader sr = new StreamReader("Help.txt");
            string[] Help = new string[int.Parse(sr.ReadLine())];
            for (int i=0; i<Help.Length; i++)
            {
                Help[i]=sr.ReadLine();
            }
            MessageBox.Show("This program is designed to help solve scientific and mathematical problems.");
            MessageBox.Show(Help[0] + "\n" + Help[1] + "\n" + Help[2] + "\n" + Help[3] + "\n" + Help[4] + "\n" + Help[5] + "\n" + Help[6] + "\n" + Help[7] + "\n" + Help[8] + "\n" + Help[9] + "\n" + Help[10] + "\n" + Help[11] + "\n" + Help[12] + "\n" + Help[13] + "\n" + Help[14] + "\n" + Help[15] + "\n" + Help[16] + "\n" + Help[17] + "\n" + Help[18] + "\n" + Help[19] + "\n" + Help[20] + "\n" + Help[21] + "\n" + Help[22]);
            MessageBox.Show(Help[23] + "\n" + Help[24] + "\n" + Help[25] + "\n" + Help[26] + "\n" + Help[27] + "\n" + Help[28] + "\n" + Help[29] + "\n" + Help[30] + "\n" + Help[31] + "\n" + Help[32] + "\n" + Help[33] + "\n" + Help[34] + "\n" + Help[35]);
            MessageBox.Show(Help[36] + "\n" + Help[37] + "\n" + Help[38] + "\n" + Help[39] + "\n" + Help[40] + "\n" + Help[41] + "\n" + Help[42] + "\n" + Help[43] + "\n" + Help[44] + "\n" + Help[45] + "\n" + Help[46] + "\n" + Help[47] + "\n" + Help[48] + "\n" + Help[49] + "\n" + Help[50] + "\n" + Help[51] + "\n" + Help[52] + "\n" + Help[53] + "\n" + Help[54] + "\n" + Help[55]);
            MessageBox.Show(Help[56] + "\n" + Help[57] + "\n" + Help[58] + "\n" + Help[59] + "\n" + Help[60] + "\n" + Help[61] + "\n" + Help[62] + "\n" + Help[63] + "\n" + Help[64] + "\n" + Help[65] + "\n" + Help[66] + "\n" + Help[67]);
        }
       
    
        // button power
        private void btn1_Click(object sender, EventArgs e)
        {
            #region
            //Tries function
            try
            {
                //If the input for power is non-numeric, the program calculates it
                if (!double.TryParse(txt1.Text, out power))
                {
                    //Converts input work and time to double
                    double.TryParse(txt2.Text, out work);
                    double.TryParse(txt3.Text, out time);
                    //Calculates, rounds, displays value for power
                    power = work / time;
                    power = Math.Round(power, 2);
                    txt1.Text = power.ToString();

                }
                //If the input for work is non-numeric, the program calculates it
                if (!double.TryParse(txt2.Text, out work))
                {
                    //Convers input for power and time to double
                    double.TryParse(txt1.Text, out power);
                    double.TryParse(txt3.Text, out time);
                    //Caculates, rounds, displays value for work
                    work = power * time;
                    work = Math.Round(work, 2);
                    txt2.Text = work.ToString();


                }
                //If the input for time is non-numeric, the program calculates it
                if (!double.TryParse(txt3.Text, out time))
                {
                    //Converts input ffor power and work
                    double.TryParse(txt1.Text, out power);
                    double.TryParse(txt2.Text, out work);
                    //Calculates, rounds, displays time
                    time = work / power;
                    time = Math.Round(time, 2);
                    txt3.Text = time.ToString();
                }
            }
            //Catches erors (including incorrect input)
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }
       
       
        // button kinematics
        private void btnKinematics_Click(object sender, EventArgs e)
        {//Kinematics calc
            #region
            //Declaring variables
            double d;
            string ds;
            double v2;
            string v2s;
            double v1;
            string v1s;
            double t;
            string ts;
            double a;
            string As;
            double Determinant;
            double t1;
            double t2;
            double v1a;
            double v1b;
            double v2a;
            double v2b;
            try
            {
                //Entering Variables
                ds = txt1.Text;
                v1s = txt4.Text;
                v2s = txt5.Text;
                As = txt2.Text;
                ts = txt3.Text;
                //Solving the First Kinematics Equation
                if (As == "a")
                {
                    //Solving for dislacement
                    if (ds == "u")
                    {
                        v1 = double.Parse(v1s);

                        v2 = double.Parse(v2s);

                        t = double.Parse(ts);

                        d = ((v1 + v2) / 2) * t;
                        d = Math.Round(d, 3);
                        txt1.Text = d.ToString();

                    }
                    //Solving for initial velocity
                    else if (v1s == "u")
                    {
                        d = double.Parse(ds);

                        v2 = double.Parse(v2s);

                        t = double.Parse(ts);

                        v1 = (2 * d * t) - v2;
                        v1 = Math.Round(v1, 3);
                        txt4.Text = v1.ToString();

                    }
                    //Solving for final velocity
                    else if (v2s == "u")
                    {
                        d = double.Parse(ds);

                        v1 = double.Parse(v1s);

                        t = double.Parse(ts);

                        v2 = (2 * d * t) - v1;
                        v2 = Math.Round(v2, 3);
                        txt5.Text = v2.ToString();
                    }
                    //Solving for time
                    else if (ts == "u")
                    {
                        d = double.Parse(ds);

                        v1 = double.Parse(v1s);

                        v2 = double.Parse(v2s);

                        t = d / ((v1 + v2) / 2);
                        t = Math.Round(t, 3);
                        txt3.Text = t.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

                  //Solving the Second Kinematics Equation
                else if (v2s == "a")
                {
                    //Solving for displacement
                    if (ds == "u")
                    {
                        v1 = double.Parse(v1s);

                        t = double.Parse(ts);

                        a = double.Parse(As);

                        d = v1 * t + (1 / 2) * a * Math.Pow(t, 2);
                        d = Math.Round(d, 3);
                        txt1.Text = d.ToString();
                    }
                    //Solving for initial velocity
                    else if (v1s == "u")
                    {
                        d = double.Parse(ds);

                        t = double.Parse(ts);

                        a = double.Parse(As);

                        v1 = (d - (1 / 2) * a * Math.Pow(t, 2)) / t;
                        v1 = Math.Round(v1, 3);
                        txt4.Text = v1.ToString();
                    }
                    //Solving for acceleration
                    else if (As == "u")
                    {
                        d = double.Parse(ds);

                        v1 = double.Parse(v1s);

                        t = double.Parse(ts);

                        a = (2 * (d - v1 * t)) / Math.Pow(t, 2);
                        a = Math.Round(a, 3);
                        txt2.Text = a.ToString();
                    }
                    //Solving for time
                    else if (ts == "u")
                    {
                        d = double.Parse(ds);

                        v1 = double.Parse(v1s);

                        a = double.Parse(As);

                        Determinant = Math.Pow(v1, 2) - 4 * (a / 2) * (-d);
                        if (Determinant < 0)
                        {
                            MessageBox.Show("No Solution!");
                        }
                        else if (Determinant == 0)
                        {
                            t = (-v1) / (2 * (a / 2));
                            t = Math.Round(t, 3);
                            txt3.Text = t.ToString();
                        }
                        else if (Determinant > 0)
                        {

                            t1 = ((-v1) - Math.Sqrt(Math.Pow(v1, 2) - 4 * (a / 2) * (-d))) / (2 * (a / 2));
                            t2 = ((-v1) + Math.Sqrt(Math.Pow(v1, 2) - 4 * (a / 2) * (-d))) / (2 * (a / 2));
                            t2 = Math.Round(t2, 3);
                            t1 = Math.Round(t1, 3);
                            txt3.Text = t1.ToString();
                            txtextra.Text = t2.ToString();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                //Solving the Third Kinematics Equation
                else if (v1s == "a")
                {
                    //Solving for displacement
                    if (ds == "u")
                    {
                        v2 = double.Parse(v2s);

                        a = double.Parse(As);

                        t = double.Parse(ts);

                        d = v2 * t - (1 / 2) * a * Math.Pow(t, 2);
                        d = Math.Round(d, 3);
                        txt1.Text = d.ToString();
                    }
                    //Solving for final velocity
                    else if (v2s == "u")
                    {
                        d = double.Parse(ds);

                        t = double.Parse(ts);

                        a = double.Parse(As);

                        v2 = (d + (1 / 2) * a * Math.Pow(t, 2)) / t;
                        v2 = Math.Round(v2, 3);
                        txt5.Text = v2.ToString();
                    }
                    //Solving for acceleration
                    else if (As == "u")
                    {
                        d = double.Parse(ds);

                        t = double.Parse(ts);

                        v2 = double.Parse(v2s);

                        a = (2 * (v2 * t - d)) / Math.Pow(t, 2);
                        a = Math.Round(a, 3);
                        txt2.Text = a.ToString();
                    }
                    //Solving for time
                    else if (ts == "u")
                    {
                        v2 = double.Parse(v2s);

                        a = double.Parse(As);

                        d = double.Parse(ds);

                        Determinant = Math.Pow(v2, 2) - 4 * (a / 2) * (-d);
                        if (Determinant < 0)
                        {
                            Console.WriteLine("No Solution!");
                        }
                        else if (Determinant == 0)
                        {
                            t = (-v2) / (2 * (a / 2));
                            t = Math.Round(t, 3);
                            txt3.Text = t.ToString();
                        }
                        else if (Determinant > 0)
                        {

                            t1 = ((-v2) - Math.Sqrt(Math.Pow(v2, 2) - 4 * (a / 2) * (-d))) / (2 * (a / 2));
                            t2 = ((-v2) + Math.Sqrt(Math.Pow(v2, 2) - 4 * (a / 2) * (-d))) / (2 * (a / 2));
                            t1 = Math.Round(t1, 3);
                            txt3.Text = t1.ToString();
                            t2 = Math.Round(t2, 3);
                            txtextra.Text = t2.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                }
                //Solving the Fourth Kinematics Equation
                else if (ds == "a")
                {
                    //Solving for final velocity
                    if (v2s == "u")
                    {
                        t = double.Parse(ts);

                        a = double.Parse(As);

                        v1 = double.Parse(v1s);

                        v2 = v1 + a * t;
                        v2 = Math.Round(v2, 2);
                        txt5.Text = v2.ToString();
                    }
                    //Solving for initial velocity
                    else if (v1s == "u")
                    {
                        v2 = double.Parse(v2s);

                        a = double.Parse(As);

                        t = double.Parse(ts);

                        v1 = v2 - a * t;
                        v1 = Math.Round(v1, 2);
                        txt4.Text = v1.ToString();
                    }
                    //Solving for acceleration
                    else if (As == "u")
                    {
                        v1 = double.Parse(v1s);

                        v2 = double.Parse(v2s);

                        t = double.Parse(ts);

                        a = (v2 - v1) / t;
                        a = Math.Round(a, 2);
                        txt2.Text = a.ToString();
                    }
                    //Solving for time
                    else if (ts == "u")
                    {
                        v1 = double.Parse(v1s);

                        v2 = double.Parse(v2s);

                        a = double.Parse(As);

                        t = (v2 - v1) / a;
                        t = Math.Round(t, 2);
                        txt3.Text = t.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
                //Solving the Fifth Kinematics Equation
                else if (ts == "a")
                {
                    //Solving for displacement
                    if (ds == "u")
                    {
                        v1 = double.Parse(v1s);

                        v2 = double.Parse(v2s);

                        a = double.Parse(As);

                        d = (Math.Pow(v2, 2) - Math.Pow(v1, 2)) / (2 * a);

                    }
                    //Solving for acceleration
                    else if (As == "u")
                    {
                        v1 = double.Parse(v1s);

                        v2 = double.Parse(v2s);

                        d = double.Parse(ds);

                        a = (Math.Pow(v2, 2) - Math.Pow(v1, 2)) / (2 * d);
                        a = Math.Round(a, 2);
                        txt2.Text = a.ToString();
                    }
                    //Solving for initial velocity
                    else if (v1s == "u")
                    {
                        v2 = double.Parse(v2s);

                        d = double.Parse(ds);

                        a = double.Parse(As);

                        v1a = Math.Sqrt(Math.Pow(v2, 2) - (2 * a * d));
                        v1b = -Math.Sqrt(Math.Pow(v2, 2) - (2 * a * d));
                        v1 = Math.Round(v1a, 2);
                        v1b = Math.Round(v1b, 2);
                        txt4.Text = v1a.ToString();
                        txtextra.Text = v1b.ToString();
                    }
                    //Solving for final velocity
                    else if (v2s == "u")
                    {
                        v1 = double.Parse(v1s);

                        d = double.Parse(ds);

                        a = double.Parse(As);

                        v2a = Math.Sqrt(Math.Pow(v1, 2) + (2 * a * d));
                        v2b = -Math.Sqrt(Math.Pow(v1, 2) + (2 * a * d));
                        v2a = Math.Round(v2a, 2);
                        v2b = Math.Round(v2b, 2);
                        txtextra.Text = v2b.ToString();
                        txt5.Text = v2a.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

                else
                {
                    MessageBox.Show("Error");
                }
            }
            //Catches any errors (including input erors)
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void kinematicsToolStripMenuItem1_Click(object sender, EventArgs e)
        { // toolstrip kinematics
            #region
            //Labels
            lbl1.Text = "Displacement (m)";
            lbl2.Text = "Acceleraion(m/s^2)";
            lbl3.Text = "Time(s)";
            lbl4.Text = "Velocity Initial(m/s)";
            lbl5.Text = "Velocity Final(m/s)";
            lblexplain2.Text = "Out of the 5, fill in 3; give 1 absent and 1 unknown";
            lblexplain3.Text = "Indicate the absent with \'a\' and the unknown with \'u\'";     
            lblextra.Text = "Some may have 2 answers; the second one will show up in the empty text box";
            lblMass1.Text = "";
            lblMass2.Text = "";
            lblexplain2.Text = "Out of the 5, fill in 3; give 1 absent and 1 unknown";
            lblexplain3.Text = "Indicate the absent with \'a\' and the unknown with \'u\'";
            //Physics buttons
            btnKinematics.Enabled = true;
            btnKinematics.Text = "Kinematics Unknown";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = true;
            txt4.Text = "";
            txt5.Enabled = true;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }
        
        private void powerToolStripMenuItem1_Click(object sender, EventArgs e)
        { // tool strip power
            #region
            // changing text and button properties
            //Labels
            lbl1.Text = "Power";
            lbl2.Text = "Work";
            lbl3.Text = "Time";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the unknown in the Power equation:";
            lblexplain3.Text = "Enter the values for known variables";
            lblextra.Text = "Enter \'u\' to indicate the unknown variable.";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = true;
            btnPower.Text = "Power Unknown";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = false;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void quadraticFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {//Quadratic tool strip
            #region
            //Labels
            lbl1.Text = "Enter A";
            lbl2.Text = "Enter B";
            lbl3.Text = "Enter C";
            lbl4.Text = "X1";
            lbl5.Text = "X2";
            lblexplain2.Text = "To solve a quadratic function:";
            lblexplain3.Text = "Enter the values for \'a\', \'b\', and \'c\'.";
            lblextra.Text = "";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = true;
            btnQuad.Text = "Calculate";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = true;
            txt4.Text = "";
            txt5.Enabled = true;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            
            #endregion
        }

        private void btnQuad_Click(object sender, EventArgs e)
        {//Quadratic formula calc
            #region
            //Tries code
            try
            {
                //Declaring variables, converting input to double
                double x1, x2;
                double a = double.Parse(txt1.Text);
                double b = double.Parse(txt2.Text);
                double c = double.Parse(txt3.Text);
                //Solving for roots based on the determinant
                double determinant = Math.Pow(b, 2) - 4 * a * c;
                if (determinant > 0)
                {
                    x1 = (-b + Math.Sqrt(determinant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(determinant)) / (2 * a);
                    txt4.Text = x1.ToString();
                    txt5.Text = x2.ToString();
                }
                else if (determinant < 0)
                {
                    MessageBox.Show("There are no roots to this equation");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(determinant)) / (2 * a);
                    txt4.Text = x1.ToString();
                }
            }
            //Catching errors
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void moleCalculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {//Stoich tool strip
            #region
            //Labels
            lbl1.Text = "First Reagent";
            lbl2.Text = "Second Reagent";
            lbl3.Text = "Desired Product";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "Enter the involved chemicals, and their respective masses.";
            lblexplain3.Text = "If entered chemical formulae have coefficient or subscript values of 1, ensure to indicate this.";
            lblextra.Text = "For example: \"1H2C1O3\" \t not \"H2CO3\"!";
            lblMass1.Text = "Mass (g)";
            lblMass2.Text = "Mass (g)";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = true;
            btnStoichCalc.Text = "Calculate Stoichiometry";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = true;
            txtStRe1.Text = "";
            txtStRe2.Enabled = true;
            txtStRe2.Text = "";
            txt4.Enabled = true;
            txt4.Text = "";
            txt5.Enabled = true;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btnStoichCalc_Click(object sender, EventArgs e)
        {//Stoich calc
            #region
            try
            {
                //Delaration of variables
                double mol1 = 0, mol2 = 0, mol3 = 0, mol3a = 0, mol3b = 0;
                double mass1 = 0, mass2 = 0, mass3 = 0;
                double[] MolarMass;
                double Excess, ExcessMol;
                double MM1 = 0, MM2 = 0, MM3 = 0;
                string Cmpd1 = "null", Cmpd2 = "null", Cmpd3 = "null";
                string[] Element1, Element2, Element3;
                int[] AtNum1, AtNum2, AtNum3;
                int[] Subscript1, Subscript2, Subscript3;
                int Coefficient1 = 0, Coefficient2 = 0, Coefficient3 = 0;
                //String array containing element symbols
                #region
                string[] periodicTable = { "j", "h", "he", "li", "be", "b", "c", "n", "o", "f", "ne", "na", "mg", "al", "si", "p", "s", "cl", "ar", "k", "ca", "sc", "ti", "v", "cr", "mn", "fe", "co", "ni", "cu", "zn", "ga", "ge", "as", "se", "br", "kr", "rb", "sr", "y", "zr", "nb", "mo", "tc", "ru", "rh", "pd", "ag", "cd", "in", "sn", "sb", "te", "i", "xe", "cs", "ba", "la", "ce", "pr", "nd", "pm", "sm", "eu", "gd", "tb", "dy", "ho", "er", "tm", "yb", "lu", "hf", "ta", "w", "re", "os", "ir", "pt", "au", "hg", "tl", "pb", "bi", "po", "at", "rn", "fr", "ra", "ac", "th", "pa", "u", "np", "pu", "am", "cm", "bk", "cf", "es", "fm", "md", "no", "lr", "rf", "db", "sg", "bh", "hs", "mt", "ds", "rg", "cn", "uut", "fl", "uup", "lv", "uus", "uuo" };
                #endregion

                //Importing molar masses
                #region
                StreamReader MMs = new StreamReader("MolarMass.txt");
                MolarMass = new double[int.Parse(MMs.ReadLine())];
                for (int i = 0; i < MolarMass.Length; i++)
                {
                    MolarMass[i] = double.Parse(MMs.ReadLine());
                }
                #endregion

                Cmpd1 = txt1.Text;
                //Breaks apart chemical formula
                #region
                #region
                int x;
                string ys = "";
                int ElCount = -1;
                string End = "n";
                int OB = -1, CB = -1;
                double CoefficientDouble = 0;
                int Count = 0;
                int[] Coeff;
                string[] Formula;
                string[] Subscripts;
                #endregion
                //Obtaining formula array

                Coeff = new int[Cmpd1.Length];
                Formula = new string[Cmpd1.Length];

                //Converting input string (formula) to array of each character

                for (int i = 0; i < Cmpd1.Length; i++)
                {
                    Formula[i] = Cmpd1.Substring(i, 1);
                }
                //Identifying polyatomic ions
                for (int i = 0; i < Formula.Length; i++)
                {
                    if (Formula[i].Equals("("))
                    {
                        OB = i;
                    }
                    else if (Formula[i].Equals(")"))
                    {
                        CB = i;
                    }
                }

                //Formula array obtained

                //Obtaining coefficient

                //Resizing coeff array to actual size
                while (End.Equals("n"))
                {
                    //Counting the integers at the front of the formula
                    if (int.TryParse(Formula[Count], out Coeff[Count]))
                    {
                        Count++;
                    }
                    //Resizing the array to the size of the integer count
                    else
                    {
                        End = "y";
                        Array.Resize(ref Coeff, Count);
                    }
                }
                //Coalescing the coeff array into one coefficient 
                for (int i = 0; i < Coeff.Length; i++)
                {
                    CoefficientDouble = CoefficientDouble + (Coeff[i] * (Math.Pow(10, (Coeff.Length - i - 1))));
                }
                //Converting coefficient to integer
                End = CoefficientDouble.ToString();
                Coefficient1 = int.Parse(End);

                //Coefficient obtained

                //Obtaining elements and sbscripts

                End = "n";
                //To mark the character in the formula
                Count = Coeff.Length;
                Element1 = new string[Cmpd1.Length];
                Subscripts = new string[Cmpd1.Length];
                Subscript1 = new int[Cmpd1.Length];
                while (Count < (Cmpd1.Length - 1))
                {
                    //To mark the element of the formula
                    ElCount++;
                    Element1[ElCount] = "";
                    Subscripts[ElCount] = "";
                    Subscript1[ElCount] = 0;
                    while (End.Equals("n"))
                    {
                        if (Count == OB)
                        {
                            Count++;
                            OB = ElCount;
                        }
                        else if (Count == CB && (Count + 1) != Formula.Length)
                        {
                            CB = ElCount;
                            Count++;
                        }
                        else if (Count == CB && (Count + 1) == Formula.Length)
                        {
                            CB = ElCount;
                            break;
                        }
                        if (int.TryParse(Formula[Count], out x))
                        {
                            End = "y";
                        }
                        else
                        {
                            Element1[ElCount] = Element1[ElCount] + Formula[Count];
                        }
                        Count++;
                    }
                    Count = Count - 1;
                    while (End.Equals("y"))
                    {
                        if (ElCount == CB && (int.TryParse(Formula[Count], out x)))
                        {
                            ys = ys + Formula[Count];
                        }
                        else if (int.TryParse(Formula[Count], out x))
                        {
                            Subscripts[ElCount] = Subscripts[ElCount] + x;
                        }
                        else
                        {
                            End = "n";
                        }
                        Count++;
                        if (Count >= Formula.Length)
                        {
                            break;
                        }
                    }

                    Count = Count - 1;
                }
                //Resizing arrays to proper size
                if (OB == -1 && CB == -1)
                {
                    Array.Resize(ref Element1, (ElCount + 1));
                    Array.Resize(ref Subscripts, (ElCount + 1));
                }
                else
                {
                    Array.Resize(ref Element1, (ElCount));
                    Array.Resize(ref Subscripts, (ElCount));
                }
                for (int i = 0; i < Subscripts.Length; i++)
                {
                    ElCount = i;
                    if (ElCount >= OB && ElCount < CB)
                    {
                        Subscript1[ElCount] = int.Parse(Subscripts[ElCount]) * int.Parse(ys);
                    }
                    else
                    {
                        Subscript1[ElCount] = int.Parse(Subscripts[ElCount]);
                    }
                }
                Array.Resize(ref Subscript1, (ElCount + 1));
                #endregion
                for (int i = 0; i < Element1.Length; i++)
                {
                    Element1[i] = Element1[i].ToLower();
                }
                //Obtains atomic numbers (first twenty elements only)
                #region
                AtNum1 = new int[Element1.Length];
                for (int i = 0; i < Element1.Length; i++)
                {
                    for (int z = 0; z < 119; z++)
                    {
                        if (Element1[i].Equals(periodicTable[z]))
                        {
                            AtNum1[i] = z;
                        }
                    }
                }
                #endregion
                Cmpd2 = txt2.Text;
                //Breaks apart chemical formula
                #region
                #region
                x = 0;
                ys = "";
                ElCount = -1;
                End = "n";
                OB = -1;
                CB = -1;
                CoefficientDouble = 0;
                Count = 0;
                for (int i = 0; i < Coeff.Length; i++)
                {
                    Coeff[i] = 0;
                }
                for (int i = 0; i < Formula.Length; i++)
                {
                    Formula[i] = "";
                }
                for (int i = 0; i < Subscripts.Length; i++)
                {
                    Subscripts[i] = "";
                }
                #endregion
                //Obtaining formula array

                Coeff = new int[Cmpd2.Length];
                Formula = new string[Cmpd2.Length];

                //Converting input string (formula) to array of each character

                for (int i = 0; i < Cmpd2.Length; i++)
                {
                    Formula[i] = Cmpd2.Substring(i, 1);
                }
                //Identifying polyatomic ions
                for (int i = 0; i < Formula.Length; i++)
                {
                    if (Formula[i].Equals("("))
                    {
                        OB = i;
                    }
                    else if (Formula[i].Equals(")"))
                    {
                        CB = i;
                    }
                }

                //Formula array obtained

                //Obtaining coefficient

                //Resizing coeff array to actual size
                while (End.Equals("n"))
                {
                    //Counting the integers at the front of the formula
                    if (int.TryParse(Formula[Count], out Coeff[Count]))
                    {
                        Count++;
                    }
                    //Resizing the array to the size of the integer count
                    else
                    {
                        End = "y";
                        Array.Resize(ref Coeff, Count);
                    }
                }
                //Coalescing the coeff array into one coefficient 
                for (int i = 0; i < Coeff.Length; i++)
                {
                    CoefficientDouble = CoefficientDouble + (Coeff[i] * (Math.Pow(10, (Coeff.Length - i - 1))));
                }
                //Converting coefficient to integer
                End = CoefficientDouble.ToString();
                Coefficient2 = int.Parse(End);

                //Coefficient obtained

                //Obtaining elements and sbscripts

                End = "n";
                //To mark the character in the formula
                Count = Coeff.Length;
                Element2 = new string[Cmpd2.Length];
                Subscripts = new string[Cmpd2.Length];
                Subscript2 = new int[Cmpd2.Length];
                while (Count < (Cmpd2.Length - 1))
                {
                    //To mark the element of the formula
                    ElCount++;
                    Element2[ElCount] = "";
                    Subscripts[ElCount] = "";
                    Subscript2[ElCount] = 0;
                    while (End.Equals("n"))
                    {
                        if (Count == OB)
                        {
                            Count++;
                            OB = ElCount;
                        }
                        else if (Count == CB && (Count + 1) != Formula.Length)
                        {
                            CB = ElCount;
                            Count++;
                        }
                        else if (Count == CB && (Count + 1) == Formula.Length)
                        {
                            CB = ElCount;
                            break;
                        }
                        if (int.TryParse(Formula[Count], out x))
                        {
                            End = "y";
                        }
                        else
                        {
                            Element2[ElCount] = Element2[ElCount] + Formula[Count];
                        }
                        Count++;
                    }
                    Count = Count - 1;
                    while (End.Equals("y"))
                    {
                        if (ElCount == CB && (int.TryParse(Formula[Count], out x)))
                        {
                            ys = ys + Formula[Count];
                        }
                        else if (int.TryParse(Formula[Count], out x))
                        {
                            Subscripts[ElCount] = Subscripts[ElCount] + x;
                        }
                        else
                        {
                            End = "n";
                        }
                        Count++;
                        if (Count >= Formula.Length)
                        {
                            break;
                        }
                    }

                    Count = Count - 1;
                }
                //Resizing arrays to proper size
                if (OB == -1 && CB == -1)
                {
                    Array.Resize(ref Element2, (ElCount + 1));
                    Array.Resize(ref Subscripts, (ElCount + 1));
                }
                else
                {
                    Array.Resize(ref Element2, (ElCount));
                    Array.Resize(ref Subscripts, (ElCount));
                }
                for (int i = 0; i < Subscripts.Length; i++)
                {
                    ElCount = i;
                    if (ElCount >= OB && ElCount < CB)
                    {
                        Subscript2[ElCount] = int.Parse(Subscripts[ElCount]) * int.Parse(ys);
                    }
                    else
                    {
                        Subscript2[ElCount] = int.Parse(Subscripts[ElCount]);
                    }
                }
                Array.Resize(ref Subscript2, (ElCount + 1));
                #endregion
                for (int i = 0; i < Element2.Length; i++)
                {
                    Element2[i] = Element2[i].ToLower();
                }
                //Obtains atomic numbers
                #region
                AtNum2 = new int[Element2.Length];
                for (int i = 0; i < Element2.Length; i++)
                {
                    for (int z = 0; z < 119; z++)
                    {
                        if (Element2[i].Equals(periodicTable[z]))
                        {
                            AtNum2[i] = z;
                        }
                    }
                }
                #endregion
                Cmpd3 = txt3.Text;
                //Breaks apart chemical formula
                #region
                #region
                x = 0;
                ys = "";
                ElCount = -1;
                End = "n";
                OB = -1;
                CB = -1;
                CoefficientDouble = 0;
                Count = 0;
                for (int i = 0; i < Coeff.Length; i++)
                {
                    Coeff[i] = 0;
                }
                for (int i = 0; i < Formula.Length; i++)
                {
                    Formula[i] = "";
                }
                for (int i = 0; i < Subscripts.Length; i++)
                {
                    Subscripts[i] = "";
                }
                #endregion
                //Obtaining formula array

                Coeff = new int[Cmpd3.Length];
                Formula = new string[Cmpd3.Length];

                //Converting input string (formula) to array of each character

                for (int i = 0; i < Cmpd3.Length; i++)
                {
                    Formula[i] = Cmpd3.Substring(i, 1);
                }
                //Identifying polyatomic ions
                for (int i = 0; i < Formula.Length; i++)
                {
                    if (Formula[i].Equals("("))
                    {
                        OB = i;
                    }
                    else if (Formula[i].Equals(")"))
                    {
                        CB = i;
                    }
                }

                //Formula array obtained

                //Obtaining coefficient

                //Resizing coeff array to actual size
                while (End.Equals("n"))
                {
                    //Counting the integers at the front of the formula
                    if (int.TryParse(Formula[Count], out Coeff[Count]))
                    {
                        Count++;
                    }
                    //Resizing the array to the size of the integer count
                    else
                    {
                        End = "y";
                        Array.Resize(ref Coeff, Count);
                    }
                }
                //Coalescing the coeff array into one coefficient 
                for (int i = 0; i < Coeff.Length; i++)
                {
                    CoefficientDouble = CoefficientDouble + (Coeff[i] * (Math.Pow(10, (Coeff.Length - i - 1))));
                }
                //Converting coefficient to integer
                End = CoefficientDouble.ToString();
                Coefficient3 = int.Parse(End);

                //Coefficient obtained

                //Obtaining elements and sbscripts

                End = "n";
                //To mark the character in the formula
                Count = Coeff.Length;
                Element3 = new string[Cmpd3.Length];
                Subscripts = new string[Cmpd3.Length];
                Subscript3 = new int[Cmpd3.Length];
                while (Count < (Cmpd3.Length - 1))
                {
                    //To mark the element of the formula
                    ElCount++;
                    Element3[ElCount] = "";
                    Subscripts[ElCount] = "";
                    Subscript3[ElCount] = 0;
                    while (End.Equals("n"))
                    {
                        if (Count == OB)
                        {
                            Count++;
                            OB = ElCount;
                        }
                        else if (Count == CB && (Count + 1) != Formula.Length)
                        {
                            CB = ElCount;
                            Count++;
                        }
                        else if (Count == CB && (Count + 1) == Formula.Length)
                        {
                            CB = ElCount;
                            break;
                        }
                        if (int.TryParse(Formula[Count], out x))
                        {
                            End = "y";
                        }
                        else
                        {
                            Element3[ElCount] = Element3[ElCount] + Formula[Count];
                        }
                        Count++;
                    }
                    Count = Count - 1;
                    while (End.Equals("y"))
                    {
                        if (ElCount == CB && (int.TryParse(Formula[Count], out x)))
                        {
                            ys = ys + Formula[Count];
                        }
                        else if (int.TryParse(Formula[Count], out x))
                        {
                            Subscripts[ElCount] = Subscripts[ElCount] + x;
                        }
                        else
                        {
                            End = "n";
                        }
                        Count++;
                        if (Count >= Formula.Length)
                        {
                            break;
                        }
                    }

                    Count = Count - 1;
                }
                //Resizing arrays to proper size
                if (OB == -1 && CB == -1)
                {
                    Array.Resize(ref Element3, (ElCount + 1));
                    Array.Resize(ref Subscripts, (ElCount + 1));
                }
                else
                {
                    Array.Resize(ref Element3, (ElCount));
                    Array.Resize(ref Subscripts, (ElCount));
                }
                for (int i = 0; i < Subscripts.Length; i++)
                {
                    ElCount = i;
                    if (ElCount >= OB && ElCount < CB)
                    {
                        Subscript3[ElCount] = int.Parse(Subscripts[ElCount]) * int.Parse(ys);
                    }
                    else
                    {
                        Subscript3[ElCount] = int.Parse(Subscripts[ElCount]);
                    }
                }
                Array.Resize(ref Subscript2, (ElCount + 1));
                #endregion
                for (int i = 0; i < Element3.Length; i++)
                {
                    Element3[i] = Element3[i].ToLower();
                }
                //Obtains atomic numbers (first twenty elements only)
                #region
                AtNum3 = new int[Element3.Length];
                for (int i = 0; i < Element3.Length; i++)
                {
                    for (int z = 0; z < 119; z++)
                    {
                        if (Element3[i].Equals(periodicTable[z]))
                        {
                            AtNum3[i] = z;
                        }
                    }
                }
                #endregion

                //Calculating molar mass of each particle
                #region
                //Cmpd1
                for (int i = 0; i < Element1.Length; i++)
                {
                    MM1 = MM1 + (MolarMass[AtNum1[i]] * Subscript1[i]);
                }
                //Cmpd2
                for (int i = 0; i < Element2.Length; i++)
                {
                    MM2 = MM2 + (MolarMass[AtNum2[i]] * Subscript2[i]);
                }
                //Cmpd3
                for (int i = 0; i < Element3.Length; i++)
                {
                    MM3 = MM3 + (MolarMass[AtNum3[i]] * Subscript3[i]);
                }
                #endregion

                //Obtaining amount of Cmpd1
                mass1 = double.Parse(txtStRe1.Text);
                mol1 = mass1 / MM1;
                //Calculating potential amount of product
                mol3a = Coefficient3 * mol1 / Coefficient1;

                //Obtaining amount of Cmpd2
                mass2 = double.Parse(txtStRe2.Text);
                mol2 = mass2 / MM2;
                //Calculating potential amount of product
                mol3b = Coefficient3 * mol2 / Coefficient2;

                //Determining limiting reagent
                if (mol3a < mol3b)
                {
                    mol3 = mol3a;
                    mass3 = mol3 * MM3;
                    mass3 = Math.Round(mass3, 2);
                    ExcessMol = mol2 - (Coefficient2 * mol3 / Coefficient3);
                    Excess = ExcessMol * MM2;
                    Excess = Math.Round(Excess, 2);
                    lbl4.Text = "Theoretical Yield (g)";
                    txt4.Text = mass3.ToString();
                    lbl5.Text = "Excess (g)";
                    txt5.Text = Excess.ToString();
                }
                else if (mol3b < mol3a)
                {
                    mol3 = mol3b;
                    mass3 = mol3 * MM3;
                    mass3 = Math.Round(mass3, 2);
                    ExcessMol = mol1 - (Coefficient3 * mol3 / Coefficient3);
                    Excess = ExcessMol * MM1;
                    Excess = Math.Round(Excess, 2);
                    lbl5.Text = "Theoretical Yield (g)";
                    txt5.Text = mass3.ToString();
                    lbl4.Text = "Excess (g)";
                    txt4.Text = Excess.ToString();
                }
                else
                {
                    mol3 = mol3b;
                    mass3 = mol3 * MM3;
                    mass3 = Math.Round(mass3, 2);
                    lbl4.Text = "Theoretical Yield (g)";
                    lbl5.Text = "No excess!";
                    txt4.Text = mass3.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void idealGasLawToolStripMenuItem_Click(object sender, EventArgs e)
        {//Ideal Gas tool strip
            #region
            //Labels
            lbl1.Text = "Pressure (kPa)";
            lbl2.Text = "Volume (L)";
            lbl3.Text = "Amount (mol)";
            lbl4.Text = "Temperature (K)";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the unknown using the Ideal Gas Law:";
            lblexplain3.Text = "Enter the values for known variables in proper unit";
            lblextra.Text = "Enter \'u\' to indicate the unknown variable.";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = true;
            btnIdealGas.Text = "Ideal Gas Unknown";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = true;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btnIdealGas_Click(object sender, EventArgs e)
        {//Ideal Gas calc
            #region
            try
            {
                //Declaring variables and constants
                double R = 8.314;
                double P, V, n, T;
                //Trying to parse the input to detect which variable to solve for; solving for unknown variable
                if (!double.TryParse(txt1.Text, out P) && double.TryParse(txt2.Text, out V) && double.TryParse(txt3.Text, out n) && double.TryParse(txt4.Text, out T))
                {
                    P = (n * R * T) / V;
                    P = Math.Round(P, 2);
                    txt1.Text = P.ToString();
                }
                else if (double.TryParse(txt1.Text, out P) && !double.TryParse(txt2.Text, out V) && double.TryParse(txt3.Text, out n) && double.TryParse(txt4.Text, out T))
                {
                    V = (n * R * T) / P;
                    V = Math.Round(V, 2);
                    txt2.Text = V.ToString();
                }
                else if (double.TryParse(txt1.Text, out P) && double.TryParse(txt2.Text, out V) && !double.TryParse(txt3.Text, out n) && double.TryParse(txt4.Text, out T))
                {
                    n = (P * V) / (R * T);
                    n = Math.Round(n, 2);
                    txt3.Text = n.ToString();
                }
                else if (double.TryParse(txt1.Text, out P) && double.TryParse(txt2.Text, out V) && double.TryParse(txt3.Text, out n) && !double.TryParse(txt4.Text, out T))
                {
                    T = (P * V) / (R * n);
                    T = Math.Round(T, 2);
                    txt4.Text = T.ToString();
                }
                else
                {
                    MessageBox.Show("Input error!");
                }
            }
            //Catching errors
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void harmonicsToolStripMenuItem_Click(object sender, EventArgs e)
        {//Harmonics tool strip
            #region
            //Labels
            lbl1.Text = "Length (m)";
            lbl2.Text = "Wavelength (m)";
            lbl3.Text = "Harmonic (n)";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the unknown Standing Wave variable:";
            lblexplain3.Text = "Enter the values for known variables in proper unit";
            lblextra.Text = "Enter \'u\' to indicate the unknown variable.";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = true;
            btnHarmonics.Text = "Similar Ended Standing Wave";
            btnHarmonics2.Enabled = true;
            btnHarmonics2.Text = "Dissimilar Ended Standing Wave";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = false;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btnHarmonics_Click(object sender, EventArgs e)
        {//Harmonics calc - Similar ended
            #region
            try
            {
                //Declaring variables
                double L, lam, n;
                //Trying to parse input to determine which variable is unknown; solving for variable using formulae for similar ended standing waves
                if (!double.TryParse(txt1.Text, out L) && double.TryParse(txt2.Text, out lam) && double.TryParse(txt3.Text, out n))
                {
                    L = n * lam / 2;
                    L = Math.Round(L, 2);
                    txt1.Text = L.ToString();
                }
                else if (!double.TryParse(txt2.Text, out lam) && double.TryParse(txt1.Text, out L) && double.TryParse(txt3.Text, out n))
                {
                    lam = 2 * L / n;
                    lam = Math.Round(lam, 2);
                    txt2.Text = lam.ToString();
                }
                else if (!double.TryParse(txt3.Text, out n) && double.TryParse(txt1.Text, out L) && double.TryParse(txt2.Text, out lam))
                {
                    n = 2 * L / lam;
                    n = Math.Round(n, 2);
                    txt3.Text = n.ToString();
                }
                //Demands valid input if invalid
                else
                {
                    MessageBox.Show("Input error!");
                }
            }
            //Catches errors
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void btnHarmonics2_Click(object sender, EventArgs e)
        {//Harmonics calc - Dissimilar ended
            #region
            try
            {
                //Declares variable
                double L, lam, n;
                //Tries to parse input to determine which variable is unknown; solves for unknown using formula for dissimilarly ended standing waves
                if (!double.TryParse(txt1.Text, out L) && double.TryParse(txt2.Text, out lam) && double.TryParse(txt3.Text, out n))
                {
                    L = ((2 * n - 1) * lam) / 4;
                    L = Math.Round(L, 2);
                    txt1.Text = L.ToString();
                }
                else if (!double.TryParse(txt2.Text, out lam) && double.TryParse(txt1.Text, out L) && double.TryParse(txt3.Text, out n))
                {
                    lam = 4 * L / (2 * n - 1);
                    lam = Math.Round(lam, 2);
                    txt2.Text = lam.ToString();
                }
                else if (!double.TryParse(txt3.Text, out n) && double.TryParse(txt1.Text, out L) && double.TryParse(txt2.Text, out lam))
                {
                    n = ((4 * L / lam) + 1) / 2;
                    n = Math.Round(n, 2);
                    txt3.Text = n.ToString();
                }
                //Demands valid input if invalid
                else
                {
                    MessageBox.Show("Input error!");
                }
            }
            //Catches errors
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
#endregion
        }

        private void ohmsLawToolStripMenuItem_Click(object sender, EventArgs e)
        {//Ohm's law tool strip
            #region
            //Labels
            lbl1.Text = "Voltage(V)";
            lbl2.Text = "Current (A)";
            lbl3.Text = "Resistance (Ohms)";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the unknown variable:";
            lblexplain3.Text = "Enter the values for known variables in proper units";
            lblextra.Text = "Enter \'u\' to indicate the unknown variable.";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = true;
            btnOhms.Text = "Calculate";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = false;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btnOhms_Click(object sender, EventArgs e)
        {//Ohm's law calc
            #region
            try
            {
                double voltage, current, resistance;
                if (!(double.TryParse(txt1.Text, out voltage)))
                {

                    double.TryParse(txt2.Text, out current);
                    double.TryParse(txt3.Text, out resistance);
                    voltage = current * resistance;
                    txt1.Text = voltage.ToString();
                }
                else if (!(double.TryParse(txt2.Text, out current)))
                {
                    double.TryParse(txt1.Text, out voltage);
                    double.TryParse(txt3.Text, out resistance);
                    current = voltage / resistance;
                    txt2.Text = current.ToString();
                }
                else if (!(double.TryParse(txt3.Text, out resistance)))
                {
                    double.TryParse(txt1.Text, out voltage);
                    double.TryParse(txt2.Text, out current);
                    resistance = voltage / current;
                    txt3.Text = resistance.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void gravitationalToolStripMenuItem_Click(object sender, EventArgs e)
        {//Eg tool strip
            #region
            //Labels
            lbl1.Text = "Mass (kg)";
            lbl2.Text = "Height (m)";
            lbl3.Text = "Total Energy (J)";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the unknown Gravitational Energy variable:";
            lblexplain3.Text = "Enter the values for known variables in proper units";
            lblextra.Text = "Enter \'u\' to indicate the unknown variable.";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = true;
            btngravity.Text = "Calculate";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = false;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btngravity_Click(object sender, EventArgs e)
        {//Eg calc
            #region
            try
            {
                double g, m, h, total;
                g = 9.8;
                if (!(double.TryParse(txt1.Text, out m)))
                {
                    double.TryParse(txt2.Text, out h);
                    double.TryParse(txt3.Text, out total);
                    m = total / (g * h);
                    txt1.Text = m.ToString();
                }
                else if (!(double.TryParse(txt2.Text, out h)))
                {
                    double.TryParse(txt3.Text, out total);
                    double.TryParse(txt1.Text, out m);
                    h = total / (m * g);
                    txt2.Text = h.ToString();
                }
                else if (!(double.TryParse(txt3.Text, out total)))
                {
                    double.TryParse(txt1.Text, out m);
                    double.TryParse(txt2.Text, out h);
                    total = m * g * h;
                    txt3.Text = total.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }


        private void kineticToolStripMenuItem_Click(object sender, EventArgs e)
        {//Ek toolstrip
            #region
            //Labels
            lbl1.Text = "Speed (m/s)";
            lbl2.Text = "Mass (kg)";
            lbl3.Text = "Total Energy (J)";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the unknown Kinetic Energy variable:";
            lblexplain3.Text = "Enter the values for known variables in proper units";
            lblextra.Text = "Enter \'u\' to indicate the unknown variable.";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = true;
            btnkinetic.Text = "Calculate";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = false;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void circleCalculationsToolStripMenuItem_Click(object sender, EventArgs e)
        {//Circle calc tool strip
            #region
            //Labels
            lbl1.Text = "Radius";
            lbl2.Text = "Area";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the unknown variable:";
            lblexplain3.Text = "Enter the values for known variables";
            lblextra.Text = "Enter \'u\' to indicate the unknown variable.";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = true;
            btnCircle.Text = "Calculate";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = false;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = false;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {  //Circle calc
            #region
            try
            {
                if (!double.TryParse(txt1.Text, out radius))
                {
                    double.TryParse(txt2.Text, out area);
                    radius = Math.Sqrt((area / Math.PI));
                    txt1.Text = radius.ToString();

                }
                else if (!double.TryParse(txt2.Text, out area))
                {
                    double.TryParse(txt1.Text, out radius);
                    area = Math.PI * Math.Pow(radius, 2);
                    txt2.Text = area.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void btnkinetic_Click(object sender, EventArgs e)
        {//Ek calc
            #region
            try
            {
                double velocity, mass, total;
                if (!double.TryParse(txt1.Text, out velocity))
                {
                    double.TryParse(txt2.Text, out mass);
                    double.TryParse(txt3.Text, out total);
                    velocity = Math.Sqrt(((2 * total) / mass));
                    txt1.Text = velocity.ToString();
                }
                else if (!double.TryParse(txt2.Text, out mass))
                {
                    double.TryParse(txt1.Text, out velocity);
                    double.TryParse(txt3.Text, out total);
                    mass = ((2 * total) / Math.Pow(velocity, 2));
                    txt2.Text = mass.ToString();
                }
                else if (!double.TryParse(txt3.Text, out total))
                {
                    double.TryParse(txt1.Text, out velocity);
                    double.TryParse(txt2.Text, out mass);
                    total = 0.5 * mass * Math.Pow(velocity, 2);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
        #endregion
        }

        private void heronsFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {//Heron's formula tool strip
            #region
            //Labels
            lbl1.Text = "Side Length:";
            lbl2.Text = "Side Length:";
            lbl3.Text = "Side Length:";
            lbl4.Text = "Area:";
            lbl5.Text = "";
            lblexplain2.Text = "To calculate the Area:";
            lblexplain3.Text = "Enter the side lengths";
            lblextra.Text = "";
            lblMass1.Text = "";
            lblMass2.Text = "";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = false;
            btnConvert.Text = "";
            btnArea.Enabled = true;
            btnArea.Text = "Calculate";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = false;
            txtStRe1.Text = "";
            txtStRe2.Enabled = false;
            txtStRe2.Text = "";
            txt4.Enabled = true;
            txt4.Text = "";
            txt5.Enabled = false;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btnArea_Click(object sender, EventArgs e)
        {//Heron's formula calc
            #region
            try
            {
                double a, b, c, s, A;
                a = double.Parse(txt1.Text);
                b = double.Parse(txt2.Text);
                c = double.Parse(txt3.Text);
                s = (a + b + c) / 2;
                A = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                A = Math.Round(A, 2);
                txt4.Text = A.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

        private void quadraticEquationConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {//Quadratic Converter tool strip
            #region
            //Labels
            lbl1.Text = "a";
            lbl2.Text = "c";
            lbl3.Text = "k";
            lbl4.Text = "r";
            lbl5.Text = "s";
            lblexplain2.Text = "To convert between different Quadratic Equation forms:";
            lblexplain3.Text = "Enter the values for \'a\' and either \'b\' and \'c\',";
            lblextra.Text = "\'h\' and \'k\', or \'r\' and \'s\'.";
            lblMass1.Text = "b";
            lblMass2.Text = "h";
            //Physics buttons
            btnKinematics.Enabled = false;
            btnKinematics.Text = "";
            btnPower.Enabled = false;
            btnPower.Text = "";
            btnOhms.Enabled = false;
            btnOhms.Text = "";
            btnHarmonics.Enabled = false;
            btnHarmonics.Text = "";
            btnHarmonics2.Enabled = false;
            btnHarmonics2.Text = "";
            btngravity.Enabled = false;
            btngravity.Text = "";
            btnkinetic.Enabled = false;
            btnkinetic.Text = "";
            //Math buttons
            btnCircle.Enabled = false;
            btnCircle.Text = "";
            btnQuad.Enabled = false;
            btnQuad.Text = "";
            btnConvert.Enabled = true;
            btnConvert.Text = "Convert";
            btnArea.Enabled = false;
            btnArea.Text = "";
            //Chemistry buttons
            btnStoichCalc.Enabled = false;
            btnStoichCalc.Text = "";
            btnIdealGas.Enabled = false;
            btnIdealGas.Text = "";
            //Text boxes
            txt1.Enabled = true;
            txt1.Text = "";
            txt2.Enabled = true;
            txt2.Text = "";
            txt3.Enabled = true;
            txt3.Text = "";
            txtStRe1.Enabled = true;
            txtStRe1.Text = "";
            txtStRe2.Enabled = true;
            txtStRe2.Text = "";
            txt4.Enabled = true;
            txt4.Text = "";
            txt5.Enabled = true;
            txt5.Text = "";
            txtextra.Enabled = false;
            txtextra.Text = "";
            #endregion
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {//Quadratic Equation Conversion
            #region
            //Declares variables
            double a = 0, b = 0, c = 0;
            double h = 0, k = 0;
            double r = 0, s = 0;
            double Determinant;
            bool Standard = false;
            bool Vertex = false;
            bool Factored = false;
            try
            {
                //Determines which form of quadratic equation the user input variables for
                Standard = double.TryParse(txt1.Text, out a) && double.TryParse(txtStRe1.Text, out b) && double.TryParse(txt2.Text, out c);
                Vertex = double.TryParse(txt1.Text, out a) && double.TryParse(txtStRe2.Text, out h) && double.TryParse(txt3.Text, out k);
                Factored = double.TryParse(txt1.Text, out a) && double.TryParse(txt4.Text, out r) && double.TryParse(txt5.Text, out s);
                //Solves for other two forms, if possible
                if (Standard)
                {
                    Determinant = (Math.Pow(b, 2)) - 4 * a * c;
                    if (Determinant < 0)
                    {
                        h = (-b) / (2 * a);
                        k = c - ((Math.Pow(b, 2)) / (4 * a));
                    }
                    else if (Determinant == 0)
                    {
                        r = (-b) / (2) * a;
                        s = r;
                        h = r;
                        k = 0;
                    }
                    else if (Determinant > 0)
                    {
                        r = ((-b) - Math.Sqrt((Math.Pow(b, 2)) - 4 * a * c)) / (2 * a);
                        s = (Math.Sqrt((Math.Pow(b, 2)) - 4 * a * c) - b) / (2 * a);
                        h = (r + s) / 2;
                        k = a * (Math.Pow(h, 2)) + b * h + c;
                    }
                }//Close standard
                else if (Vertex)
                {
                    b = (-2) * a * h;
                    c = a * (Math.Pow(h, 2)) + k;
                    Determinant = (Math.Pow(b, 2)) - 4 * a * c;
                    if (Determinant < 0)
                    {

                    }
                    else if (Determinant == 0)
                    {
                        r = h;
                        s = r;
                        k = 0;
                    }
                    else if (Determinant > 0)
                    {
                        r = ((-b) - Math.Sqrt((Math.Pow(b, 2)) - 4 * a * c)) / (2 * a);
                        s = (Math.Sqrt((Math.Pow(b, 2)) - 4 * a * c) - b) / (2 * a);
                    }
                }//Close vertex
                else if (Factored)
                {
                    h = (r + s) / 2;
                    k = a * (h - r) * (h - s);
                    b = (-a) * (s + r);
                    c = a * r * s;
                }
                else
                {
                    MessageBox.Show("Error! Invalid input!");
                }
                //Rounds output
                a = Math.Round(a, 2);
                b = Math.Round(b, 2);
                c = Math.Round(c, 2);
                h = Math.Round(h, 2);
                k = Math.Round(k, 2);
                r = Math.Round(r, 2);
                s = Math.Round(s, 2);
                //Displays output
                txt1.Text = a.ToString();
                txtStRe1.Text = b.ToString();
                txt2.Text = c.ToString();
                txtStRe2.Text = h.ToString();
                txt3.Text = k.ToString();
                txt4.Text = r.ToString();
                txt5.Text = s.ToString();
            }
            //Catches errors
            catch (Exception error)
            {
                MessageBox.Show("Error! " + error);
            }
            #endregion
        }

      
    }


    }
    

