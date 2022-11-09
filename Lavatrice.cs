// See https://aka.ms/new-console-template for more information
public class Lavatrice :  Elettrodomestico
{
    public int Qtdetersivo {  get; set; }
    public int Qtammorbidente {  get; set;}




    //costruttore
    public Lavatrice(string marca)
    {
        Stato = "non in uso";
        Marca = marca;
        Gettoni = 0;
        Qtdetersivo = 1000;
        Qtammorbidente = 500;
        Programmi = new ProgrammaLavaggio[3];
        Programmi[0] = new ProgrammaLavaggio("Programma Rinfrescante", 20, 2, 20, 5);
        Programmi[1] = new ProgrammaLavaggio("Programma Rinnovante", 40, 3, 40, 10);
        Programmi[2] = new ProgrammaLavaggio("Programma Sgrassante", 60, 4, 60, 15);
        ProgrammaAttuale = new ProgrammaLavaggio("inattivo", 0, 0, 0, 0);
    }

    public ProgrammaLavaggio ProgrammaAttuale
    {
        get
        {
            return (ProgrammaLavaggio)base.ProgrammaAttuale;
        }
        protected set
        {
            base.ProgrammaAttuale = value;
        }
    }
    public void StartLavaggio()
    {
        Console.WriteLine("scegli la tipologia di lavaggio");
        Console.WriteLine("Lavaggio Rinfrescante - numero 1");
        Console.WriteLine("Lavaggio Rinnovante -  numero 2");
        Console.WriteLine("Lavaggio Sgrassante - numero 3");
        //crea una variabile random
        Random random = new Random();
        //assegna alla scelta
        int scelta = random.Next(1, 4);
        //controlliamo che la scelta sia nei pararmetri
        if (scelta == 1 || scelta == 2 || scelta == 3)
        {
            //se il detersivo e l'ammorbidente meno il consumo e superiore a 0
            if (Qtdetersivo - GetProgrammaLavaggio(scelta).ConsumoDetersivo > 0 && Qtammorbidente - GetProgrammaLavaggio(scelta).ConsumoAmmorbidente > 0)
            {
                ProgrammaAttuale.Nome = GetProgrammaLavaggio(scelta).Nome;
                ProgrammaAttuale.Tempo = GetProgrammaLavaggio(scelta).Tempo;
                ProgrammaAttuale.TempoRimanente = GetProgrammaLavaggio(scelta).Tempo;
                ProgrammaAttuale.Costo = GetProgrammaLavaggio(scelta).Costo;
                ProgrammaAttuale.ConsumoDetersivo = GetProgrammaLavaggio(scelta).ConsumoDetersivo;
                ProgrammaAttuale.ConsumoAmmorbidente = GetProgrammaLavaggio(scelta).ConsumoAmmorbidente;
                Gettoni += ProgrammaAttuale.Costo;
                Qtdetersivo -= ProgrammaAttuale.ConsumoDetersivo;
                Qtammorbidente -= ProgrammaAttuale.ConsumoAmmorbidente;
                Stato = "in uso";

            }
            

        } else
        {
            Console.WriteLine("scegli un numero corretto");
        }



    }








    public override void Dettaglio()
    {
        Console.WriteLine("marca: " + Marca);
        Console.WriteLine("Stato: " + Stato);
        Console.WriteLine("Detersivo rimanente: " + Qtdetersivo);
        Console.WriteLine("Ammorbidente rimanente: " + Qtammorbidente);

    }

    

    private ProgrammaLavaggio GetProgrammaLavaggio(int scelta)
    {
        return (ProgrammaLavaggio)Programmi[scelta - 1];
    }






}
    



