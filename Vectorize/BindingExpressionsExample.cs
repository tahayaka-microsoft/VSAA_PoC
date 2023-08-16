using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using Vectorize.Models;
using Vectorize.Services;

namespace Vectorize
{
    public static class BindingExpressionsExample
    {
        [FunctionName("LogQueueMessage")]
        public static void Run(
            [QueueTrigger("%queueappsetting%")] string myQueueItem,
            DateTimeOffset insertionTime,
            ILogger log)
        {
            log.LogInformation($"Message content: {myQueueItem}");
            log.LogInformation($"Created at: {insertionTime}");
        }
    }
}
