using System.Reflection;

AppDomain Domain = AppDomain.CurrentDomain;//загружаем в созданный нами домен приложения заранее подготовленную dll библиотеку
Assembly asm = Domain.Load(AssemblyName.GetAssemblyName("SampleLibrary.dll"));
//получаем модуль, из которого будем осуществлять вызов
Module module = asm.GetModule("SampleLibrary.dll")!;
//получаем тип данных, содержащий искомый метод
Type type = module.GetType("SampleLibrary.SampleClass")!;
//получаем метод из типа данных
MethodInfo method = type.GetMethod("DoSome")!;
//осуществляем вызов метода
method.Invoke(null, null);
//однострочный вариант вызова того же метода через анонимные объекты
asm.GetModule("SampleLibrary.dll")!.GetType("SampleLibrary.SampleClass")!.GetMethod("DoSome")!.Invoke(null, null);

