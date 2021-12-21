using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        [Obsolete]
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.0;

            Padding = Device.OnPlatform(
                iOS: new Thickness(0,20,0,0),
                Android: new Thickness(10, 20, 0, 0),
                WinPhone: new Thickness(30,20,0,0)
            );

        }

        //private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = String.Format("O novo valor é {0:F2}",e.NewValue);
        //}
    }
}