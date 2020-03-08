using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using NLayersApp.Persistence.Abstractions;
using NLayersApp.Persistence;
using NLayersApp.CQRS;
using BackendApi.Models;
using System.Threading;
using System.Linq;

namespace BackendApi
{
    public class BackendFunction
    {

        private IContext _context;
        private ITypesResolver _resolver;

        public BackendFunction(IContext context, ITypesResolver resolver)
        {
            _resolver = resolver;
            _context = context;
        }
        [FunctionName("Function1")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            ActionResult result = (req.HttpContext.Request) switch
            {
                { Method: "POST" } => await handlePost(req),
                { Method: "GET" } => handleGet(req),
                _ => new ForbidResult()
            };

            return result;

            ActionResult handleGet(HttpRequest req)
            {
                var id = req.Query.ContainsKey("id") ? req.Query["id"].FirstOrDefault() : null;
                
                var result = !String.IsNullOrEmpty(id) ? _context.Set<TestModel>().Where(t => t.Id == Convert.ToInt32(id)) : _context.Set<TestModel>();
                
                return (ActionResult)new OkObjectResult(result.ToArray());
            }

            async Task<ActionResult> handlePost(HttpRequest req)
            {

                var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                TestModel data = JsonConvert.DeserializeObject<TestModel>(requestBody);
                await _context.Set<TestModel>().AddAsync(data);
                await _context.SaveChangesAsync(CancellationToken.None);

                return (ActionResult)new AcceptedResult();
            }
        }
    }
}
