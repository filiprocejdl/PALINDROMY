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
        string InputText;
        public MainPage()
        {
            InitializeComponent();
            
           
        }

        void JeToPalindrom()
        {

            
            InputText = Input.Text;

            if (string.IsNullOrEmpty(InputText))
            {
                Result.Text = "Prosím napiště palindrom!";
                Result.TextColor = Color.Red;
                InputText = "";
            } else
            {
                foreach 
            }
        } 

         
        void OnButtonClicked(object sender, EventArgs args)
        {
            JeToPalindrom();
        }
    }
}
