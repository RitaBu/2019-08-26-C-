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



