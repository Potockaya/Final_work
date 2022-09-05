Console.Clear();
Console.WriteLine("Введите слова, символы или цифры через запятую");
string inputLine = Console.ReadLine();

string[] words = inputLine.Split(new char[] { ',' });
foreach (string s in words)
{
    if (s.Length<=3)
    {
        Console.WriteLine(s);
    }
    
}

