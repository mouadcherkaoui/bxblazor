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
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

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
        [FunctionName(nameof(TestModelAPI))]
        public async Task<IActionResult> TestModelAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "testmodels")] HttpRequest req,
            ILogger log) => await GenericHandler<TestModel>(req, log);

        [FunctionName(nameof(PagesAPI))]
        public async Task<IActionResult> PagesAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "pages")] HttpRequest req,
            ILogger log) => await GenericHandler<Page>(req, log);

        [FunctionName(nameof(SectionsAPI))]
        public async Task<IActionResult> SectionsAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "sections")] HttpRequest req,
            ILogger log) => await GenericHandler<Section>(req, log);

        [FunctionName(nameof(ComponentsAPI))]
        public async Task<IActionResult> ComponentsAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "components")] HttpRequest req,
            ILogger log) => await GenericHandler<Component>(req, log);

        [FunctionName(nameof(MembersAPI))]
        public async Task<IActionResult> MembersAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "members")] HttpRequest req,
            ILogger log) => await GenericHandler<Member>(req, log);
        
        public async Task<IActionResult> GenericHandler<TItem> (HttpRequest req, ILogger log) 
            where TItem : class
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            
            var keyProperty = typeof(TItem).GetProperties().FirstOrDefault(p => p.Name.StartsWith("Id"))
                ?? typeof(TItem).GetProperties().FirstOrDefault(p => p.GetCustomAttribute<KeyAttribute>() != null);
            
            var keyPropertyType = keyProperty.PropertyType;

            ActionResult result = (req.HttpContext.Request) switch
            {
                { Method: "GET" } => handleGet(req),
                { Method: "POST" } => await handlePost(req),
                { Method: "PUT" } => await handlePut(req, keyProperty),
                _ => new ForbidResult()
            };

            return result;

            ActionResult handleGet(HttpRequest req)
            {
                var id = req.Query.ContainsKey("id") ? req.Query["id"].FirstOrDefault() : null;
                
                var result = !String.IsNullOrEmpty(id) ? 
                    _context.Set<TItem>()
                        .Where(t => Convert.ChangeType(keyProperty.GetValue(t), keyPropertyType) == Convert.ChangeType(id, keyPropertyType)) 
                    : (IQueryable<TItem>)_context.Set<TestModel>();
                
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
            async Task<ActionResult> handlePut(HttpRequest req, PropertyInfo keyProperty)
            {

                var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                TItem data = JsonConvert.DeserializeObject<TItem>(requestBody);
                
                var currentRecord = await _context.Set<TItem>().FindAsync(keyProperty.GetValue(data));
                
                ((DbContext)_context).Entry(currentRecord).CurrentValues.SetValues(data);

                await _context.SaveChangesAsync(CancellationToken.None);

                return (ActionResult)new AcceptedResult();
            }

        }
    }
}
