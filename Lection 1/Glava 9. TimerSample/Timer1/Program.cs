void TimerTick(object a)
{
    Console.WriteLine("Hello in timer");
}

TimerCallback timercallback = new TimerCallback(TimerTick);
Timer timer = new Timer(timercallback);
timer.Change(2000, 500); // Запуск таймера.

Console.ReadKey(); // Задержка.