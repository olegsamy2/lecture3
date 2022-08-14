// Упорядочить массив (метод по минимальному значению)

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; // дан массив
void PtintArray(int[] array)  // вывод массива на экран
{
int count = array.Length;        // длина массива
for (int i = 0; i < count; i++)  // перебор элементоа массива
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();   // пустая строчка
}


void SelectionSort(int[] array)  // метод упорядующий массив
{
for (int i = 0; i < array.Length - 1; i++) //перебераем все элементы массива
{
int minPosition = i;                  // позиция где будет минимальный элемент
for (int j = i+1; j < array.Length; j++) // цикл дальнейшей сортировки, после того как 1ый 
                                      // найденный элемент занял свою минимальную позицию 
                                    //   
{
if(array[j] < array[minPosition]) minPosition = j; //если минимум оказывается другое значение,
                                                 // то оно присваевается минимальной позиции 
} 
int temporary =  array[i];  // обмен найденной миним. переменной на следующую разыскиваемую переменную
array[i] = array[minPosition];
array[minPosition] = temporary;  // положим из временной переменной в минимальную переменную
}
}

PtintArray(arr);
SelectionSort(arr);

PtintArray(arr);