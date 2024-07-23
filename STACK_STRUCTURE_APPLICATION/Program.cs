namespace STACK_STRUCTURE_APPLICATION
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //STACK APPLICATION

            Console.WriteLine("LÜTFEN BİR SAYI GİRİNİZ: ");
            int num1=Convert.ToInt32(Console.ReadLine());

            var sayı_yığını=new Stack<int>();
             while (num1 > 0)
            {
                int k = num1 % 10;
                sayı_yığını.Push(k);
                num1 = num1/10;
            }

            int i = 0;
            int n = sayı_yığını.Count-1;
            foreach (var s in sayı_yığını)
            {
                Console.WriteLine($"{s} x {Math.Pow(10,n-i)} = {s* Math.Pow(10, n - i)}");
                i++;
            }



            Console.ReadLine();

        }
    }
}
