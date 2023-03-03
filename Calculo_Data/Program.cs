internal class Program
{
    private static void Main(string[] args)
    {
        int first_year, last_year, days = 0, count = 0;

        Console.WriteLine("Informe o primeiro ano: ");
        first_year = int.Parse(Console.ReadLine());

        last_year = first_year - 1;

        while(first_year > last_year)
        {
            Console.WriteLine("Informe o segundo ano: ");
            last_year = int.Parse(Console.ReadLine());
        }

        days = (last_year - first_year+1)*365;
        count = first_year;

        do
        {
            if ((count % 4 == 0) && (count % 100 != 0) || (count % 400 == 0))
            {
                days = days + 1;
            }
            count++;
        } while (count <= last_year);

        Console.WriteLine("{0}", days);

    }
}