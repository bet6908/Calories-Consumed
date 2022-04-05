namespace Calories_Consumed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double FatCalories(double fatGrams)
        {
            return fatGrams * 9;
        }
        private double CarbCalories(double carbGrams)
        {
            return carbGrams * 9;
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double calFromfat, fatGrams, calFromCarbs, carbGrams;

            if (double.TryParse(txt_fat.Text, out fatGrams))
            {
                calFromfat = fatGrams * 9;
                lbl_fat.Text = calFromfat.ToString("n1");
            }
            else
            {
                MessageBox.Show("Enter a valid number for Fat grams.");
            }

            if (double.TryParse(txt_carbs.Text, out carbGrams))
            {
                calFromCarbs = carbGrams * 4;
                lbl_carbs.Text = calFromCarbs.ToString("n1");
            }

            else
            {
                MessageBox.Show("Enter a valid number for Carbs grams.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fat.Text = "";
            txt_carbs.Text = "";
            lbl_carbs.Text = "";
            lbl_fat.Text = "";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}