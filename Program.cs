// Знакомство GB Итоговая работа.
// Написать программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше лобо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры , либо задать на старте выполнения адгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];
void array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
  }
}
array(stringArray);