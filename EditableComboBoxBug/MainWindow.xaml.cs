using Microsoft.UI.Xaml;

namespace EditableComboBoxBug;

/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public MainWindowViewModel ViewModel { get; } = new MainWindowViewModel();
}
