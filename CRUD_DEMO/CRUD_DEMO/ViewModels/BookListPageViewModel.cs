using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CRUD_DEMO.Helps;
using CRUD_DEMO.Model;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;

namespace CRUD_DEMO.ViewModels
{
	public class BookListPageViewModel : BindableBase, INavigationAware
	{

//		public DelegateCommand AddDataCommand;

		public DelegateCommand AddDataCommand => new DelegateCommand(AddData);

		#region myData
		private ObservableCollection<BookListItemViewModel> myData = new ObservableCollection<BookListItemViewModel>();
		/// <summary>
		/// MyItemList
		/// </summary>
		public ObservableCollection<BookListItemViewModel> MyData
		{
			get { return myData; }
			set { SetProperty(ref myData, value); }
		}
		#endregion

		private readonly INavigationService _navigationService;

		public readonly IPageDialogService _dialogService;
		private readonly IEventAggregator _eventAggregator;

		public BookListPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator,
			IPageDialogService dialogService)
		{		
			_navigationService = navigationService;
			_dialogService = dialogService;
			_eventAggregator = eventAggregator;
			AddData();
//			AddDataCommand = new DelegateCommand(AddData);
		}

		private async void AddData()
		{
			var fooPara = new NavigationParameters();
			fooPara.Add("模式", "新增");
			fooPara.Add("AllBooks", new Books {Title = "",Composer = "",Year = null}
			);
			await _navigationService.NavigateAsync("BookPage", fooPara);
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			重新整理資料();
		}


		public void 重新整理資料()
		{
			MyData.Clear();
			foreach (var item in AppData.AllBooks)
			{
				MyData.Add(new BookListItemViewModel
				{
					ID = item.BookID,
					BookName = item.Title,
				});
			}
		}
	}
}
