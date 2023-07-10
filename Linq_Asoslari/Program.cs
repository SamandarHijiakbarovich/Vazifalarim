using Linq_Asoslari.Models;

IList<User> users = new List<User>()
{
    new User(){Id = 1,FirstName="Samandar",LastName="Mamasoatov",Age=19,CarId="8600312970015588",PhonNumber="937650083"},
    new User(){Id = 2,FirstName="Sardor",LastName="Bekmurodov",Age=18,CarId="8600312967548909",PhonNumber="931072383"},
    new User(){Id = 3,FirstName="Sanjar",LastName="Soatov",Age=14,CarId="8600312956431200",PhonNumber="942647610"},
    new User(){Id = 3,FirstName="Sanjar",LastName="Soatov",Age=14,CarId="8600312956431200",PhonNumber="942647610"},
    new User(){Id = 4,FirstName="Abror",LastName="Allaberdiyev",Age=14,CarId="8600312955443322",PhonNumber="934568787"},
    new User(){Id = 5,FirstName="Omadbek",LastName="Davlatov",Age=14,CarId="8600312966437899",PhonNumber="942341013"},
    new User(){Id = 6,FirstName="Omadbek",LastName="Davlatov",Age=14,CarId="8600312966437899",PhonNumber="942341013"},

};

IList<Car> cars = new List<Car>()
{
    new Car(){Id=1,Marka="Chevrolet",Model="nexia 1",Color="qora"},
    new Car(){Id=2,Marka="Chevrolet",Model="matiz",Color="qizil"},
    new Car(){Id=3,Marka="Chevrolet",Model="spark",Color="sariq"},
    new Car(){Id=4,Marka="Chevrolet",Model="malibu",Color="oq"},
    new Car(){Id=5,Marka="Chevrolet",Model="nexia 2",Color="kul rang"},
    new Car(){Id=6,Marka="Chevrolet",Model="nexia 3",Color="pushti"},
};
// where methodi shart bajarilgandagi elementlarimizni bitta list qilib qaytaradi
//var result = users.Where(x => x.Id >= 3).ToList();
//result.ForEach(d => Console.WriteLine($"FirstName {d.FirstName}    |Lastname {d.LastName}  |Age {d.Age}  |Card number {d.CarId}|Phon Number {d.PhonNumber}"));



// Take bu element olib beradi
//var result =users.Take(4).ToList();
//result.ForEach(x => Console.WriteLine(x.Age));


// Distinct() methodi bu to'plamdagi elementdan hammasidan bittadan olib yangi list qilib qaytaradi
//var result = users.Distinct().ToList();
//result.ForEach(x => Console.WriteLine(x.FirstName));
//foreach(var user in result)
//{
//    Console.WriteLine($"ismi {user.FirstName } Carta raqami {user.CarId}");
//}




//DistinctBy() methodi 
//var result=users.DistinctBy(x=>x.CarId).ToList();





// Thenby methodi bir nechta maydonlarda saralash uchun ishlatiladi
// OrderBy methodi bu belgilangan maydon asosida to'plamni o'sish tartibida tartibida tartiblaydi
// To'plamni boshqa maydonda o'sish tartibida tartiblash uchun OrderBy dan keyin ThenBy methoddan foydalanish kerak

//var result = users.OrderBy(x => x.LastName).ThenBy(p => p.FirstName).ThenBy(p => p.Age).ToList();
//result.ForEach(d => Console.WriteLine($"{d.LastName}|{d.FirstName}|{d.Age}"));



// Grupby methodi bu key valu qiymatga asoslangan eleementlar guruhini qaytaradi

//var result = users.GroupBy(p => p.PhonNumber).Select(p => p.First()).ToList();
//result.ForEach(p => Console.WriteLine(p.LastName));




// ofType() methodi
//var resultString = from s in users.OfType<string>().ToList()
//                   select s;
//var intResult = from s in users.OfType<int>().ToList()
//                select s;

//foreach(var user in resultString)
//{
//    Console.WriteLine(user);
//}

//Console.WriteLine(intResult.ToString());
//Console.WriteLine(resultString.ToString());




//Join methodi kalit asosida ikkita to'plamni birlashtiradi

//var innerjoin = users.Join(cars,
//    user=>user.FirstName,
//    car=>car.Model,
//    (user,car)=>user).ToList();

//innerjoin.ForEach(x => Console.WriteLine(x.FirstName));


// grupjoin methodi join methodi bilan bir xil
//var groupJoin = users.GroupJoin(cars,  //inner sequence
//                                std => std.Id, //outerKeySelector 
//                                s => s.Model,     //innerKeySelector
//                                (std, studentsGroup) => new // resultSelector 
//                                {
//                                    users = studentsGroup,
//                                    StandarFulldName = std.FirstName
//                                });

//foreach (var item in groupJoin)
//{
//    Console.WriteLine(item.StandarFulldName);

//    foreach (var stud in item.Students)
//        Console.WriteLine(stud.StudentName);
//}







