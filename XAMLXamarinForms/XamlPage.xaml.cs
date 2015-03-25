using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace XAMLXamarinForms
{
	public partial class XamlPage : ContentPage
	{
		public XamlPage ()
		{
			this.LoadFromXaml (typeof(XamlPage));
		}
		async void btn_clicked(object sender, EventArgs args){
			Button button = (Button)sender;
			await DisplayAlert("Clicked!",
				"The button labeled '" + button.Text + "' has been clicked",
				"OK");
		}
	}
}

