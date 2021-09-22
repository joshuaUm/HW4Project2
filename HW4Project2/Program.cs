using System;

namespace HW4Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numHeads = 0, numTails = 0, numAttempts = 8;

            Console.WriteLine("Coin flip tosses statistics for "+ numAttempts +" attempts.");

            for(int i = 0; i < numAttempts; i++)
            {
                while(true) 
                {
                   Console.WriteLine("Enter \'h\' or \'t\' #" + (i + 1) + ": ");
                   String choice = Console.ReadLine();

                   if (choice.CompareTo("h") == 0)
                   {
                        numHeads++;
                        break;
                   }
                   else if(choice.CompareTo("t") == 0)
                   {
                        numTails++;
                        break;
                   }
                    else
                    {
                        Console.WriteLine("Invalid choice, try again.");
                    }
                }
             
            }

            Console.WriteLine("NumHeads : " + Math.Round((numHeads / (double) numAttempts) * 100 , 1) + "%\n" 
                            + "NumTails : " + Math.Round((numTails / (double) numAttempts) * 100, 1) + "%");



        }
    }
}
