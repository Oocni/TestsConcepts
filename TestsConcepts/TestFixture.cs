using System.Diagnostics;

namespace TestsConcepts;

/// <summary>
/// Fixture is a class that contains implementation that should be called once for a group of tests
/// It is associated to a test class using IClassFixture interface
/// </summary>
public class TestFixture : IDisposable
{
    /// <summary>
    /// Code to be run before the test class is run
    /// </summary>
    public TestFixture()
    {
        Debug.Print("TestFixture constructor");
    }        
    
    /// <summary>
    /// Code to be run after the test class is run
    /// </summary>
    public void Dispose()
    {
        Debug.Print("TestFixture Dispose");
    }
}