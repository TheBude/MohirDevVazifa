/*Console.Write(" Toq sonlar yig'indisini hisoblavchi dastur: ");
int toqSon = Convert.ToInt32(Console.ReadLine());

int hisob = 0;
int i = 1;
while (i < toqSon)
{
    hisob += i;
    i += 2;
}

Console.WriteLine($"{toqSon} gacha bo'lgan toqson yig'indisi: {hisob}");

Console.Write("Massiv Sonini Kiriting (3-6): ");
int massivSonni = Convert.ToInt32(Console.ReadLine());
int[] massiv = new int[massivSonni];

for (int i = 0; i < massivSonni; i++)
{
    Console.Write($"{i + 1} Massivga qiymat Kiriting: ");
    massiv[i] = Convert.ToInt32(Console.ReadLine());
}

int min  = massiv[0];
int max = massiv[0];

for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] < min)
    {
        min = massiv[i];
    }
    if (massiv[i] > max)
    {
        max = massiv[i];
    }
}
Console.WriteLine($"{min} minimal qiytmat\n{max} maxsimal qiymat");*/

Console.Write("Faktarial Hisoblash uchun son kiriting: ");
int faktarial = Convert.ToInt32(Console.ReadLine());
int a = 1;

for  (int i = 1; i <= faktarial; i++)
{
    a *= i;
}
Console.WriteLine(a);