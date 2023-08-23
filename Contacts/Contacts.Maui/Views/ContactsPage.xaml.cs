using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        var contacts = ContactRepository.GetContacts();
        listContacts.ItemsSource = contacts;
    }

    private void ListContacts_OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        System.Console.WriteLine("On tapped...");
    }

    private async void ListContacts_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (listContacts.SelectedItem is null) return;

        System.Diagnostics.Debug.WriteLine((e.SelectedItem as Contact).Email);
        await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)listContacts.SelectedItem).Id}");

        listContacts.SelectedItem = null;
    }
}