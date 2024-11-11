using Avalonia.Controls;

namespace Transman.Extensions.DependencyInjection.Controls;

public class DIUserControl : UserControl, IInjectable {
    protected DIUserControl() {
        this.Inject();
    }
}