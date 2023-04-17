using Geometria;


//*********************** INIZIO PROGRAMMA *******************************************
int baseRettangolo;
int altezzaRettangolo;
string inputUtente;


Console.WriteLine("Ciao! Benvenuto nel programma \"calcola il tuo rettangolo!\" Ti prego di inserire i seguenti valori! ");
do
{
    Console.Write("Inserisci la base del rettangolo (maggiore di 0): ");
    inputUtente = Console.ReadLine();
    baseRettangolo = int.Parse(inputUtente);
    Console.Write("Inserisci l'altezza del rettangolo (maggiore di 0): ");
    inputUtente = Console.ReadLine();
    altezzaRettangolo = int.Parse(inputUtente);
} while ((baseRettangolo <= 0) || (altezzaRettangolo <= 0));

Rettangolo myRettangolo = new Rettangolo(baseRettangolo, altezzaRettangolo);



myRettangolo.CalcolaArea();
myRettangolo.CalcolaPerimetro();

MostraRettangolo();

Console.WriteLine("\n Ed ora l'esclusivo programma in alpha di disegno del rettangolo : \n");

myRettangolo.DisegnaRettangolo();

void MostraRettangolo()
{
    Console.WriteLine("------Rettangolo------");
    Console.WriteLine("base: " + myRettangolo.baseRettangolo + "cm");
    Console.WriteLine("altezza: " + myRettangolo.altezzaRettangolo + "cm");
    Console.WriteLine("Perimetro: " + myRettangolo.perimetro + "cm");
    Console.WriteLine("Area: " + myRettangolo.area + "cm2");
    Console.WriteLine("----------------------");
}