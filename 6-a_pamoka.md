1.1 Deklaruokite skaičių masyvą, kuriame bus 15-a skaičių - neigiamų ir teigiamų.

```c#
int[] skaiciai = { -8, 10, 8, 19, 45, -8, -10, 88, 19, 95, -8, 10, 12, 1, -4 };
```

1.2 Atspausdinkite masyvą vienoje eilutėje palikdami tarpus tarp skaičių.

```c#
for (int i = 0; i < skaiciai.Length; i++)
{
    Console.Write(skaiciai[i] + " ");
}
```

1.3 Raskite masyve didžiausią skaičių.

```c#
int max = skaiciai[0];

for (int i = 0; i < skaiciai.Length; i++)
{
    if(skaiciai[i] > max)
    {
        max = skaiciai[i];
    }
}

Console.WriteLine("Didžiausias skaičius: " + max);
```

1.4 Suskaičiuokite, kiek masyve yra neigiamų skaičių.

```c#
int neigSk = 0;

for (int i = 0; i < skaiciai.Length; i++)
{
    if(skaiciai[i] < 0)
    {
        neigSk++;
    }
}

Console.WriteLine("Rasta neigiamų skaičių: " + neigSk);
```

1.5 Paverskite masyve visus neigiamus skaičius teigiamais, o teigiamus - neigiamais.

```c#
for (int i = 0; i < skaiciai.Length; i++)
{
    skaiciai[i] = skaiciai[i] * -1;
}
```

2.2 Deklaruokite 20-ies skaičių masyvą.

```c#
int[] skaiciai = { 99, 4, -18, -10, 78, -6, 10, 8, 19, 45, -8, -10, 88, 19, 95, -8, 10, 12, 1, -4 };
```

2.3 Suskaičiuokite, kiek masyve yra lyginių skaičių, o kiek nelyginių.

```c#
int lyginiuSk = 0;
int nelyginiuSk = 0;

for (int i = 0; i < skaiciai.Length; i++)
{
    if (skaiciai[i] % 2 == 0)
    {
        lyginiuSk++;
    }
    else
    {
        nelyginiuSk++;
    }
}

Console.WriteLine("Lyginiu skaicius: " + lyginiuSk);
Console.WriteLine("Neyginiu skaicius: " + nelyginiuSk);
```

2.4 Atspausdinkite kas trečią masyvo elementą.

```c#
for (int i = 0; i < skaiciai.Length; i = i + 3)
{
    Console.Write(skaiciai[i] + " ");
}
```

2.5 Raskite didžiausią ir mažiausią reikšmes masyve.

```c#
int min = 0;
int max = 0;

for (int i = 0; i < skaiciai.Length; i++)
{
    if(skaiciai[i] < min)
    {
        min = skaiciai[i];
    }
    else if(skaiciai[i] > max)
    {
        max = skaiciai[i];
    }
}

Console.WriteLine("Maziausia reiksme: " + min);
Console.WriteLine("Didziausia reiksme: " + max);
```

2.6 Suskaičiuokite, kiek skaičių masyve dalinasi iš 5.

```c#
int dalinasIs5 = 0;

for (int i = 0; i < skaiciai.Length; i++)
{
    if(skaiciai[i] % 5 == 0)
    {
        dalinasIs5++;
    }
}

Console.WriteLine(dalinasIs5 + " skaiciai dalinasi is 5-iu.");
```

3. Masyve įrašyti n žmonių gimimo metai. Sudarykite programą, kuri nustatytų didžiausią žmonių amžiaus skirtumą.
Duomenys: ```1989, 1988, 2010, 2007, 1999, 1994, 1974, 1963, 1932, 1950, 1967, 2003, 2000```

4. Krituliai

```c#
int[] krituliai = { 10, 20, 0, 0, 0, 45, 25, 30, 50, 25 };

//1.

Console.WriteLine("Krituliai (lietus)");
Console.WriteLine("-------------------------------");
Console.WriteLine("  Diena\tKritulių kiekis (mm)");
Console.WriteLine("-------------------------------");

for (int i = 0; i < krituliai.Length; i++)
{
    Console.WriteLine($"  {i + 1}\t{krituliai[i]}");
}

//2.
int krituliuSuma = 0;

foreach (var k in krituliai)
{
    krituliuSuma += k;
}

Console.WriteLine($"Iš viso iškrito kritulių (mm): {krituliuSuma}");

//3.
int dienuBeLietausSk = 0;

foreach (var k in krituliai)
{
    if (k == 0)
        dienuBeLietausSk++;
}
Console.WriteLine($"Nelijo (dienas): {dienuBeLietausSk}");

//4.

int lietinguDienuKrituliuVid = krituliuSuma / (krituliai.Length - dienuBeLietausSk);
Console.WriteLine($"Vidutiniškai kiekvieną lietingą dieną iškrito kritulių (mm): {lietinguDienuKrituliuVid}");
```

5. Ūgiai

```c#
int[] ugiai = { -178, 175, -186, 172, 173, 175, -185, -180, -169, 165, 176, 172, -180, 176, -190, 176, -174, 177, -172, 178 };

//1.
double ugiuSuma = 0;

foreach (var ugis in ugiai)
{
    //berniuku ugius reikia paverst i teigiamus skaicius
    ugiuSuma += ugis < 0 ? ugis * -1 : ugis;
}

Console.WriteLine($"Klasės ūgių vidurkis (cm): {ugiuSuma/ugiai.Length}");
//2. ir 3.
double merginuUgiuSuma = 0;
int merginuSk = 0;
double vaikinuUgiuSuma = 0;
int vaikinuSk = 0;

foreach (var ugis in ugiai)
{
    if (ugis > 0)
    {
        merginuUgiuSuma += ugis;
        merginuSk++;
    }
    else
    {
        vaikinuUgiuSuma += ugis * -1;
        vaikinuSk++;
    }
}

Console.WriteLine($"Merginų ūgių vidurkis (cm): {merginuUgiuSuma / merginuSk}");
Console.WriteLine($"Vaikinų ūgių vidurkis (cm): {vaikinuUgiuSuma / vaikinuSk}");


//4.

int merginuKomanda = 0;
int vaikinuKomanda = 0;

foreach (var ugis in ugiai)
{
    if (ugis < 0 && ugis <= -175)
    {
        vaikinuKomanda++;
    }
    else if (ugis > 0 && ugis >= 175)
    {
        merginuKomanda++;
    }
}

if (vaikinuKomanda >= 7)
{
    Console.WriteLine("Vaikinų komandą sudaryti pavyks.");
}
else Console.WriteLine("Vaikinų komandos sudaryti nepavyks.");

if (merginuKomanda >= 7)
{
    Console.WriteLine("Merginų komandą sudaryti pavyks.");
}
else Console.WriteLine("Merginų komandos sudaryti nepavyks.");
```

