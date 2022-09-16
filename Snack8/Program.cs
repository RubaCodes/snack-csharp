//snack8: crea array di numeri e stampa quelli all'indice dispari
int[] array = { 1, 2, 5, 3, 6, 9, 4, 0, 33, 21, 455, 9 };
int sum = 0 ;
for (int i = 1; i < array.Length; i=  i + 2) {
    sum += array[i];
    }

Console.WriteLine($"La somma é: {sum}");