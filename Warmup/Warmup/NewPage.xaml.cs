using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Warmup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}