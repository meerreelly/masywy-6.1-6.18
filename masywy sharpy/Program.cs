using System;
using System.Collections.Immutable;
using System.Drawing;
using System.Text;
using System.Xml.Linq;
Console.OutputEncoding = Encoding.UTF8;
void printmas(int[,] mas)
{
    Console.WriteLine("Матриця:\n");
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]:D02} ");
        }
        Console.WriteLine("\n");
    }
}
void printarray(int[] array)
{
    Console.WriteLine("\nМасив:");
    foreach(int element in array)
{
    Console.Write(element+" ");
}
}

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

/*Console.WriteLine("Введіть розмір масиву");
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
printarray(temparray);*/

//Задача 6.7
//Написати програму, що обчислює середнє значення серед парних елементів масиву.
//Елементи генеруються випадковим чином у діапазоні [10; 100). Кількість елементів визначає користувач.

/*Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
Random random = new Random(2413);
for(int i = 0; i < size; i++)
{
    array[i] = random.Next(10,100);
} 
printarray(array);
int parni=0, count =0;
foreach(int element in array)
{
    if(element%2==0){ parni+=element; count++; }
}
Console.WriteLine($"\nCереднє значення серед парних елементів масиву:{parni/count}");*/

//Задача 6.8
//Написати програму, що генерує ?????????вектор??????? випадкових елементів з діапазону [100,200] та виводить його на консоль.
// Усі елементи вектора повинні бути кратними 7-ми. Генерацію випалкового числа винести в окремий метод.

/*Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] vector = new int[size];
int[] RandomArray(int[] array)
{
    Random random = new Random(2413);
    for(int i = 0; i < size; i++)
    {
        int temp =random.Next(100,200);
        if(temp%7==0){
            array[i] = temp;
            }else i--;
    }
    return array;
}
RandomArray(vector);
printarray(vector);*/


//Задача 6.9
//Написати програму, що дозволяє маніпулювати елементами цілочисельного масиву.
//Суть роботи програми полягає у наступному: через діалог з користувачем потрібно реалізувати функції:
//додавання, видалення, вставки числа у існуючий масив.
//На початку роботи програми масив уже повинен бути ініціалізований 5-ма випадковими значеннями з діапазону [10,500]
/*int[] addelement(int[] array, int element)
{
    int[] arraynew = new int[array.Length+1];
    
    for(int i = 0; i < array.GetLength(0); i++)arraynew[i] = array[i];
    arraynew[array.Length]= element;  
    return arraynew;
}
int[] randomarray(int[] array)
{
    Random random = new Random(23613);
    for(int i = 0; i < array.GetLength(0); i++)
    {
    array[i] = random.Next(10,500);
    } 
    return array;
}
int[] deleteelement(int[] array, int index)
{
    int temp =0;
    int[] arraynew= new int[array.Length-1];
    for(int i = 0; i < arraynew.GetLength(0); i++)
    {
        if (i == index)
        {
            arraynew[i] = array[temp+1];
            temp+=2;
            continue;
        }
        arraynew[i]=array[temp];
        temp++;
    }
    return arraynew;
}
int[] pastelement(int[] array, int element,int index)
{
    int[] arraynew = new int[array.Length+1];
    int temp =0;
    for(int i = 0; i < arraynew.GetLength(0); i++)
        {
        if (i == index)
        {
            arraynew [i] = element;
            arraynew[i+1] = array[temp];
            temp++;
            i++;
            continue;
        }
        arraynew[i] = array[temp];
        temp++;
        }
    return arraynew;
}
int[] array = new int[5];
array = randomarray(array);
while (true){
    Console.WriteLine("\nВиберіть операцію:\n1-Додавання\n2-Видалення\n3-Вставка\n0-Вихід");
    int temp = int.Parse(Console.ReadLine());
    printarray(array);
    switch(temp)
    {
        case 1: 
            Console.WriteLine("\nВведіть число яке додати");
            int num = int.Parse(Console.ReadLine());
            array =addelement(array,num);
            printarray(array);
            break;
        case 2:
            Console.WriteLine("\nВведіть індекс елемента який потрібно видалити");
            int index = int.Parse(Console.ReadLine());
            array = deleteelement(array,index);
            printarray(array);   
            break;
        case 3:
            Console.WriteLine("\nВведіть число яке додати");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nВведіть індекс елемента який потрібно вставити");
            index = int.Parse(Console.ReadLine());
            array = pastelement(array,num,index);
            printarray(array); 
            break;
        case 4:
            return;
         default:
            break;


    }
    }
*/


//Задача 6.10
//Задано одновимірний масив. Знайти два серед його елементів, модуль різниці яких має найменше значення.
/*int[] randomarray(int[] array)
{
    Random random = new Random(213);
    for(int i = 0; i < array.GetLength(0); i++)
    {
    array[i] = random.Next(-100,100);
    } 
    return array;
}

Console.WriteLine("Введіть розмір масиву");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
array = randomarray(array); 
printarray(array);
int distance=200;
int num1=0,num2=0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 1;j < array.GetLength(0); j++)
    {
        int temp = array[i]-array[j];
        if(temp<0) temp*=-1;
        if(temp<distance&&i!=j){ 
        distance = temp; 
        num1 = array[i];
        num2 = array[j];
        }
    }

}
Console.WriteLine($"\nДва елементи, модуль різниці яких має найменше значення: {num1}\t{num2}");
*/

//Задача 6.4x
//Написати програму, яка знаходить суму парних і суму непарних елементів масиву.
//Елементи масиву генеруються випадковим чином. Кількість стовпців та рядків вводить користувач.
/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(2321358);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(1,100);
        }
    }
    return mas;
}
Console.WriteLine("Введіть кількість стовпців");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть кількість рядків");
int rows = int.Parse(Console.ReadLine());
int[,] mas = new int[rows, colums];
fillmas(mas);
printmas(mas);
int sump=0, sumn=0;
for (int i = 0;i < rows; i++)
{
    for (int j = 0;j < colums; j++)
    {
        if(mas[i,j]%2== 0)
        {
            sump+=mas[i,j];
        }else
        {
            sumn+=mas[i,j];
        }
    }
}
Console.WriteLine($"Сума парних елементів:{sump}\nСума непарних елементів:{sumn}");*/

//Задача 6.11
//Сформувати цілочисельний масив, елементами якого є випадкові числа із діапазону [100,300].
//Знайти суму елементів масиву, значення яких кратні 8.

/*int[] randomarray(int[] array)
{
    Random random = new Random(2013);
    for(int i = 0; i < array.GetLength(0); i++)
    {
    array[i] = random.Next(100,300);
    } 
    return array;
}
Console.WriteLine("Введіть кількість елементів");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int sum=0;
array = randomarray(array); 
printarray(array);
foreach(int element in array)
{
    if (element % 8 == 0)
    {
        sum+=element;
    }
}
Console.WriteLine($"\nСума елементів які кратні 8:{sum}");*/

//Задача 6.12
//Знайти мінімальний елемент серед тих елементів масиву A, які не є елементами масиву B 

/*int[] randomarray(int[] array, int seed)
{
    Random random = new Random(seed);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = random.Next(0, 200);
    }
    return array;
}
Console.WriteLine("Введіть кількість елементів масивів:");
int size = int.Parse(Console.ReadLine());
int[] arrayA = new int[size];
int[] arrayB = new int[size];
arrayA = randomarray(arrayA, 76);
arrayB = randomarray(arrayB, 25);
int min = arrayA.Min();
Array.Sort(arrayA);
Array.Sort(arrayB);
printarray(arrayA);
printarray(arrayB);

for (int i = 0; i < arrayA.Length; i++)
{
    for (int j = 0; j < arrayB.Length; j++)
    {
        if (arrayA[i] == arrayB[j])
        {
            break;

        }
        if (j == arrayB.Length - 1)
        {
            min = arrayA[i];
            Console.WriteLine($"\n{min}");
            return;
        }

    }
}
*/

//Задача 6.13
//Визначити, скільки різних чисел міститься в заданому цілочисельному масиві.

/*int[] randomarray(int[] array, int seed)
{
    Random random = new Random(seed);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}
Console.WriteLine("Введіть кількість елементів масивів:");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
array = randomarray(array, 12);
printarray(array);
int temp =0;
for(int i =0;i<array.Length;i++)
{  
    for(int j = 1;j < array.Length; j++)
    {
        if(array[j] == array[i] && i!=j)
        {
            array[j] = -1;
            break;
        }
    } 
}
foreach(int element in array)
{
    if (element != -1)
    {
        temp++;
    }
}

Console.WriteLine("\nКількість різних чисел"+temp);
*/

//Задача 6.14
//Написати програму, яка знаходить в масиві значення, що повторюються два і більше разів, і показує їх на екран.
//Елементи масиву генеруються випадковим чином. Кількість стовпців та рядків вводить користувач. 

/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(2321);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(1,100);
        }
    }
    return mas;
}
Console.WriteLine("Введіть кількість стовпців");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть кількість рядків");
int rows = int.Parse(Console.ReadLine());
int[,] mas = new int[rows, colums];
fillmas(mas);
printmas(mas);
int temp=-1;
foreach (int element in mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[i, j] == element)
                {           
                    temp++;
                    if (temp == 1)
                    {                    
                        mas[i,j]*=-1;
                        break;
                    }
                    if (temp > 1)
                    {
                        mas[i,j]=0;
                        break;
                    }
                }
            }   
    }
    temp=-1;
}
Console.Write($"схожі елементи:   ");
foreach (int element in mas)
{
    if(element<0)
    {
        Console.Write($" {element*-1} ");
    }
}*/

//Задача 6.15
//Розробити функцію, що переставляє в зворотному порядку елементи головної діагоналі квадтаної матриці.

/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(2321);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(1,100);
        }
    }
    return mas;
}
static int[,] reverse(int[,] mas)
{
    int temp;
    for (int i = 0;i < mas.GetLength(0)/2;i++)
    {
       temp = mas[i,i];
       mas[i,i] = mas[mas.GetLength(0)-1-i,mas.GetLength(0)-1-i];
       mas[mas.GetLength(0)-1-i,mas.GetLength(0)-1-i] = temp;
        
    }
    return mas;
}
Console.WriteLine("Введіть розмір");
int size = int.Parse(Console.ReadLine());
int[,] mas = new int[size,size];
fillmas(mas);
printmas(mas); 
reverse(mas);
printmas(mas);*/

//Задача 6.16
//Переформатувати марицю (двовимірний масив) таким чином, щоб її рядки розміщувалися за зростанням їх поелементних сум.

/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(2321);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(1,100);
        }
    }
    return mas;
}
Console.WriteLine("Введіть кількість стовпців");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть кількість рядків");
int rows = int.Parse(Console.ReadLine());
int[,] mas = new int[rows, colums];
fillmas(mas);
printmas(mas);
int[] sum =new int[rows];
for(int i = 0; i < rows; i++)
{
    for (int j = 0;j < colums; j++)
    {
        sum[i]+=mas[i,j];
    }
}
int n = sum.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (sum[j] > sum[j + 1])
                {
                    
                    int temp = sum[j];
                    sum[j] = sum[j + 1];
                    sum[j + 1] = temp;
                    for(int k = 0; k < colums; k++)
                    {   
                        temp = mas[j,k];
                        mas[j,k] = mas[j+1,k];
                        mas[j+1,k] = temp;
                        

                     }


                }
            }
        }
printmas(mas);*/

//Задача 6.17
//Відсортувати рядки двохвимірного масиву за зростанням.
//Кількість рядків і стовпців вводить користувач. Масив заповнюється випадковими числами із діапазону [10,100].

/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(2321);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(10,100);
        }
    }
    return mas;
}
Console.WriteLine("Введіть кількість стовпців");
int colums = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть кількість рядків");
int rows = int.Parse(Console.ReadLine());
int[,] mas = new int[rows, colums];
fillmas(mas);
printmas(mas);
int n = mas.GetLength(0);
for(int k =0; k<mas.GetLength(0);k++){
 for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (mas[k,j] > mas[k,j + 1])
                {                  
                    int temp = mas[k,j];
                    mas[k,j] = mas[k,j + 1];
                    mas[k,j + 1] = temp;
                }
            }
        }
}
 printmas(mas);*/

//Задача 6.18
//Згенерувати матрицю значень n*n (квадратну). Знайти максимальний елемент у виділеному кольором діапазоні масиву:

/*static int[,] fillmas(int[,] mas)
{
    Random random = new Random(6521);   
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j] = random.Next(1,100);
        }
    }
    return mas;
}
Console.WriteLine("Введіть розмір матриці:");
int size = int.Parse(Console.ReadLine());
int[,] mas = new int[size, size];
fillmas(mas);
printmas(mas);
int temp = size;
int max=0;
for (int i = 0;i < mas.GetLength(0); i++)
{
    for (int j = 0;j < temp; j++)
    {
        if (mas[i, j] > max)
        {
            max = mas[i, j];
        }
    }
    temp--;
}
Console.WriteLine(max);*/