using System.Text.Json;
using Amazon.SQS;
using Amazon.SQS.Model;
using SqsPublisher;

var sqsClient = new AmazonSQSClient();

var customer = new CustomerCreated
{
    Id = Guid.NewGuid(),
    FullName = "Danilo Maia Florezano",
    Email = "danilo@florenzano.com",
    DateOfBirth = new DateTime(2000, 12, 6),
    GitHubUsername = "daniloflorenzano"
};

var queueUrlResponse = await sqsClient.GetQueueUrlAsync("customers");

var sendMessage = new SendMessageRequest
{
  QueueUrl = queueUrlResponse.QueueUrl,
  MessageBody = JsonSerializer.Serialize(customer),
  MessageAttributes = new Dictionary<string, MessageAttributeValue>
  {
      {
          "MessageType", new MessageAttributeValue
          {
              DataType = "String",
              StringValue = nameof(CustomerCreated)
          }
      }
  }
};

var response = await sqsClient.SendMessageAsync(sendMessage);

Console.WriteLine();