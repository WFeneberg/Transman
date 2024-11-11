using Avalonia.Controls;

namespace Transman.Extensions.DependencyInjection.Controls;

public class DIWindow : Window, IInjectable {
    protected DIWindow() {
        this.Inject();
    }
}