using CollectionViewPerfIssues.Data;
using CollectionViewPerfIssues.Pages;

namespace CollectionViewPerfIssues;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainPageModel();
    }

    void ListView_ItemTapped(Object sender, ItemTappedEventArgs e)
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
            Page page = testItemType switch
            {
                TestItemType.CollectionViewStatic50 => new CollectionViewStaticPage(50),
                TestItemType.CollectionViewStatic100 => new CollectionViewStaticPage(100),
                TestItemType.CollectionViewStatic250 => new CollectionViewStaticPage(250),
                TestItemType.ListViewStatic50 => new ListViewStaticPage(50),
                TestItemType.ListViewStatic100 => new ListViewStaticPage(100),
                TestItemType.ListViewStatic250 => new ListViewStaticPage(250),
                TestItemType.VirtualListViewStatic50 => new VirtualListViewStaticPage(50),
                TestItemType.VirtualListViewStatic100 => new VirtualListViewStaticPage(100),
                TestItemType.VirtualListViewStatic250 => new VirtualListViewStaticPage(250),
                TestItemType.CollectionViewDynamic => new CollectionViewDynamicPage(),
                TestItemType.ListViewDynamic => new ListViewDynamicPage(),
                TestItemType.VirtualListViewDynamic => new VirtualListViewDynamicPage(),
                TestItemType.CollectionViewTimer => new CollectionViewTimerPage(),
                TestItemType.ListViewTimer => new ListViewTimerPage(),
                TestItemType.VirtualListViewTimer => new VirtualListViewTimerPage(),
                TestItemType.CollectionViewDynamicKeepItemsInView => new CollectionViewDynamicUpdatingScrollModePage(ItemsUpdatingScrollMode.KeepItemsInView),
                TestItemType.CollectionViewDynamicKeepScrollOffset => new CollectionViewDynamicUpdatingScrollModePage(ItemsUpdatingScrollMode.KeepScrollOffset),
                TestItemType.CollectionViewDynamicKeepLastItemInView => new CollectionViewDynamicUpdatingScrollModePage(ItemsUpdatingScrollMode.KeepLastItemInView),
                _ => throw new Exception("TestItemType not handled"),
            };

            Navigation.PushAsync(page);
        }
    }
}


