
delegate void Printdelegate(string massage);
delegate void Ispalindrom(int son);
internal class Program
{
    static void Main(string[] args)
    {
        Printdelegate printdelegate = PrintMessage;
        printdelegate("SAlom Samandar");

         Ispalindrom ispalindrom_delegate = new Ispalindrom(PalindromSon);
         ispalindrom_delegate(121);
    }

     static void PalindromSon(int son)
    {
         int r, sum = 0, result;
        Console.Write("Enter the Number: ");
        son = int.Parse(Console.ReadLine());
        result = son;
        while (son > 0)
        {
            r = son % 10;
            sum = (sum * 10) + r;
            son = son / 10;
        }
        if (result == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }

    static void PrintMessage(string message)
    {
        Console.WriteLine(message); 
    }
}
    