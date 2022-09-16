//Snack3: il programma chiede all'utente di inserire 10 volte un numero, il programma stampa la somma
double sum = default;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Inserisci un numero:");
    sum += Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("La somma vale: " + sum);

//con ciclo while
int j = 0;
sum = 0;
while (j < 10) {
    Console.WriteLine("Inserisci un numero:");
    sum += Convert.ToDouble(Console.ReadLine());
    j++;
}
Console.WriteLine("La somma vale: " + sum);