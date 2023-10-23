List<string> binarne = new List<string>();
List<string> onlyZero = new List<string>();
List<string> onlyOne = new List<string>();
string eln;
bool check = false;
int ln = 1;
//Czytanie oraz dodawanie linijek z pliku .txt do listy
//  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/  \/
try
{
    StreamReader sr = new StreamReader("binarne.txt");
    string r = sr.ReadLine()!;
    while(r != null)
    {
        binarne.Add(r);
        r = sr.ReadLine()!;
    }
    sr.Close();
}
catch
{
    Console.WriteLine("LOL");
}
finally
{
    Console.WriteLine("NOT LOL");
}
//Sortowanie listy
binarne.Sort((a, b) => b.Length.CompareTo(a.Length));
//Wypisywanie każdej pozycji z Listy binarne
foreach(string n in binarne)
{
    for(int i = 0; i < n.Length; i++)
    {
        check = false;
        if (n[i] != n.Last())
        {
            break;
        }
        else
        {
            check = true;
        }
    }
    if (check)
    {
        if (n[0] == '0')
        {
            eln = "[" + ln + "]";
            onlyZero.Add(eln + n);
        }
        else
        {
            eln = "[" + ln + "]";
            onlyOne.Add(n);
        }
    }
    Console.WriteLine("[" + ln + "]" + n);
    ln++;
}
Console.WriteLine("Only one line: ");
foreach(string o in onlyOne)
{
    Console.WriteLine(o);
}
Console.WriteLine("Only zero line: ");
foreach (string z in onlyZero)
{
    Console.WriteLine(z);
}