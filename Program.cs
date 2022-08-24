//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.

//Console.WriteLine("Enter number: ");
//int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
//string stringNumber = Convert.ToString(threeDigitNumber);
//Console.WriteLine("Second Number -> "+stringNumber[1]);


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.Write("Enter number: ");
//int anyNumber = Convert.ToInt32(Console.ReadLine());
//string anyNumberText = Convert.ToString(anyNumber);
//if (anyNumberText.Length > 2)
//{
//    Console.WriteLine("третья цифра -> " + anyNumberText[2]);
//}
//else
//{
//    Console.WriteLine("третьей цифры нет =(");
//}


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 7 )
{
    switch(number)
    {

    case 1: System.Console.WriteLine("1"); break;

    case 2: System.Console.WriteLine("2"); break;

    case 3: System.Console.WriteLine("3"); break;

    case 4: System.Console.WriteLine("4"); break;

    case 5: System.Console.WriteLine("5"); break;

    case 6: System.Console.WriteLine("6"); break;

    case 7: System.Console.WriteLine("7"); break;

    default: System.Console.WriteLine("Bad number");  break;
}
if (number == 1)
    {
        System.Console.WriteLine("(этот день не выходной) -> нет");
    }
    else if(number == 2){
        System.Console.WriteLine("(этот день не выходной) -> нет");
    }
    else if(number == 3){
        System.Console.WriteLine("(этот день не выходной) -> нет");
    }
    else if(number == 4){
        System.Console.WriteLine("(этот день не выходной) -> нет");
    }
    else if(number == 5){
        System.Console.WriteLine("(этот день не выходной) -> нет");
    }
    else if(number == 6){
        System.Console.WriteLine("(этот день выходной) -> да");
    }
    else if(number == 7){
        System.Console.WriteLine("(этот день выходной) -> да");
    }
    else {
        System.Console.WriteLine("Bad number"); 
    };
}

