// 2 ta butun songa ega Tuple toifasidan iborat to'plam berilgan.ularni tartib bo'yicha 
// bitta son sifatida satrga joylashtiring


/*Tuple<int,int>[] array = new Tuple<int,int>[3];

for(int i=0;i<3;i++)
{
    int s1 = int.Parse(Console.ReadLine());
    int s2 = int.Parse(Console.ReadLine());
    array[i]=new Tuple<int,int>(s1,s2);
}
string result = string.Empty;

int[] arr = new int[array.Length * 2];
//Array.Sort(array);


foreach(Tuple<int,int> t in array)
{
    result += t.Item1;
    result += t.Item2;
}

result.Reverse();
Console.WriteLine(result);

*/

/*Tuple<int, int> tuple1 = new Tuple<int, int>(10, 20);
Tuple<int, int> tuple2 = new Tuple<int, int>(30, 40);

Tuple<int, int>[] tupleArray = new Tuple<int, int>[2];
tupleArray[0] = tuple1;
tupleArray[1] = tuple2;

string result = string.Empty;

foreach (Tuple<int, int> tuple in tupleArray)
{
    int firstNumber = tuple.Item1;
    int secondNumber = tuple.Item2;

    result += firstNumber + secondNumber + " ";
}

Console.WriteLine(result);
*/
