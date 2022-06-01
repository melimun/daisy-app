using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Daisy
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            flyout.listview.ItemSelected += OnSelectedItem;
            //This line will add the item selectedevent
        }

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyoutItemPage; 
            //This line will cast the selected item as an Item class

            if (item!=null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                //It will get it's Target property and cast it as a New Navigation Page
                flyout.listview.SelectedItem = null;
                //Resets the item selection
                IsPresented = false;
                //Will hide the flyout menu after selection is done
            }
        }
    }
}
