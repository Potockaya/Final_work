// Console.Clear();
// Console.WriteLine("Введите слова, символы или цифры через запятую");
// string inputLine = Console.ReadLine();

// string[] words = inputLine.Split(new char[] { ',' });
// foreach (string s in words)
// {
//     if (s.Length<=3)
//     {
//         Console.WriteLine(s);
//     }
    
// }

string[] inputLine =  {"hello", "two", "world", ")))","Russia", "Denmark", "Kazan","1234", "1567", "-2", "computer science"};
int countInputLine = CountLessThree(inputLine);
string[] result =  FillResultArray(inputLine,countInputLine);

void PrintArray(string[] array) 
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write("\""+array[i]+"\""+",");
            }
        Console.Write("\""+$"{array[array.Length - 1]}"+"\""+"]");
    }

int CountLessThree(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
        return count;
    }

string[] FillResultArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }

PrintArray(result);
