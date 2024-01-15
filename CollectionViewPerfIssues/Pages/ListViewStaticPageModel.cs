using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;

namespace CollectionViewPerfIssues.Pages;

public class ListViewStaticPageModel
{
    public ObservableCollection<EventItem> EventItems { get; } = new ObservableCollection<EventItem>();

    public ListViewStaticPageModel(int itemCount)
    {
        for (var i = 0; i < itemCount; ++i)
        {
            EventItems.Add(EventItem.GenerateEventWithRandomMessage());
        }
        
    }
}