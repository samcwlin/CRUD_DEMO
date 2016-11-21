using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace CRUD_DEMO.ViewModels
{
	public class BookPageViewModel : BindableBase, INavigationAware
	{

		#region Title
		private string _title;
		/// <summary>
		/// Title
		/// </summary>
		public string Title
		{
			get { return this._title; }
			set { this.SetProperty(ref this._title, value); }
		}
		#endregion



		#region Composer
		private string _composer;
		/// <summary>
		/// PropertyDescription
		/// </summary>
		public string Composer
		{
			get { return this._composer; }
			set { this.SetProperty(ref this._composer, value); }
		}
		#endregion


		#region Years
		private int _years;
		/// <summary>
		/// PropertyDescription
		/// </summary>
		public int Years
		{
			get { return this._years; }
			set { this.SetProperty(ref this._years, value); }
		}
		#endregion



		public BookPageViewModel()
		{

		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
		}
	}
}
