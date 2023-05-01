using FluentAssertions;

namespace Abgabearbeit_gross.Tests;

public class TodoListTest
{
    private TodoList testee = new TodoList("TestList");

    [Fact]
    private void CanAddItem()
    {
        var todoItem = new TodoItem("item 1");
        this.testee.Add(todoItem);
        this.testee.Items.Should().Contain(todoItem);
    }

    [Fact]
    private void CanRemoveItem()
    {
        var todoItem = new TodoItem("item 1");
        this.testee.Add(todoItem);
        this.testee.Remove(todoItem);
        this.testee.Items.Should().NotContain(todoItem);
    }

    [Fact]
    private void CanShiftState()
    {
        this.testee.Finalize();
        this.testee.State.Should().Be(TodoListState.Finalized);
    }
}