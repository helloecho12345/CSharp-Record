namespace ToDo.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void Initialise_Return_Empty_String()
    {
        // ARRANGE
        ToDo todo = new ToDo();

        // ACT
        List<string> expected = new List<string>{};
        List<string> actual = todo.getTaskList;

        // ASSERT
        Assert.AreEqual(actual, expected);
    }
}