//L'utente inserisce due numeri in successione, il software stampa il maggiore;

//primo input
Console.WriteLine("Inserire il primo numero:");
double num1 = Convert.ToDouble(Console.ReadLine());
//secondo input
Console.WriteLine("Inserire il secondo numero:");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("I due numeri immessi sono uguali");
}
else if (num1 > num2)
{
    Console.WriteLine($"{num1} é maggiore di {num2}");
}
else { Console.WriteLine($"{num2} é maggiore di {num1}"); }