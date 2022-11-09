// See https://aka.ms/new-console-template for more information

public class ProgrammaLavaggio : Programma
{

    public int ConsumoDetersivo { get; set; }
    public int ConsumoAmmorbidente { get; set; }

public ProgrammaLavaggio(string nome, int tempo, int costo, int consumoDetersivo, int consumoAmmorbidente)
    {
        Tempo = tempo;
        TempoRimanente = 0;
        Nome = nome;
        Costo = costo;
        ConsumoDetersivo = consumoDetersivo;
        ConsumoAmmorbidente = consumoAmmorbidente;
    }

    
}

