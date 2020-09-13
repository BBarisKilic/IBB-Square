using System;

namespace Square_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;

            while (length!=1)
            {
                Console.WriteLine();
                Console.Write("Karenin birim uzunluğunu giriniz: ");
                length = Convert.ToInt32(Console.ReadLine());

                for (int column = 0; column < length; column++)
                {
                    for (int row = 0; row < length; row++)
                    {
                        if (column == 0 || column == length - 1)
                        {
                            if(column == length - 1 && row == 0){
                                Console.WriteLine();
                            }
                            Console.Write("*");
                        }
                        else
                        {
                            if (row == 0 || row == length - 1)
                            {
                                if(row == 0){
                                    Console.WriteLine();
                                } 
                                Console.Write("*");
                            }else{
                                Console.Write(" ");
                            }
                        }
                    }
                }
            }
        }
    }
}
