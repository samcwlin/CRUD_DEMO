using Prism.Unity;
using CRUD_DEMO.Views;

namespace CRUD_DEMO
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("LoadingPage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MainPage>();

			Container.RegisterTypeForNavigation<LoadingPage>();
			Container.RegisterTypeForNavigation<BookListPage>();
			Container.RegisterTypeForNavigation<NaviPage>();
			Container.RegisterTypeForNavigation<BookPage>();
		}
	}
}
