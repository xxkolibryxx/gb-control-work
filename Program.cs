string[] initArray = ["Hello", "2", "world", ":-)"];
// string[] initArray = ["1234", "1567", "-2", "computer science"];
// string[] initArray = ["Russia", "Denmark", "Kazan"];

static string[] filterArray(string[] array)
{
    List<string> output = [];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            output.Add(array[i]);
        }
    }
    return [.. output];
}
static void printArrayResult(string[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}
string[] result = filterArray(initArray);
printArrayResult(result);
