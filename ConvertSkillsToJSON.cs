using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Aruma.Integration
{
    public class ConvertSkillsToJSON
    {
        private readonly ILogger<ConvertSkillsToJSON> _logger;

        public ConvertSkillsToJSON(ILogger<ConvertSkillsToJSON> logger)
        {
            _logger = logger;
        }

        [Function("ConvertSkillsToJSON")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
