using System.Reflection;
namespace RANSANMOI
{
    class Program
    {
        static void Main(string[] args)
        {
             bool gameOver = false;
            Thread _game = new Thread(SnakeControl.ListenKey);
            _game.Start();
            while(!gameOver)
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
                //Task.Delay(SnakeControl.speed).Wait();
                Thread.Sleep(SnakeControl.speed);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at"+ ex);
                }
            }
            if(SnakeControl.Collied())
            {
             Console.WriteLine("Game Over!"); 
            }
            
               
                
                
            
            
            
            
            

             
        }
    }
}
