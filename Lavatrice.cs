// See https://aka.ms/new-console-template for more information
public class Lavatrice :  Elettrodomestico
{
    public int Qtdetersivo {  get; set; }
    public int Qtammorbidente {  get; set;}

    public int Tempo { get; set; }



    //costruttore
    public Lavatrice(string marca)
    {
        Stato = "non in uso";
        Marca = marca;
        Gettoni = 0;
        Qtdetersivo = 1000;
        Qtammorbidente = 500;



    }

    public override void Dettaglio()
    {
        Console.WriteLine("marca: " + Marca);
        Console.WriteLine("Stato: " + Stato);
        Console.WriteLine("Detersivo rimanente: " + Qtdetersivo);
        Console.WriteLine("Ammorbidente rimanente: " + Qtammorbidente);

    }

    private void Rinfrescante()
    {
            Qtdetersivo -= 20;
            Qtammorbidente -= 5;
            Stato = "Lavaggio Rinfrescante";
            Tempo = 20;
            Gettoni += 2;
        
    }

    private void Rinnovante()
    {

            Qtdetersivo -= 40;
            Qtammorbidente -= 10;
            Stato = "Lavaggio Rinnovante";
            Tempo = 40;
            Gettoni += 3;
    }

    private void Sgrassante()
    {

        Qtdetersivo -= 60;
        Qtammorbidente -= 16;
        Stato = "Lavaggio Sgrassante";
        Tempo = 60;
        Gettoni += 4;
    }

    public void StartLavatrici()
    {
        Console.WriteLine("scegli la tipologia di lavaggio");
        Console.WriteLine("Lavaggio Rinfrescante - numero 1");
        Console.WriteLine("Lavaggio Rinnovante -  numero 2");
        Console.WriteLine("Lavaggio Sgrassante - numero 3");

        int scelta = Convert.ToInt32(Console.ReadLine());

        switch (scelta)
        {
            case 1:
                Rinfrescante();
                break;
            case 2:
                Rinnovante();
                break;
            case 3:
                Sgrassante();
                break;
            default:
                Console.WriteLine("hai selezionato un numero errato");
                break;
        }
    }

   


}
    



