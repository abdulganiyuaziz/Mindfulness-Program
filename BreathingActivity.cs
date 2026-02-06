using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by guiding you through slow breathing."
        )
    { }

    public void Run()
    {
        StartActivity();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            Countdown(4);
            elapsed += 4;

            Console.Write("\nBreathe out... ");
            Countdown(4);
            elapsed += 4;
        }

        EndActivity();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
