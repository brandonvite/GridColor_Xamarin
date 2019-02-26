using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LenguajeXaml
{
    public partial class MainPage : ContentPage
    {
        Random rnd = new Random();
        public MainPage()
        {
            InitializeComponent();
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Color rndColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            var boxColor = sender as BoxView;
            if (boxColor.Color == Color.White)
            {
                boxColor.Color = rndColor;
            }
            else
            {
                boxColor.Color = Color.White;
            }
        }
    }
}
