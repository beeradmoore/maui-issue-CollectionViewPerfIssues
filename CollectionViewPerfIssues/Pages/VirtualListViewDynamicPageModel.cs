using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Adapters;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewDynamicPageModel : ObservableObject
{
	ObservableCollection<EventItem> eventItems { get; } = new ObservableCollection<EventItem>();

	[ObservableProperty]
	ObservableCollectionAdapter<EventItem> eventItemAdapter;

	public VirtualListViewDynamicPageModel()
	{
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
			}
		}
	}
}