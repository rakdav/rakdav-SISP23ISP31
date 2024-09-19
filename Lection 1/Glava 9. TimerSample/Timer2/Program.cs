int Sek = 10;
void TimerTick(object obj)
{
    Sek--;
    Console.WriteLine(Sek.ToString());
    if (Sek <= 0)
    {
        Timer a = (Timer)obj;
        a.Dispose(); // Остановка таймера.
        Console.WriteLine("Timer End");
    }

}

TimerCallback timercallback = new TimerCallback(TimerTick);
Timer timer = new Timer(timercallback);
timer.Change(1000, 1000); // Запуск таймера.

Console.ReadKey(); // Задержка.