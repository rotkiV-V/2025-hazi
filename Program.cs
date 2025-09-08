// generáljatok 22 számjegyű számokat 12000 darabot ezeket a számokat írjátok ki egy fájlba ez után a fájlból találjátok meg a legnagyobb és legkisebb számot
// legkissebb és legnagyobb átlagából hány darab szám val felette és alatta

using System.Runtime.ExceptionServices;

Random rand = new Random();

int[] szamok=new int[12000];

 string szam() 
{
    string vissza = "";
    vissza += rand.Next(1,10);

    
    for (int i = 0; i < 21; i++)
    {
        vissza+=rand.Next(10);
    }
    return vissza;
}
Console.WriteLine(szam());
using (StreamWriter iras = new StreamWriter("szamok.txt"))
{
    for (int i = 0;i < 12000; i++)
    {
        iras.WriteLine(szam());
    }
}
    