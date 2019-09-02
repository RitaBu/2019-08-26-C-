### ```if```

1. Loterijos bilietą sudaro šešiaženklis numeris. Loterijoje laimi tas bilietas, kurio numerio skaitmenų suma dalosi iš 4. Nustatykite, ar loterijos bilietas yra laimingas.

```c#
int loterijosBilietoNr = 123456;

int pirmasSk = loterijosBilietoNr / 100000;
int antrasSk = loterijosBilietoNr % 100000 / 10000;
int treciasSk = loterijosBilietoNr % 10000 / 1000;
int ketvirtasSk = loterijosBilietoNr % 1000 / 100;
int penktasSk = loterijosBilietoNr % 100 / 10;
int sestasSk = loterijosBilietoNr % 10;

int skaitmenuSuma = pirmasSk + antrasSk + treciasSk + ketvirtasSk + penktasSk + sestasSk;

if(skaitmenuSuma % 4 == 0)
{
    Console.WriteLine("Valioooo! Bilietas yra laimingas!");
}
else Console.WriteLine("Bilietas nelaimingas. Bandykite dar karta.");
```

2. Petras išėjo iš namų, kai laikrodis rodė v1 valandų ir m1 minučių. Į gimnaziją Petro kelionė trunka m2 minučių. Parašykite programą, kuri ekrane parodytų pranešimą apie tai, ar Petras nepavėluos į pamoką, prasidedančią v valandų ir m minučių.

```c#

```

3. Kai kurie keturženkliai skaičiai turi tokią savybę, (30+25)2=3025. Nustatykite, ar keturženklis skaičius N turi šią savybę.

```c#
int keturzenklis = 3025;

int duPirmiSk = keturzenklis / 100;
int duPaskutiniaiSk = keturzenklis % 100;

if(Math.Pow(duPirmiSk + duPaskutiniaiSk, 2) == keturzenklis)
{
    Console.WriteLine("Turi tokia savybe.");
}
else
{
    Console.WriteLine("Tokios savybes neturi.");
}
```

### ```while```

1. Parašykite programą, kuri atspausdintų skaičių kubus intervale nuo 1 iki įvesto skaičiaus x tokiu formatu:
```Skaičius = 1, kubas = 1
Skaičius = 2, kubas = 8
Skaičius = 3, kubas = 27
...
```

```c#
Console.WriteLine("Iveskite skaiciu:");
int x = int.Parse(Console.ReadLine());

int i = 1;

while (i <= x)
{
    Console.WriteLine("Skaičius = " + i + ", Kubas = " + i*i*i);
    i++;
}
```

2. Slidininkas treniruotis pradėjo nušliuoždamas a km nuotolį. Kiekvieną kitą treniruotę jis įveikdavo b km daugiau. Parašykite programą, nurodančią kurią, treniruotę nušliuožtas nuotolis viršys c km. Pasitikrinkite. Jei a = 1, b = 1, c = 10, tai turi būti išvesta: 6. Jei a = 2, b = 3, c = 10, tai turi būti išvesta 4.

```c#
int a = 1; //pirma diena nuvaziuos toki atstuma
int b = 1; //kiekviena diena nuvaziuos b km toliau
int c = 10; //tikrinam, kada pasieks c atstuma
int tNr = 0; //treniruociu skaicius

var atstumas = 0;

while(atstumas < c)
{
    tNr++;
    atstumas = a + b * (tNr - 1);
}

Console.WriteLine(tNr);
```

3. Gobšus žemių savininkas pradėjo supirkinėti žemę. Pirmojo jo pirkto sklypo plotas – n hektarų, antrojo – m hektarų. Toliau žemvaldžio apetitas pradėjo augti. Trečiojo sklypo plotas buvo lygus pirmojo ir antrojo sklypų plotų sumai, ketvirtojo plotas – antrojo ir trečiojo plotų sumai ir t.t. Sudarykite programą, nustatančią, kelinto gobšuolio sklypo plotas viršys s hektarų. 
Pasitikrinkite. Kai n = 5, m = 6, s = 12, tai turi būti išvesta 4. Kai n = 1, m = 1, s = 10, tai turi būti išvesta 7. Kai n = 8, m = 10, s = 25, tai turi būti išvesta 4.

```c#

```

### ```for```

1. Parašykite programą, kuri šimtą kartų atspausdina tą pačią frazę kartu su jos eilės numeriu, pvz.:
```Labas
1) Labas
2) Labas Ir t.t.
```

```c#
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i + ") Labas");
}
```

2. Parašykite programą, kuri išves kas trečią skaičių nuo 1 iki 30.

```c#
for (int i = 1; i <= 30; i = i + 3)
{
    Console.WriteLine(i);
}
```

3. Kiekvieną dieną Petriukas, eidamas į mokyklą, skaičiuoja kiekvieną savo žingsnį ir žaidžia tokį žaidimą: kai žingsnių skaičius baigiasi nuliu, Petriukas suploja rankomis, o kai penketu - spragteli pirštais. Parašykite programą, kuri suskaičiuotų, kiek kartų Petriukas suplos rankomis ir kiek – spragtels pirštais, jei jam iki mokyklos yra lygiai n žingsnių.

```c#
int n = 150;

var spragtelejimuSk = 0;
var suplojimuSk = 0;

for (int i = 1; i <= n; i++)
{
    if(i % 10 == 0)
    {
        suplojimuSk++;
    }
    else if( i % 5 == 0)
    {
        spragtelejimuSk++;
    }
}

Console.WriteLine("Spragtels " + spragtelejimuSk + " kartu.");
Console.WriteLine("Suplos " + suplojimuSk + " kartu.");
```
