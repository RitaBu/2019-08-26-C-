### ```while``` ciklas

12. Martynas labai mėgsta saldainius. Mamos slėptuvėje jis rado m saldainių. Pirmą dieną jis suvalgė 1 saldainį, antrąją – 2, trečiąją – 3. Kiekvieną kitą dieną jis suvalgydavo vienu saldainiu daugiau negu prieš tai buvusią dieną. Per kelias dienas d Martynas suvalgys visus saldainius? Paskutinei dienai gali likti mažiau saldainių. 

```c#
Console.WriteLine("Įveskite saldainių skaičių:");
var m = int.Parse(Console.ReadLine());

int d = 0; //kiek dienu Martynas uztruks

while (m > 0)
{
    d++;
    m = m - d; // arba m -= d;
}

Console.WriteLine("Martynas saldainius suvalgys per " + d + " dienų");
```

13. Parašykite programą klaviatūra renkamai teigiamų skaičių sekai analizuoti: suskaičiuokite, kiek yra šioje sekoje lyginių ir nelyginių skaičių. Sekos pabaigos požymis – nulis. 

```c#
bool pabaiga = false;
int lyginiuSk = 0;
int nelyginiuSk = 0;

while (!pabaiga) //kol ne pabaiga
{
    Console.WriteLine("Įveskite skaičių:");
    var sk = int.Parse(Console.ReadLine());

    if(sk == 0)
    {
        pabaiga = true;
    }
    else
    {
        if(sk % 2 == 0)
        {
            lyginiuSk++;
        }
        else
        {
            nelyginiuSk++;
        }
    }
}

Console.WriteLine("Rasta tiek lyginiu skaičių: " + lyginiuSk + ", ir tiek nelyginių: " + nelyginiuSk);
```

14. Parašykite programą klaviatūra renkamos skaičių sekos aritmetiniam vidurkiui rasti. Sekos pabaigos požymis – nulis.

```c#
bool pabaiga = false;
double suma = 0;
int kiekis = 0;

while (!pabaiga) //kol ne pabaiga
{
    Console.WriteLine("Įveskite skaičių:");
    var sk = int.Parse(Console.ReadLine());

    if(sk == 0)
    {
        pabaiga = true;
    }
    else
    {
        suma += sk;
        kiekis++;
    }
}

Console.WriteLine("Sekos vidurkis: " + suma / kiekis);
```

#### Papildomos užduotys

1. Bankas už indėlius moka p procentų palūkanų per metus. Metų gale palūkanos pridedamos prie indėlio. Jei indėlininkas pinigų nė kiek neišima, palūkanos skaičiuojamos nuo vis didesnės sumos. Parašykite programą, kuri apskaičiuotų, per kiek metų t pradinis indėlis ind pasieks sumą s. 

```c#
double p = 5;
double ind = 1000;
double s = 1200;
int t = 0;

while(ind < s)
{
    ind = ind * (1 + p / 100); // arba ind *= (1 + p / 100);
    t++;
}

Console.WriteLine("Pradinis indelis pasieks reikiama suma per " + t + " metu.");
```

2. Nurodytas natūralusis skaičius n. Parašykite programą, nustatančią, ar jis lygus iš eilės einančių natūraliųjų skaičių (pradedant vienetu) sumai. Pvz.: jei n = 15, tai turi būti išvesta: TAIP. Jei n =12, tai turi būti išvesta: NE. 

```c#
int n = 15;
int i = 1;
int suma = 0;

while(suma < n)
{
    suma = suma + i;
    i++;
}

if(suma == n)
{
    Console.WriteLine("TAIP");
}
else
{
    Console.WriteLine("NE");
}
```

### ```for``` ciklas

1. Parašykite programą, kuri išvestų į ekraną 5 kartus tą patį žodį.

```c#
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("skruzdėda");
}

Console.ReadLine();
```

2. Parašykite programą, kuri išveda į ekraną skaičius nuo 1 iki 100.

```c#
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
```

3. Parašykite programą, kuri išveda į ekraną skaičius nuo 1 iki įvesto skaičiaus x.

```c#
Console.WriteLine("Iveskite skaiciu");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    Console.WriteLine(i);
}
```

4. Parašykite programą, kuri išveda į ekraną skaičius nuo įvesto skaičiaus x iki x+10.

```c#
Console.WriteLine("Iveskite skaiciu");
int x = int.Parse(Console.ReadLine());

for (int i = x; i <= x + 10; i++)
{
    Console.WriteLine(i);
}
```

5. Parašykite programą, kuri išvestų skaičius nuo m iki n.

```c#
Console.WriteLine("Iveskite skaiciu m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite skaiciu n:");
int n = int.Parse(Console.ReadLine());

for (int i = m; i <= n; i++)
{
    Console.WriteLine(i);
}
```

6. Parašykite programą, kuri suskaičiuotų skaičių nuo m iki n sumą ```s = m + (m+1) +... + n```
Pvz.: kai m = 5, n = 10, tai s = 45.

```c#
Console.WriteLine("Iveskite skaiciu m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Iveskite skaiciu n:");
int n = int.Parse(Console.ReadLine());

int suma = 0;

for (int i = m; i <= n; i++)
{
    suma = suma + i; //arba suma += i;
}

Console.WriteLine("Suma: " + suma);
```

7. Parašykite programą, kuri suskaičiuotų skaičiaus n faktorialą ```s= 1 * 2 *... * n.```

```c#
Console.WriteLine("Iveskite skaiciu n:");
int n = int.Parse(Console.ReadLine());

int faktorialas = 1;

for (int i = 1; i <= n; i++)
{
    faktorialas = faktorialas * i;
}

Console.WriteLine("Skaiciaus " + n + " faktorialas: " + faktorialas);
```

8. Parašykite programą, kuri suskaičiuotų, kiek yra triženklių skaičių, besidalinančių iš keturių ir išvestų juos į ekraną.

```c#
int dalinasiIs4 = 0;

for (int i = 100; i <= 999; i++)
{
    if(i % 4 == 0)
    {
        dalinasiIs4++;
    }
}

Console.WriteLine(dalinasiIs4 + " trizenkliai skaiciai dalinasi is 4-iu.");
```

#### Papildomos užduotys

9. Architektas suprojektavo salę, kurioje bus n eilių. Pirmoje eilėje stovės k kėdžių, o kiekvienoje kitoje – 2 kėdėmis daugiau, negu prieš tai buvusioje. Parašykite programą, kuri apskaičiuotų, kiek iš viso kėdžių s reikia užsakyti, kad architekto sumanymas būtų įgyvendintas.
Pvz., kai n = 3, o k = 8, turi būti išvesta: Reikia užsakyti s = 30 kėdžių.

```c#
int n = 3;
int k = 8;
int s = 0;

for (int i = 1; i <= n; i++)
{
    s = s + k + 2*(i - 1);
}

Console.WriteLine("Reikes kedziu: " + s);
```

10. Keliamieji metai turi 366 dienas, paprastieji – 365.  Jeigu metai nėra šimtmečio metai, jie yra keliamieji, jeigu dalosi iš 4; Jeigu metai yra šimtmečio metai, jie yra keliamieji, jeigu dalosi iš 400 (pvz., 2000 ir 2400 metai yra keliamieji, o 2100, 2200, 2300 metai – ne keliamieji). Parašykite programą, kuri ekrane parodytų keliamuosius metus laikotarpio, kuris prasideda m-aisiais, o baigiasi n-aisiais metais. 
Pvz., kai m = 1898, o n = 1910, tai turi būti išvesta: Keliamieji metai yra 1904, 1908.

```c#
int m = 1898;
int n = 1910;

Console.WriteLine("Keliamieji metai yra:");

for (int i = m; i <= n; i++)
{
    if((i % 100 == 0 && i % 400 == 0) || (i % 100 != 0 && i % 4 == 0))
    {
        Console.WriteLine(i);
    }
}
```
