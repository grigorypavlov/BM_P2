using FluentAssertions;

namespace Abgabearbeit_gross.Tests;

public class TodoItemTest
{
    private TodoItem testee = new TodoItem("TestItem");

    [Fact]
    private void CanShiftStateFromCreatedToApproved()
    {
        testee.Approve();
        testee.State.Should().Be(TodoItemState.Approved);
    }
    
    [Fact]
    private void CanShiftStateFromApprovedToFinalized()
    {
        testee.Approve();
        testee.Do();
        testee.State.Should().Be(TodoItemState.Finalized);
    }
}