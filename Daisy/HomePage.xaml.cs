using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daisy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            dscrp1.Text = "Daisy is a plant management automation platform comprising of three parts." +
                " \n 1. A soil measurement and management device " +
                " \n 2. A reporting server " +
                " \n 3. A mobile application." +
                " \n The device measures plant data and reports it to the log server for display in the application.";
        }
    }
}