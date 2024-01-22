
using Microsoft.Maui.Controls;
using System.Diagnostics;
using TodoApp.DataService;
using TodoApp.Models;
using TodoApp.Pages;

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

        protected async void onAppearingAsync( )
        {
            base.OnAppearing();
            collectionview.ItemsSource = await _service.GetAllTodosAsync();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("--- Add Button Clicked ----");

            var NavigationParameter = new Dictionary<string, object>
              {
                  {nameof(Todo), new Todo() }
              };

            await Shell.Current.GoToAsync(nameof(ManageToDo), NavigationParameter);

        }

        private async void collectionview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("==>");

            var NavigationParameter = new Dictionary<string, object>
              {
                    {nameof(Todo), e.CurrentSelection.FirstOrDefault()  as Todo}
              };

            await Shell.Current.GoToAsync(nameof(ManageToDo), NavigationParameter);
        }



        /* public async void ToolbarItem_Clicked_1(object sender, EventArgs e)
          {
              Debug.WriteLine("--- Add Button Clicked ----");

              var NavigationParameter = new Dictionary<string, object>
              {
                  {nameof(Todo), new Todo() }
              };

              await Shell.Current.GoToAsync(nameof(ManageToDo), NavigationParameter);
          }
  */
        /*  private void OnSelectionItem(object sender, SelectionChangedEventArgs e)
          {
              Debug.WriteLine("==>");

              var NavigationParameter = new Dictionary<string, object>
              {
                    {nameof(Todo), e.CurrentSelection.FirstOrDefault()  as Todo}
              };

              await Shell.Current.GoToAsync(nameof(ManageToDo), NavigationParameter);
          }*/



    }
}