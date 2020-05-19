using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Kafka;
using Microsoft.Extensions.Logging;

namespace FunctionAppTopics
{
    public static class KafkaTopicTrigger
    {
        [FunctionName("KafkaTopicTrigger")]
        public static void Run([KafkaTrigger(
            "BrokerKafka", "topic-kafka",
            ConsumerGroup = "topic-kafka-group0")]KafkaEventData<string> kafkaEvent,
            ILogger log)
        {
            log.LogInformation($"Dados recebidos via Topic do Apache Kafka: {kafkaEvent.Value.ToString()}");
        }
    }
}