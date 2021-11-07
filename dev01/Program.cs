// Описание задачи 
// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые
// - нарушают порядок возрастания
// - больше среднего арифметического элементов A
// - чётные

//Ввод переменных
int index = 0;
int VarOfIndex = 10; // размерность массива

//Модуль создания случайного массива 
void FillArrayRandomly (int [] Array_R)
{
    int index = 0;
    //Создание массива путем генерации случайных числе
    while (index < Array_R.Length)
    {
        Array_R [index] = new Random().Next(10, 100);
        index++;
    }
}

//Модуль вывода данных
void PrintArray(int [] collection)
{
    int position = 0;
    while (position < collection.Length)
    {
        Console.Write($"{collection[position]} ");
        position++;
    }
    
}

//Запуск инициализации массива
int [] Array_Main = new int [VarOfIndex];
FillArrayRandomly(Array_Main);

Console.Write("Массив А: ");
PrintArray(Array_Main);

//Первый фильтр
void Filter1 (int [] Array_F1)
{   
    index = 1;
    int temp_index = 1;
    int LastPos = Array_Main[0];
    Array_F1 [0] = Array_Main[0]; 
    while (index<Array_F1.Length)
    {
        if (Array_F1[index]>LastPos)
        {
            Array_F1[temp_index] = Array_Main[index];
            LastPos = Array_Main[index];
            temp_index++;
        }
        index++;
    }
}
Filter1(Array_Main);
Console.WriteLine();

Console.Write("Массив B: ");
PrintArray(Array_F1);



