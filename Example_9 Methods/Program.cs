// Метод 1 - не принимает, не возвращает

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

// Метод 2 - не возвращают, но принимают аргументы 

void Method2(string msg)
{
  Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
      i++; // инкремент, уменьшение - декримент
    }
}
Method21(msg: "Текст", count: 4);
Method21(count:4, msg:"Новый текст");

//Метод 3 - возвращают, но не принимают

int Method3()
{
   return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year); 

// Метод 4 - возвращают и принимают

string Method4( int count, string c)
{
  int i = 0;
  string result = String.Empty;
  
  while (i<count)
  {
    result = result + c;
    i++;
  }
  return result;
}
string res = Method4(10, "S");
Console.WriteLine(res);


string Method41( int count, string c)
{
  
  string result = String.Empty;
  for (int i = 0; i < count; i++)
  {
    result = result + c;
  }
  return result;
}
string res41 = Method41(10, "S");
Console.WriteLine(res41);