// See https://aka.ms/new-console-template for more information
using evelopments_sobitia_29._09._2022;

void PrintMes(string mes) 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mes);
}

Acc acc1 = new Acc(1000);

acc1.Notify += PrintMes;

acc1.Put(20);

acc1.Take(70);

//Console.WriteLine($"Сумма на счете: {acc1.Sum}");

acc1.Take(180);

//Console.WriteLine($"Сумма на счете: {acc1.Sum}");