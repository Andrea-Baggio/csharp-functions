int[] myArray = { 1, 2, 3, 4, 5 };
StampaArray(myArray);

static void StampaArray(int[] num)
{
    Console.Write("[");
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write("elemento " + num[i]);
        if (i != num.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


