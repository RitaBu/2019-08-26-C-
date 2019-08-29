### Sąlygos

[1-6 užduočių sprendimus rasite čia.](https://github.com/RitaBu/2019-08-26-C-sharp/blob/master/2-a_pamoka.md)

7. Laurynas žino, kad mokytoja jam gali duoti spręsti vieną iš trijų kontrolinio darbo variantų. Atlikdamas užduotį jis gaus du skaičius a ir b, o jam reikės apskaičiuoti x reikšmę pagal vieną iš trijų formulių:
 - Pirmas variantas: x = ab+3;
 - Antras variantas: x = 2a+b;
 - Trečias variantas: x = a-3b.
Parašykite programą, kuri padėtų Laurynui pasitikrinti, ar jis teisingai skaičiuoja x reikšmę spręsdamas kiekvieno varianto užduotį.

```c#
 Console.WriteLine("Įveskite skaičių a:");
 int a = int.Parse(Console.ReadLine());

 Console.WriteLine("Įveskite skaičių b:");
 int b = int.Parse(Console.ReadLine());

 Console.WriteLine("Įveskite varianto numerį:");
 int numeris = int.Parse(Console.ReadLine());

 if (numeris == 1)
 {
     Console.WriteLine("x = ab+3 = " + (a * b + 3));
 }
 else if (numeris == 2)
 {
     Console.WriteLine("x = 2a + b = " + (2 * a + b));
 }
 else if (numeris == 3)
 {
     Console.WriteLine("x = a - 3b = " + (a - 3 * b));
 }
 else
 {
     Console.WriteLine("Tokio varianto nėra.");
 }
```
---------------------

1. Duoti du skaičiai a ir b. Parašykite programą, kuri nustatytų, ar šių skaičių suma yra lygi 5.

```c#
int a = 2;
int b = 3;

if(a + b == 5)
{
    Console.WriteLine("Suma lygi 5.");
}
```

2. Duotas skaičius a. Parašykite programą, kuri nustatytų, ar šis skaičius dalijasi iš 3 be liekanos.

```c#
int sk = 6;

if(sk % 3 == 0)
{
    Console.WriteLine("Skaicius dalinasi is 3-ju.");
}
```

3. Parašykite programą, kuri išvestų į ekraną duotą skaičių x padidintą 2 kartus, jei jis didesnis už 10.

```c#
int x = 15;

if(x > 10)
{
    Console.WriteLine(x*2);
}
```

4. Parašykite programą, kuri nustatytų, ar terminale įvestas skaičius yra teigiamas, neigiamas ar nulinis.

```c#
Console.WriteLine("Iveskite skaicius:");
int sk = int.Parse(Console.ReadLine());

if(sk > 0)
{
    Console.WriteLine("Skaicius yra teigiamas.");
}
else if(sk < 0)
{
    Console.WriteLine("Skaicius yra neigiamas.");
}
else
{
    Console.WriteLine("Skaicius yra lygus 0.");
}
```

5. Duotas keturženklis skaičius x. Parašykite programą, kuri nustatytų, ar šio skaičiaus pirmasis skaitmuo yra lyginis skaičius.

```c#
int keturzenklis = 1234;

//cia dalinant kompiuteris numeta liekana, nes operuojame sveikais skaiciais
//tada mus ir lieka pirmas skaitmuo - kuris nusako, kiek tukstanciu yra skaiciuje
int pirmasSkaitmuo = keturzenklis / 1000; 

if(pirmasSkaitmuo % 2 == 0)
{
    Console.WriteLine("Pirmas skaitmuo yra lyginis.");
}
else 
{
    Console.WriteLine("Pirmas skaitmuo yra nelyginis.");
}
```

6. Pirmosios olimpinės žaidynės įvyko 1896 metais ir toliau organizuojamos kas ketveri metai. Jei žaidynės neįvyksta, tie metai vis tiek laikomi olimpiniais, o žaidynėms skiriamas eilės numeris. Parašykite programą, kuri surastų m-tųjų metų olimpinių žaidynių numerį n. Jei metai neolimpiniai, turi būti spausdinama „Metai neolimpiniai“. ‘ Pvz.: Kai m = 1904, turi būti spausdinama: Metai olimpiniai, žaidynių eilės numeris yra 3. Kai m = 2005, turi būti spausdinama: Metai neolimpiniai.

```c#
int pirmosOlimpines = 1986;

Console.WriteLine("Iveskite metus:");
int metai = int.Parse(Console.ReadLine());

if(metai >= pirmosOlimpines)
{
    int skirtumas = metai - pirmosOlimpines;
    if (skirtumas % 4 == 0)
    {
        int kelintos = skirtumas / 4 + 1;
        Console.WriteLine("Tai olimpiniai metai. Olimpiniu zaidyniu numeris: " + kelintos);
    }
    else Console.WriteLine("Metai nera olimpiniai.");
}
```

7. Gamtininkas registruoja likusius žiemoti paukščius. Jo tikslas yra nustatyti, kurios iš trijų paukščių rūšių atstovų liko žiemoti daugiausia. Klaviatūra įvedami trijų paukščių rūšių kiekiai, parašykite programą, kuri surikiuotų juos iš eilės nuo didžiausio iki mažiausio ir apskaičiuotų, kiek skiriasi didžiausias ir mažiausias kiekiai. Pvz.: Įvesti kiekiai - 1000 1500 1800, Atsakymas - 1800 1500 1000; Skirtumas tarp didžiausio ir mažiausio kiekio 800.

```c#
Console.WriteLine("Įveskite pirmos rūšies paukščių skaičių:");
int pirmosRusiesSk = int.Parse(Console.ReadLine());
Console.WriteLine("Įveskite antros rūšies paukščių skaičių:");
int antrosRusiesSk = int.Parse(Console.ReadLine());
Console.WriteLine("Įveskite trecios rūšies paukščių skaičių:");
int treciosRusiesSk = int.Parse(Console.ReadLine());


if (pirmosRusiesSk > antrosRusiesSk && pirmosRusiesSk > treciosRusiesSk)
{
    if (antrosRusiesSk > treciosRusiesSk)
    {
        Console.WriteLine($"{pirmosRusiesSk} {antrosRusiesSk} {treciosRusiesSk}");
    }
    else
    {
        Console.WriteLine($"{pirmosRusiesSk} {treciosRusiesSk} {antrosRusiesSk}");
    }
}
if (antrosRusiesSk > pirmosRusiesSk && antrosRusiesSk > treciosRusiesSk)
{
    if (pirmosRusiesSk > treciosRusiesSk)
    {
        Console.WriteLine($"{antrosRusiesSk} {pirmosRusiesSk} {treciosRusiesSk}");
    }
    else
    {
        Console.WriteLine($"{antrosRusiesSk} {treciosRusiesSk} {pirmosRusiesSk}");
    }
}
if (treciosRusiesSk > pirmosRusiesSk && treciosRusiesSk > antrosRusiesSk)
{
    if (pirmosRusiesSk > antrosRusiesSk)
    {
        Console.WriteLine($"{treciosRusiesSk} {pirmosRusiesSk} {antrosRusiesSk}");
    }
    else
    {
        Console.WriteLine($"{treciosRusiesSk} {antrosRusiesSk} {pirmosRusiesSk}");
    }
}
```

### ```while``` ciklas

1. Parašykite programą naudojant while ciklą, kuri išvestų 10 pirmų natūraliųjų skaičių.

```c#
int i = 1;
while(i <= 10) 
{
  Console.WriteLine(i);
  i++;
}
Console.ReadLine();
```

2. Parašyti programą naudojant `while` ciklą, kuri nuskaitinėja įvestus skaičius tol, kol jų suma nėra daugiau 50.

```c#
int sum = 0;
while(sum < 50) 
{
  int number = int.Parse(Console.ReadLine());
  sum += number;
  Console.WriteLine($"suma: {sum} ");
}
Console.ReadLine();
```

3. Sukurkite programą naudojant while ciklą, kuri apskaičiuotų dvejeto laipsnį 2n, kuris yra ne didesnis už teigiamą sveikąjį skaičių a. 
Pvz.: Jei a = 20, tai turi būti išvesta 16. Jei a = 1024, tai turi būti išvesta 1024.

```c#
Console.WriteLine("Iveskite skaiciu: ");
int sk = int.Parse(Console.ReadLine());

int laipsnis = 0;
while(sk > 1) 
{
  sk = sk / 2; //arba sk/=2;
  laipsnis++;
}

Console.WriteLine(Math.Pow(2, laipsnis));
Console.ReadLine();
```
