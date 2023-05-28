class RSA
{
    public static int[] word = new int[] { 3, 1, 2 };
    public static int p = 3;
    public static int q = 11;
    public static int kv = 3;
    public static int n = p * q;

    public static int Euler(int p, int q)
    {
        return (p - 1) * (q - 1);
    }

    public static void Encrypt(int Kv, int N)
    {
        int word1 = word[0];
        int word2 = word[1];
        int word3 = word[2];
        Console.WriteLine();
        Console.WriteLine(word1 + " c");
        Console.WriteLine(word2 + " a");
        Console.WriteLine(word3 + " b");
        int C1 = (int)Math.Pow(word1, Kv) % (p * q);
        int C2 = (int)Math.Pow(word2, Kv) % (p * q);
        int C3 = (int)Math.Pow(word3, Kv) % (p * q);
        Console.WriteLine("Вычисляем по формуле остаток при делении");
        Console.WriteLine(C1);
        Console.WriteLine(C2);
        Console.WriteLine(C3);

        Decrypt(n, kv, C1, C2, C3);
    }

    public static void Decrypt(int n, int kv, int C1, int C2, int C3)
    {
        int M1 = (int)Math.Pow(C1, kv) % n;
        int M2 = (int)Math.Pow(C2, kv) % n;
        int M3 = (int)Math.Pow(C3, kv) % n;
        Console.WriteLine("При вычислении по формуле дешифровки получаем");
        Console.WriteLine(M1 + "c");
        Console.WriteLine(M2 + "a");
        Console.WriteLine(M3 + "b");
    }

    public static void Main()
    {
        int N = Euler(p, q);
        int Kv = 1;
        while ((kv * Kv) % N != 1)
        {
            Kv++;
        }
        Console.WriteLine("Наибольший общий делитель - " + Kv);
        
        Encrypt(Kv, N);        
    }
}