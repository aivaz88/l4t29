Console.Clear();

print_array();

void print_array()
{
    int[] new_array = array();
    for (int i = 0; i < new_array.Length; i++)
        Console.Write($"{new_array[i]} ");
}

int[] array()
{
    int[] new_array = new int[8];
    Random randGenerator = new Random();
    for (int i = 0; i < 8; i++)
    {
        new_array[i] = randGenerator.Next();
    }
    return(new_array);
}