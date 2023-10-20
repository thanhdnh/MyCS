class Program
{
  static void Main()
  {
    Console.Clear();
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.InputEncoding = System.Text.Encoding.UTF8;

    /*=== Bai 6 ===*/
    //for
    Console.WriteLine("Nhap n: ");
    int n = int.Parse(Console.ReadLine());
    double sum = 0;
    int i = 1;
    for (i = 1; i <= n; i++)
    {
      sum = sum + 1.0 / (i * (i + 1));
    }
    Console.WriteLine("For:" + sum);
    //do...while
    sum = 0;
    i = 1;
    do
    {
      sum += 1.0 / (i * (i + 1));
      i++;
    } while (i <= n);
    Console.WriteLine("do...while: " + sum);
    //while
    i = 1;
    double S = 0;
    while (i <= n)
    {
      S += 1.0 / (i * (i + 1));
      i = i + 1;
    }
    Console.WriteLine("while: {0}", S);
    Console.ReadLine();

    /*=== Bai 11 ===*/
    //for
    ulong sum2 = 0;
    ulong giaithua = 1;
    for (i = 1; i <= n; i++)
    {
      giaithua = giaithua * (ulong)i;
      sum2 = sum2 + giaithua;
    }
    Console.WriteLine("for:" + sum2);
    //do...while
    sum = 0; i = 1;
    ulong s = 1;
    do
    {
      s = s * (ulong)i;
      sum += s;
      i++;
    }
    while (i <= n);
    Console.WriteLine("do...while: " + sum);

    //while
    S = 0;
    i = 1;
    ulong P = 1L;
    while (i <= n)
    {
      P = P * (ulong)i;
      S = S + P;
      i = i + 1;
    }
    Console.Write("while: " + S);

    //Bai 33
    //Nhap n>=1
    double Tong33 = 2;
    for(i=1; i<n; i++)
      Tong33 = Math.Sqrt(Tong33) + 2;
    System.Console.WriteLine(Math.Sqrt(Tong33));

    //Bai 34
    //Nhap n>=1
    double Tong34 = 1;
    for(i=1; i<n; i++)
      Tong34 = Math.Sqrt(Tong34) + i;
    System.Console.WriteLine(Math.Sqrt(Tong34));

    Console.ReadLine();
  }
}