using ExceptionsDemo;

Console.WriteLine("Lūdzu ievadi skaitli?");
string numberText = Console.ReadLine();

try
{
    int userNumber = int.Parse(numberText);
    Console.WriteLine($"Tu ievadīji skaitli: {userNumber}");
}
catch (FormatException ex)
{
    string exceptionMessage = ex.Message;

    Console.WriteLine("Tas nebija skaitlis");
    Console.WriteLine($"Apstrādes kļūda: {exceptionMessage}");
}
finally
{
 
    Console.WriteLine($"nosledz konekciju");
}

Console.WriteLine("Programmas beigas");

Console.WriteLine();
Console.WriteLine("==================");
Console.WriteLine();


Console.WriteLine("Ievadi tekstu?");
string userText = Console.ReadLine();

if (string.IsNullOrWhiteSpace(userText))
{
    throw new NotFoundException("Lietotājs neievadīja tekstu");
}
else
{
    Console.WriteLine($"Tavs teksts: {userText}");
}
