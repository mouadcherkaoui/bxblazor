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
using NLayersApp.CQRS.Requests;
using BackendApi.Models;
using System.Threading;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MediatR;

namespace BackendApi
{
    public class BackendFunction
    {

        private IMediator _mediator;
        public BackendFunction(IContext context, ITypesResolver resolver, IMediator mediator)
        {
            _mediator = mediator;
        }
        [FunctionName(nameof(TestModelAPI))]
        public async Task<IActionResult> TestModelAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "testmodels")] HttpRequest req,
            ILogger log) => await GenericHandler<TestModel, int>(req, log);

        [FunctionName(nameof(PagesAPI))]
        public async Task<IActionResult> PagesAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "pages")] HttpRequest req,
            ILogger log) => await GenericHandler<Page, object>(req, log);

        [FunctionName(nameof(SectionsAPI))]
        public async Task<IActionResult> SectionsAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "sections")] HttpRequest req,
            ILogger log) => await GenericHandler<Section, object>(req, log);

        [FunctionName(nameof(ComponentsAPI))]
        public async Task<IActionResult> ComponentsAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "components")] HttpRequest req,
            ILogger log) => await GenericHandler<Component, object>(req, log);

        [FunctionName(nameof(MembersAPI))]
        public async Task<IActionResult> MembersAPI(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "members")] HttpRequest req,
            ILogger log) => await GenericHandler<Member, object>(req, log);

        public async Task<IActionResult> GenericHandler<TItem, TKey>(HttpRequest req, ILogger log)
            where TItem : class
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var keyProperty = typeof(TItem).GetProperties().FirstOrDefault(p => p.Name.StartsWith("Id"))
                ?? typeof(TItem).GetProperties().FirstOrDefault(p => p.GetCustomAttribute<KeyAttribute>() != null);

            var keyPropertyType = keyProperty.PropertyType;

            ActionResult result = (req.HttpContext.Request) switch
            {
                { Method: "GET" } => await handleGet(req),
                { Method: "POST" } => await handlePost(req),
                { Method: "PUT" } => await handlePut(req),
                _ => new ForbidResult()
            };

            return result;

            async Task<ActionResult> handleGet(HttpRequest req)
            {
                var id = req.Query.ContainsKey("id")
                    ? req.Query["id"].FirstOrDefault()
                        .pipeTo(value => Convert.ChangeType(value, keyPropertyType))
                    : null;

                dynamic result = (id) switch
                {
                    null => await _mediator.Send(new ReadEntitiesRequest<TItem>(new string[0])),//  _context.Set<TItem>().ToListAsync(),
                    _ => await _mediator.Send(new ReadEntityRequest<TKey, TItem>((TKey)id)) //_context.Set<TItem>().FindAsync(id)
                };

                return (ActionResult)new OkObjectResult(result);
            }

            async Task<ActionResult> handlePost(HttpRequest req)
            {

                var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                TItem data = JsonConvert.DeserializeObject<TItem>(requestBody);

                var result = await _mediator.Send(new CreateEntityRequest<TItem>(data));
                return (ActionResult)new CreatedResult($"/{((dynamic)result).Id}", result);
            }

            async Task<ActionResult> handlePut(HttpRequest req)
            {

                var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                TItem data = JsonConvert.DeserializeObject<TItem>(requestBody);
                TKey id = ((dynamic)data).Id;

                await _mediator.Send(new UpdateEntityRequest<TKey, TItem>(id, data));

                return (ActionResult)new AcceptedResult();
            }

        }
    }
}
