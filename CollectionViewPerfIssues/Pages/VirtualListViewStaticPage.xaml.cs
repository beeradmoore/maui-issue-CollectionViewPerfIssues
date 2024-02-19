using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewStaticPage : ContentPage
{
	public VirtualListViewStaticPage(int itemCount)
	{
		InitializeComponent();
		BindingContext = new VirtualListViewStaticPageModel(itemCount);
	}
}