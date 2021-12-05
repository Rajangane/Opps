// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Object Oriented Programs *****************");

using Object_Oriented_Programs;

Console.Write("Select Number:\n1)Stock\n2)DeckOfCards");
int option = Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1:
        new Stock().add();
        break;
    case 2:
        new DeckOfCards().CardsCreator();
        break;

    default:
        Console.WriteLine("invalid choice");
        break;
}