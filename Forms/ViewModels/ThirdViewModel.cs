using System.Diagnostics;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace XFdemo
{
	public class ThirdViewModel : BaseViewModel
	{
		public ICommand RefreshCommand { get; set; }
		public ICommand ButtonClickCommand { get; set; }

		public ObservableCollection<ToDoItem> TodoItems { get; set; }

		bool _isRefreshing;
		public bool IsRefreshing {
			get {
				return _isRefreshing;
			}
			set {
				if (_isRefreshing != value) {
					_isRefreshing = value;
					RaisePropertyChanged ();
				}
			}
		}

		ToDoItem _selectedTodoItem;
		public ToDoItem SelectedTodoItem {
			get {
				return _selectedTodoItem;
			}
			set {
				if (_selectedTodoItem != value) {
					_selectedTodoItem = value;

					RaisePropertyChanged ();
					HandleItemSelected (_selectedTodoItem);
				}
			}
		}

		public ThirdViewModel ()
		{
			TodoItems = new ObservableCollection<ToDoItem> { 
				new ToDoItem { Name = "Afwas", 				Description = "Witte was doen" },
				new ToDoItem { Name = "Stofzuigen", 		Description = "Slaapkamers stofzuigen" },
				new ToDoItem { Name = "Olie pijlen", 		Description = "Olie pijlen van auto" },
				new ToDoItem { Name = "Rekeningen betalen", Description = "Openstaande rekeningen betalen" },
				new ToDoItem { Name = "Cadeau kopen", 		Description = "Verjaardagscadeau kopen voor Pietje" }
			};

			RefreshCommand = new Command (() => {
				TodoItems.Add (new ToDoItem { Name = "Pull to refresh item", Description = "Demo item"});
				IsRefreshing = false;
			});

			ButtonClickCommand = new Command (() => {
				TodoItems.Add (new ToDoItem { Name = "Button clicked item", Description = "Demo item"});
			});
		}

		public void HandleItemSelected(ToDoItem selectedTodoItem)
		{
			Debug.WriteLine (selectedTodoItem.Name + " clicked");
		}
	}
}