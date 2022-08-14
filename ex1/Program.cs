// // Вид 1
// void Method1()
// {            
//     System.Console.WriteLine("Автор...");
// }

// Method1(); // вызов метода

// // Вид 2
// void Method2(string msg)  // ничего не возвращают, но принимают аргументы
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");  // вызов 2го метода

// void Method21(string msg, int count) 
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;  // инкримент
//     }
// }

// Method21("Текст", 4);

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

string Method4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
result = result + text;
i++;
}
return result;
}
string res = Method4(10,"adsf");
Console.WriteLine(res);