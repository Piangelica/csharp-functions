/*Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
-void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array 
in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina
-int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
 */
int[] elencoNumeri = { 2, 6, 7, 8, 3, 9 };

stampaArrayNumeriInteri(elencoNumeri);

int[]arrayConIQuadrati = elevazioneArrayAlQuadrato(elencoNumeri);
stampaArrayNumeriInteri(arrayConIQuadrati);
stampaArrayNumeriInteri(elencoNumeri);
int somma = sommaElementiArray(elencoNumeri);
Console.WriteLine("la somma dei numeri è:" + somma);
int sommaAlQuadrato = sommaElementiArray(arrayConIQuadrati);
Console.WriteLine("La somma dei numeri elevati al quadrato è:" +sommaAlQuadrato);

void stampaArrayNumeriInteri(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length-1; i++)
    {
       Console.Write(array[i]+ ",");
    }
    Console.Write(array[array.Length-1] + "]");
}
    int quadrato(int numero)
{
    int risultato;
    risultato = numero * numero;
    return risultato;
}
int[] elevazioneArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < array.Length; i++)
    {
        copiaArray[i] = quadrato(copiaArray[i]);
    }
    return copiaArray;
}
int sommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
      somma += copiaArray[i];
    }
    return somma;
}
