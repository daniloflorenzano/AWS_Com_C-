using Amazon.SQS.Model;

namespace Customers.Api.Messaging;

public interface ISqsMessanger
{
    Task<SendMessageResponse> SendMessageAsync<T>(T message);
}