using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CRUD_DEMO.ViewModels
{
	public class BookListItemViewModel : BindableBase
	{


		#region ID
		private int iD;
		/// <summary>
		/// PropertyDescription
		/// </summary>
		public int ID
		{
			get { return this.iD; }
			set { this.SetProperty(ref this.iD, value); }
		}
		#endregion


		#region BookName
		private string bookName;
		/// <summary>
		/// PropertyDescription
		/// </summary>
		public string BookName
		{
			get { return this.bookName; }
			set { this.SetProperty(ref this.bookName, value); }
		}
		#endregion



		public BookListItemViewModel()
		{

		}
	}
}
