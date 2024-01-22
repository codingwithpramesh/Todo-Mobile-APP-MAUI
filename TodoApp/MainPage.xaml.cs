using System.Diagnostics;
using TodoApp.DataService;

namespace TodoApp
{
    public partial class MainPage : ContentPage
    {

        private readonly IRestService _service;
        public MainPage(IRestService service)
        {
            InitializeComponent();
            _service = service;
        }

        protected async Task onAppearingAsync()
        {
            base.OnAppearing();
            //collectionview.ItemSource = await _service.GetAllTodosAsync();
        }

        async void onAddToDoClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("--- Add Button Clicked ----");
        }

        async void OnSelectionChanged(object sender, SelectedItemChangedEventArgs e)
        {
            Debug.WriteLine("==>");
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }
    }
}