using System;
namespace CollectionViewPerfIssues.Data;

public enum TestItemType
{
    CollectionViewStatic50,
    CollectionViewStatic100,
    CollectionViewStatic250,
    ListViewStatic50,
    ListViewStatic100,
    ListViewStatic250,
    VirtualListViewStatic50,
    VirtualListViewStatic100,
    VirtualListViewStatic250,
    CollectionViewDynamic,
    ListViewDynamic,
    VirtualListViewDynamic,
    CollectionViewTimer,
    ListViewTimer,
    VirtualListViewTimer,
    CollectionViewDynamicKeepItemsInView,
    CollectionViewDynamicKeepScrollOffset,
    CollectionViewDynamicKeepLastItemInView,
}







