//Snack 4 : Calcola la somma e la media dei numeri da 2 a 10;
int[] array =  new int [9];
int sum =default;
for (int i = 0; i < array.Length; i++) { 
    array [i] = i + 2 ;
    sum += array [i];
}
int mean = sum/array.Length;
Console.WriteLine("la somma é: " + sum);
Console.WriteLine("la media é: " + mean);
