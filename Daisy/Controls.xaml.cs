﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daisy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Controls : ContentPage
    {
        public Controls()
        {
            InitializeComponent();

            //Task<string> task = Models.Device.GetDevice();
            //task.Wait();
            //devicepicker.ItemsSource = Models.Device.Name.ToList();
        }

    }
}