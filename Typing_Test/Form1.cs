using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _NumOfTypedWords = 0;
        byte _Delay = 30;        
        int _LettersCounter = 0;
        bool _IsKeyboardOn = false;

        string[] _arrMainText = new string[] 
        {
       
            "the","opera","fall","love","someone","me","hello",

            "we","crazy","midnight","stars","date","will",

            "would","should","can"

            ,"blind","show","programming","mohammed",

            "alive","life","word","work","hard",

            "sick","lit","eminem","rap","now","are"

            ,"great","kamakazi","swift","fools","rush","in","help","letter","wait",

            "bad","student","i","you","she","is"

            ,"dope","fancy","something","hold","they",

            "what","why","when","pillow","rat",

            "sheet","no","but","phone","phenomenon",

            "a","an","view","table","two"

            ,"addict","ring","lie","try","three"

        };

    

        class clsTestStats
        {
            public int TestTime;
            public int TimeThatPassed;
            public int NumOfAllLetters;
            public int NumOfLettersSpelledWrong;          
            public float Accuracy;
           
            public clsTestStats(int _TestTime, int _NumOfAllLetters,
                int _NumOfLettersSpelledWrong, int _TimeThatPassed, float _Accuracy)
            {
                TestTime = _TestTime;
                NumOfAllLetters = _NumOfAllLetters;
                NumOfLettersSpelledWrong = _NumOfLettersSpelledWrong;              
                Accuracy = _Accuracy;
                TimeThatPassed = _TimeThatPassed;
            }          

        }

        clsTestStats TestStats;

        int GetNumOfAllLettters()
        {
            return txtMain.Text.Length;
        }

        byte GetTestTime()
        {
            if (rb10Seconds.Checked)
                return Convert.ToByte(rb10Seconds.Tag);

            else if (rb15Seconds.Checked)
                return Convert.ToByte(rb15Seconds.Tag);

            else if ((rb20Seconds.Checked))
                return Convert.ToByte(rb20Seconds.Tag);

            else if ((rb30Seconds.Checked))
                return Convert.ToByte(rb30Seconds.Tag);

            else if ((rb1Minute.Checked))
                return Convert.ToByte(rb1Minute.Tag);



            return Convert.ToByte(rb10Seconds.Tag);

        }

        float GetSpeedWPM()
        {
            float Speed =  (float)Math.Round(((float)_NumOfTypedWords / (float)(TestStats.TimeThatPassed / 60.0)));
            return Speed;
        }

        double GetAccuracy()
        {
            int NumOfLettersSpelledRight = TestStats.NumOfAllLetters - TestStats.NumOfLettersSpelledWrong;
            int NumOfAllLetters = TestStats.NumOfAllLetters;
            double Accuracy = ((double)NumOfLettersSpelledRight / (double)NumOfAllLetters * 100.0);
            Accuracy = Math.Round(Accuracy);
            return Accuracy;

        }

        void EndTest()
        {
            lblAccuracy.Text = (GetAccuracy()).ToString() + "%";
            lblErrors.Text = TestStats.NumOfLettersSpelledWrong.ToString();
            lblSpeed.Text = GetSpeedWPM().ToString() + " WPM";
            timer1.Enabled = false;
            _LettersCounter = 0;
            txtCopy.Enabled = false;
            txtCopy.Clear();
            _IsKeyboardOn = false;
            gbKeyBoard.Enabled = false;
            TestStats.TimeThatPassed = 0;
            lblTime.Text = TestStats.TimeThatPassed.ToString();
            MessageBox.Show("Test Is Done");         
            txtCopy.Focus();

        }



        void GenerateRandomText()
        {
            txtMain.Clear();
            txtCopy.Clear();
            txtCopy.Enabled = false;

            Random rnd = new Random();
            
            for (int i = 0; i <= 30; i++)
            {
                txtMain.Text += _arrMainText[rnd.Next(0, 70)].ToString();
                txtMain.Text += " ";
            }

            lblAccuracy.Text = "";
            lblErrors.Text = "";
            lblSpeed.Text = "";
            txtCopy.Focus();


        }

        private void Form1_Load(object sender, EventArgs e)
        {                      
            this.KeyPreview = true;
            gbKeyBoard.Enabled = false;
            TestStats = new clsTestStats(GetTestTime(), GetNumOfAllLettters(), 0, 0, 0);
            GenerateRandomText();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _ = btnSpaceBar_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.Z)
            {
                _ = btnZ_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.X)
            {
                _ = btnX_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.C)
            {
                _ = btnC_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.V)
            {
                _ = btnV_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.B)
            {
                _ = btnB_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.N)
            {
                _ = btnN_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.M)
            {
                _ = btnM_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.Oemcomma)
            {
                _ = btnComma_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.OemPeriod)
            {
                _ = btnDot_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.A)
            {
                _ = btnA_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.S)
            {
                _ = btnS_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D)
            {
                _ = btnD_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.F)
            {
                _ = btnF_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.G)
            {
                _ = btnG_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.H)
            {
                _ = btnH_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.J)
            {
                _ = btnJ_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.K)
            {
                _ = btnK_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.L)
            {
                _ = btnL_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.OemSemicolon)
            {
                _ = btnSemiColon_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.OemQuotes)
            {
                _ = btnQuotationmark_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.Q)
            {
                _ = btnQ_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.W)
            {
                _ = btnW_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.E)
            {
                _ = btnE_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.R)
            {
                _ = btnR_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.T)
            {
                _ = btnT_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.Y)
            {
                _ = btnY_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.U)
            {
                _ = btnU_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.I)
            {
                _ = btnI_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.O)
            {
                _ = btnO_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.P)
            {
                _ = btnP_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.OemOpenBrackets)
            {
                _ = btnOpenBracket_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.OemCloseBrackets)
            {
                _ = btnCloseBracket_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D1)
            {
                _ = btn1_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D2)
            {
                _ = btn2_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D3)
            {
                _ = btn3_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D4)
            {
                _ = btn4_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D5)
            {
                _ = btn5_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D6)
            {
                _ = btn6_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D7)
            {
                _ = btn7_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D8)
            {
                _ = btn8_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D9)
            {
                _ = btn9_ClickAsync(sender, e);
            }

            else if (e.KeyCode == Keys.D0)
            {
                _ = btn0_ClickAsync(sender, e);
            }

           

        }

        async void PerformClickFunc(Button B, char C, bool IsSpaceBar = false)
        {

            if (!_IsKeyboardOn)
                return;

            if (_LettersCounter == TestStats.NumOfAllLetters)
            {
                EndTest();
                return;
            }

            if (txtMain.Text[_LettersCounter] == C)
            {
                if (IsSpaceBar)
                    _NumOfTypedWords++;


                B.BackColor = Color.Green;
                txtCopy.Text += C;
                await Task.Delay(_Delay);
                B.BackColor = SystemColors.Control;
                _LettersCounter++;              
            }
            else
            {
                B.BackColor = Color.Red;
                await Task.Delay(_Delay);
                B.BackColor = SystemColors.Control;
                TestStats.NumOfLettersSpelledWrong++;
            }
        }

        //All Buttons:
        private Task btnSpaceBar_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnSpaceBar, ' ', true);           
            return Task.CompletedTask;
        }

        private Task btnZ_ClickAsync(object sender, EventArgs e)
        {          
            PerformClickFunc(btnZ, 'z');
            return Task.CompletedTask;
        }

        private Task btnX_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnX, 'x');
            return Task.CompletedTask;
        }

        private Task btnC_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnC, 'c');
            return Task.CompletedTask;
        }

        private Task btnV_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnV, 'v');
            return Task.CompletedTask;
        }

        private Task btnB_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnB, 'b');
            return Task.CompletedTask;
        }

        private Task btnN_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnN, 'n');
            return Task.CompletedTask;
        }

        private Task btnM_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnM, 'm');
            return Task.CompletedTask;
        }

        private Task btnComma_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnComma, ',');
            return Task.CompletedTask;
        }

        private Task btnDot_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnDot, '.');
            return Task.CompletedTask;
        }

        private Task btnA_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnA, 'a');
            return Task.CompletedTask;
        }

        private Task btnS_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnS, 's');
            return Task.CompletedTask;
        }

        private Task btnD_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnD, 'd');
            return Task.CompletedTask;
        }

        private Task btnF_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnF, 'f');
            return Task.CompletedTask;
        }

        private Task btnG_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnG, 'g');
            return Task.CompletedTask;
        }

        private Task btnH_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnH, 'h');
            return Task.CompletedTask;
        }

        private Task btnJ_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnJ, 'j');
            return Task.CompletedTask;
        }

        private Task btnK_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnK, 'k');
            return Task.CompletedTask;
        }

        private Task btnL_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnL, 'l');
            return Task.CompletedTask;
        }

        private Task btnSemiColon_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnSemiColon, ';');
            return Task.CompletedTask;
        }

        private Task btnQuotationmark_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnQuotationmark, '"');
            return Task.CompletedTask;
        }

        private Task btnQ_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnQ, 'q');
            return Task.CompletedTask;
        }

        private Task btnW_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnW, 'w');
            return Task.CompletedTask;
        }

        private Task btnE_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnE, 'e');
            return Task.CompletedTask;
        }

        private Task btnR_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnR, 'r');
            return Task.CompletedTask;
        }

        private Task btnT_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnT, 't');
            return Task.CompletedTask;
        }

        private Task btnY_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnY, 'y');
            return Task.CompletedTask;
        }

        private Task btnU_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnU, 'u');
            return Task.CompletedTask;
        }

        private Task btnI_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnI, 'i');
            return Task.CompletedTask;
        }

        private Task btnO_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnO, 'o');
            return Task.CompletedTask;
        }

        private Task btnP_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnP, 'p');
            return Task.CompletedTask;
        }

        private Task btnOpenBracket_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnOpenBracket, '{');
            return Task.CompletedTask;
        }

        private Task btnCloseBracket_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btnCloseBracket, '}');
            return Task.CompletedTask;
        }

        private Task btn1_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn1, '1');
            return Task.CompletedTask;
        }

        private Task btn2_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn2, '2');
            return Task.CompletedTask;
        }

        private Task btn3_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn3, '3');
            return Task.CompletedTask;
        }

        private Task btn4_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn4, '4');
            return Task.CompletedTask;
        }

        private Task btn5_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn5, '5');
            return Task.CompletedTask;
        }

        private Task btn6_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn6, '6');
            return Task.CompletedTask;
        }

        private Task btn7_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn7, '7');
            return Task.CompletedTask;
        }

        private Task btn8_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn8, '8');
            return Task.CompletedTask;
        }

        private Task btn9_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn9, '9');
            return Task.CompletedTask;
        }

        private Task btn0_ClickAsync(object sender, EventArgs e)
        {
            PerformClickFunc(btn0, '0');
            return Task.CompletedTask;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {          
            TestStats.TimeThatPassed++;
            lblTime.Text = TestStats.TimeThatPassed.ToString();
        
            if (TestStats.TestTime == TestStats.TimeThatPassed)
            {
                timer1.Enabled = false;
                txtCopy.Enabled = false;
                MessageBox.Show("Test Is Done");
                lblAccuracy.Text = (GetAccuracy()).ToString() + "%";
                lblErrors.Text = TestStats.NumOfLettersSpelledWrong.ToString();              
                lblSpeed.Text = GetSpeedWPM().ToString() + " WPM";
                
            }
        }
            

        private void btnStart_Click(object sender, EventArgs e)
        {         
            _LettersCounter = 0;
            txtCopy.Enabled = true;
            txtCopy.Clear();
            _IsKeyboardOn = true;
            gbKeyBoard.Enabled = true;
            TestStats = new clsTestStats(GetTestTime(), GetNumOfAllLettters(), 0, 0, 0);          
            lblTime.Text = TestStats.TimeThatPassed.ToString();
            timer1.Enabled = true;
            txtCopy.Focus();

        }

        private void btnGenerateNewWords_Click(object sender, EventArgs e)
        {
            _NumOfTypedWords = 0;
            TestStats.TimeThatPassed = 0;
            timer1.Enabled = false;
            gbKeyBoard.Enabled = false;
            GenerateRandomText();                      
            _LettersCounter = 0;
            lblTime.Text = 0.ToString();
        }
    }
}