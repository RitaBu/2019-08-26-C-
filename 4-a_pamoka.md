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

```

### ```while``` ciklas
