//1)  Visual studio - Console Application
//2)  Создать приложение калькулятор:
//3)  Интерфейс и содержание кода полностью на английском(пользуйтесь переводчиком)
//4)  Читабельная структура программы, соответствующая конвенциям написания кода и именования (содержит информативные комментарии) 
//5)  Добавить функцию вывести 5 последних результатов операций (ответов)
//6)  Меню взаимодействия с пользователем, в том числе, по окончанию операции - начать сначала, повторить последнее действие (вводить только числа без действия), выйти
//7)  Приложение не должно падать ни при каких условиях – обработка всевозможных ситуаций
//8)  Дополнительно:
//•  возможность вводить пример в одну строку
//•  в несколько действий.


Console.WriteLine("\t\t\t\t\tWelcome to \"Epic-Calc 2000\"");
Console.WriteLine();
Console.WriteLine("Enter values and action and I'll make the math for you!");
double firstNum;
double secondNum;
double sum;
string action;
bool isInputValid = false;
Console.WriteLine("First value..");
while (!isInputValid)
{
    bool result = double.TryParse(Console.ReadLine(), out firstNum);
    if (result)
    {
        Console.WriteLine($"{firstNum} ... ");
        isInputValid = true;
    }
    else
    {
        Console.WriteLine("Wrong input!");
        continue;
    }
    //try
    //{
    //    firstNum = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine($"{firstNum} ... ");
    //}
    //catch (Exception)
    //{
    //    Console.WriteLine("Entered wrong number!");
    //    continue;
    //}
    //isInputValid = true;
}
isInputValid = false;
Console.WriteLine("Second value..");
while (!isInputValid)
{
    bool result = double.TryParse(Console.ReadLine(), out secondNum);
    if (result)
    {
        Console.WriteLine($"{secondNum} ... ");
        isInputValid = true;
    }
    else
    {
        Console.WriteLine("Wrong input!");
        continue;
    }
    //try
    //{
    //    secondNum = Convert.ToDouble(Console.ReadLine());
    //    Console.WriteLine($"Value B: {secondNum}");
    //}
    //catch (Exception)
    //{
    //    Console.WriteLine("Entered wrong number!");
    //    continue;
    //}
    //isInputValid = true;
}
isInputValid = false;
Console.WriteLine("Action..");
while (!isInputValid) //ошибка здесь
{
    action = Console.ReadLine();
    switch (action)
    {
        case "+":
            sum = firstNum + secondNum;
            Console.WriteLine("Say smth");
            break;
        case "-":
            break;
        case "/":
            break;
        case "*":
            break;
        default:
            Console.WriteLine("Entered wrong action!");
            continue;
    }

    isInputValid = true;
}



