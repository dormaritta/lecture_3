/* 1.) Самая важная группа методов. Что-то принимают и что-то возвращают. C for вместо цикла*/

string Method_4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method_4(10, "qwerty");
Console.WriteLine(res);

/* 2.) Цикл в цикле. Таблица умножения. */

for (int i = 2; i <= 9; i++)
{
    for (int j = 2; j <= 9; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}