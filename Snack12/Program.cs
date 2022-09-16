
static bool isEven(int number)
{
    if (number % 2 == 0) return true;
    else return false;
}

Console.WriteLine("Inserire numero");
int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( isEven(input) ? $"In numero {input} é  pari" : $"Il numero {input} é dispari" );
