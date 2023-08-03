namespace test_sofinans_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prog = true;

            Console.WriteLine("Володя мегахорош представляет:");
            while (prog == true)
            {
                Console.WriteLine("Введите объём гранта:");
                double grantAmount = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите объём вложений:");
                double helpAmount = double.Parse(Console.ReadLine());
                Console.WriteLine(MathBasic.Calculate(grantAmount, helpAmount));
                Console.WriteLine("Введите q для выхода из программы, \nЛибо Enter для введения новых данных для рассчёта.");
                string res = Console.ReadLine();

                if (res == "q")
                {
                    prog = false;
                }
                else
                {
                    Console.WriteLine("Я тебя не понял, давай по новой:");
                }
            }
            
        }
    }
}