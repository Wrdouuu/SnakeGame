using System.Reflection;
namespace RANSANMOI
{
    class Program
    {
        static void Main(string[] args)
        {
           Thread _game = new Thread(SnakeControl.ListenKey);
            _game.Start();
            while(true)
            {
                try
                {
                Console.Clear();
                SnakeControl.Drawboard();
                SnakeControl.setUpBoard();
                SnakeControl.MoveSnakeHead();
                SnakeControl.EatFood();
                SnakeControl.SpawnBody();
                SnakeControl.PopUpfood();
                SnakeControl.ShowPoint();
                SnakeControl.Collied();
                //Task.Delay(SnakeControl.speed).Wait();
                Thread.Sleep(SnakeControl.speed);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at"+ ex);
                }
            }
            
            
        }
    }
}
