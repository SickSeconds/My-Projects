using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnonInvest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dInitial = 0;
            decimal dRate;
            int iPeriod;
            decimal dROI2 =0 ;
            decimal dROI = dROI2;
            string sMsg;
            Console.WriteLine("Enter the intial amount in decimal:");
            dInitial = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the investment period int years:");
            iPeriod = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the interest rate as a percentage:");
            dRate = decimal.Parse(Console.ReadLine()) / 100;
            try
            {

                if (dInitial >= 0 && iPeriod >= 0 && dRate >= 0)
                {
                    dROI2 = dInitial * Math.Pow( 1+ dRate, iPeriod);
                }
                else
                {
                    sMsg = iPeriod < 0 ? "Invalid Period " :
                    dInitial < 0 ? "Invalid Initial Amount" :
                    "Invalid Interest Rate";
                }
                sMsg = String.Format("Investment of {0:C} for {1}years returns {2:C}", dInitial, iPeriod, dRate);
                Console.WriteLine();
                Console.WriteLine(sMsg);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("YOur ROI is:" + dROI);
            Console.ReadKey();


        }
    }
}
