using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ButtonClick
{
    public partial class MainPage : ContentPage
    {
        Random random;
        String [] Phrases = { "You were born yourself, now help the others.",
                    "There’s good climate in heaven, but a better company in hell.",
                    "There are lots of good people, but much less of useful ones.",
                    "Cleavage – is an art of being naked so that you’re still dressed up.",
                    "Everyone has a conscience: it doesn’t matter if he wants it or not.",
                    "There is no point of running away form a sniper. You will die from exhaustion."};
        public MainPage()
        {
            InitializeComponent();
            random = new Random();

        }
        void NewPhrase(object sender, EventArgs e)
        {
            
            int randomNumber = random.Next(0, 6);
            LabelText.Text = Phrases[randomNumber];
        }
    }
}
