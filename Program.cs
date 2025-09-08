// generáljatok 22 számjegyű számokat 12000 darabot ezeket a számokat írjátok ki egy fájlba ez után a fájlból találjátok meg a legnagyobb és legkisebb számot
// legkissebb és legnagyobb átlagából hány darab szám val felette és alatta

Random rand = new Random();

int[] szamok=new int[12000];

szam();
 string szam() 
{
    for (int i = 0; i < 22; i++)
    {
        Console.Write(rand.Next(10));
    }

}
