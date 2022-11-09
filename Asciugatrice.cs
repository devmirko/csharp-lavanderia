// See https://aka.ms/new-console-template for more information
public class Asciugatrice : Elettrodomestico
{



    //costruttore
    public Asciugatrice(string marca)
    {
        Stato = "non in uso";
        Marca = marca;
        Gettoni = 0;
        Programmi = new ProgrammaAsciugatura[2];
        Programmi[0] = new ProgrammaAsciugatura("Programma rapido", 30, 2);
        Programmi[1] = new ProgrammaAsciugatura("Programma intenso", 60, 4);
        ProgrammaAttuale = new ProgrammaAsciugatura("inattivo", 0, 0);




    }


    public void StartAsciugatrici()
    {
        Console.WriteLine("Digita:");
        Console.WriteLine("1 per Asciugatura rapida");
        Console.WriteLine("2 per Asciugatura intensa");
        //int scelta = Convert.ToInt32(Console.ReadLine());
        Random random = new Random();
        int scelta = random.Next(1, 3);
        if (scelta == 1 || scelta == 2)
        {
            ProgrammaAttuale.Nome = Programmi[scelta - 1].Nome;
            ProgrammaAttuale.Tempo = Programmi[scelta - 1].Tempo;
            ProgrammaAttuale.TempoRimanente = Programmi[scelta - 1].Tempo;
            ProgrammaAttuale.Costo = Programmi[scelta - 1].Costo;
            Gettoni += ProgrammaAttuale.Costo;
            Stato = "in uso";
        }

        else
            Console.WriteLine("scegli un numero corretto");
    }

    public override void  Dettaglio()
    {
        Console.WriteLine("marca: " + Marca);
        Console.WriteLine("Stato: " + Stato);

    }


  





}
    



