namespace CollectionViewPerfIssues;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainPageModel();
    }

    void ListView_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        if (e.Item == null)
        {
            return;
        }

        if (sender is ListView listView)
        {
            listView.SelectedItem = null;
        }

        if (e.Item is TestItemType testItemType)
        {
            /*
            Page page = testItemType switch
            {
                TestItemType.CollectionViewStatic50 => ,
                _ => throw new Exception("TestItemType not handled"),
            };

            Navigation.PushAsync(page);
            */
        }
    }
}


