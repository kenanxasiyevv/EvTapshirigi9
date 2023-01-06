namespace EvTapshirigi9
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Birinci maksimal elementi tapmaq
            
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[max])
                    max = i;
            }
                    Console.WriteLine(max);
        }
    }
}
