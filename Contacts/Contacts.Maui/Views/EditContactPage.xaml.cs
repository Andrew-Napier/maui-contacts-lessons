using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
    private Contact _contact;

    public EditContactPage()
    {
        InitializeComponent();
    }

    public string ContactId
    {
        set
        {
            _contact = ContactRepository.GetContactById(int.Parse(value));
            Name.Text = _contact.Name;
        }
    }

    private void Cancel_OnClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}