using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloMicroservices
{
    public class CurrentDateTimeController : Controller
    {
        [HttpGet("/")]
        public object Get() => DateTime.UtcNow;
    }
}