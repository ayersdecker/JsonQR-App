using Newtonsoft.Json;

namespace WifiScan;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		QR.Barcode = JsonConvert.SerializeObject(new WifiCode(UIDText.Text, NameText.Text, PWText.Text));
    }
}

