// See https://aka.ms/new-console-template for more information
public class Asciugatrice : Elettrodomestico
{

    public int Tempo { get; set; }

    //costruttore
    public Asciugatrice(string marca)
    {
        Stato = "non in uso";
        Marca = marca;
        Gettoni = 0;


    }

    public override void  Dettaglio()
    {
        Console.WriteLine("marca: " + Marca);
        Console.WriteLine("Stato: " + Stato);

    }

    public void StartAsciugatrici()
    {
        Console.WriteLine("scegli il tipo di asciugatura");
        Console.WriteLine("Asciugatura rapida - numero 1");
        Console.WriteLine("Asciugatura intensa -  numero 2");
        

        int scelta = Convert.ToInt32(Console.ReadLine());

        switch (scelta)
        {
            case 1:
                Rapida();
                break;
            case 2:
                Intensa();
                break;
            default:
                Console.WriteLine("hai selezionato un numero errato");
                break;
        }
    }

    private void Rapida()
    {
        Stato = "Asciugatura rapida";
        Tempo = 30;
        Gettoni += 2;

    }

    private void Intensa()
    {
        Stato = "Asciugatura intensa";
        Tempo = 30;
        Gettoni += 2;

    }







}
    



