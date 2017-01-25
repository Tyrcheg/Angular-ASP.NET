using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net;
using System.Web.Mvc;

namespace angpluralmvcempty.Controllers
{
    public class JsonController : Controller
    {
        protected new ActionResult Json(object data, JsonRequestBehavior behaviour = JsonRequestBehavior.DenyGet)
        {
            var jsonSerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            if (Request.RequestType == WebRequestMethods.Http.Get && behaviour == JsonRequestBehavior.DenyGet)
                throw new InvalidOperationException("");

            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(data, jsonSerializerSettings),
                ContentType = "application/json"
            };
        }
    }
}