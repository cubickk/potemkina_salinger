
using System;
using System.Security.Cryptography.X509Certificates;

enum Typ { Nalozit, Nalozeno, Vylozeno, PrijezdDoB, PrijezdDoA };

public int pisekA;
public int pisekB;
public int pisekMezi;
public int cas;
public int KdyNakladat;
public int pocetAut = 4;

for (int i = 0; i<pocetAut; i++)
{
    new Auto(15, 60, 5, 120);
}

var kalendar = new PriorityQueue<Udalost, int>();

public void Planuj(Auto a, int k, Typ c)
{
    kalendar.Enqueue(new Udalost(a, k, c), k);
}
public void Nalozit(Auto a)
{
    Planuj(a, a.dobaNakladani, Nalozeno);   
}
public void Nalozeno(Auto a)
{
    pisekA -= a.nosnost;
    pisekMezi += a.nosnost;
    Planuj(a, a.dobaJizdy, PrijezdDoB);
}
public void PrijezdDoB(Auto a)
{
    Planuj(a, a.dobaVykladani, Vylozeno)
}
public void Vylozeno(Auto a)
{
    pisekMezi -= a.nosnost;
    pisekB += a.nosnost;
    Planuj(a, a.dobaJizdy, PrijezdDoA);
}

    

class Auto;
{
    int nosnost;
    int dobaNakladani;
    int dobaJizdy;
    int dobaVykladani;
    public Auto(int n, int dn, int dj, int dv)
    {
        nosnost = n;
        dobaNakladani = dn;
        dobaJizdy = dj;
        dobaVykladani = dv;
    }
}

class Udalost
{
    Auto kdo;
    int kdy;
    Typ co;
    public Udalost(Auto a, int k, Typ c)
    {
        kdo = a;
        kdy = k;
        co = c;
    }
}

