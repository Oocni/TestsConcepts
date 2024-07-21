namespace TestsConcepts;

/// <summary>
/// The test fixture collection will allow to reuse the same test fixture on multiple test classes
/// but with only one instance of the test fixture for all
/// Otherwise, we can add the interface IClassFixture(TestFixture) to each test class but it will create a new instance of the test fixture for each test class
/// </summary>
[CollectionDefinition("Test fixture collection")]
public class TestFixtureCollection : ICollectionFixture<TestFixture>
{
}