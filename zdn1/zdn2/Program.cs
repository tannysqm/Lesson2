Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string text = Convert.ToString(num);
if (text.Length > 2)
{
  Console.WriteLine(text[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}