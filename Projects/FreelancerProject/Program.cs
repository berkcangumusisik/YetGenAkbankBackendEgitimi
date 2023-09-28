using FreelancerProject.Entities;
using FreelancerProject.Services;


string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

//Customer customer1 = new Customer()
//{
//    Id = Guid.NewGuid(),
//    CreatedOn = DateTimeOffset.Now,
//    FirstName = "John",
//    LastName = "Doe",
//    PhoneNumber = "0533 333 33 33"
//};

var anotherCustomerInstance = new Customer
{
    Id = Guid.NewGuid(),          
    CreatedOn = DateTime.Now,    
    FirstName = "Bob",
    LastName = "Smith",
    PhoneNumber = "555-123-4567" 
};
NotepadService notepadService = new NotepadService();

string customerData = notepadService.GetOnNotepad($"{path}\\Database\\Customers.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}