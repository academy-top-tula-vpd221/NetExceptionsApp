//Method();

//if(Int32.TryParse(Console.ReadLine(), out int a))
//    Console.WriteLine(a);

//Func1();
try
{
    User user = new() { Name = "Bob", Age = -10 };
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}



void Method()
{
    int a, b;
    a = Int32.Parse(Console.ReadLine());
    try
    {
        
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"{a} / {b} = {a / b}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Деление на ноль!");
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Неверный формат числа");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error! {ex.Message}");
        return;
    }
    finally
    {
        Console.WriteLine("Required code!!!!");
    }
    

}

void Func1()
{
    try
    {
        Func2();
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.Source);
        Console.WriteLine(ex.TargetSite);
        Console.WriteLine(ex.StackTrace);
    }
}

void Func2()
{
    try
    {
        int a = 5, b = 0;
        int c = a / b;
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.Source);
        Console.WriteLine(ex.TargetSite);
        Console.WriteLine(ex.StackTrace);
        Console.WriteLine();
        throw;
    }
}

class User
{
    public string Name { get; set; }
    int age;
    public int Age 
    { 
        get { return age; }
        set
        {
            if (value > 0 && value < 100)
                age = value;
            else
                throw new AgeInvalidException();
        }
    }
}

class AgeInvalidException : Exception
{
    public AgeInvalidException() : base("Invalid Age for User") { }
}