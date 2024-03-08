using System;
using System.Collections.Immutable;
using System.Text;
using System.Xml.Linq;
Console.OutputEncoding = Encoding.UTF8;

//Задача 6.1
//Написати програму, що знаходить суму парних та суму непарних елементів масиву.
//Кількість елементів визначає користувач, елементи генеруються випадковим чином у діапазоні [10;100] (цілі числа).

/*Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sump=0,sumn=0;
Random random = new Random(201232);
Console.WriteLine("Масив:");
for(int i = 0; i < size; i++)
{
    array[i] = random.Next(10,100);
    Console.Write(array[i]+"\t");
}
foreach (int element in array)
{
    if (element %2== 0)
    {
        sump+=element;
    }else
    {sumn+=element;}
}
Console.WriteLine($"\nСума парних елементів:{sump}\nСума непарних елементів:{sumn}");*/

//Задача 6.2
//Написати програму, що знаходить і виводить на консоль у цілочисельному масиві усі парні значення кратні 3-м.
//Елементи масиву генеруються випадковим чином у діапазоні [100,200].
//Кількість елементів визначає користувач

/*Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random random = new Random(223432);
Console.WriteLine("Масив:");
for(int i = 0; i < size; i++)
{
    array[i] = random.Next(100,200);
    Console.Write(array[i]+" ");
}
Console.WriteLine("\nУсі парні значення кратні 3-м:");
foreach(int i in array)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        Console.Write($"{i} ");
    }
}*/

//Задача 6.3
//Написати програму, яка знаходить в масиві найменше непарне число і показує його на екран.
//Елементи масиву генеруються випадковим чином у діапазоні [1,1000].
//Кількість стовпців вводить користувач.

/*Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random random = new Random(2234);
Console.WriteLine("Масив:");
for(int i = 0; i < size; i++)
{
    array[i] = random.Next(1,1000);
    Console.Write(array[i]+" ");
}
int min = array.Max();
foreach(int element in array)
{
    if (element < min && element % 2 != 0)
    {
        min=element;
    }
}
Console.WriteLine($"\nНайменше непарне число:{min}");*/

//Задача 6.4
//Написати програму, що сортує масив у вказаному користувачем порядку: за зростанням або за спаданням.
//Елементи масиву генеруються випадковим чином у діапазоні [100,200].
//Кількість елементів визначає користувач.

void printarray(int[] array)
{
    Console.WriteLine("Масив:");
    foreach(int element in array)
{
    Console.Write(element+" ");
}
}
/*Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random random = new Random(29774);
Console.WriteLine("Масив:");
for(int i = 0; i < size; i++)
{
    array[i] = random.Next(100,201);
    Console.Write(array[i]+" ");
} 
Console.WriteLine("\nВиберіть тип сортування:\n1-За зростанням\n2-За спаданням");
int temp=int.Parse(Console.ReadLine());
switch (temp)
{
    case 1:
        Array.Sort(array);
        printarray(array);
        break;
    case 2:      
        Array.Sort(array);
        Array.Reverse(array);
        printarray(array);
        break;
}*/

//Задача 6.2x
//Дано пустий масив розмірності 5х5 елементів.
//Заповнити його випадковими значеннями з діапазону [10;20] і вивести на консоль.

void printmas(int[,] mas)
{
    Console.WriteLine("Матриця:\n");
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write(mas[i, j]+" ");
        }
        Console.WriteLine("\n");
    }
}
/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(2321358);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(10,20);
        }
    }
    return mas;
}*/

/*int[,] mas = new int[5,5];
fillmas(mas);
printmas(mas);*/

//Задача 6.5
//Задано масив із n дійсних чисел. Обчислити різницю між максимальним та мінімальним за модулем елементами цього масиву.
//Елементи масиву генеруються випадковим чином. Кількість стовпців та рядків вводить користувач.

/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(2387658);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(-10,10);
        }
    }
    return mas;
}
Console.WriteLine("Введіть кількість стовпців:");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("\nВведіть кількість рядків:");
int rows = int.Parse(Console.ReadLine());   
int[,] mas = new int[rows, colums];
fillmas(mas);
int max = mas[0,0], min = mas[0,0];
for (int i = 0;i< mas.GetLength(0); i++)
{
    for (int j = 0;j < mas.GetLength(1); j++)
    {
        if(mas[i,j] > max)
        {
            max = mas[i,j];
        }

        if(mas[i,j] < min)
        {
            min = mas[i,j];
        }
    }
}    
printmas(mas);
int temp = max-min;
if (temp < 0) temp*=-1;
Console.WriteLine($"Різницю між максимальним та мінімальним за модулем:{temp}");*/

//Задача 6.6
//Дано одновимірний масив із дійсних чисел.
//Відсортувати його таким чином, щоб всі додатні елементи знаходилися на початку, а всі від’ємні – в кінці,
//і при цьому зберігся початковий порядок елементів в обох групах.

Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random random = new Random(29774);
for(int i = 0; i < size; i++)
{
    array[i] = random.Next(-100,100);
   
} 
int[] temparray = new int[size];    
printarray(array);
int numelem =0;
foreach(int element in array)
{
    if(element >= 0){
        temparray[numelem]=element;
        numelem++; }
} 
foreach(int element in array)
{
    if(element < 0){
      temparray[numelem]=element;
        numelem++;}
}
Console.WriteLine("\nВідсортований масив:");
printarray(temparray);