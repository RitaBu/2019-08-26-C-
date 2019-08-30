### Sąlygos

1. Programa paprašo vartotojo įvesti skaičių nuo 0 iki 5. Įvedus programa nustato kokį skaičių įvedė vartotojas ir atspausdina tekstu. Pvz jei vartotojas įvedė 5 programa atspausdina “Penki”. Jei vartotojas įvedė skaičių, kuris nėra tarp 0 ir 5 programa atspausdina: “Bad input”.

```c#
Console.WriteLine("Įveskite skaičių:");
var sk = int.Parse(Console.ReadLine());

switch (sk)
{
    case 1:
        Console.WriteLine("Vienas");
        break;
    case 2:
        Console.WriteLine("Du");
        break;
    case 3:
        Console.WriteLine("Trys");
        break;
    case 4:
        Console.WriteLine("Keturi");
        break;
    case 5:
        Console.WriteLine("Penki");
        break;
    default:
        Console.WriteLine("Bad input");
        break;
}
```

2. Parašyti programą, kuri užduoda klausimą ir pateikia keturis atsakymo variantus. Vartotojas gali pasirinkti vieną iš jų ir priklausomai nuo to ar jis yra teisingas, programa atspausdina (Teisingai/Neteisingai).

```c#
Console.WriteLine("Who does Han Solo owe money to?");
Console.WriteLine("A) Luke");
Console.WriteLine("B) Leia");
Console.WriteLine("C) Jabba the Hutt");
Console.WriteLine("D) None of the above");

var ats = Console.ReadLine();

if(ats == "C" || ats == "c")
{
    Console.WriteLine("Correct! The great Jabba thinks perhaps you know this, because you are the one who stole it...");
}
else
{
    Console.WriteLine("Try again...");
}
```

3. Parduotuvė parduoda saldainius po 0.28 euro centų už vienetą. Perkant daugiau kaip už 1000 eurų taikoma 3 % nuolaida, daugiau kaip už 2000 eurų - 4 % nuolaida. Kiek eurų kainuos N saldainių? (N įveda vartotojas)

```c#
Console.WriteLine("Iveskite saldainių kiekį");
int saldainiuSk = int.Parse(Console.ReadLine());

double vienetoKaina = 0.28;
double suma = saldainiuSk * vienetoKaina;

if(suma > 1000 && suma <= 1999)
{
    suma = suma * 0.97;
}
else if(suma >= 2000)
{
    suma = suma * 0.96;
}

Console.WriteLine("Jums reikia sumokėti " + suma + " eurų.");
```

### ```while``` ciklas

1. Parašykite programą, kuri išvestų į ekraną 5 kartus tą patį žodį.

```c#
int i = 1;

while(i <= 5)
{
    Console.WriteLine("Labas");
    i++;
}
```

2. Parašykite programą, kuri išvestų 10 pirmų natūraliųjų skaičių.

```c#
int i = 1;

while(i <= 10)
{
    Console.WriteLine(i);
    i++;
}
```

3. Parašykite programą, kuri išvestų 10 pirmų natūraliųjų skaičių atvirkščiai mažėjančia tvarka.

```c#
int i = 10;

while(i >= 1)
{
    Console.WriteLine(i);
    i--;
}
```

4. Parašykite programą, kuri paprašo įvesti skaičių x ir išveda skaičius nuo 1 iki x.

```c#
Console.WriteLine("Įveskite skaičių:");
var x = int.Parse(Console.ReadLine());

int i = 1;

while(i <= x)
{
    Console.WriteLine(i);
    i++;
}
```

5. Parašykite programą, kuri paprašo įvesti skaičių x ir išveda skaičius nuo x iki 1 (mažėjančia tvarka).

```c#
Console.WriteLine("Įveskite skaičių:");
var x = int.Parse(Console.ReadLine());

while(x >= 1)
{
    Console.WriteLine(i);
    x--;
}
```

6. Parašykite programą, kuri prašo įvesti du skaičius - m ir n, ir atspausdina visus sveikus skaičius [m; n] intervale.

```c#
Console.WriteLine("Įveskite skaičių m:");
var m = int.Parse(Console.ReadLine());

Console.WriteLine("Įveskite skaičių n:");
var n = int.Parse(Console.ReadLine());

while(m <= n)
{
    Console.WriteLine(m);
    m++;
}
```

7. Parašykite programą, kuri paprašo įvesti skaičių ir atspausdina jo daugybos lentelę.

```c#
Console.WriteLine("Įveskite skaičių:");
var sk = int.Parse(Console.ReadLine());

int i = 1;

while(i <= 10)
{
    Console.WriteLine(sk + "x" + i + "=" + sk*i);
    i++;
}
```

8. Parašykite programą, kuri paprašo įvesti skaičių x ir paskaičiuoja, kiek yra lyginių skaičių [1; x] intervale.

```c#
Console.WriteLine("Įveskite skaičių:");
var x = int.Parse(Console.ReadLine());

int i = 1;
int lyginiuSk = 0;

while(i <= x)
{
    if(i % 2 == 0)
    {
        lyginiuSk++;
    }
    i++;
}

Console.WriteLine("Intervale rasta tiek lyginių skaičių: " + lyginiuSk);
```

9. Parašykite programą, kuri paskaičiuoja pirmų 10-ies natūraliųjų skaičių sumą.

```c#
int i = 1;
int suma = 0;

while(i <= 10)
{
    suma = suma + i;
    i++;
}

Console.WriteLine("Pirmų 10-ies natūraliųjų skaičių suma yra: " + suma);
```

10. Parašykite programą, kuri paprašo įvesti skaičių x ir paskaičiuoja nelyginių skaičių sumą [1; x] intervale.

```c#
Console.WriteLine("Įveskite skaičių:");
var x = int.Parse(Console.ReadLine());

int i = 1;
int nelyginiuSkSuma = 0;

while(i <= x)
{
    if(i % 2 != 0)
    {
        nelyginiuSkSuma = nelyginiuSkSuma + i;
    }
    i++;
}

Console.WriteLine("Nelyginių skaičių suma intervale yra: " + nelyginiuSkSuma);
```

11. Parašyti programą, kuri nuskaitinėja įvestus skaičius tol, kol jų suma nėra daugiau už 50.

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

