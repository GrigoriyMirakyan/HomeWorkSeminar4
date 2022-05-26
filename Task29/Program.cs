/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

void FillArray(int[] collection)  // метод, задающий массив из 8 элементов
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(0, 100);
    }
}
int[] array = new int[8];
FillArray(array);
for (int i = 0; i < array.Length; i++)  //  цикл, выводящий массив в консоль
{
    Console.Write(array[i] + " ");
}

// задание очень неконкретное...
