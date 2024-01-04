namespace Restoran_Yonetim_Sistemi_v2.Sayfalar;

public partial class AnaSayfa : ContentPage
{
	public AnaSayfa()
	{
		InitializeComponent();
	}

    private async void btn_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Hakkimizda());


    }

    private async void masalar_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Masalar());

    }
}