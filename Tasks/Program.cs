using System.ComponentModel;
using System.Threading.Tasks;

#region Task example kod 1

var task1 = new Task(Ertalab_turish);
var task2 = new Task(Yuvinish);
var task3 = new Task(Badan_tarbiya);
var task4 = new Task(Nonushtaga);
var task5 = new Task(Yeyish);

task2.Start();
task1.Start();
task2.Wait(TimeSpan.FromSeconds(3));
task3.Start();
task3.Wait(TimeSpan.FromSeconds(5));
task5.Start();
task5.Wait(TimeSpan.FromSeconds(10));
task4.Start();
//task4.Wait(5);

Console.ReadKey();

static void Ertalab_turish()
{
    Console.WriteLine("1-ishlaydigan method");
    Console.WriteLine("uyqudan turdim");
    
}
static  void Yuvinish()
{
    Task.Delay(TimeSpan.FromSeconds(5)).Wait();

    Console.WriteLine("2-ishlaydigan method\nYuzimni yuvdim");
    Console.WriteLine("tishimni yuvdim");



}

static void Badan_tarbiya()
{
    Task.Delay(TimeSpan.FromSeconds(5)).Wait();

    Console.WriteLine("3-ishlaydigan method\nYugurish ketdim ");
    Console.WriteLine("Turnik tortindim");
    Console.WriteLine("Mashiqlar qildim");

}
static void Nonushtaga()
{
    //Task.Delay(TimeSpan.FromSeconds(10)).Wait();
    
    Console.WriteLine("4-ishlaydigan method\ndasturxon yozdim");
    Console.WriteLine("Non qo'ydim");
    Console.WriteLine("Nonushta tayorladim");
    Console.WriteLine("Nonushtaga o'tirdim ");

    

}
static void Yeyish()
{

    Task.Delay(TimeSpan.FromSeconds(15)).Wait();
    Console.WriteLine("5-ishlaydigan method\nchoy ichdim ");
    Console.WriteLine("tuxum yedim ");
    Console.WriteLine("qolgan narsalarni xam yedim ");

    Task.Delay(TimeSpan.FromSeconds(30)).Wait();
}

#endregion

#region Start methodi
/*
Task t = new Task(() =>
{
    Console.WriteLine("Task bajarilyabdi....");
});

t.Start();
t.Wait(TimeSpan.FromSeconds(20));
//Console.Read();
*/
#endregion

#region Asinxron amalni yozish
/*
Task<int> task = (Task<int>)Task.Run(() =>
{
    int sum = 0;
    for (int i = 0; i <= 10; i++)
    {
        sum += i;
    }
   
    return sum;
});
task.Wait(TimeSpan.FromSeconds(10));
int result=task.Result;
Console.WriteLine(result);
*/

#endregion

/*Task<int> task = Task.Run(() =>
{
    int sum = 0;
    for (int i = 0; i <=9; i++)
    {
        sum += i;
    }
    return sum;
});

Console.WriteLine(task.Result);*/




