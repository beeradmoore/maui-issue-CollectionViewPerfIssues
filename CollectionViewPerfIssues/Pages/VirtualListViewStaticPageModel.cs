using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Maui.Adapters;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewStaticPageModel : ObservableObject
{
	ObservableCollection<EventItem> eventItems { get; } = new ObservableCollection<EventItem>();

	[ObservableProperty]
	ObservableCollectionAdapter<EventItem> eventItemAdapter;
	
	public VirtualListViewStaticPageModel(int itemCount)
	{
		EventItemAdapter = new ObservableCollectionAdapter<EventItem>(eventItems);
		
		for (var i = 0; i < itemCount; ++i)
		{
			eventItems.Add(EventItem.GenerateEventWithRandomMessage());
		}
        
	}
}