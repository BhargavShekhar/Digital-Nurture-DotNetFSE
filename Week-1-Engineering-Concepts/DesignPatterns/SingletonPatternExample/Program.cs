Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Log("First Message");
logger2.Log("Second Message");

if (logger1 == logger2)
{
    Console.WriteLine("Both objects are the same instance.");
}
else
{
    Console.WriteLine("Different instances created.");
}