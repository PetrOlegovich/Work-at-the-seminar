Console.WriteLine("введите трехзначное число : ");
int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (num>999 || num<100)
{
    Console.WriteLine("Это не трехзначное число");
}
else
{
   Console.WriteLine(num % 10); 
}

