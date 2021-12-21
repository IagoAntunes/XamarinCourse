using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinCourse.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio : ContentPage
    {
        public Exercicio()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        public static int index=0;
        string[] lista = new string[3]
        {
            "Ola mundo",
            "Hello World",
            "Hola mundo"
        };
        string texto;
        public string Texto
        {
            get { return texto; }
            set
            {
                texto = value;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Texto= lista[index];
            index++;
            if (index > lista.Length-1)
                index = 0;
            OnPropertyChanged(nameof(Texto));
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            label2.TextColor = Color.Red;
        }
        private void Botao_ChangeColor(object sender,EventArgs e)
        {
            label2.TextColor = Color.Blue;
        }
    }
}