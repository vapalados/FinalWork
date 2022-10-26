string[] VvodMass()
{
    Console.WriteLine("Введите значения через запятую без пробела: ");
    return Console.ReadLine().Split(",");
}
int Magic(string[] arr, int n)
{
    int dlina = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= n)
            dlina++;
    }
    return dlina;
}
string[] Itog(string[] VvodMassiva, int n)
{
    string[] result = new string[Magic(VvodMassiva, n)];
    for (int i = 0, j = 0; i < VvodMassiva.Length; i++)
    {
        if (VvodMassiva[i].Length <= n)
        {
            result[j] = VvodMassiva[i];
            j++;
        }
    }
    return result;
}
string[] vvod = VvodMass();
string[] vivod = Itog(vvod, 3);
Console.WriteLine($"{string.Join(", ", vvod)} -> {string.Join(", ", vivod)}");