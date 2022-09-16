//snack9
double[] array = { 0 };
while (array[0] < 50) {
    Console.WriteLine("Inserisci un numero");

    array[0] += Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Hai superato 50!");