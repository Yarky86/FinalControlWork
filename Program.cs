// Task


// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
// [“Russia”, “Denmark”, “Kazan”] → []]

// Methods

int InputArraySize(string messageSize) // Input the size of the array
{
    Console.Write(messageSize);
    string inputSize = Console.ReadLine();
    int size;
    // try 
    // {
    //     size = Convert.ToInt32(inputSize);
    // }
    // catch (OverflowException) 
    // {
    //     // Console.WriteLine("{0} is outside the range of the Int32 type.", inputSize);
    //     size = InputArraySize($"{inputSize} is outside the range of the Int32 type. Please input an integer value -> ");
    // }
    // catch (FormatException) 
    // {
    //     // Console.WriteLine("The {0} value '{1}' is not in a recognizable format.", inputSize.GetType().Name, inputSize);
    //     size = InputArraySize($"The {inputSize.GetType().Name} value '{inputSize}' is not in a recognizable format. Please input an integer value -> ");
    // }
    if (int.TryParse(inputSize, out size))
        {
            if (size <= 0) size = InputArraySize($"The value '{inputSize}' is less or equal 0. Please input an integer value greater than 0 -> ");
        }
    else size = InputArraySize($"The {inputSize.GetType().Name} value '{inputSize}' is not in a recognizable format or outside the range of the Int32 type. Please input an integer value greater than 0 -> ");
    return size;
}

string InputArrayItem(string messageItem) // Input the item of the array
{
    Console.Write(messageItem);
    string item = Console.ReadLine();
    if (item == string.Empty)
    {
        item = InputArrayItem("Please, input not empty value -> ");
    }
    return item;
}

string[] CreateBaseArray(int arraySize) // Create a base arrat from the user
{
    string[] baseArray = new string[arraySize];
    for (int i = 0; i < baseArray.Length; i++)
    {
        baseArray[i] = InputArrayItem("Input an item for the element № " + i + " -> ");
    }
    return baseArray;
}

void PrintArray(string[] arrayToPrint, string printMessage) // Print any array
{
    Console.WriteLine(printMessage);
    for (int ii = 0; ii < arrayToPrint.Length; ii++)
    {
        Console.Write($"{arrayToPrint[ii]}, ");
    }
    Console.WriteLine();
}

string[] CreateCheckArray(string[] oldArray) // check the item of the array for 3 or less characters and paste this item to the new array
{
    string[] checkArray = new string[0];
    for (int k = 0; k < oldArray.Length; k++)
    {
        if (oldArray[k].Length <= 3)
        {
            Array.Resize(ref checkArray, checkArray.Length + 1);
            checkArray[checkArray.Length - 1] = oldArray[k];
        }
    }
    return checkArray;
}


string[] myArray = CreateBaseArray(InputArraySize("Hello, please, input a number that means the size of the new array -> "));
string[] newArray = CreateCheckArray(myArray);
PrintArray(myArray, "Here is your array -> ");
Console.WriteLine();
PrintArray(newArray, "Here is the new array with items consisting 3 or less characters from the your array ->");

