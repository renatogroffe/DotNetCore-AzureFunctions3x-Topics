using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionAppTopics
{
    public static class ServiceBusTopicTrigger
    {
        [FunctionName("ServiceBusTopicTrigger")]
        public static void Run([ServiceBusTrigger("topic-servicebus", "groffe0", Connection = "AzureServiceBusConnection")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"Dados recebidos via Topic do Azure Service Bus: {mySbMsg}");
        }
    }
}