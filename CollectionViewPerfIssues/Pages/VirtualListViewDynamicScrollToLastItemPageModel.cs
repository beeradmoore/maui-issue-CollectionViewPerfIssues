using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Adapters;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewDynamicScrollToLastItemPageModel : ObservableObject
{
	ObservableCollection<EventItem> eventItems { get; } = new ObservableCollection<EventItem>();

	[ObservableProperty]
	ObservableCollectionAdapter<EventItem> eventItemAdapter;

	WeakReference<VirtualListViewDynamicScrollToLastItemPage> weakPage;

	public VirtualListViewDynamicScrollToLastItemPageModel(VirtualListViewDynamicScrollToLastItemPage page)
	{
		weakPage = new WeakReference<VirtualListViewDynamicScrollToLastItemPage>(page);
		EventItemAdapter = new ObservableCollectionAdapter<EventItem>(eventItems);
	}
	
	[RelayCommand]
	void AddEvents(string itemCountString)
	{
		if (Int32.TryParse(itemCountString, out int itemCount) == true)
		{
			for (var i = 0; i < itemCount; ++i)
			{
				eventItems.Add(EventItem.GenerateEventWithRandomMessage());

				// If the last item
				if (i == itemCount - 1)
				{
					if (weakPage.TryGetTarget(out VirtualListViewDynamicScrollToLastItemPage? page) == true)
					{
						page.ThePublicVirtualListView.ScrollToItem(new ItemPosition(0, eventItems.Count - 1), true);
					}
				}
			}
		}
	}
}