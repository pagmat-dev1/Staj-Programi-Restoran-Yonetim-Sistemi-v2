namespace Restoran_Yonetim_Sistemi_v2.Sayfalar;

public partial class Masalar : ContentPage
{
	public Masalar()
	{
		InitializeComponent();
	}

   

    private async void masa1_Clicked_1(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Masa1());


    }
}