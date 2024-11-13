using System.Linq;
using Transman.Data.Persons;

namespace Transman.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Oberflaeche kommt noch, Backend geht vor";
 
    //Demo DbContext 
    PersonDbContext? _personDbContext = null!;
    public MainWindowViewModel()
    {
        _personDbContext = App.Current?.Services?.GetService(typeof(PersonDbContext)) as PersonDbContext;
        var personlist = _personDbContext?.Persons.ToList();
    }
}