namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        private static List<Contact> _contacts = new List<Contact>()
        {
            new Contact { Id = 0, Name = "John Doe", Email = "john.doe@gmail.com" },
            new Contact { Id = 1, Name = "Jane Doe", Email = "jane.doe@gmail.com" },
            new Contact { Id = 2, Name = "Tom Hanks", Email = "tom.hanks@gmail.com" }
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int id)
        {
            return _contacts[id];
        }
    }
}