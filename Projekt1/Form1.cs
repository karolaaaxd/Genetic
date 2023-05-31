using System;
using System.Windows.Forms;
using Equation_resolving_GA.GaClasses;


namespace Projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void startbutton_Click(object sender, EventArgs e)
        {
            startbutton.Visible = false;
            fill.Visible = false;
            GA x = new GA();
            try
            {
                await x.Start(provideequation.Text, int.Parse(populationsize.Text), int.Parse(maxiteration.Text), float.Parse(mutationrate.Text), float.Parse(crossoverrate.Text), double.Parse(domaina.Text), double.Parse(domainb.Text), selectmethod.SelectedIndex, solutionbox, bestbox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong... (" + ex.Message + ")");
            }
            startbutton.Visible = true;
            fill.Visible = true;
        }

        private void fill_Click(object sender, EventArgs e)
        {
            provideequation.Text = "(x^2)*y+8*x-x*(y^3)+5*y";
            populationsize.Text = "100";
            maxiteration.Text = "1000";
            mutationrate.Text = "0,1";
            crossoverrate.Text = "0,01";
            domaina.Text = "-100";
            domainb.Text = "100";
            selectmethod.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
