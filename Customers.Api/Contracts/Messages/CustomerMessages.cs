namespace Customers.Api.Contracts.Messages;

public class CustomerCreated
{
    public Guid Id { get; init; }
    public string FullName { get; init; }
    public string Email { get; init; }
    public string GitHubUsername { get; init; }
    public DateTime DateOfBirth { get; init; }
}

public class CustomerUpdated
{
    public Guid Id { get; init; }
    public string FullName { get; init; }
    public string Email { get; init; }
    public string GitHubUsername { get; init; }
    public DateTime DateOfBirth { get; init; }
}

public class CustomerDeleted
{
    public Guid Id { get; init; }
}