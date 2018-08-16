using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Numbgen_mobile
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            Erg.Text = "Zufallszahlengenerator. Geben Sie die Zahlen von 1 bis 1000";
            Erg.FontSize = 16;

           
        }
       
    private void Gen6x49_Clicked(object sender, EventArgs e)
        {
            Rand(6, 49);
        }

        private void GenByClick_Clicked (object sender, EventArgs e)
        {
            try
            {
                int lg = Convert.ToInt32(Eing1.Text);
                int kg = Convert.ToInt32(Eing2.Text);

                if (lg == 0 || kg > 1000)
                {
                    Erg.Text = "nur von 1 bis 1000";
                   
                    Erg.FontSize = 16;

                }

                else
                {

                    Rand(lg, kg);
                }
            }
            catch (Exception ex)
            {
                Erg.Text = ex.Message;
             
                Erg.FontSize = 16;
            }
        }

        private void Gen5x50ByClick_Clicked (object sender, EventArgs e)
        {
            Rand(5, 50);
        }

       


        private void Rand(int lg, int kg)
        {
            Random rnd = new Random();

            StringBuilder sb = new StringBuilder();

            if (lg == 5 && kg == 50)
            {
                string[] numbs = new string[lg];

                for (int ctr = 0; ctr < lg; ctr++)
                {
                    numbs[ctr] = rnd.Next(1, kg).ToString();
                }

                foreach (var num in numbs.OrderBy(x => int.Parse(x)))
                {
                    sb.Append(num).Append(" ");
                }

                sb.Append("   ");


                string[] numbs2 = new string[2];

                for (int tr = 0; tr < 2; tr++)
                {
                    numbs2[tr] = rnd.Next(1, 10).ToString();
                }

                foreach (var num in numbs2.OrderBy(x => int.Parse(x))) // zahlen anordnen
                {
                    sb.Append(num).Append(" ");
                }

                string res = sb.ToString();
                Erg.Text = res;
               
            }
            else
            {
                // string array initialesieren
                string[] numbs = new string[lg];
                // befüllen
                for (int ctr = 0; ctr < lg; ctr++)
                {
                    numbs[ctr] = rnd.Next(1, kg).ToString();
                }
                //ausgeben 
                foreach (var num in numbs.OrderBy(x => int.Parse(x)))
                {
                    sb.Append(num).Append(" ");
                }

                string res = sb.ToString();
                Erg.Text = res;
               
            }
        }
    }
}
