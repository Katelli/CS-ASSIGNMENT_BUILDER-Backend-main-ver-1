using C_ASSIGNMENT_BUILDER.Engine.AssignmentBuilder;
using Xunit;

public class TDDTests : AssignmentBase
{
    /// <summary>
    /// A method thath calls itself within its own function(recursive)
    /// To check the factorial we look at n!, where n = n x (n - 1) x (n - 2) x etc...
    /// For example n! = 3! => n = 3 x (3 - 1) x (3 - 2)
    ///    (in other words) => n = 3 x 2 x 1
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int RecursiveFactorial(int n)
    {
        if(n == 0)
        {
            return 1;
        }
        return n * RecursiveFactorial(n - 1);
        //throw new NotImplementedException();
    }

    /// <summary>
    /// A method that returns a greeting accoridng to the declared language
    /// I could have used a switch case instead of an if/else statement.
    /// I also thought of using ToUpperCase or ToLowerCase to avoid issues,
    /// but I figured a website would not ask the user to type in their language, only choose it
    /// so it seemed unnecessary to add it in.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string Greeting(string n)
    {
        if(n == "spanish")
        {
            return "Hola!";
        }
        else if(n == "japanese")
        {
            return "Konichiwa!";
        }
        else if(n == "english")
        {
            return "Hello!";
        }
        throw new NotImplementedException();
    }

    /// <summary>
    /// A method that converts the numeric type double into an int
    /// Since there is no rounding up, and converting it will make it ignore the decimals,
    /// it will only add the numbers before the comma
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int NumericTypeConverison(double a, double b)
    {   
        return (int)a + (int)b;
        //throw new NotImplementedException();
    }


    [Assignment(1)]
    public void TestRecursiveFactorial()
    {
        Assert.Equal(2, RecursiveFactorial(2));
        Assert.Equal(6, RecursiveFactorial(3));
        Assert.Equal(720, RecursiveFactorial(6));
        Assert.Equal(3628800, RecursiveFactorial(10));
    }

    [Assignment(2)]
    public void TestGreeting()
    {
        Assert.Equal("Hola!", Greeting("spanish"));
        Assert.Equal("Konichiwa!", Greeting("japanese"));
        Assert.Equal("Hello!", Greeting("english"));
    }

    [Assignment(3)]
    public void TestNumericTypeConverison()
    {
        Assert.Equal(3, NumericTypeConverison(2.5, 1.6));
        Assert.NotEqual(4.1, NumericTypeConverison(2.5, 1.6));
    }
}