class Sums
{
    public void sm(int num1, int num2)
    {
        Console.WriteLine($"Сумма 2 чисел: {num1 + num2}");
    }
    public void sm(int num1, int num2, int num3)
    {
        Console.WriteLine($"Сумма 3 чисел: {num1 + num2 + num3}");
    }
    public void sm(int num1, int num2, int num3, int num4)
    {
        Console.WriteLine($"Сумма 4 чисел: {num1 + num2 +num3 + num4}");
    }


    public int width, hight;
    public double wt;
    public Sums() { }
    public Sums(int hight, double wt)
    {
        this.hight = hight;
        this.wt = wt;
        Console.WriteLine($"Рост: {hight}, Вес: {wt}");
    }
    public Sums(int hight, int width, double wt)
    {
        this.hight = hight;
        this.width = width;
        this.wt = wt;
        Console.WriteLine($"Рост: {hight}, Вес: {wt}, Ширина: {width}");
    }


    int[] arr;
    public int Length;
    public Sums(int Size)
    {
        arr = new int[Size];
        Length = Size;
    }
    public int this[double index]
    {
        get
        {
            return arr[(int)Math.Round(index)];
        }
        set
        {
            arr[(int)Math.Round(index)] = value+5;
        }
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Sums sum1 = new Sums();
        sum1.sm(1, 2);
        sum1.sm(3, 4, 5);
        sum1.sm(6, 7, 8, 9);
        Sums plant1 = new Sums(hight: 5, wt: 6);
        Sums plant2 = new Sums(hight: 5, width: 7, wt: 6);
        Sums arr = new Sums(5);
        arr[0] = 1;
        arr[1.123] = 2;
        arr[1.89] = 3;
        arr[3.01] = 4;
        arr[4.222] = 5;
        Console.WriteLine("Массив:");
        for (int i = 0; i < arr.Length; i++)
            Console.Write("{0}\t", arr[i]);
        Console.ReadLine();
    }
}
