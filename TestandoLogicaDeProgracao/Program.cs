namespace TestandoLogicaDeProgracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            while (x < 10)
            {
                x += 2;
            }

            Console.WriteLine("Resultado da pergunta 41 Prova Teoria Lógica de Progração");
            Console.WriteLine(x);
            Console.WriteLine("---------------------------------------------------------");


            int y = 0;

            for (int i = 1; i <= 5; i++)
            {
                y += i;
            }
            Console.WriteLine("Resultado da pergunta 42 Prova Teoria Lógica de Progração");
            Console.WriteLine(y);
            Console.WriteLine("---------------------------------------------------------");

            int a = 10;

            do
            {
                a--;
            } while (a > 5);

            Console.WriteLine("Resultado da pergunta 43 Prova Teoria Lógica de Progração");
            Console.WriteLine(a);

            Console.WriteLine("---------------------------------------------------------");

            int b = 1;

            for (int i = 0; i < 3; i++)
            {
                b *= 2;
            }

            Console.WriteLine("Resultado da pergunta 44 Prova Teoria Lógica de Progração");
            Console.WriteLine(b);

            Console.WriteLine("---------------------------------------------------------");

            int c = 0;

            while(c++ < 3)
            {
                c += 1;
            }

            Console.WriteLine("Resultado da pergunta 45 Prova Teoria Lógica de Progração");
            Console.WriteLine(c);

            Console.WriteLine("---------------------------------------------------------");

            int d = 0;

            for (int i = 1; i <= 4; i++)
            {
                if(i % 2 == 0)
                {
                    d += i;
                }
            }

            Console.WriteLine("Resultado da pergunta 46 Prova Teoria Lógica de Progração");
            Console.WriteLine(d);

            Console.WriteLine("---------------------------------------------------------");

            int e = 10;

            while(e > 0)
            {
                e -= 3;
            }

            Console.WriteLine("Resultado da pergunta 47 Prova Teoria Lógica de Progração");
            Console.WriteLine(e);

            Console.WriteLine("---------------------------------------------------------");

            int f = 1;

            for (int i = 0; i < 5; i++)
            {
                f += f;
            }

            Console.WriteLine("Resultado da pergunta 48 Prova Teoria Lógica de Progração");
            Console.WriteLine(f);

            Console.WriteLine("---------------------------------------------------------");

            int g = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i > 5) break;
                g++;
            }

            Console.WriteLine("Resultado da pergunta 49 Prova Teoria Lógica de Progração");
            Console.WriteLine(g);

            Console.WriteLine("---------------------------------------------------------");

            int h = 0;

            for (int i = 0; i < 10; i += 2)
            {
                h += i;
            }

            Console.WriteLine("Resultado da pergunta 50 Prova Teoria Lógica de Progração");
            Console.WriteLine(h);

            Console.ReadLine();

        }
    }
}
