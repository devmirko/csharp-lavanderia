// See https://aka.ms/new-console-template for more information

using System.Reflection.PortableExecutable;

Console.WriteLine("Hello, World!");
//Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici. 

//clienti che usufruiscono delle macchine, possono effettuare diversi programmi di lavaggio e asciugatura ognuno con un costo diverso (in gettoni) e di una specifica durata ( 

//Ogni gettone costa 0.50 centesimi di euro e ogni lavaggio consuma detersivo e ammorbidente dai serbatoi della lavatrice ( propieta lavatrice : detersivo, ammorbidente, stato, nome, tipi di lavaggio)

//Ogni lavatrice può tenere fino ad un massimo di 1 litro di detersivo e 500ml di ammorbidente

//I programmi di lavaggio hanno quindi queste caratteristiche
//Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
//Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
//Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.

//Le asciugatrici invece hanno soltanto due programmi di asciugatura, rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti rispettivamente.

//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono (in lavaggio / asciugatura oppure ferme)
//Possa essere richiesto il dettaglio di una macchina:
//Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del lavaggio.
//l’attuale incasso generato dall’utilizzo delle macchine.


Lavanderia lavanderia = new Lavanderia();
Console.WriteLine("Inserisci un opzione");
Console.WriteLine("1 Stato Macchine");
Console.WriteLine("2 Dettagli macchina");
Console.WriteLine("3 programa Lavatrici");
Console.WriteLine("4 programma Asciugatrici");
Console.WriteLine("5 incassi");

int scelta = Convert.ToInt32(Console.ReadLine());

switch (scelta)
{
    case 1:
        lavanderia.Stato();
        break;
    case 2:
        Console.WriteLine("lavatrice o asciugatrice");
        string tipo = Console.ReadLine();
        Console.WriteLine("Digita il numero");
        int numero = Convert.ToInt32(Console.ReadLine());
        lavanderia.Macchina(tipo, numero);
        break;
    case 3:
        lavanderia.AssegnaProgrammaLavatrice();
        break;
    case 4:
        lavanderia.AssegnaProgrammaAsciugatrice();
        break;
    case 5:
        Console.WriteLine("Incasso Totale:{0}€", lavanderia.Incasso());
        break;
    default:
        Console.WriteLine("inserisci un numero corretto");
        break;
}



