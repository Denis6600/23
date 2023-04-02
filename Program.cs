Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());



for (int i = 1; i <= num; i++)
{
  double pow = Math.Pow(i,3);
  Console.WriteLine($"{pow}");
}