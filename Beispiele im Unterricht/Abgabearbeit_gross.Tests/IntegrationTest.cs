using FluentAssertions;

namespace Abgabearbeit_gross.Tests;

public class IntegrationTest
{
    [Fact]
    public void RepositorySavesTodoList()
    {
        TodoRepository repo = new TodoRepository();

        TodoList waesche = new TodoList("Wäsche");
        waesche.Add(new TodoItem("Wäsche waschen"));
        waesche.Add(new TodoItem("Wäsche aufhängen"));
        waesche.Add(new TodoItem("Wäsche zusammenlegen"));
        waesche.Add(new TodoItem("Wäsche in den Schrank legen"));

        TodoList auto = new TodoList("Auto");
        auto.Add(new TodoItem("Auto waschen"));
        auto.Add(new TodoItem("Auto polieren"));
        auto.Add(new TodoItem("Auto wachsen"));

        waesche.Items.ToList().ForEach(todoItem => todoItem.Approve());
        auto.Items.ToList().ForEach(todoItem => todoItem.Approve());

        repo.Save(waesche);
        repo.Save(auto);

        repo.Get(waesche.Id).Should().Be(waesche);
        repo.Get(auto.Id).Should().Be(auto);
    }
}