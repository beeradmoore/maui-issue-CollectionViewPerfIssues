using System;
namespace CollectionViewPerfIssues;

public enum TestItemType
{
    CollectionViewStatic50,
    CollectionViewStatic100,
    CollectionViewStatic250,
    ListViewStatic50,
    ListViewStatic100,
    ListViewStatic250,
    CollectionViewDynamic,
    ListViewDynamic,
    CollectionViewTimer,
    ListViewTimer,
}

public class TestItem
{
	public TestItem()
	{

	}
}

