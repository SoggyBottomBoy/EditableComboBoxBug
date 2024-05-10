using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace EditableComboBoxBug;

public class MainWindowViewModel : ReactiveObject
{
    public MainWindowViewModel()
    {
        this.WhenAnyValue(x => x.SelectedItem1)
            .Select(
                x =>
                    x switch
                    {
                        "Item 1" => new[] { "Item 1" },
                        "Item 2" => new[] { "Item 2" },
                        _ => Array.Empty<string>()
                    }
            )
            .ToPropertyEx(this, x => x.Items2);
    }

    [Reactive]
    public string? SelectedItem1 { get; set; }

    [Reactive]
    public string? SelectedItem2 { get; set; }

    public IReadOnlyList<string> Items1 { get; } = new List<string>() { "Item 1", "Item 2" };

    [ObservableAsProperty]
    public IReadOnlyList<string> Items2 { get; } = Array.Empty<string>();
}
