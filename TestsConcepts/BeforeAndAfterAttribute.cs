using System.Diagnostics;
using System.Reflection;
using Xunit.Sdk;

namespace TestsConcepts;

/// <summary>
/// Attribute that indicates code to be run before and after the test is run
/// Should decorate each test method or class that needs to run code before and after the test
/// </summary>
public class BeforeAndAfterAttribute : BeforeAfterTestAttribute
{
    /// <summary>
    /// Code to be run before the test is run
    /// </summary>
    /// <param name="methodUnderTest"></param>
    public override void Before(MethodInfo methodUnderTest)
    {
        Debug.Print("BeforeAndAfterAttribute Before");
    }

    /// <summary>
    /// Code to be run after the test is run
    /// </summary>
    /// <param name="methodUnderTest"></param>
    public override void After(MethodInfo methodUnderTest)
    {
        Debug.Print("BeforeAndAfterAttribute After");
    }
}
