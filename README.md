# dotnet MAUI - CollectionView performance issues

Test repo for looking at CollectionView performance issues. While it does show some performance issues, it also shows some usability issues when using CollectionViews in general.

Any and all performance suggestions are more than welcome as an issue or as a pull request.

# What is inside this application:
- This uses compiled bindings where possible.
- In places where it makes sense this uses `ObservableObject`, `RelayCommand` and `ObservablePropety` from `CommunityToolkit.MVVM`.
- Each test (where possible) is duplicated as a ListView and a CollectionView for comparison.
- Each tests only ever adds to the end, it never inserts elsewhere.
- Each row displayed in the List/CollectionViews has its height set to 40 to try avoid row height measurement performance.
- Each row displayed in the List/CollectionViews is a Grid with 3 columns which are sized 100,100,*.
- Each `EventItem` which is the row only displays 3 strings. Originally I was using a string formatter to convert DateTime to a string in the xaml but as a performance constraint I do that in the constructor.

# The tests
- Static tests - List/CollectionViews with 50, 100, and 250 items.
- Dynamic tests - List/CollectionViews on a page with buttons that will add 1, 10, 50, or 100 items at once.
- Timer tests - List/CollectionViews which get a new item added every 0.5 sec.
- UpdatingScrollMode tests - Duplicate of the dynamic tests, only has CollectionView. Lets you test how `UpdatingScrollMode`` works between `KeepItemsInView`, `KeepScrollOffset`, and `KeepLastItemInView`

# Possible Improvements
- Some tests use `ObservableCollection` when they don't get any data dynamically added after the constructor is called. So they could just use a list. In my experience this does not solve any of the scrolling performance.

# Results
TBM (to be measured)