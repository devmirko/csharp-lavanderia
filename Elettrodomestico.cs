// See https://aka.ms/new-console-template for more information
public abstract class Elettrodomestico : IIncasso
{
    public string Stato { get; set; }
    public string Marca { get; set; }
    public int Gettoni { get; set; }

    public abstract void Dettaglio();
    public double Incasso()
    {
        return (double)Gettoni * 0.50;
    }






}
    



