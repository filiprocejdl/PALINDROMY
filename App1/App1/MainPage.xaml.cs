using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
           
        }

       

        private void OnButtonClicked(object sender, EventArgs e)
        {
            string text = Input.Text;
            

            if (string.IsNullOrEmpty(text))
            {
                Result.Text = "Zadejte slovo!";
                Result.TextColor = Color.Red;
            } else
            {
                text = text.Replace(" ", "");
                if (JeToPalindrom(text))
                {
                    Result.Text = "Text je palindrom!";
                    Result.TextColor = Color.Blue;
                }
                else
                {
                    Result.Text = "Zadaný text není palindrom!";
                    Result.TextColor = Color.Red;
                }
            }
            
           
        }

        private bool JeToPalindrom(string text)
        {
            List<string> nwm = new List<string>();
            int y = 0;
            foreach (char char1 in text)
            {
                nwm.Add(text[y].ToString());    
                y++;
            }

            for (int x = 0; x < nwm.Count; x++)
            {
                if (nwm[x].ToLower() == "c" && x < nwm.Count)
                {
                    if (nwm[x + 1].ToLower() == "h")
                    {
                        nwm[x] = "ch";
                        nwm.RemoveAt(x + 1);
                    }
                }
            }

            for (int i = 0; i < nwm.Count; i++)
            {
                if ((nwm[i].ToLower()) == (nwm[nwm.Count - 1 - i].ToLower()))
                {
                    if (i == nwm.Count - 1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            };
            return false;
        }
    }


    
}
