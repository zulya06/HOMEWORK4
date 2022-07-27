int[] n= new int[8];
      
void Pavelprivet (int[] array) // this is joke name of metod Creatrarray
{
    for (int i = 0; i<array.Length; i++ )
    {
        array[i] = new Random().Next(-666, 666);
    }
}

void Howeareyou (int[] array) // name of metod Pechatarray
{
    for (int i = 0; i<array.Length; i++ )
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(array);
}

Pavelprivet (n);
Howeareyou (n);