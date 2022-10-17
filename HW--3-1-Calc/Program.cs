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


using System.Runtime.CompilerServices;
using System.Globalization;

Console.WriteLine("\t\t\t\t\tWelcome to \"Epic-Calc 2000\"");
Console.WriteLine();
Console.WriteLine("Enter values and action and I'll make the math for you!");
double firstNum;
double secondNum;
double sum;
string action;
bool repeatCalc = false;
Queue<double> history = new Queue<double>(); 
//NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
//{
//    NumberDecimalSeparator = ".",
//};
void HistoryAdd(double AddToQueue)//Adds results to list
{
    
    history.Enqueue(AddToQueue);
    if (history.Count > 5)
    { 
        history.Dequeue();
    }
}
void HistoryView()//Shows last 5 results
{
    Console.WriteLine("Last 5 results:");
    short i=1;
    foreach (var item in history)
    {
        Console.WriteLine($"{i}) {item}");
        ++i;
    }
}
double EnterValue()//Entering values
{ 
    bool resultOfParse = double.TryParse(Console.ReadLine(), out double returningValue);
    
    if (!resultOfParse)
    {
        Console.WriteLine("<!>Wrong input, try again<!>");
        EnterValue();
    }
    return returningValue;
}
string EnterAction()//Entering action to perform
{
    action = Console.ReadLine();
        switch (action)
        {
            case "+":
                sum = firstNum + secondNum;
                Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
                HistoryAdd(sum);
                break;
            case "-":
                sum = firstNum - secondNum;
                Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
                HistoryAdd(sum);
                break;
            case "/":
                sum = firstNum / secondNum;
                Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
                HistoryAdd(sum);
                if (secondNum == 0)
                    Console.WriteLine("<!>You can't devide by 0<!>");
                break;
            case "*":
                sum = firstNum * secondNum;
                Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
                HistoryAdd(sum);
                break;
            default:
            Console.WriteLine("<!>No such action, please try again<!>");
            EnterAction();
                break;

        }
    return action;
}
string RepeatLastAction()//Repeat last used action
{
    switch (action)
    {
        case "+":
            sum = firstNum + secondNum;
            Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
            HistoryAdd(sum);
            break;
        case "-":
            sum = firstNum - secondNum;
            Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
            HistoryAdd(sum);
            break;
        case "/":
            sum = firstNum / secondNum;
            Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
            HistoryAdd(sum);
            if (secondNum == 0)
                Console.WriteLine("<!>You can't devide by 0<!>");
            break;
        case "*":
            sum = firstNum * secondNum;
            Console.WriteLine($"{firstNum} {action} {secondNum} = {sum}");
            HistoryAdd(sum);
            break;
        default:
            Console.WriteLine("<!>No such action, please try again<!>");
            EnterAction();
            break;

    }
    return action;
}
while (!repeatCalc)
    
{//entering first number
    Console.WriteLine("<First value> ...");
    firstNum = EnterValue();
    Console.WriteLine($"{firstNum} ... ");
    //bool resultFirst = double.TryParse(Console.ReadLine(), out firstNum);
    //if (resultFirst)
    //{
    //    Console.WriteLine($"{firstNum} ... ");
    //}
    //else
    //{
    //    Console.WriteLine("<!>Wrong input, try again<!>");
    //    continue;
    //}


    //entering second number
    Console.WriteLine($"{firstNum} ... <Second value>");
    secondNum = EnterValue();
    Console.WriteLine($"{firstNum} ... {secondNum} ");
    //bool resultSecond = double.TryParse(Console.ReadLine(), out secondNum);
    //if (resultSecond)
    //{
    //    Console.WriteLine($"{firstNum} ... {secondNum} ");
    //}
    //else
    //{
    //    Console.WriteLine("<!>Wrong input, try again<!>");
    //    continue;
    //}


    //entering action
    Console.WriteLine("Action... |+| |-| |/| |*|");
    EnterAction();
    
    //Menu show and restarting  ////NEED ONE MORE CYCLE
    bool repeatMenu = false;
    while (!repeatMenu)
    {
        Console.WriteLine("Do you want to continue?...Y-y/N-n");
        string userInput = Console.ReadLine();
        if (userInput != null && userInput == "Y" || userInput == "y")
        {

            Console.WriteLine("Select option: \n1. Restart. \n2. Repeat last action. \n3. Show history(Last 5 answers). \n4. Quit.");
            //user chose
            int userChose = int.Parse(Console.ReadLine());
            switch (userChose)
            {
                case 1:
                    repeatMenu = true;
                    continue;
                case 2:
                    Console.WriteLine($"Repeat {action}");
                    Console.WriteLine("<First value> ...");
                    firstNum = EnterValue();
                    Console.WriteLine($"{firstNum} ... <Second value>");
                    secondNum = EnterValue();
                    Console.WriteLine($"{firstNum} ... {secondNum} ");
                    RepeatLastAction();
                    continue;
                case 3:
                    HistoryView();
                    continue;
                case 4:
                    repeatMenu = true;
                    repeatCalc = true;
                    break;
                default:
                    Console.WriteLine("No such case in menu, please try once more.");
                    continue;
            }
            
        }
        else if (userInput != null && userInput == "N" || userInput == "n")
        {
            repeatMenu = true;
            repeatCalc = true;
        }
        else //if (userInput == null || userInput != "Y" || userInput != "y" || userInput != "N" || userInput != "n")
        {
            Console.WriteLine("Please select the correct option.");
            continue;
        }
    }
    continue;
    
}



