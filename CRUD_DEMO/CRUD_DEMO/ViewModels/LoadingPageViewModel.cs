using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_DEMO.Helps;
using Prism.Navigation;

namespace CRUD_DEMO.ViewModels
{
	public class LoadingPageViewModel :BindableBase,INavigationAware
	{
		private readonly INavigationService _navigationService;
	public LoadingPageViewModel(INavigationService navigationService)
	{
		_navigationService = navigationService;
	}

	public void OnNavigatedFrom(NavigationParameters parameters)
	{

	}

	public async void OnNavigatedTo(NavigationParameters parameters)
	{
		var fooItems = (await AppData.DataService.GetTravelExpensesAsync()).ToList();
			AppData.AllBooks = fooItems;
		await _navigationService.NavigateAsync("xf:///NaviPage/BookListPage");
	}
}
}
