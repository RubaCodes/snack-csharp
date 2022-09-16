//snack7: Crea un array vuoto, chiedi 6 volte all'utente di inserire un numero , se disapri inseriscilo nell'array

int[] array = new int[6];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Inserisci un numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero % 2 != 0) {
        array[i] = numero;
    }
}
Console.WriteLine("Array risultante:");
for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]);
}