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
    /// Third code executed before test
    /// </summary>
    public override void Before(MethodInfo methodUnderTest)
    {
        Debug.Print("BeforeAndAfterAttribute Before");
    }

    /// <summary>
    /// Code to be run after the test is run
    /// First code executed after test
    /// </summary>
    public override void After(MethodInfo methodUnderTest)
    {
        Debug.Print("BeforeAndAfterAttribute After");
    }
}
