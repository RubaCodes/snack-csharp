//Snack5 : Il software chiede allútente di inserire un numero, se pari stampa "pari altrimenti "disparí"
Console.WriteLine("Inserire numero intero:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0) {
    Console.WriteLine("Il numero inserito é pari");
}
else { Console.WriteLine("Il numero inserito é dispari");
}
