using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rusu_Nicu_Marian_Lab10.Models
async void OnSaveButtonClicked(object sender, EventArgs e)
{
    var slist = (ShopList)BindingContext;
    slist.Date = DateTime.UtcNow;
    await App.Database.SaveShopListAsync(slist);
    await Navigation.PopAsync();
}
async void OnDeleteButtonClicked(object sender, EventArgs e)
{
    var slist = (ShopList)BindingContext;
    await App.Database.DeleteShopListAsync(slist);
    await Navigation.PopAsync();
}