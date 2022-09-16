//Snack6: array nomi festa gatsby, utente inserisce nome e vede se contenuto nella lista
string[] invitati = { "Marco", "Luca", "Giovanni" };

Console.WriteLine("Inserisci il tuo nome:");
string name = Console.ReadLine();

bool checkname = false;
for (int i = 0; i < invitati.Length; i++) {
    if (invitati[i].ToUpper() == name.ToUpper()) {
        checkname = true;
    }
}

//checkname == false ? Console.WriteLine("Non sei inviato alla festa") : Console.WriteLine("Sei invitato entra pure");
Console.WriteLine(checkname == false ? "Non sei invitato": "Sei invitato");