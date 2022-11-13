// написать программу которая выдает дни недели взамен чисел от 1 до 7

Console.WriteLine("Введите число от 1 до 7");
int numberA = Convert.ToInt32(Console.ReadLine());

if(numberA == 1)
Console.WriteLine(" ПОНЕДЕЛЬНИК ");
if(numberA == 2)
Console.WriteLine(" ВТОРНИК ");
if(numberA == 3)
Console.WriteLine(" СРЕДА ");
if(numberA == 4)
Console.WriteLine(" ЧЕТВЕРГ ");
if(numberA == 5)
Console.WriteLine(" ПЯТНИЦА ");
if(numberA == 6)
Console.WriteLine(" СУББОТА ");
if(numberA == 7)
Console.WriteLine(" ВОСКРЕСЕНЬЕ ");
if(numberA > 7)
Console.WriteLine("Ты пьяный что ли? Давай досвидания");
if(numberA < 1)
Console.WriteLine("Ты пьяный что ли? Давай досвидания");