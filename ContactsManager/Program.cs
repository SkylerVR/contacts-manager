Dictionary<int, string> myContacts = new Dictionary<int, string>();

myContacts.Add(1, "John Doe");
myContacts.Add(2, "Jane Smith");
myContacts.Add(3, "Michael Johnson");
myContacts.Add(4, "Emily Davis");
myContacts.Add(5, "David Wilson");

Dictionary<int, string> myContactsPhones = new Dictionary<int, string>();

myContactsPhones.Add(1, "123-456-7890");
myContactsPhones.Add(2, "987-654-3210");
myContactsPhones.Add(3, "555-123-4567");
myContactsPhones.Add(4, "111-222-3333");
myContactsPhones.Add(5, "999-888-7777");

while (true)
{
    ShowUserChoice();
    int appState = int.Parse(Console.ReadLine());

    switch (appState)
    {
        case 0:
            Console.Clear();
            ShowContacts(myContacts, myContactsPhones);
            break;

        case 1:
            Console.Clear();
            AddContacts(myContacts, myContactsPhones);
            break;

        case 2:
            Console.Clear();
            EditContacts(myContacts, myContactsPhones);
            break;

        case 3:
            Console.Clear();
            DeleteContact(myContacts, myContactsPhones);
            break;

        default:
            Console.Clear();
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}


static void ShowContacts(Dictionary<int, string> myContacts, Dictionary<int, string> myContactsPhones)
{
    Console.WriteLine("Contacts:");
    var contactKeys = myContacts.Keys.ToList();

    for (int i = 0; i < contactKeys.Count; i++)
    {
        int contactKey = contactKeys[i];
        string contactName = myContacts[contactKey];
        string phoneNumber = myContactsPhones[contactKey];

        Console.WriteLine($"Contact ID: {contactKey}, Name: {contactName}, Phone: {phoneNumber}");
    }
}

static void ShowUserChoice()
{
    Console.WriteLine("Please select an option:");
    Console.WriteLine("  0 - Show Contacts");
    Console.WriteLine("  1 - Add Contacts");
    Console.WriteLine("  2 - Edit Contacts");
    Console.WriteLine("  3 - Delete Contacts");

}


static void AddContacts(Dictionary<int, string> myContacts, Dictionary<int, string> myContactsPhones)
{

    int newContactId = myContacts.Count + 1;

    Console.WriteLine("Enter the contact name:");
    string contactName = Console.ReadLine();

    Console.WriteLine("Enter the contact phone number:");
    string phoneNumber = Console.ReadLine();

    myContacts.Add(newContactId, contactName);
    myContactsPhones.Add(newContactId, phoneNumber);
    
    Console.WriteLine("Contact added successfully!");

}

static void EditContacts(Dictionary<int, string> myContacts, Dictionary<int, string> myContactsPhones)
{
    ShowContacts(myContacts, myContactsPhones);
    Console.WriteLine("Which contact do you want to edit? Enter the contact ID:");
    int contactId = int.Parse(Console.ReadLine());

    if (myContacts.ContainsKey(contactId))
    {
        Console.WriteLine("Enter the new contact name:");
        string newName = Console.ReadLine();

        Console.WriteLine("Enter the new phone number:");
        string newPhoneNumber = Console.ReadLine();

        myContacts[contactId] = newName;
        myContactsPhones[contactId] = newPhoneNumber;

        Console.WriteLine("Contact edited successfully!");
    }
    else
    {
        Console.WriteLine("Contact not found.");
    }
}
static void DeleteContact(Dictionary<int, string> myContacts, Dictionary<int, string> myContactsPhones)
{
    ShowContacts(myContacts, myContactsPhones);
    Console.WriteLine("Which contact do you want to edit? Enter the contact ID:");
    int contactId = int.Parse(Console.ReadLine());

    if (myContacts.ContainsKey(contactId))
    {
        myContacts.Remove(contactId);
        myContactsPhones.Remove(contactId);
        Console.WriteLine("Contact removed successfully!");
    }
    else
    {
        Console.WriteLine("Contact not found.");
    }
}