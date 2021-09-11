using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Money : ");
            int moneyReceipt = Convert.ToInt32(Console.ReadLine());
            int count100 = 0;
            int count500 = 0;
            int count1000 = 0;

            bool checkMoneyInvalid = false;

            while (moneyReceipt > 0) {
                if (moneyReceipt > 1000)
                {
                    moneyReceipt = moneyReceipt - 1000;
                    count1000++;
                }

                if (moneyReceipt < 1000 && moneyReceipt> 500)
                {
                    moneyReceipt = moneyReceipt - 500;
                    count500++;
                }

                if (moneyReceipt < 500)
                {
                    moneyReceipt = moneyReceipt - 100;
                    count100++;
                }
                if(moneyReceipt<100 && moneyReceipt>0)
                {
                    moneyReceipt = moneyReceipt - moneyReceipt;
                    checkMoneyInvalid = true;
                }
            }
            if (checkMoneyInvalid)
            {
                Console.WriteLine("จำนวนเงินไม่ถูกต้อง");

            }
            else {
                Console.WriteLine($"แบงค​์ 1000 บาท : {count1000}");
                Console.WriteLine($"แบงค​์ 500 บาท : {count500}");
                Console.WriteLine($"แบงค​์ 100 บาท : {count100}");
            }
        }
    }
}
