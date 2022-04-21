// See https://aka.ms/new-console-template for more information
using line_comparision;

Console.WriteLine("Welcome to Line Comparison!");


while (true)
{

    Console.WriteLine("Choose the Program to be executed :\n1)createline\n2)comparingtwolinesusingEqualTo\n3)comparingtwolinesusingCompareTo");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            creatingline line = new();
            line.Line();
            break;
        case 2:
            comparingtwolines equaltomethod = new();
            equaltomethod.EqualtoMethod();
            break;
        case 3:
            comparetomethod compareto = new();
            compareto.CompareTo();
            break;
        default:
            break;

    }
}