using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using Transman.Persons;

namespace Transman.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

    //Demo DbContext 
    PersonDbContext? _personDbContext = null!;

    public MainWindowViewModel()
    {
        _personDbContext = App.Current?.Services?.GetService(typeof(PersonDbContext)) as PersonDbContext;
        var personlist = _personDbContext?.Persons.ToList();

        TriggerPaneCommand = ReactiveCommand.Create(TriggerPane);
    }

    public ICommand TriggerPaneCommand { get; }

    private bool _isPaneOpen;

    public bool IsPaneOpen
    {
        get => _isPaneOpen;
        set => this.RaiseAndSetIfChanged(ref _isPaneOpen, value);
    }

    private Task TriggerPane()
    {
        IsPaneOpen = !IsPaneOpen;
        return Task.CompletedTask;
    }
}