/*Заданы массивы D и E. Вычислить и вывести значения fi=(2di+sinei)/di, где i=1,2,…,16; вывести 1<fi<3.*/

class Program
{
    public static void printArray(double[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 15) { Console.Write(arr[i]); } else
            Console.Write(arr[i] + ", ");
        }
        Console.Write("]");
    }

    public static void printF(double[] arr)
    {
        Console.WriteLine();
        Console.Write("Массив F = [");
        for (int i = 0; i < arr.Length; i++)
        {
            if (1 < arr[i] && arr[i] < 3)
            {

                if (i == 15) { Console.Write(Math.Round(arr[i], 2)); }
                else
                    Console.Write(Math.Round(arr[i],2) + ", ");
            }
        }
        Console.Write("]");
    }

    static void Main(string[] args)
    {

        Random random = new Random();   

        double[] D = new double[16];
        double[] E = new double[16];
        double[] F = new double[16];

        for (int i = 0;i<16;i++)
        {
            D[i] = random.Next(0,20);
            E[i] = random.Next(0,20);
        }

        Console.Write("Массив D = ");
        printArray(D);
        Console.WriteLine();
        Console.Write("Массив E = ");
        printArray(E);

        for (int i = 0; i < 16; i++)
        {// (2di + sinei)/ di
            F[i] = (2 * D[i] + Math.Sin(E[i])) / D[i];
        }

        printF(F);

    }
}