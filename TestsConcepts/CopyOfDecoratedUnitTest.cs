using System.Diagnostics;

namespace TestsConcepts;

[Collection("Test fixture collection")]
public class CopyOfDecoratedUnitTest : IDisposable, IAsyncLifetime
{
    /// <summary>
    /// Constructor is run before any test
    /// </summary>
    public CopyOfDecoratedUnitTest()
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
    public void Test3()
    {
        Debug.Print("UnitTest Test3");
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
        
        // Suppress the call to dispose on this object as it is already being disposed
        GC.SuppressFinalize(this);
    }
}