namespace homework05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****************************************************************************//
            // task2
             Console.Write("Enter number: ");
              int number1= int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
              int number2= int.Parse(Console.ReadLine());
              for (int i = number1; i < number2; i++)
              {
                  if (i % 2 !=0 && i %i==0)
                  {
                      Console.Write(i+" ");
                  }
              }

            //******************************************************************************//
            // Task3    it is error in the code
            Console.Write(" Enter  number: ");
            int number4 = int.Parse(Console.ReadLine());
            int[] array = new int[number4];
            int summ = 0;
            for (int i = array[0]; i < number4; i++)
            {
                summ += i;

            }
            Console.WriteLine(summ);

            //****************************************************************************//
            // task 4 
            Console.Write(" Enter numbers: ");
             int number = int.Parse(Console.ReadLine());
              int sum = 0;
            for (int i = 0; i < number; i++)
              {
                  sum +=   number ;
                  Console.Write(sum+" ");
              }
            //*****************************************************************************//
            // task 5
             Console.WriteLine("Enter number: ");
             int number3 = int.Parse(Console.ReadLine());
             for (int i = 0; i < number3; i++)
             {
                 for (int j = i; j < number3; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }

      


        }
    }
}