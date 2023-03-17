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