string[] initArray = ["Hello", "2", "world", ":-)"];

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