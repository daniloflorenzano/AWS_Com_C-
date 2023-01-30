using MediatR;

namespace Customers.Consumer.Messages;

public class CustomerCreated : ISqsMessage
{
    public Guid Id { get; init; }
    public string FullName { get; init; }
    public string Email { get; init; }
    public string GitHubUsername { get; init; }
    public DateTime DateOfBirth { get; init; }
}

public class CustomerUpdated : ISqsMessage
{
    public Guid Id { get; init; }
    public string FullName { get; init; }
    public string Email { get; init; }
    public string GitHubUsername { get; init; }
    public DateTime DateOfBirth { get; init; }
}

public class CustomerDeleted : ISqsMessage
{
    public Guid Id { get; init; }
}