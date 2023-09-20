/*Даны коэффициенты двух прямых a, b, c, d (y = ax + b, y = cx + d).Известно, что прямые не параллельны (a≠c). Определить координаты точки пересечения этих прямых
 */
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("а = ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("c = ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("d = ");
        double d = Convert.ToDouble(Console.ReadLine());

        if(a == c)
        {
            Console.WriteLine("Прямые параллельны");
        }
        else if (a == c && b == d) 
        {
            Console.WriteLine("Две прямые совпадают");
        }
        else
        {
            double x = (d - b)/(a - c);
            double y = a * x + b;

            Console.WriteLine("Точка (" + x + "," + y + ") является пересечением прямых y = " + a + "x + " + b + " и y = " + c +  "x + " + d);

        }

    }
}