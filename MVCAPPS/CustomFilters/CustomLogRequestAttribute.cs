﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System.Diagnostics;

namespace MVCAPPS.CustomFilters
{
    public class CustomLogRequestAttribute : ActionFilterAttribute 
    {
        private void LogRequest(string currentState, RouteData route) 
        {
            string controller = route.Values["controller"].ToString();
            string action = route.Values["action"].ToString();
            string logMessage = $"Current State of Execution is {currentState} in {action} action method of {controller} Controller";
            Debug.WriteLine(logMessage);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            LogRequest("OnActionExecuting", context.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            LogRequest("OnActionExecuted", context.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            LogRequest("OnResultExecuting", context.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            LogRequest("OnResultExecuted", context.RouteData);
        }
    }
}
