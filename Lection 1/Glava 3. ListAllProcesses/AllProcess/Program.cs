using System.Diagnostics;

Console.Title = "Список процессов";
//изменяем размер буфера консоли и окна на необходимый нам
Console.WindowWidth = 40;
Console.BufferWidth = 40;
//получаем список процессов
Process[] processes = Process.GetProcesses();
//выводим заголовок
Console.WriteLine("  {0,-28}{1,-10}", "Имя процесса:", "PID:");
//для каждого процесса выводим имя и PID
foreach (Process p in processes)
    Console.WriteLine("  {0,-28}{1,-10}", p.ProcessName, p.Id);
