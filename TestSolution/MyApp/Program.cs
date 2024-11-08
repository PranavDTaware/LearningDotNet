using MyApp;

int count = 0;
count++;
bool status = false;
string company = "Transflower";
DateTime dateTime = DateTime.Now;

Person prn = new Person();
Person prn2 = new Person("Rohan", "Patil", 35);

prn.Show();
prn2.Show();

Console.WriteLine(company);
Console.WriteLine(count);
Console.WriteLine(dateTime);
Console.WriteLine(status);
Console.WriteLine("Hello, World!");
