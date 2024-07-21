namespace TestsConcepts.ManageFixtures;

/// <summary>
/// Manages fixtures for tests.
/// </summary>
public class FixturesManager
{
    /// <summary>
    /// Dictionary of fixtures.
    /// </summary>
    private readonly Dictionary<string, object> _fixtures = new();

    public FixturesManager()
    {
    }
    
    public FixturesManager(List<object> fixtures)
    {
        AddFixtures(fixtures);
    }
    
    /// <summary>
    /// Get a fixture by type.
    /// </summary>
    public T? GetFixture<T>()
        where T : class
    {
        var fixtureName = typeof(T).Name;
        if (_fixtures.TryGetValue(fixtureName, out var fixture))
        {
            return fixture as T;
        }
        return null;
    }

    /// <summary>
    /// Add a fixture.
    /// </summary>
    public void AddFixture<T>(T fixture)
    {
        var fixtureName = typeof(T).Name;
        if (fixture != null)
        {
            _fixtures[fixtureName] = fixture;
        }
    }

    /// <summary>
    /// Add multiple fixtures.
    /// </summary>
    public void AddFixtures(List<object> fixtures)
    {
        foreach (var fixture in fixtures)
        {
            var fixtureName = fixture.GetType().Name;
            _fixtures[fixtureName] = fixture;
        }
    }
}