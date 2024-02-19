using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewPerfIssues.Pages;

public partial class VirtualListViewDynamicPage : ContentPage
{
	public VirtualListViewDynamicPage()
	{
		InitializeComponent();
		BindingContext = new VirtualListViewDynamicPageModel();
	}
}