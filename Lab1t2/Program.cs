/*Заданы массивы D и E. Вычислить и вывести значения fi=(2di+sinei)/di, где i=1,2,…,16; вывести 1<fi<3.*/

class Program
{
    static void Main(string[] args)
    {

        Random random = new Random();   

        double[] D = new double[16];
        double[] F = new double[16];

        for(int i = 0;i<16;i++)
        {
            D[i] = random.Next(0,20);
            F[i] = random.Next(0,20);
        }

        for (int i = 0; i < 16; i++)
        {
           Console.WriteLine(D[i]);
           Console.WriteLine(D[i]);
           Console.WriteLine(D[i]);
        }
    }
}