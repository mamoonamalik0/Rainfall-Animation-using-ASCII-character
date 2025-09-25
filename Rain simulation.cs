using System;
using System.Threading;
class RainSimulation
{
    static void Main()
    {
        string[] frames = new string[] {
                @" .--.     .--.
   .-(    ).-(    ).
  (         )
   '-(     )-'" };

        Console.CursorVisible = false;
        for (int i = 0; i < 50; i++)
        {
            foreach (string frame in frames)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(frame);
                Thread.Sleep(50);

            }
        }
        Console.CursorVisible = true;
    }
}