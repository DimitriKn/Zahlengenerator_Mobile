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
            Erg.Text = "Willkommen! Das ist ein Zufallszahlengenerator. Geben Sie die Zahlen von 1 bis 1000";
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
                    Erg.Text = "Es sind die Zahlen nur von 1 bis 1000 erlaubt";


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
                string[] numbs = new string[lg * 2];

                for (int ctr = 0; ctr < lg * 2; ctr++)
                {
                    numbs[ctr] = rnd.Next(1, kg).ToString();
                }

                // identische Zahlen entfernen

                numbs = numbs.Distinct().ToArray();


                foreach (var num in numbs.OrderBy(x => int.Parse(x)).Take(lg))
                {
                    sb.Append(num).Append(" ");
                }

                sb.Append("   ");


                string[] numbs2 = new string[4];



                for (int tr = 0; tr < 4; tr++)
                {
                    numbs2[tr] = rnd.Next(1, 10).ToString();
                }

                numbs2 = numbs2.Distinct().ToArray();

                foreach (var num in numbs2.OrderBy(x => int.Parse(x)).Take(2)) // zahlen anordnen
                {
                    sb.Append(num).Append(" ");
                }

                string res = sb.ToString();
                Erg.Text = res;
               
            }
            else
            {
                // string array initialisieren

                string[] numbs = new string[lg * 2];

                // befüllen

                for (int ctr = 0; ctr < lg * 2; ctr++)
                {
                    numbs[ctr] = rnd.Next(1, kg).ToString();
                }

                // identische Zahlen entfernen

                numbs = numbs.Distinct().ToArray();

                //ausgeben 

                foreach (var num in numbs.OrderBy(x => int.Parse(x)).Take(lg))
                {
                    sb.Append(num).Append(" ");

                }

                string res = sb.ToString();
                Erg.Text = res;
               
            }
        }
    }
}
