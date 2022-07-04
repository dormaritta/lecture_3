/* 1.) Метод который ничего не возвращает и ничего не принимает */

void Method_1 ()
{
    Console.WriteLine("Author: Dara Kosova");
}

/* Вызов метода */

Method_1();

/* 2.) Методы которые ничего не возвращают, но могут принимать какие-то аргументы */

void Method_2 (string msg)
{
    Console.WriteLine(msg);
}
Method_2("Text message");

void Method_2_1 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
Method_2_1(msg: "Text", count: 2);

/* 3.) Методы которые что-то возвращают, но ничего не принимают */

int Method_3 ()
{
    return DateTime.Now.Year;
}

int year = Method_3();
Console.WriteLine(year);

/* 4.) Самая важная группа методов. Что-то принимают и что-то возвращают. */

string Method_4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method_4(10, "qwerty");
Console.WriteLine(res);