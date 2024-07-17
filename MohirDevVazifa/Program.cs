Console.Write(" Toq sonlar yig'indisini hisoblavchi dastur: ");
int toqSon = Convert.ToInt32(Console.ReadLine());

int hisob = 0;
int i = 1;
while (i < toqSon)
{
    hisob += i;
    i += 2;
}

Console.WriteLine($"{toqSon} gacha bo'lgan toqson yig'indisi: {hisob}");