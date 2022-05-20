// See https://aka.ms/new-console-template for more information
String[] array_name = new string[6];
array_name[0] = "Jemmie";
array_name[1] = "Jessica";
array_name[2] = "Ahl";
array_name[3] = "alea";
array_name[4] = "luke";
array_name[5] = "Arcilla";

foreach (String name in array_name)
{
    Console.WriteLine(name);
}
Console.WriteLine("how many names is listed on the array list?");

string userName = Console.ReadLine();

int time = 6;
if (time < 4)
{
    Console.WriteLine("Correct");
}
else
{
    Console.WriteLine("the right answer is 6");
}