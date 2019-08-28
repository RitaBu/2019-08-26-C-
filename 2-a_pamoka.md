```c#
//uzkomentuota eilute

/* 
  uzkomentuotas kodo blokas
*/

//paselectinus norimas eilutes ir CTRL + K + C jas visas uzkomentuoja (windows)
//paselectinus norimas eilutes ir CTRL + K + U jas visas atkomentuoja (windows)
```

###Kintamieji

1.  Parašyti programą, kuri prašo įvesti apskritimo spindulį ir pagal jį suskaičiuoja jo ilgį ir plotą.
```c# 
Console.WriteLine("Iveskite apskritimo spinduli:");
var spindulysTekstas = Console.ReadLine();
var spindulys = int.Parse(spindulysTekstas);

var ilgis = 2 * Math.PI * spindulys;
var plotas = Math.PI * Math.Pow(spindulys, 2);

Console.WriteLine("Apskritimo ilgis: " + ilgis);
Console.WriteLine("Apskritimo plotas: " + plotas);

Console.ReadLine();
```
2. Parašyti programą, kuri prašo įvesti atstumą (metrais) ir laiką (sekundėmis), o iš įvestų duomenų suskaičiuoja greitį km/h formatu.

```c#
Console.WriteLine("Iveskite atstuma metrais:");
var atstumasMetraisTekstas = Console.ReadLine();
var atstumasMetrais = double.Parse(atstumasTekstas);

Console.WriteLine("Iveskite laika sekundemis:");
var laikasSekundemisTekstas = Console.ReadLine();
var laikasSekundemis = double.Parse(laikasSekundemisTekstas);

var greitis = (atstumasMetrais / 1000) / (laikasSekundemis/3600);

Console.WriteLine($"Greitis km/h: ", greitis);

Console.ReadLine();
```

3. Parašyti programą, kuri prašo įvesti vardą, pavardę ir gimimo vietą ir atspausdina juos ekrane tokiu formatu:

`Jonas Jonaitis deginasi Palangoje`


```c#
Console.WriteLine("Koks jusu vardas?");
var vardas = Console.ReadLine();

Console.WriteLine("Kokia jusu pavarde?");
var pavarde = Console.ReadLine();

Console.WriteLine("Kuriame mieste gimete?");
var miestas = Console.ReadLine();

var tekstas = vardas + " " + pavarde + " deginasi " + miestas;
Console.WriteLine(tekstas);

Console.ReadLine();
```

### Sąlygos

1. Duotas skaičius a. Parašykite programą, kuri nustatytų, ar skaičius a yra neigiamas.

```C#
int a = -3;

if(a < 0)
{
    Console.WriteLine("Neigiamas!");
}
```

2. Duoti du skaičiai a ir b. Parašykite programą, kuri nustatytų, ar šių skaičių skirtumas yra lygus -3.

```C#
int a = -3;
int b = 0;

if(a - b == -3)
{
    Console.WriteLine("Skirtumas yra - 3");
}
```

3. Parašykite programą, kuri išvestų į ekraną duotą skaičių x pakeltą kvadratu, jei jis didesnis už 5 arba padalintą iš 10, jei jis mažesnis už 5.

```C#
double x = 6.0;

if(x > 5)
{
    Console.WriteLine(x*x);
}
else if(x < 5)
{
    Console.WriteLine(x/10);
}
```

4. Parašyti programą, kuri nuskaito įvestą skaičių ir patikrintų, ar jis yra lyginis ar nelyginis.

```C#
Console.WriteLine("Iveskite skaiciu:");
var sk = int.Parse(Console.ReadLine());

if (sk % 2 == 0)
{
    Console.WriteLine("Lyginis!");
}
else
{
    Console.WriteLine("Nelyginis!");
}
```

5. Parašyti programą, kuri nuskaito savaitės dienos numerį ir atspausdina jos žodinį pavadinimą ekrane.

```C#
Console.WriteLine("Įveskite savaitės dienos numerį:");
var numeris = Console.ReadLine();

if (numeris == "1")
{
    Console.WriteLine("Pirmadienis");
}
else if (numeris == "2")
{
    Console.WriteLine("Antradienis");
}
else if (numeris == "3")
{
    Console.WriteLine("Trečiadienis");
}
else if (numeris == "4")
{
    Console.WriteLine("Ketvirtadienis");
}
else if (numeris == "5")
{
    Console.WriteLine("Penktadienis");
}
else if (numeris == "6")
{
    Console.WriteLine("Šeštadienis");
}
else
{
    Console.WriteLine("Sekmadienis");
}
```

6. Parašyti programą kalkuliatorių, kuri nuskaito 2 skaičius, nuskaito matematinį veiksmą, atlieka veiksmą ir atspausdina rezultatą ekrane tokiu formatu:
“{pirmas skaicius} {matematinis veiksmas} {antras skaičius} = {rezultatas}”

```C#
Console.WriteLine("Įveskite pirmą skaičių:");
var sk1 = int.Parse(Console.ReadLine());

Console.WriteLine("Įveskite antrą skaičių:");
var sk2 = int.Parse(Console.ReadLine());

Console.WriteLine("Įveskite operatorių:");
var o = Console.ReadLine();

if(o == "+")
{
    Console.WriteLine(sk1 + " + " + sk2 + " = " + (sk1 + sk2));
}
else if (o == "-")
{
    Console.WriteLine(sk1 + " + " + sk2 + " = " + (sk1 - sk2));
}
else if (o == "*")
{
    Console.WriteLine(sk1 + " + " + sk2 + " = " + (sk1 * sk2));
}
else if (o == "/")
{
    Console.WriteLine(sk1 + " + " + sk2 + " = " + (sk1 / sk2));
}
else
{
    Console.WriteLine("nežinau tokios operacijos!");
}
```

