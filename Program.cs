class Program
{
    static int GetSum(int[] hits)
    {
        int sum = 0;
        for (int i = 0; i < hits.Length; i++)
        {
            sum += hits[i];
        }
        return sum;
    }
    static double GetAverage(int[] hits)
    {
        int sum = GetSum(hits);
        double average = (double)sum / hits.Length;
        return average;
    }
    static int GetMin(int[] hits)
    {
        int min = hits[0];
        for (int i = 1; i < hits.Length; i++)
        {
            if (hits[i] < min)
            {
                min = hits[i];
            }
        }
        return min;
    }
    static int GetMax(int[] hits)
    {
        int max = hits[0];
        for (int i = 1; i < hits.Length; i++)
        {
            if (hits[i] > max)
            {
                max = hits[i];
            }
        }
        return max;
    }
    static void ShowResults(int[] hits)
    {
        Console.WriteLine($"Общий урон команды: {GetSum(hits)}");
        Console.WriteLine($"Средний урон: {GetAverage(hits)}");
        Console.WriteLine($"Самый слабый герой нанёс: {GetMin(hits)}");
        Console.WriteLine($"Самый сильный герой нанёс: {GetMax(hits)}");
    }
    static void Main()
    {
        int[] hits = new int[5];
        int i = 0;

        while (i < hits.Length)
        {
            Console.Write("Введите урон: ");
            hits[i] = int.Parse(Console.ReadLine());
            i++;
        }
        ShowResults(hits);
    }
}
