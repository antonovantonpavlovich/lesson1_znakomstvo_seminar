Console.WriteLine("Введите положительное 3х значное число");
int n = Convert.ToInt32(Console.ReadLine());
int lastDigit = 0;
if (100 <= n && n <= 999) 
{
lastDigit = n % 10;
Console.WriteLine(lastDigit);
}
else 
{
    Console.WriteLine("Вы ввели неверное число");
}





//Console.WriteLine("Введите положительное целое число");
//int a = Convert.ToInt32(Console.ReadLine());
//int i = -a;
//while (i <= a) {
//    Console.Write(" " + i + " ");
//    i = i + 1;
//}