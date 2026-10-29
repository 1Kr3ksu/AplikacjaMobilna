using System.Collections.ObjectModel;

namespace AplikacjaMobilna;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Note> Notes { get; } = new();

    public MainPage()
    {
          Notes.Add(new Note(
        "Zima",
        "Gra z Ewą w poniedziałek",
        false));

    InitializeComponent();
    BindingContext = this;
        
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TytulEntry.Text) ||
            string.IsNullOrWhiteSpace(TrescEditor.Text))
        {
            return;
        }

        Notes.Add(new Note(
            TytulEntry.Text,
            TrescEditor.Text,
            false));

        TytulEntry.Text = string.Empty;
        TrescEditor.Text = string.Empty;
    }
}