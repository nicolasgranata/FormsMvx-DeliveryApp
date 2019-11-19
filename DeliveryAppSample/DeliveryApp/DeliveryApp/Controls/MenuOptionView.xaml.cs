using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeliveryApp.Forms.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuOptionView : StackLayout
    {
        public MenuOptionView()
        {
            InitializeComponent();
        }

        public string Text
        {
            set
            {
                Label.Text = value;
            }
        }

        public string Source
        {
            set
            {
                Icon.Source = value;
            }
        }
    }
}