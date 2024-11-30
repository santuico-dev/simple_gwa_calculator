using ComponentFactory.Krypton.Toolkit;
using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace GWACalc
{
    public partial class CalcModule : KryptonForm
    {
        public CalcModule()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public CalcModule(string term)
        {
            InitializeComponent();
            this.Term = term;
            this.MaximizeBox = false;

        }

        public string Term { get; set; }


        private void CalcModule_Load(object sender, EventArgs e)
        {
            sub1.Text = "";
            sub2.Text = "";
            sub3.Text = "";
            sub4.Text = "";
            sub5.Text = "";
            sub6.Text = "";
            sub7.Text = "";
            sub8.Text = "";
            sub9.Text = "";

            //-------------------------

            sub1FGrade.Text = "";
            sub2FGrade.Text = "";
            sub3FGrade.Text = "";
            sub4FGrade.Text = "";
            sub5FGrade.Text = "";
            sub6FGrade.Text = "";
            sub7FGrade.Text = "";
            sub8FGrade.Text = "";
            sub9FGrade.Text = "";

            //------------------------

            sub1FGrade.Text = "0.00";
            sub2FGrade.Text = "0.00";
            sub3FGrade.Text = "0.00";
            sub4FGrade.Text = "0.00";
            sub5FGrade.Text = "0.00";
            sub6FGrade.Text = "0.00";
            sub7FGrade.Text = "0.00";
            sub8FGrade.Text = "0.00";
            sub9FGrade.Text = "0.00";

            calculatedGWA.Text = "0.00";

            calcBtn.Enabled = false;

            if(Term.Equals("1Y, 1st Term"))
            {
                FirstYearFirstTerm();

            }else if(Term.Equals("1Y, 2nd Term"))
            {
                FirstYearSecondTerm();

            }else if (Term.Equals("2Y, 1st Term"))
            {
                SecondYearFirstTerm();

            }else if(Term.Equals("2Y, 2nd Term"))
            {

                SecondYearSecondTerm();

            }else if(Term.Equals("3Y, 1st Term"))
            {

                ThirdYearFirstTerm();

            }else if(Term.Equals("3Y, 2nd Term"))
            {
                ThirdYearSecondTerm();

            }else if(Term.Equals("4Y, 1st Term"))
            {
                ForthYearFirstTerm();
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Index().Show();
        }

        public void FirstYearFirstTerm()
        {
            sub1.Text = "ComProg 1";
            sub2.Text = "Intro Com.";
            sub3.Text = "NSTP1";
            sub4.Text = "Contemp World";
            sub5.Text = "Euthenics 1";
            sub6.Text = "Math in MW";
            sub7.Text = "PE 1";
            sub8.Text = "Entrep Mind";
            sub9.Text = "UTS";

            //

            sub1Final.Text = "ComProg 1:";
            sub2Final.Text = "Intro Com:";
            sub3Final.Text = "NSTP1:";
            sub4Final.Text = "Contemp World:";
            sub5Final.Text = "Euthenics 1:";
            sub6Final.Text = "Math in MW:";
            sub7Final.Text = "PE 1:";
            sub8Final.Text = "Entrep Mind:";
            sub9Final.Text = "UTS:";

        }

        public void FirstYearSecondTerm()
        {
            sub1.Text = "Art App.";
            sub2.Text = "Discrete Math";
            sub3.Text = "NSTP2";
            sub4.Text = "PurComm.";
            sub5.Text = "Sytem ADM";
            sub6.Text = "ComProg 2";
            sub7.Text = "Ethics";
            sub8.Text = "PE 2";
            sub9.Text = "STS";

            //

            sub1Final.Text = "Art App.:";
            sub2Final.Text = "Discrete Math:";
            sub3Final.Text = "NSTP2:";
            sub4Final.Text = "PurComm:";
            sub5Final.Text = "Sytem ADM:";
            sub6Final.Text = "ComProg 2:";
            sub7Final.Text = "Ethics:";
            sub8Final.Text = "PE 2:";
            sub9Final.Text = "STS:";
        }

        //

        public void SecondYearFirstTerm()
        {
            sub9.Visible = false;
            sub9PrelimTxtBox.Visible = false;
            sub9PreFinalTxtBox.Visible = false;
            sub9MidtermTxtBox.Visible = false;
            sub9FinalTxtBox.Visible = false;
            sub9FGrade.Visible = false;
            sub9Final.Visible = false;

            sub1.Text = "DSAA";
            sub2.Text = "OOP";
            sub3.Text = "Platform Tech.";
            sub4.Text = "RIPH";
            sub5.Text = "HCI";
            sub6.Text = "PE 3";
            sub7.Text = "PrinComm";
            sub8.Text = "RLAW";

            //

            sub1Final.Text = "DSAA:";
            sub2Final.Text = "OOP:";
            sub3Final.Text = "Platform Tech:";
            sub4Final.Text = "RIPH:";
            sub5Final.Text = "HCI:";
            sub6Final.Text = "PE 3:";
            sub7Final.Text = "PrinComm:";
            sub8Final.Text = "RLAW:";

        }

        public void SecondYearSecondTerm()
        {
            sub9.Visible = false;
            sub9PrelimTxtBox.Visible = false;
            sub9PreFinalTxtBox.Visible = false;
            sub9MidtermTxtBox.Visible = false;
            sub9FinalTxtBox.Visible = false;
            sub9FGrade.Visible = false;
            sub9Final.Visible = false;

            sub1.Text = "Information Mng.";
            sub2.Text = "NetTech 1";
            sub3.Text = "PE 4";
            sub4.Text = "SIA";
            sub5.Text = "Integ Prog.";
            sub6.Text = "PPC";
            sub7.Text = "Quanti Methods";
            sub8.Text = "Techno.";

            //

            sub1Final.Text = "Information Mng:";
            sub2Final.Text = "NetTech 1:";
            sub3Final.Text = "PE 4:";
            sub4Final.Text = "SIA:";
            sub5Final.Text = "Integ Prog:";
            sub6Final.Text = "PPC:";
            sub7Final.Text = "Quanti Methods:";
            sub8Final.Text = "Techno:";
        }

        //

        public void ThirdYearFirstTerm()
        {
            sub9.Visible = false;
            sub9PrelimTxtBox.Visible = false;
            sub9PreFinalTxtBox.Visible = false;
            sub9MidtermTxtBox.Visible = false;
            sub9FinalTxtBox.Visible = false;
            sub9FGrade.Visible = false;
            sub9Final.Visible = false;

            //

            sub8.Visible = false;
            sub8PrelimTxtBox.Visible = false;
            sub8PreFinalTxtBox.Visible = false;
            sub8MidtermTxtBox.Visible = false;
            sub8FinalTxtBox.Visible = false;
            sub8FGrade.Visible = false;
            sub8Final.Visible = false;

            //

            sub7.Visible = false;
            sub7PrelimTxtBox.Visible = false;
            sub7PreFinalTxtBox.Visible = false;
            sub7MidtermTxtBox.Visible = false;
            sub7FinalTxtBox.Visible = false;
            sub7FGrade.Visible = false;
            sub7Final.Visible = false;

            sub1.Text = "App Dev.";
            sub2.Text = "ADV Info. Mng";
            sub3.Text = "ADV DBS"; 
            sub4.Text = "Event Driven Prog.";
            sub5.Text = "PIIST";
            sub6.Text = "Data Comm.";

            //

            sub1Final.Text = "App Dev:";
            sub2Final.Text = "ADV Info. Mng:";
            sub3Final.Text = "ADV DBS:";
            sub4Final.Text = "Event Driven Prog:";
            sub5Final.Text = "PIIST:";
            sub6Final.Text = "Data Comm:";

        }

        public void ThirdYearSecondTerm()
        {
            sub9.Visible = false;
            sub9PrelimTxtBox.Visible = false;
            sub9PreFinalTxtBox.Visible = false;
            sub9MidtermTxtBox.Visible = false;
            sub9FinalTxtBox.Visible = false;
            sub9FGrade.Visible = false;
            sub9Final.Visible = false;

            //

            sub8.Visible = false;
            sub8PrelimTxtBox.Visible = false;
            sub8PreFinalTxtBox.Visible = false;
            sub8MidtermTxtBox.Visible = false;
            sub8FinalTxtBox.Visible = false;
            sub8FGrade.Visible = false;
            sub8Final.Visible = false;

            //

            sub7.Visible = false;
            sub7PrelimTxtBox.Visible = false;
            sub7PreFinalTxtBox.Visible = false;
            sub7MidtermTxtBox.Visible = false;
            sub7FinalTxtBox.Visible = false;
            sub7FGrade.Visible = false;
            sub7Final.Visible = false;

            sub1.Text = "Mobile Systems";
            sub2.Text = "Great Books";
            sub3.Text = "Mng Info System";
            sub4.Text = "Capstone 1";
            sub5.Text = "Cyber Security";
            sub6.Text = "Web Systems";

            //

            sub1Final.Text = "Mobile Systems:";
            sub2Final.Text = "Great Books:";
            sub3Final.Text = "Mng Info System:";
            sub4Final.Text = "Capstone 1:";
            sub5Final.Text = "Cyber Security:";
            sub6Final.Text = "Web Systems:";

        }

        //

        public void ForthYearFirstTerm()
        {
            sub9.Visible = false;
            sub9PrelimTxtBox.Visible = false;
            sub9PreFinalTxtBox.Visible = false;
            sub9MidtermTxtBox.Visible = false;
            sub9FinalTxtBox.Visible = false;
            sub9FGrade.Visible = false;
            sub9Final.Visible = false;

            //

            sub8.Visible = false;
            sub8PrelimTxtBox.Visible = false;
            sub8PreFinalTxtBox.Visible = false;
            sub8MidtermTxtBox.Visible = false;
            sub8FinalTxtBox.Visible = false;
            sub8FGrade.Visible = false;
            sub8Final.Visible = false;

            //

            sub7.Visible = false;
            sub7PrelimTxtBox.Visible = false;
            sub7PreFinalTxtBox.Visible = false;
            sub7MidtermTxtBox.Visible = false;
            sub7FinalTxtBox.Visible = false;
            sub7FGrade.Visible = false;
            sub7Final.Visible = false;

            sub1.Text = "Euthenics 2";
            sub2.Text = "Data Privacy";
            sub3.Text = "Capstone 2";
            sub4.Text = "NetTech 2";
            sub5.Text = "IT Service Mng";
            sub6.Text = "Com. GP";

            //

            sub1Final .Text = "Euthenics 2:";
            sub2Final.Text = "Data Privacy:";
            sub3Final.Text = "Capstone 2:";
            sub4Final.Text = "NetTech 2:";
            sub5Final.Text = "IT Service Mng:";
            sub6Final.Text = "Com. GP:";
        }


        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void calculatedPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void sub1FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub1PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub2PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub3PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub4PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub5PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub6PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub7PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub8PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub9PrelimTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub1MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub2MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub3MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub4MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub5MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub6MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub7MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub8MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub9MidtermTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub1PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub2PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub3PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub4PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub5PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub6PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub7PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub8PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub9PreFinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub2FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub3FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub4FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub5FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub6FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub7FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub8FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

        }

        private void sub9FinalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void sub1PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
     
            if (sub1PrelimTxtBox.Text == string.Empty || Convert.ToDouble(sub1PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;
                }
            }
        }

        private void sub2PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub2PrelimTxtBox.Text == string.Empty || Convert.ToDouble(sub2PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub3PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub3PrelimTxtBox.Text == string.Empty || Convert.ToDouble(sub3PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub4PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub4PrelimTxtBox.Text == string.Empty ||Convert.ToDouble(sub4PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub5PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub5PrelimTxtBox.Text == string.Empty ||Convert.ToDouble(sub5PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub6PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub6PrelimTxtBox.Text == string.Empty ||Convert.ToDouble(sub6PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub7PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub7PrelimTxtBox.Text == string.Empty ||Convert.ToDouble(sub7PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub8PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub8PrelimTxtBox.Text == string.Empty ||Convert.ToDouble(sub8PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub9PrelimTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub9PrelimTxtBox.Text == string.Empty ||Convert.ToDouble(sub9PrelimTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub1MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub1MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub1MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub2MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub2MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub2MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub3MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub3MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub3MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub4MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub4MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub4MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub5MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub5MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub5MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub6MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub6MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub6MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub7MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub7MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub7MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub8MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub8MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub8MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub9MidtermTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub9MidtermTxtBox.Text == string.Empty || Convert.ToDouble(sub9MidtermTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub1PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub1PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub1PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub2PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub2PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub2PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub3PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub3PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub3PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub4PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub4PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub4PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub5PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub5PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub5PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub6PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub6PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub6PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub7PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub7PreFinalTxtBox.Text == string.Empty ||Convert.ToDouble(sub7PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub8PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub8PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub8PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub9PreFinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub9PreFinalTxtBox.Text == string.Empty || Convert.ToDouble(sub9PreFinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub1FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(sub1PrelimTxtBox.Text != string.Empty && sub1MidtermTxtBox.Text != string.Empty && sub1PreFinalTxtBox.Text != string.Empty && sub1FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub1PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub1MidtermTxtBox.Text) <= 100 &&
                Convert.ToDouble(sub1PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub1FinalTxtBox.Text) <= 100)
            {
                if (sub1FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub1FinalTxtBox.Text) <= 100 || sub1FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub1FinalTxtBox.Text) <= 100 || sub1PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub1PrelimTxtBox.Text) <= 100 ||
                  sub1PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub1PrelimTxtBox.Text) <= 100 || sub1MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub1MidtermTxtBox.Text) <= 100 || sub1MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub1MidtermTxtBox.Text) <= 100 ||
                  sub1PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub1PreFinalTxtBox.Text) <= 100 || sub1PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub1PreFinalTxtBox.Text) <= 100)
                {
                    AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                    sub1FGrade.Text = calculateSubAverage(sub1PrelimTxtBox.Text, sub1MidtermTxtBox.Text, sub1PreFinalTxtBox.Text, sub1FinalTxtBox.Text).ToString();

                }
            }else
            {
                if(sub1FinalTxtBox.Text.Length == 5 || sub1FinalTxtBox.Text.Length == 3)
                {
                    MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (sub1FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub1FinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub2FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub2PrelimTxtBox.Text != string.Empty && sub2MidtermTxtBox.Text != string.Empty && sub2PreFinalTxtBox.Text != string.Empty && sub2FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub2PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub2MidtermTxtBox.Text) <= 100 &&
       Convert.ToDouble(sub2PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub2FinalTxtBox.Text) <= 100)
            {
                if (sub2FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub2FinalTxtBox.Text) <= 100 || sub2FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub2FinalTxtBox.Text) <= 100 || sub2PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub2PrelimTxtBox.Text) <= 100 ||
                  sub2PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub2PrelimTxtBox.Text) <= 100 || sub2MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub2MidtermTxtBox.Text) <= 100 || sub2MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub2MidtermTxtBox.Text) <= 100 ||
                  sub2PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub2PreFinalTxtBox.Text) <= 100 || sub2PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub2PreFinalTxtBox.Text) <= 100)
                {
                    AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                    sub2FGrade.Text = calculateSubAverage(sub2PrelimTxtBox.Text, sub2MidtermTxtBox.Text, sub2PreFinalTxtBox.Text, sub2FinalTxtBox.Text).ToString();

                }
            }
            else
            {
                if (sub2FinalTxtBox.Text.Length == 5 || sub2FinalTxtBox.Text.Length == 3)
                {
                    MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (sub2FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub2FinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub3FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub3PrelimTxtBox.Text != string.Empty && sub3MidtermTxtBox.Text != string.Empty && sub3PreFinalTxtBox.Text != string.Empty && sub3FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub3PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub3MidtermTxtBox.Text) <= 100 &&
       Convert.ToDouble(sub3PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub3FinalTxtBox.Text) <= 100)
            {
                if (sub3FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub3FinalTxtBox.Text) <= 100 || sub3FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub3FinalTxtBox.Text) <= 100 || sub3PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub3PrelimTxtBox.Text) <= 100 ||
                  sub3PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub3PrelimTxtBox.Text) <= 100 || sub3MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub3MidtermTxtBox.Text) <= 100 || sub3MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub3MidtermTxtBox.Text) <= 100 ||
                  sub3PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub3PreFinalTxtBox.Text) <= 100 || sub3PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub3PreFinalTxtBox.Text) <= 100)
                {
                    AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                    sub3FGrade.Text = calculateSubAverage(sub3PrelimTxtBox.Text, sub3MidtermTxtBox.Text, sub3PreFinalTxtBox.Text, sub3FinalTxtBox.Text).ToString();

                }
            }
            else
            {
                if (sub3FinalTxtBox.Text.Length == 5 || sub3FinalTxtBox.Text.Length == 3)
                {
                    MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (sub3FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub3FinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub4FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub4PrelimTxtBox.Text != string.Empty && sub4MidtermTxtBox.Text != string.Empty && sub4PreFinalTxtBox.Text != string.Empty && sub4FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub4PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub4MidtermTxtBox.Text) <= 100 &&
       Convert.ToDouble(sub4PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub4FinalTxtBox.Text) <= 100)
            {
                if (sub4FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub4FinalTxtBox.Text) <= 100 || sub4FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub4FinalTxtBox.Text) <= 100 || sub4PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub4PrelimTxtBox.Text) <= 100 ||
                  sub4PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub4PrelimTxtBox.Text) <= 100 || sub4MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub4MidtermTxtBox.Text) <= 100 || sub4MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub4MidtermTxtBox.Text) <= 100 ||
                  sub4PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub4PreFinalTxtBox.Text) <= 100 || sub4PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub4PreFinalTxtBox.Text) <= 100)
                {
                    AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                    sub4FGrade.Text = calculateSubAverage(sub4PrelimTxtBox.Text, sub4MidtermTxtBox.Text, sub4PreFinalTxtBox.Text, sub4FinalTxtBox.Text).ToString();

                }
            }
            else
            {
                if (sub4FinalTxtBox.Text.Length == 5 || sub4FinalTxtBox.Text.Length == 3)
                {
                    MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            if (sub4FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub4FinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub5FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub5PrelimTxtBox.Text != string.Empty && sub5MidtermTxtBox.Text != string.Empty && sub5PreFinalTxtBox.Text != string.Empty && sub5FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub5PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub5MidtermTxtBox.Text) <= 100 &&
      Convert.ToDouble(sub5PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub5FinalTxtBox.Text) <= 100)
            {
                if (sub5FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub5FinalTxtBox.Text) <= 100 || sub5FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub5FinalTxtBox.Text) <= 100 || sub5PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub5PrelimTxtBox.Text) <= 100 ||
                  sub5PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub5PrelimTxtBox.Text) <= 100 || sub5MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub5MidtermTxtBox.Text) <= 100 || sub5MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub5MidtermTxtBox.Text) <= 100 ||
                  sub5PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub5PreFinalTxtBox.Text) <= 100 || sub5PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub5PreFinalTxtBox.Text) <= 100)
                {
                    AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                    sub5FGrade.Text = calculateSubAverage(sub5PrelimTxtBox.Text, sub5MidtermTxtBox.Text, sub5PreFinalTxtBox.Text, sub5FinalTxtBox.Text).ToString();

                }
            }
            else
            {
                if (sub5FinalTxtBox.Text.Length == 5 || sub5FinalTxtBox.Text.Length == 3)
                {
                    MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (sub5FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub5FinalTxtBox.Text) > 100)
            {
                calcBtn.Enabled = false;
            }else {

                if(isAllFilled() == true) {
                    calcBtn.Enabled = true;

                }
            }
        }

        private void sub6FinalTxtBox_TextChanged(object sender, EventArgs e)
        {

            if(sub7PrelimTxtBox.Visible == false && sub8PrelimTxtBox.Visible == false && sub9PrelimTxtBox.Visible == false)
            {
                if (sub6PrelimTxtBox.Text != string.Empty && sub6MidtermTxtBox.Text != string.Empty && sub6PreFinalTxtBox.Text != string.Empty && sub6FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub6PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub6MidtermTxtBox.Text) <= 100 &&
     Convert.ToDouble(sub6PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub6FinalTxtBox.Text) <= 100)
                {
                    if (sub6FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6FinalTxtBox.Text) <= 100 || sub6FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6FinalTxtBox.Text) <= 100 || sub6PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6PrelimTxtBox.Text) <= 100 ||
                      sub6PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6PrelimTxtBox.Text) <= 100 || sub6MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6MidtermTxtBox.Text) <= 100 || sub6MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6MidtermTxtBox.Text) <= 100 ||
                      sub6PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6PreFinalTxtBox.Text) <= 100 || sub6PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6PreFinalTxtBox.Text) <= 100)
                    {
                        AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                        sub6FGrade.Text = calculateSubAverage(sub6PrelimTxtBox.Text, sub6MidtermTxtBox.Text, sub6PreFinalTxtBox.Text, sub6FinalTxtBox.Text).ToString();

                    }
                }
                else
                {
                    if (sub6FinalTxtBox.Text.Length == 5 || sub6FinalTxtBox.Text.Length == 3)
                    {
                        MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                if (sub6FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub6FinalTxtBox.Text) > 100)
                {
                    calcBtn.Enabled = false;
                }
                else
                {

                    if (isAllFilled() == true)
                    {
                        calcBtn.Enabled = true;

                    }
                }
            }
            else
            {
                if (sub6PrelimTxtBox.Text != string.Empty && sub6MidtermTxtBox.Text != string.Empty && sub6PreFinalTxtBox.Text != string.Empty && sub6FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub6PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub6MidtermTxtBox.Text) <= 100 &&
     Convert.ToDouble(sub6PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub6FinalTxtBox.Text) <= 100)
                {
                    if (sub6FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6FinalTxtBox.Text) <= 100 || sub6FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6FinalTxtBox.Text) <= 100 || sub6PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6PrelimTxtBox.Text) <= 100 ||
                      sub6PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6PrelimTxtBox.Text) <= 100 || sub6MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6MidtermTxtBox.Text) <= 100 || sub6MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6MidtermTxtBox.Text) <= 100 ||
                      sub6PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub6PreFinalTxtBox.Text) <= 100 || sub6PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub6PreFinalTxtBox.Text) <= 100)
                    {
                        AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                        sub6FGrade.Text = calculateSubAverage(sub6PrelimTxtBox.Text, sub6MidtermTxtBox.Text, sub6PreFinalTxtBox.Text, sub6FinalTxtBox.Text).ToString();

                    }
                }
                else
                {
                    if (sub6FinalTxtBox.Text.Length == 5 || sub6FinalTxtBox.Text.Length == 3)
                    {
                        MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                if (sub6FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub6FinalTxtBox.Text) > 100)
                {
                    calcBtn.Enabled = false;
                }
                else
                {

                    if (isAllFilled() == true)
                    {
                        calcBtn.Enabled = true;

                    }
                }
            }

           
        }

        private void sub7FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(sub7PrelimTxtBox.Visible == true)
            {
                if (sub7PrelimTxtBox.Text != string.Empty && sub7MidtermTxtBox.Text != string.Empty && sub7PreFinalTxtBox.Text != string.Empty && sub7FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub7PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub7MidtermTxtBox.Text) <= 100 &&
     Convert.ToDouble(sub7PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub7FinalTxtBox.Text) <= 100)
                {
                    if (sub7FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub7FinalTxtBox.Text) <= 100 || sub7FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub7FinalTxtBox.Text) <= 100 || sub7PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub7PrelimTxtBox.Text) <= 100 ||
                      sub7PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub7PrelimTxtBox.Text) <= 100 || sub7MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub7MidtermTxtBox.Text) <= 100 || sub7MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub7MidtermTxtBox.Text) <= 100 ||
                      sub7PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub7PreFinalTxtBox.Text) <= 100 || sub7PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub7PreFinalTxtBox.Text) <= 100)
                    {
                        AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                        sub7FGrade.Text = calculateSubAverage(sub7PrelimTxtBox.Text, sub7MidtermTxtBox.Text, sub7PreFinalTxtBox.Text, sub7FinalTxtBox.Text).ToString();

                    }
                }
                else
                {
                    if (sub7FinalTxtBox.Text.Length == 5 || sub7FinalTxtBox.Text.Length == 3)
                    {
                        MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                if (sub7FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub7FinalTxtBox.Text) > 100)
                {
                    calcBtn.Enabled = false;
                }
                else
                {

                    if (isAllFilled() == true)
                    {

                        calcBtn.Enabled = true;
                    }
                }
            }
            else
            {
                if (isAllFilled() == true)
                {
                    calcBtn.Enabled = true;

                }
            }

        }

        private void sub8FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub8PrelimTxtBox.Text != string.Empty && sub8MidtermTxtBox.Text != string.Empty && sub8PreFinalTxtBox.Text != string.Empty && sub8FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub8PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub8MidtermTxtBox.Text) <= 100 &&
    Convert.ToDouble(sub8PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub8FinalTxtBox.Text) <= 100)
            {
                if (sub8FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub8FinalTxtBox.Text) <= 100 || sub8FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub8FinalTxtBox.Text) <= 100 || sub8PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub8PrelimTxtBox.Text) <= 100 ||
                  sub8PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub8PrelimTxtBox.Text) <= 100 || sub8MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub8MidtermTxtBox.Text) <= 100 || sub8MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub8MidtermTxtBox.Text) <= 100 ||
                  sub8PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub8PreFinalTxtBox.Text) <= 100 || sub8PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub8PreFinalTxtBox.Text) <= 100)
                {
                    AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                    sub8FGrade.Text = calculateSubAverage(sub8PrelimTxtBox.Text, sub8MidtermTxtBox.Text, sub8PreFinalTxtBox.Text, sub8FinalTxtBox.Text).ToString();

                }
            }
            else
            {
                if (sub8FinalTxtBox.Text.Length == 5 || sub8FinalTxtBox.Text.Length == 3)
                {
                    MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            if (sub8PrelimTxtBox.Visible == true)
            {
                if (sub8FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub8FinalTxtBox.Text) > 100)
                {
                    calcBtn.Enabled = false;
                }
                else
                {

                    if (isAllFilled() == true)
                    {
                        calcBtn.Enabled = true;

                    }
                }
            }else 
            {
                if (isAllFilled() == true)
                {
                    calcBtn.Enabled = true;

                }
            }

        }

        private void sub9FinalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sub9PrelimTxtBox.Text != string.Empty && sub9MidtermTxtBox.Text != string.Empty && sub9PreFinalTxtBox.Text != string.Empty && sub9FinalTxtBox.Text != string.Empty && Convert.ToDouble(sub9PrelimTxtBox.Text) <= 100 && Convert.ToDouble(sub9MidtermTxtBox.Text) <= 100 &&
  Convert.ToDouble(sub9PreFinalTxtBox.Text) <= 100 && Convert.ToDouble(sub9FinalTxtBox.Text) <= 100)
            {
                if (sub9FinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub9FinalTxtBox.Text) <= 100 || sub9FinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub9FinalTxtBox.Text) <= 100 || sub9PrelimTxtBox.Text.Length >= 5 && Convert.ToDouble(sub9PrelimTxtBox.Text) <= 100 ||
                  sub9PrelimTxtBox.Text.Length >= 3 && Convert.ToDouble(sub9PrelimTxtBox.Text) <= 100 || sub9MidtermTxtBox.Text.Length >= 5 && Convert.ToDouble(sub9MidtermTxtBox.Text) <= 100 || sub9MidtermTxtBox.Text.Length >= 3 && Convert.ToDouble(sub9MidtermTxtBox.Text) <= 100 ||
                  sub9PreFinalTxtBox.Text.Length >= 5 && Convert.ToDouble(sub9PreFinalTxtBox.Text) <= 100 || sub9PreFinalTxtBox.Text.Length >= 3 && Convert.ToDouble(sub9PreFinalTxtBox.Text) <= 100)
                {
                    AutoClosingMessageBox.Show("Prompt", "Loading, Please close wthen its not closed automatically :)", 20, MessageBoxButtons.OK);
                    sub9FGrade.Text = calculateSubAverage(sub9PrelimTxtBox.Text, sub9MidtermTxtBox.Text, sub9PreFinalTxtBox.Text, sub9FinalTxtBox.Text).ToString();

                }
            }
            else
            {
                if (sub9FinalTxtBox.Text.Length == 5 || sub9FinalTxtBox.Text.Length == 3)
                {
                    MessageBox.Show("Invalid Grade Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            if (sub9PrelimTxtBox.Visible == true)
            {
                if (sub9FinalTxtBox.Text == string.Empty || Convert.ToDouble(sub9FinalTxtBox.Text) > 100)
                {
                    calcBtn.Enabled = false;
                }
                else
                {

                    if (isAllFilled() == true)
                    {
                        calcBtn.Enabled = true;
                    }

                }
            }
            else 
            {
                if (isAllFilled() == true)
                {
                    calcBtn.Enabled = true;

                }
            }
        }

        public bool isAllFilled()
        {
            if (sub7PrelimTxtBox.Visible == false && sub8PrelimTxtBox.Visible == false && sub9PrelimTxtBox.Visible == false)
            {
                if (sub1PrelimTxtBox.Text.Length > 0 && sub2PrelimTxtBox.Text.Length > 0 && sub3PrelimTxtBox.Text.Length > 0 &&
            sub4PrelimTxtBox.Text.Length > 0 && sub5PrelimTxtBox.Text.Length > 0 && sub6PrelimTxtBox.Text.Length > 0 &&
            sub1MidtermTxtBox.Text.Length > 0 && sub2MidtermTxtBox.Text.Length > 0 && sub3MidtermTxtBox.Text.Length > 0 &&
            sub4MidtermTxtBox.Text.Length > 0 && sub5MidtermTxtBox.Text.Length > 0 && sub6MidtermTxtBox.Text.Length > 0 &&
            sub1PreFinalTxtBox.Text.Length > 0 && sub2PreFinalTxtBox.Text.Length > 0 && sub3PreFinalTxtBox.Text.Length > 0 &&
            sub4PreFinalTxtBox.Text.Length > 0 && sub5PreFinalTxtBox.Text.Length > 0 && sub6PreFinalTxtBox.Text.Length > 0 &&
            sub1FinalTxtBox.Text.Length > 0 && sub2FinalTxtBox.Text.Length > 0 && sub3FinalTxtBox.Text.Length > 0 &&
            sub4FinalTxtBox.Text.Length > 0 && sub5FinalTxtBox.Text.Length > 0 && sub6FinalTxtBox.Text.Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (sub9PrelimTxtBox.Visible == false)
            {
              
                if (sub1PrelimTxtBox.Text.Length > 0 && sub2PrelimTxtBox.Text.Length > 0 && sub3PrelimTxtBox.Text.Length > 0 &&
             sub4PrelimTxtBox.Text.Length > 0 && sub5PrelimTxtBox.Text.Length > 0 && sub6PrelimTxtBox.Text.Length > 0 &&
             sub7PrelimTxtBox.Text.Length > 0 && sub8PrelimTxtBox.Text.Length > 0 &&
             sub1MidtermTxtBox.Text.Length > 0 && sub2MidtermTxtBox.Text.Length > 0 && sub3MidtermTxtBox.Text.Length > 0 &&
             sub4MidtermTxtBox.Text.Length > 0 && sub5MidtermTxtBox.Text.Length > 0 && sub6MidtermTxtBox.Text.Length > 0 &&
             sub7MidtermTxtBox.Text.Length > 0 && sub8MidtermTxtBox.Text.Length > 0 &&
             sub1PreFinalTxtBox.Text.Length > 0 && sub2PreFinalTxtBox.Text.Length > 0 && sub3PreFinalTxtBox.Text.Length > 0 &&
             sub4PreFinalTxtBox.Text.Length > 0 && sub5PreFinalTxtBox.Text.Length > 0 && sub6PreFinalTxtBox.Text.Length > 0 &&
             sub7PreFinalTxtBox.Text.Length > 0 && sub8PreFinalTxtBox.Text.Length > 0 &&
             sub1FinalTxtBox.Text.Length > 0 && sub2FinalTxtBox.Text.Length > 0 && sub3FinalTxtBox.Text.Length > 0 &&
             sub4FinalTxtBox.Text.Length > 0 && sub5FinalTxtBox.Text.Length > 0 && sub6FinalTxtBox.Text.Length > 0 &&
             sub7FinalTxtBox.Text.Length > 0 && sub8FinalTxtBox.Text.Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
               if (sub1PrelimTxtBox.Text.Length > 0 && sub2PrelimTxtBox.Text.Length > 0 && sub3PrelimTxtBox.Text.Length > 0 &&
               sub4PrelimTxtBox.Text.Length > 0 && sub5PrelimTxtBox.Text.Length > 0 && sub6PrelimTxtBox.Text.Length > 0 &&
               sub7PrelimTxtBox.Text.Length > 0 && sub8PrelimTxtBox.Text.Length > 0 && sub9PrelimTxtBox.Text.Length > 0 &&
               sub1MidtermTxtBox.Text.Length > 0 && sub2MidtermTxtBox.Text.Length > 0 && sub3MidtermTxtBox.Text.Length > 0 &&
               sub4MidtermTxtBox.Text.Length > 0 && sub5MidtermTxtBox.Text.Length > 0 && sub6MidtermTxtBox.Text.Length > 0 &&
               sub7MidtermTxtBox.Text.Length > 0 && sub8MidtermTxtBox.Text.Length > 0 && sub9MidtermTxtBox.Text.Length > 0 &&
               sub1PreFinalTxtBox.Text.Length > 0 && sub2PreFinalTxtBox.Text.Length > 0 && sub3PreFinalTxtBox.Text.Length > 0 &&
               sub4PreFinalTxtBox.Text.Length > 0 && sub5PreFinalTxtBox.Text.Length > 0 && sub6PreFinalTxtBox.Text.Length > 0 &&
               sub7PreFinalTxtBox.Text.Length > 0 && sub8PreFinalTxtBox.Text.Length > 0 && sub9PreFinalTxtBox.Text.Length > 0 &&
               sub1FinalTxtBox.Text.Length > 0 && sub2FinalTxtBox.Text.Length > 0 && sub3FinalTxtBox.Text.Length > 0 &&
               sub4FinalTxtBox.Text.Length > 0 && sub5FinalTxtBox.Text.Length > 0 && sub6FinalTxtBox.Text.Length > 0 &&
               sub7FinalTxtBox.Text.Length > 0 && sub8FinalTxtBox.Text.Length > 0 && sub9FinalTxtBox.Text.Length > 0)
               {
                    return true;
               }else
               {
                    return false;
               }
            }

        }

        public double calculateSubAverage(string sub1, string sub2, string sub3, string sub4)
        {
            double subjectRaw1, subjectRaw2, subjectRaw3, subjectRaw4, subGwa;

            subjectRaw1 = Convert.ToDouble(sub1) * .20;
            subjectRaw2 = Convert.ToDouble(sub2) * .20;
            subjectRaw3 = Convert.ToDouble(sub3) * .20;
            subjectRaw4 = Convert.ToDouble(sub4) * .40;

            subGwa = subjectRaw1 + subjectRaw2 + subjectRaw3 + subjectRaw4;


            if (subGwa >= 97.50)
            {
                return 1.00;

            } else if (subGwa >= 94.50 && subGwa <= 97.49)
            {
                return 1.25;

            } else if (subGwa >= 91.50 && subGwa <= 94.49)
            {
                return 1.50;
            }else if(subGwa >= 88.50 && subGwa <= 91.49)
            {
                return 1.75;
            }else if(subGwa >= 85.50 && subGwa <= 88.49)
            {
                return 2.00;
            }else if(subGwa >= 82.50 && subGwa <= 85.49)
            {
                return 2.25;
            }else if(subGwa >= 79.50 && subGwa <= 82.49)
            {
                return 2.50;
            }else if(subGwa >= 76.50 && subGwa <= 79.49)
            {
                return 2.75;
            }else if(subGwa >= 74.50 && subGwa <= 76.49)
            {
                return 3.00;
            }else
            {
                return 5.00;
            }


        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            double subject1FGrade = 0.0, subject2FGrade = 0.0, subject3FGrade = 0.0, subject4FGrade = 0.0, subject5FGrade = 0.0, subject6FGrade = 0.0, subject7FGrade = 0.0, subject8FGrade = 0.0, subject9FGrade = 0.0;
            subject1FGrade = Convert.ToDouble(sub1FGrade.Text);
            subject2FGrade = Convert.ToDouble(sub2FGrade.Text);
            subject3FGrade = Convert.ToDouble(sub3FGrade.Text);
            subject4FGrade = Convert.ToDouble(sub4FGrade.Text);
            subject5FGrade = Convert.ToDouble(sub5FGrade.Text);
            subject6FGrade = Convert.ToDouble(sub6FGrade.Text);
            subject7FGrade = Convert.ToDouble(sub7FGrade.Text);
            subject8FGrade = Convert.ToDouble(sub8FGrade.Text);
            subject9FGrade = Convert.ToDouble(sub9FGrade.Text);

            if (sub7PrelimTxtBox.Visible == false && sub8PrelimTxtBox.Visible == false && sub9PrelimTxtBox.Visible == false)
            {
                double finalGwa = subject2FGrade + subject3FGrade + subject4FGrade + subject5FGrade + subject6FGrade;
                finalGwa /= 5;
                calculatedGWA.Text = Math.Round(finalGwa, 2).ToString();
            }
            else if(sub9PrelimTxtBox.Visible == false) 
            {
              if(Term.Equals("2Y, 1st Term"))
              {
                    double finalGwa = subject1FGrade + subject2FGrade + subject4FGrade + subject5FGrade + subject6FGrade + subject7FGrade + subject8FGrade;
                    finalGwa /= 7;
                    calculatedGWA.Text = Math.Round(finalGwa,2).ToString();
              }
              else
              {
                    double finalGwa = subject1FGrade + subject2FGrade + subject3FGrade + subject4FGrade + subject5FGrade + subject7FGrade + subject8FGrade;
                    finalGwa /= 7;
                    calculatedGWA.Text = Math.Round(finalGwa, 2).ToString();

                }
            }
            else
            {
                if(Term.Equals("1Y, 1st Term"))
                {
                    double finalGwa = subject1FGrade + subject2FGrade + subject4FGrade + subject5FGrade + subject7FGrade + subject9FGrade;
                    finalGwa /= 6;
                    calculatedGWA.Text = Math.Round(finalGwa, 2).ToString();

                }
                else
                {
                    double finalGwa = subject1FGrade + subject2FGrade + subject4FGrade + subject5FGrade + subject6FGrade + subject7FGrade + subject9FGrade;
                    finalGwa /= 7;
                    calculatedGWA.Text = Math.Round(finalGwa, 2).ToString();
                }
            }
        }
    }
}
