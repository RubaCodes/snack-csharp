﻿//Snack10
Console.WriteLine("Inserisci un numero N intero");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
Random rdm = new Random();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < 10; j++)
    {
        array[j] =  rdm.Next(100); 
    }
    Console.WriteLine($"{i + 1}-esimo array generato");
    foreach (int obj in array) {
        
        Console.WriteLine(obj.ToString());
    }
}