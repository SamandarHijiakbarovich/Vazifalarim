using Linq_Asoslari.Models;

IList<User> users = new List<User>()
{
    new User(){Id = 1,FirstName="Samandar",LastName="Mamasoatov",Age=19,CarId=4,PhonNumber="937650083"},
    new User(){Id = 2,FirstName="Sardor",LastName="Mamasoatov",Age=18,CarId=3,PhonNumber="931072383"},
    new User(){Id = 2,FirstName="Sanjar",LastName="soatov",Age=14,CarId=3,PhonNumber="942647610"},

};
//var result = users.OrderBy(x=>x.LastName).ThenBy(p=>p.FirstName).ThenBy(p=>p.Age).ToList();
//result.ForEach(d => Console.WriteLine($"{d.LastName}|{d.FirstName}|{d.Age}"));

//var result =users.GroupBy(p=>p.PhonNumber).Select(p=>p.First()).ToList();
//result.ForEach(p=>Console.WriteLine(p.LastName));

var natija = users.Distinct().ToList();
natija.ForEach(x=>Console.WriteLine(x.FirstName));  