

using Business.Concrete;
using Entities.Concrete;

SelamVer("Deli");
Topla(4,2);


//Arrays ...
string [] students = new string[3];
students[0] = "Deli";
students[1] = "Veli";
students[2] = "Zeki";

foreach (string student in students)
{
    Console.WriteLine(student);
}


List<string> cities = new List<string> { "Ankara", "Istanbul","Izmir"};
cities.Add("Adana");

foreach (string city in cities)
{
    Console.WriteLine(city);
}

static void SelamVer(string name)
{
    Console.WriteLine("hello " + name);
}


static int Topla(int a, int b)
{

    int result = a + b;
    Console.WriteLine(result);
    return result;
}

Citizen citizen1 = new Citizen();   
citizen1.FirstName  = "Engin";
citizen1.LastName = "Demirog";
citizen1.NationalIdentity = 123456789010;
citizen1.DateOfBirthYear = 1985;



PttManager pttManager = new PttManager(new CitizenManager());
pttManager.GiveMask(citizen1);

