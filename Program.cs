using System;

public class Program
{
    public static void Affiche(int[] tab, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|" + tab[i] + "|");
        }
    }
    public static bool rechercheseq(int n, int[] tab, int v)
    {

        int i = 0;
        bool f = false;
        while (i < n && f == false)
        {
            if (tab[i] == v)
            {
                f = true;
            }
            i++;
        }
        return f;
    }
    public static void remplir(int[] tab, int n)
    {

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("T[" + i + "]");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == -1)
            {
                break;

            }
            else
            {

                tab[i] = x;

            }
        }
    }
    public static bool Doublon(int[] tab, int val, int n)
    {
        int s = 0;
        bool f = false;
        for (int i = 0; i < n; i++)
        {
            if (tab[i] == val)
            {
                s++;
            }
        }
        if (s > 1)
        {
            f = true;
        }
        return f;
    }
    public static int saisie()

    {

        Console.WriteLine("saisie la taille du tableau ");
        int s = Convert.ToInt32(Console.ReadLine());
        return s;
    }
    public static int saisieval()
    {
        Console.WriteLine("saisie un variable ");
        int v = Convert.ToInt32(Console.ReadLine());
        return v;
    }
    public static int deuxiemspluspetit(int[] tab, int n)
    {
        int d = 0;
        int v = 0;

        for (int i = 0; i < n; i++)
        {
            if (Doublon(tab, tab[i], n) == true)
            {
                d = i;
            }
        }
        v = tab[d];
        int v1 = 0;
        for (int i = d + 1; i < n; i++)
        {

            if (tab[i] > v)
            {
                v1 = tab[i];
            }
        }
        return v1;
    }

    public static void Main()
    {
        int n;
        int val;
        int[] tab = new int[50];
        n = saisie();
        remplir(tab, n);
        val = saisieval();
        Doublon(tab, val, n);
        deuxiemspluspetit(tab, n);
        rechercheseq(n, tab, val);


    }
}