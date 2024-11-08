using MyApp;

int count = 0;
count++;
bool status = false;
string company = "Transflower";
DateTime dateTime = DateTime.Now;

Person prn = new Person();
Person prn2 = new Person("Rohan", "Patil", 35);

Employee emp = new Employee("Aditya", "More", 20, 101, 1000, 4000, 20);
Employee emp2 = new Employee("Ganesh", "Kale", 25, 11, 5000, 8000, 24);


prn.Show();
prn2.Show();

emp.Show();
emp2.Show();

Console.WriteLine(company);
Console.WriteLine(count);
Console.WriteLine(dateTime);
Console.WriteLine(status);
Console.WriteLine("Hello, World!");
