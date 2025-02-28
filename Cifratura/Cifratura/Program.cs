string sostituzione(string parola, int s, string alfabeto, ref string sost)
{
    for(int i = 0; i < parola.Length; i++)
    {
        for(int j = 0; j < alfabeto.Length; j++)
        {
            if (parola[i] == alfabeto[j])
            {
                if(j + s >= alfabeto.Length)
                {
                    sost += alfabeto[j + s - alfabeto.Length];
                }
                else
                {
                    sost += alfabeto[j + s];
                }             
            }
        }
    }
    return sost;
}
string trasposizione(int t, string sost, ref string trasp)
{
    for(int i = 0; i < sost.Length; i++)
    {
        if(i < t)
        {
            trasp += sost[i - t + sost.Length];
        }
        else
        {
            trasp += sost[i - t];
        }
    }
    return trasp;
}
string ritornoS(string trasp, int s, string alfabeto, ref string semifinale)
{
    for (int i = 0; i < trasp.Length; i++)
    {
        for (int j = 0; j < alfabeto.Length; j++)
        {
            if (trasp[i] == alfabeto[j])
            {
                if (j - s < 0)
                {
                    semifinale += alfabeto[j - s + alfabeto.Length];
                }
                else
                {
                    semifinale += alfabeto[j - s];
                }
            }
        }
    }
    return semifinale;
}
string ritornoT(int t, string semifinale, ref string finale)
{
    for (int i = 0; i < semifinale.Length; i++)
    {
        if (i + t >= semifinale.Length)
        {
            finale += semifinale[i + t - semifinale.Length];
        }
        else
        {
            finale += semifinale[i + t];
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
string sost = "", trasp = "", semifinale = "", finale = "";
Console.WriteLine(sostituzione(parola, s, alfabeto, ref sost));
Console.WriteLine(trasposizione(t, sost, ref trasp));
Console.WriteLine(ritornoS(trasp, s, alfabeto, ref semifinale));
Console.WriteLine(ritornoT(t, semifinale, ref finale));
