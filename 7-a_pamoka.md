### masyvai

Ūgių ir Kritulių uždavinių atsakymus rasite šeštos pamokos atsakymuose [čia](https://github.com/RitaBu/2019-08-26-C-sharp/blob/master/6-a_pamoka.md).

Gyventojai.
Gatvėje yra 10 namų. Namai, kurių numeriai yra lyginiai, stovi dešiniojoje gatvės pusėje, o kurių nelyginiai - kairiojoje. Sukurkite programą, kuri apskaičiuotų:

1. Kiek gyventojų iš viso gyvena gatvėje

```c#
int[] gyventojai = { 5, 4, 4, 5, 6, 5, 0, 0, 5, 0 };

int isVisoGyventoju = 0;

for (int i = 0; i < gyventojai.Length; i++)
{
    isVisoGyventoju = isVisoGyventoju + gyventojai[i];
}

Console.WriteLine("Is viso gyventoju: " + isVisoGyventoju);
```

2. Kiek gyventojų gyvena kairiojoje gatvės pusėje ir kiek dešiniojoje
3. Kiek vidutiniškai gyvena gyventojų name, kuris stovi dešiniojoje gatvės pusėje ir kiek vidutiniškai gyvena gyventojų name, kuris stovi kairiojoje.

```c#
double isVisoGyventojuK = 0;
double isVisoGyventojuD = 0;

int gyventojuSkK = 0;
int gyventojuSkD = 0;

for (int i = 0; i < gyventojai.Length; i++)
{
    if (i + 1 % 2 == 0)
    {
        isVisoGyventojuD = isVisoGyventojuD + gyventojai[i];
        gyventojuSkD++;
    }
    else
    {
        isVisoGyventojuK = isVisoGyventojuK + gyventojai[i];
        gyventojuSkK++;
    }
}

Console.WriteLine("Is viso gyventoju kairej: " + isVisoGyventojuK);
Console.WriteLine("Is viso gyventoju desinej: " + isVisoGyventojuD);

Console.WriteLine("Vidutiniskai gyventoju kairej: " + isVisoGyventojuK/gyventojuSkK);
Console.WriteLine("Vidutiniskai gyventoju desinej: " + isVisoGyventojuD/gyventojuSkD);
```

