using System.Reflection;
namespace RANSANMOI
{
    class Program
    {
        static void Main(string[] args)
        {
           Thread _game = new Thread(SnakeControl.ListenKey);
            _game.Start();
            SnakeControl snakeControl = new SnakeControl();
            while(true)
            {
                try
                {
                Console.Clear();
                snakeControl.Drawboard();
                snakeControl.setUpBoard();
                snakeControl.MoveSnakeHead();
                snakeControl.EatFood();
                snakeControl.SpawnBody();
                snakeControl.PopUpfood();
                snakeControl.ShowPoint();
                snakeControl.Collied();
                //Task.Delay(SnakeControl.speed).Wait();
                Thread.Sleep(snakeControl.speed);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at"+ ex);
                }
            }
            
            
        }
    }
}
