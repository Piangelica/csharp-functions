Console.WriteLine("Inserisci i numeri a tua scelta");
int dimensioneArray = Convert.ToInt32(Console.ReadLine());
int[] arrayUtente = new int[dimensioneArray];

for (int i = 0; i < dimensioneArray; i++)
{
    Console.Write("Inserire il " + (i + 1) + "° numero:");
    arrayUtente[i] = Convert.ToInt32(Console.ReadLine());
}
stampaArrayNumeriInteri(arrayUtente);
stampaArrayNumeriInteri(elevazioneArrayAlQuadrato(arrayUtente));
stampaArrayNumeriInteri(arrayUtente);
int somma = sommaElementiArray(arrayUtente));
Console.WriteLine("la somma di tutti i numeri è" + somma);
int sommaAlQuadrato = sommaElementiArray(elevazioneArrayAlQuadrato(arrayUtente));
Console.WriteLine("La somma dei  numeri elevati al quadrato è:"+ sommaAlQuadrato);
