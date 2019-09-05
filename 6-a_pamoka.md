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
