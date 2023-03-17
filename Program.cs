Console.WriteLine("Array originale: ");
int[] array = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine(string.Join(", ", array));

Console.WriteLine("Applicazione della prima funzione: ");
StampaArray(array);
Console.WriteLine();

Console.WriteLine("Applicazione della seconda funzione: ");
int[] arrayAlQuadrato = ElevaArrayAlQuadrato(array);
StampaArray(arrayAlQuadrato);
Console.WriteLine();

Console.WriteLine("Applicazione della terza funzione: ");
int arraySomma = sommaElementiArray(array);
Console.WriteLine(arraySomma);
Console.WriteLine();

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("elemento " + array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int Quadrato(int numero)
{
    int result = numero * numero;
    return result;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }

    return copiaArray;
}


int sommaElementiArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}