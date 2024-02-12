// See https://aka.ms/new-console-template for more information
// rakendus küsib kasutajal sisestada tema vanuse
// kui kasutaja vanus on alla 13, siiskonsoolis kuvatakse: 
//"you are too young to use Instagram"
//muul juhul
// "welcome to Instagram"

Console.WriteLine("Enter your age" );
string userAge = Console.ReadLine();
int userAgeNum = 0;
//boolean- true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

Console.WriteLine($"Parse result {userAgeNum} years old. ");

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old");

if(isAgeNumber == true)
{
    if(userAgeNum >=13)
    {
        Console.WriteLine("Welcome to Instagram");
            }
    else
    {
        Console.WriteLine("You are too young to use Instagram");
     }
}
else
{
    Console.WriteLine("Colud not read your age");
}
