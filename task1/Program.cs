Console.WriteLine("Введите 5-ти значное число");
string a = Console.ReadLine();
int alength = a.Length;

if(alength == 5)
{
    char[] revA = a.ToCharArray();
    Array.Reverse(revA);
    string backCurrens = new string(revA);
    int resultPolindrom = Convert.ToInt32(a) - Convert.ToInt32(backCurrens);
    if(resultPolindrom == 0)
    {
        Console.WriteLine("Полиндром");
    }
    else
    {
        Console.WriteLine("Не яв-ся полиндромом");
    }
}
else
{
    Console.WriteLine("не верный формат числа");
}