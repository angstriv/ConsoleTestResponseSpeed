namespace ConsoleTestResponseSpeed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎游玩测试打字反应力的游戏");


            //用户选择难度
            while (true)
            {
                Console.Write("请选择难度:");
                string dLevel = Console.ReadLine();//用户选择难度
                if (dLevel == "easy")
                {
                    DifferentModeMethod.ExecuteEasy();
                    break;
                }
                else if (dLevel == "medium")
                {
                    DifferentModeMethod.ExecuteMedium();
                    break;
                }
                else if (dLevel == "difficult")
                {
                    DifferentModeMethod.ExecuteDifficult();
                    break;
                }
                else
                {
                    Console.WriteLine("难度错误,请重新输入!");
                    continue;
                }
            }


        }
    }
}
