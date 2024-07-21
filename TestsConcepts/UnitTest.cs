using System.Diagnostics;

namespace TestsConcepts;

public class UnitTest : IDisposable, IAsyncLifetime, IClassFixture<TestFixture>
{
    /// <summary>
    /// Constructor is run before any test
    /// </summary>
    public UnitTest()
    {
        Debug.Print("UnitTest constructor");        
    }
    
    /// <summary>
    /// InitializeAsync is run before any test
    /// It comes from IAsyncLifetime interface
    /// Here we can initialize any resources that needs asynchronous initialization
    /// </summary>
    public Task InitializeAsync()
    {
        Debug.Print("UnitTest InitializeAsync");
        return Task.CompletedTask;
    }
    
    [Fact]
    public void Test1()
    {
        Debug.Print("UnitTest Test1");
    }
    
    [Fact]
    public void Test2()
    {
        Debug.Print("UnitTest Test2");
    }
    
    [Fact]
    [BeforeAndAfter]
    public void DecoratedTest()
    {
        Debug.Print("UnitTest DecoratedTest");
    }
    
    /// <summary>
    /// DisposeAsync is run after any test
    /// It comes from IAsyncLifetime interface
    /// Here we can dispose any resources that needs asynchronous disposal
    /// </summary>
    public Task DisposeAsync()
    {
        Debug.Print("UnitTest DisposeAsync");
        return Task.CompletedTask;
    }

    /// <summary>
    /// Dispose is run after any test
    /// Comes from IDisposable interface
    /// </summary>
    public void Dispose()
    {
        Debug.Print("UnitTest Dispose");
    }
}