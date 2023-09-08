using Application.Abstractions.Messaging;

namespace Application.Categories.Commands.CreateCommand;

public class CreateCategoryCommand : ICommand<CategoryDto>
{
    public string Name { get; set; }
}
