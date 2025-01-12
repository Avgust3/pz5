Console.WriteLine("введите число");
int number = Int32.Parse(Console.ReadLine()); //Int32.Parse преобразует строковое представление числа в его 32-битный подписанный целочисленный эквивалент
Console.WriteLine($"вот какое число вы ввели {number}");