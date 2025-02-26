string sostituzione(string parola, int s, string alfabeto, ref string finaleS)
{
    for(int i = 0; i < parola.Length; i++)
    {
        for(int j = 0; j < alfabeto.Length; j++)
        {
            if (parola[i] == alfabeto[j])
            {
                if(j + s >= alfabeto.Length)
                {
                    int diff = j + s - alfabeto.Length;
                    finaleS += alfabeto[diff];
                }
                else
                {
                    finaleS += alfabeto[j + s];
                }             
            }
        }
    }
    return finaleS;
}
string trasposizione(int t, string finaleS, ref string finale)
{
    for(int i = 0; i < finaleS.Length; i++)
    {
        if(i + t >= finaleS.Length)
        {
            int diff = i + t - finaleS.Length;
            finale += finaleS[diff];
        }
        else
        {
            finale += finaleS[i + t];
        }
    }
    return finale;
}
Console.WriteLine("Inserisci parola");
string p = Console.ReadLine();
string parola = p.ToLower();
string alfabeto = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine("Chiave sostituzione");
int s = Int32.Parse(Console.ReadLine());
Console.WriteLine("Chiave trasposizione");
int t = Int32.Parse(Console.ReadLine());
string finaleS = "";
Console.WriteLine(sostituzione(parola, s, alfabeto, ref finaleS));
string finale = "";
Console.WriteLine(trasposizione(t, finaleS, ref finale));
