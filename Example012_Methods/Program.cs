// Вид 1 - не принимает никаких аргументов и ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();


// Вид 2 - принимает какие-то аргументы, но ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);    
}
// Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);  
        i++;
    }
      
}
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "New Текст");


// Вид 3 - может что-то возвращать, но ничего не принимает.
// Например, генерация случайных чисел
int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);


// Вид 4 - что-то принимает (аргументы, данные) и что-то возрващает
// string Method4(int count, string text)  // F2 - переименование
// {
//     int i = 0;
//     string result = String.Empty; // string result = ""

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

string Method4(int count, string text)  // F2 - переименование
{ 
    string result = String.Empty; // string result = ""
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
// string res = Method4(10, "z");
// Console.WriteLine(res);


// Цикл в цикле
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }