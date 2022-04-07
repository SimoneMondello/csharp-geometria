
// E' RESPONSABILITA' DEL PROGRAMMA PRINCIPALE OCCUPARSI DI REPERIRE LE INFORMAZIONI
using Rettangoli;

Console.WriteLine("Inserisci la base del rettangolo: ");
int baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci l'altezza del rettangolo: ");
int altezzaRettangolo = int.Parse(Console.ReadLine());

// Creo un rettangolo

Ilmiorettangolo rettangoloutente = new Ilmiorettangolo (baseRettangolo, altezzaRettangolo);
rettangoloutente.stamparettangolo();



Ilmiorettangolo rettangolo2 = new Ilmiorettangolo(baseRettangolo, altezzaRettangolo);
rettangolo2.Stamparerettangolouno();