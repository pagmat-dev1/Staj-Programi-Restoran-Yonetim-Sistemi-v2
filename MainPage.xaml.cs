using Restoran_Yonetim_Sistemi_v2.Sayfalar;

namespace Restoran_Yonetim_Sistemi_v2
{
    public partial class MainPage : ContentPage
    {
       
       

        public MainPage()
        {
            InitializeComponent();
        }
     

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (username == "admin" && password == "1234")
            {

                await Navigation.PushAsync(new AnaSayfa());

            }
            else
            {

                await DisplayAlert("Uyarı", "Geçersiz kullanıcı adı veya şifre", "Tamam");

            }

        }

       
    }

}
