using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewDynamicScrollToLastItemPage : ContentPage
{
	public VirtualListView ThePublicVirtualListView => TheVirtualListView;
	public VirtualListViewDynamicScrollToLastItemPage()
	{
		InitializeComponent();
		BindingContext = new VirtualListViewDynamicScrollToLastItemPageModel(this);
	}
}