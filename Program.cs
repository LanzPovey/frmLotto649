/NAME: Lanz Povey
//DATE: May 31st 2016
//TEACHER: Mr. Wachs
//ASSIGNEMENT: Computer Science 20S, Unit 5: Looping. Question 2.
//PURPOSE: The purpose of this program is to generate a set collection of Lotto 649 based 
on the users input into the combo box.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _5thUnit03Question1
{
    public partial class frmLotto649 : Form
    {
        public frmLotto649()
        {
            InitializeComponent();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (libLottoNumbers.Text == "") libLottoNumbers.Items.Clear();
            if (cboNumberOfDraws.Text == "") MessageBox.Show("Please insert a number via 
           the combo box options or your own custom number!");
            else
            {
                int numberOfDraws = Convert.ToInt32(cboNumberOfDraws.Text);
                if (numberOfDraws <= 0) MessageBox.Show("Please insert a number that's 
               above 0 into the textbox!");
                else
                {
                    Random random = new Random();
                    // This needs to be Greater Than (>), since if it's Less Than(<), it 
                    will never enter the loop.
 while (numberOfDraws > 0) // Nested event controlled loops.
                    {
                        numberOfDraws -= 1; // A control variable to stop it from 
                        looping.
 int lottoNumber1 = random.Next(1, 50), lottoNumber2 =
random.Next(1, 50), lottoNumber3 = random.Next(1, 50), lottoNumber4 = random.Next(1, 50),
lottoNumber5 = random.Next(1, 50), lottoNumber6 = random.Next(1, 50);
                        while (lottoNumber1 == lottoNumber2 || lottoNumber1 ==
                       lottoNumber3 || lottoNumber1 == lottoNumber4 || lottoNumber1 == lottoNumber5 ||
                       lottoNumber1 == lottoNumber6)
                        {
                            lottoNumber1 = random.Next(1, 50);
                        }
                        while (lottoNumber2 == lottoNumber1 || lottoNumber2 ==
                        lottoNumber3 || lottoNumber2 == lottoNumber4 || lottoNumber2 == lottoNumber5 ||
                        lottoNumber2 == lottoNumber6)
                        {
                            lottoNumber2 = random.Next(1, 50);
                        }
                        while (lottoNumber3 == lottoNumber1 || lottoNumber3 ==
                        lottoNumber2 || lottoNumber3 == lottoNumber4 || lottoNumber3 == lottoNumber5 ||
                        lottoNumber3 == lottoNumber6)
                        {
                            lottoNumber3 = random.Next(1, 50);
                        }
                        while (lottoNumber4 == lottoNumber1 || lottoNumber4 ==
                        lottoNumber2 || lottoNumber4 == lottoNumber3 || lottoNumber4 == lottoNumber5 ||
                        lottoNumber4 == lottoNumber6)
                        {
                            lottoNumber4 = random.Next(1, 50);
                        }
                        while (lottoNumber5 == lottoNumber1 || lottoNumber5 ==
                       lottoNumber2 || lottoNumber5 == lottoNumber3 || lottoNumber5 == lottoNumber4 ||
                       lottoNumber5 == lottoNumber6)
                        {
                            lottoNumber5 = random.Next(1, 50);
                        }
                        while (lottoNumber6 == lottoNumber1 || lottoNumber6 ==
                        lottoNumber2 || lottoNumber6 == lottoNumber3 || lottoNumber6 == lottoNumber4 ||
                        lottoNumber6 == lottoNumber5)
                        {
                            lottoNumber6 = random.Next(1, 50);
                        }
                        libLottoNumbers.Items.Add(lottoNumber1 + ", " + lottoNumber2
                        + ", " + lottoNumber3 + ", " + lottoNumber4 + ", " + lottoNumber5 + ", " + lottoNumber6);
                    }
                }
            }
        }
        private void frmLotto649_Load(object sender, EventArgs e)
        {
            cboNumberOfDraws.Items.Add("1");
            cboNumberOfDraws.Items.Add("10");
            cboNumberOfDraws.Items.Add("50");
            cboNumberOfDraws.Items.Add("100");
        }
    }