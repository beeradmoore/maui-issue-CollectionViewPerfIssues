using System.Collections.ObjectModel;
using CollectionViewPerfIssues.Data;

namespace CollectionViewPerfIssues.Pages;

public class CollectionViewStaticPageModel
{
    public ObservableCollection<EventItem> EventItems { get; } = new ObservableCollection<EventItem>();

    public CollectionViewStaticPageModel(int itemCount)
    {
        for (var i = 0; i < itemCount; ++i)
        {
            EventItems.Add(EventItem.GenerateEventWithRandomMessage());
        }
    }
}