using FluentAssertions;

namespace Abgabearbeit_gross.Tests;

public class TodoRepositoryTest
{
    private readonly TodoRepository testee = new TodoRepository();

    [Fact]
    private void RepositoryCanNotSaveListsWithItemsNotApproved()
    {
        var todoList = new TodoList("a list");
        todoList.Add(new TodoItem("an item"));
        var act = () => testee.Save(todoList);
        act.Should().Throw<ApplicationException>();
    }

    [Fact]
    private void RepositoryCanSaveListsWithItemsApprovedAndBeyond()
    {
        var todoList = new TodoList("a list");
        var item1 = new TodoItem("item1");
        item1.Approve();
        todoList.Add(item1);
        var item2 = new TodoItem("item2");
        item2.Approve();
        item2.Do();
        todoList.Add(item2);
        var act = () => testee.Save(todoList);
        act.Should().NotThrow();
    }

    [Fact]
    private void CanGetListById()
    {
        var todoList = new TodoList("blub");
        testee.Save(todoList);
        testee.Get(todoList.Id).Should().Be(todoList);
    }
    
    [Fact]
        private void GettingRemoveItemThrows()
        {
            
            var todoList = new TodoList("blub");
            testee.Save(todoList);
            testee.Remove(todoList);
            Action act = () => testee.Get(todoList.Id);
            act.Should().Throw<ApplicationException>().WithMessage("Not found");
        }
}