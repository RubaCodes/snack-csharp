//L'utente inserisce du parole in successione, il software stampa prima la parola piu corta, poi la piu lunga
Console.WriteLine("Inserire la prima parola:");
string firstWord = Console.ReadLine();
Console.WriteLine("Inserire la seconda parola:");
string secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine($"La parola {firstWord} é piu lunga della parola {secondWord}");
}
else if (firstWord.Length < secondWord.Length)
{
    Console.WriteLine($"La parola {secondWord} é piu lunga della parola {firstWord}");
}
else {
    Console.WriteLine("Le due parole hannno lunghezza uguale");
}