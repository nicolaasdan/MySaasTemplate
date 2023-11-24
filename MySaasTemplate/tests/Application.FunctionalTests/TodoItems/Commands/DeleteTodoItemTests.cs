//using MySaasTemplate.Application.TodoItems.Commands.CreateTodoItem;
//using MySaasTemplate.Application.TodoItems.Commands.DeleteTodoItem;
//using MySaasTemplate.Application.TodoLists.Commands.CreateTodoList;
//using MySaasTemplate.Domain.Entities;

//using static MySaasTemplate.Application.FunctionalTests.TestingBase;

//namespace MySaasTemplate.Application.FunctionalTests.TodoItems.Commands;
//public class DeleteTodoItemTests : BaseTestFixture
//{
//    [Test]
//    public async Task ShouldRequireValidTodoItemId()
//    {
//        var command = new DeleteTodoItemCommand(99);

//        await FluentActions.Invoking(() =>
//            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
//    }

//    [Test]
//    public async Task ShouldDeleteTodoItem()
//    {
//        var listId = await SendAsync(new CreateTodoListCommand
//        {
//            Title = "New List"
//        });

//        var itemId = await SendAsync(new CreateTodoItemCommand
//        {
//            ListId = listId,
//            Title = "New Item"
//        });

//        await SendAsync(new DeleteTodoItemCommand(itemId));

//        var item = await FindAsync<TodoItem>(itemId);

//        item.Should().BeNull();
//    }
//}
