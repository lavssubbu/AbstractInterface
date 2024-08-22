namespace Day3dover
{ 
    //Method Overloading 
    class MatheOp
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a,double b)
        {
            return a + b;
        }

        public string Add(string x,string y)
        {
            return x + y;
        }
        public void Add(int a,double b)
        {
          Console.WriteLine(a + b);  
         }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            MatheOp op = new MatheOp();
            Console.WriteLine(op.Add("Rohit", "Sharma"));
            Console.WriteLine(op.Add(20, 30, 40));
        }
    }
}
   