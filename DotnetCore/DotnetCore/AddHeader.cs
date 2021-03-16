using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore
{
    public class AddHeaderAttribute : ResultFilterAttribute
    {

        public AddHeaderAttribute()
        {

        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.Headers.Add("Auther", "Akshayraj");
            base.OnResultExecuting(context);
        }
    }
}
