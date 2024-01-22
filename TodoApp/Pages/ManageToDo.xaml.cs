using TodoApp.DataService;
using TodoApp.Models;

namespace TodoApp.Pages;

[QueryProperty(nameof(todo), "todo")]
public partial class ManageToDo : ContentPage
{
	private readonly IRestService _service;
	Todo _todo;
	bool _isnew;

	public ManageToDo(IRestService service)
	{
		_service = service;
		InitializeComponent();
		BindingContext = this;
	}

    public Todo todo
	{
		get => _todo;
		set
		{
            _isnew = IsNew(value);
			_todo = value;
			OnPropertyChanged();	
		}
	}

    bool IsNew(Todo todo)
	{
		if(todo.Id == 0)
		{
			return true;
		}
	return false;
	}
}