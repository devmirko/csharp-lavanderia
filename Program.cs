// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

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
lavanderia.Stato();
lavanderia.Macchina("lavatrice", 2);



public class Lavatrice
{
    public int Qtdetersivo { private get; set; }
    public int Qtammorbidente { private get; set; }
    public string Stato { get; set; }
    public string Marca { get; set; }
    public int Tempo { get; set; }
    public int Gettoni { get; set; }

    //costruttore
    public Lavatrice(string marca)
    {
        Stato = "non in uso";
        Marca = marca;
        Gettoni = 0;
        Qtdetersivo = 1000;
        Qtammorbidente = 500;



    }

    public void DettaglioLavatrice()
    {
        Console.WriteLine("marca: " + Marca);
        Console.WriteLine("Stato: " + Stato);
        Console.WriteLine("Detersivo rimanente: " + Qtdetersivo);
        Console.WriteLine("Ammorbidente rimanente: " + Qtammorbidente);

    }




}


public class Asciugatrice
{
    public string Stato { get; set; }
    public string Marca { get; set; }
    public int Tempo { get; set; }
    public int Gettoni { get; set; }

    //costruttore
    public Asciugatrice(string marca)
    {
        Stato = "non in uso";
        Marca = marca;
        Gettoni = 0;


    }

    public void DettaglioAsciugatrice()
    {
        Console.WriteLine("marca: " + Marca);
        Console.WriteLine("Stato: " + Stato);

    }

}


public class Lavanderia
{
    private Lavatrice[] lavatrici;
    private Asciugatrice[] asciugatrici;

    public Lavanderia()
    {
        lavatrici = new Lavatrice[5];
        asciugatrici = new Asciugatrice[5];
        for (int i = 0; i < 5; i++)
        {
            lavatrici[i] = new Lavatrice("Lavatrice" + (i + 1));
            asciugatrici[i] = new Asciugatrice("Asciugatrice" + (i + 1));
        }
    }

    public void Stato()
    {
        for (int i = 0; i < lavatrici.Length; i++)
        {
            Console.WriteLine(lavatrici[i].Stato + ": " + lavatrici[i].Marca);
            Console.WriteLine(asciugatrici[i].Stato + ": " + asciugatrici[i].Marca);


        }
    }

    public void Macchina(string macchina, int numero)
    {
        Console.WriteLine("Scegli la macchina");
        if (macchina == "lavatrice")
            lavatrici[numero].DettaglioLavatrice();
        else if (macchina == "asciugatrice")
            asciugatrici[numero].DettaglioAsciugatrice();
    }




}
    



