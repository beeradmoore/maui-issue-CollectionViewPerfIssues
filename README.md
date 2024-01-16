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
- ListViews use `CachingStrategy="RecycleElement"`

# The tests
- Static tests - List/CollectionViews with 50, 100, and 250 items.
- Dynamic tests - List/CollectionViews on a page with buttons that will add 1, 10, 50, or 100 items at once.
- Timer tests - List/CollectionViews which get a new item added every 0.5 sec.
- UpdatingScrollMode tests - Duplicate of the dynamic tests, only has CollectionView. Lets you test how `UpdatingScrollMode`` works between `KeepItemsInView`, `KeepScrollOffset`, and `KeepLastItemInView`

# Possible Improvements
- Some tests use `ObservableCollection` when they don't get any data dynamically added after the constructor is called. So they could just use a list. In my experience this does not solve any of the scrolling performance.
- As some events are inserting multiple, it could be worth re-implementing `ObservableRangeCollection` from [Xamarin.CommunityToolkit](https://github.com/xamarin/XamarinCommunityToolkit/blob/main/src/CommunityToolkit/Xamarin.CommunityToolkit/ObjectModel/ObservableRangeCollection.shared.cs) as it allows adding multiple items while only raising the changed event once. This should have no impact on the static tests, timer tests, or dynamic test where you add 1 item.

# Results

TBM (to be measured)

### iOS 

iPhone 15 Pro Max (iOS 17.2.1)

| Test                                    | Result | Notes |
|-----------------------------------------|--------|-------|
| CollectionViewStatic50                  | ❓     |       |
| CollectionViewStatic100                 | ❓     |       |
| CollectionViewStatic250                 | ❓     |       |
| ListViewStatic50                        | ❓     |       |
| ListViewStatic100                       | ❓     |       |
| ListViewStatic250                       | ❓     |       |
| CollectionViewDynamic                   | ❓     |       |
| ListViewDynamic                         | ❓     |       |
| CollectionViewTimer                     | ❓     |       |
| ListViewTimer                           | ❓     |       |
| CollectionViewDynamicKeepItemsInView    | ❓     |       |
| CollectionViewDynamicKeepScrollOffset   | ❓     |       |
| CollectionViewDynamicKeepLastItemInView | ❓     |       |

### Android

Pixel 2 XL (Android 13)

| Test                                    | Result | Notes |
|-----------------------------------------|--------|-------|
| CollectionViewStatic50                  | ❓     |       |
| CollectionViewStatic100                 | ❓     |       |
| CollectionViewStatic250                 | ❓     |       |
| ListViewStatic50                        | ❓     |       |
| ListViewStatic100                       | ❓     |       |
| ListViewStatic250                       | ❓     |       |
| CollectionViewDynamic                   | ❓     |       |
| ListViewDynamic                         | ❓     |       |
| CollectionViewTimer                     | ❓     |       |
| ListViewTimer                           | ❓     |       |
| CollectionViewDynamicKeepItemsInView    | ❓     |       |
| CollectionViewDynamicKeepScrollOffset   | ❓     |       |
| CollectionViewDynamicKeepLastItemInView | ❓     |       |

### macOS

Late 2018 Mac Mini (macOS 14.2.1, Intel i7 3.2ghz 6C/12T, 32GB RAM, Radeon RX 580)

| Test                                    | Result | Notes |
|-----------------------------------------|--------|-------|
| CollectionViewStatic50                  | ❓     |       |
| CollectionViewStatic100                 | ❓     |       |
| CollectionViewStatic250                 | ❓     |       |
| ListViewStatic50                        | ❓     |       |
| ListViewStatic100                       | ❓     |       |
| ListViewStatic250                       | ❓     |       |
| CollectionViewDynamic                   | ❓     |       |
| ListViewDynamic                         | ❓     |       |
| CollectionViewTimer                     | ❓     |       |
| ListViewTimer                           | ❓     |       |
| CollectionViewDynamicKeepItemsInView    | ❓     |       |
| CollectionViewDynamicKeepScrollOffset   | ❓     |       |
| CollectionViewDynamicKeepLastItemInView | ❓     |       |

### Windows  

Desktop (Window 11 23H2, AMD Ryzen 3 3300X, 32 GB RAM, NVIDIA RTX 3060)

| Test                                    | Result | Notes |
|-----------------------------------------|--------|-------|
| CollectionViewStatic50                  | ❓     |       |
| CollectionViewStatic100                 | ❓     |       |
| CollectionViewStatic250                 | ❓     |       |
| ListViewStatic50                        | ❓     |       |
| ListViewStatic100                       | ❓     |       |
| ListViewStatic250                       | ❓     |       |
| CollectionViewDynamic                   | ❓     |       |
| ListViewDynamic                         | ❓     |       |
| CollectionViewTimer                     | ❓     |       |
| ListViewTimer                           | ❓     |       |
| CollectionViewDynamicKeepItemsInView    | ❓     |       |
| CollectionViewDynamicKeepScrollOffset   | ❓     |       |
| CollectionViewDynamicKeepLastItemInView | ❓     |       |