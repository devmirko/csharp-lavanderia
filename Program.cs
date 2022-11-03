﻿// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");
//Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici. ( creaiamo una classe e stampiamo tutte le macchine  )

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

lavanderia.Stampa();

public class Macchina
{
    public int Qtdetersivo {  private get; set; }
    public int Qtammorbidente { private get; set; }
    public bool Stato { get; set; }
    public string Marca { get; set; }
    public string Programma { get; set; }
    public int DurataProgramma { get; set; }
    public int DurataRimanente { get; set; }

    //costruttore
    public Macchina( bool stato, string marca)
    {
        this.Stato = stato;
        this.Marca = marca;

    }

    public Macchina(bool stato, string marca, int Qtdetersivo, int Qtammorbidente)
    {
        this.Stato = stato;
        this.Marca = marca;
        this.Qtdetersivo = Qtdetersivo;
        this.Qtammorbidente = Qtammorbidente;

    }












}


public class Lavanderia
{
    private Macchina[] macchine;

    public Lavanderia()
    {
        //lavatrici
        macchine = new Macchina[10];
        macchine[0] = new Macchina(false, "lavatrice 1", 1000, 500);
        macchine[1] = new Macchina(false, "lavatrice 2", 1000, 500);
        macchine[2] = new Macchina(false, "lavatrice 3", 1000, 500);
        macchine[3] = new Macchina(false, "lavatrice 4", 1000, 500);
        macchine[4] = new Macchina(false, "lavatrice 5", 1000, 500);

        //asciugatrici
        macchine[5] = new Macchina(false, "asciugatrice 1");
        macchine[6] = new Macchina(false, "asciugatrice 2");
        macchine[7] = new Macchina(false, "asciugatrice 3");
        macchine[8] = new Macchina(false, "asciugatrice 4");
        macchine[9] = new Macchina(false, "asciugatrice 5");
      

    }

    public void Stampa()
    {
        for (int i = 0; i < macchine.Length; i++)
        {
            Console.WriteLine("nome: {0} -  stato: {1}", macchine[i].Marca, macchine[i].Stato);
        }
    }





}



