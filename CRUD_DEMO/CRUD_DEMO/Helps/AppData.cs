using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_DEMO.Model;
using CRUD_DEMO.Services;

namespace CRUD_DEMO.Helps
{
	class AppData
	{
		public static string AllBooksUrl { get; set; } = "http://demo.ptrd.us/api/BooksAPI";

		public static List<Books> AllBooks = new List<Books>();
		public static DataService DataService = new DataService();
		//		public static List<TravelExpense> AllTravelExpense = new List<TravelExpense>();
		//		public static List<TravelExpensesCategory> AllTravelExpensesCategory = new List<TravelExpensesCategory>();
	}
}
