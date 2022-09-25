namespace MauiTutorial2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnSubscriptionsClicked(object sender, EventArgs e)
	{
        var url = string.Empty;
        var sku = "sku";
        if (DeviceInfo.Platform == DevicePlatform.iOS)
        {
            url = "https://support.apple.com/HT202039";
        }
        else if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            if (string.IsNullOrWhiteSpace(sku))
            {
                url = "https://play.google.com/store/account/subscriptions";
            }
            else
            {
                url = $"https://play.google.com/store/account/subscriptions?sku={sku}&package={AppInfo.PackageName}";
            }
        }

        if (string.IsNullOrWhiteSpace(url))
            return;

        await Browser.OpenAsync(url);
    }
}

