using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace GymProyect.Web
{
    public static class HtmlHelpers
    {
        public static string IsSelected(this IHtmlHelper html, string area = null, string controller = null, string action = null, string cssClass = null)
        {

            if (String.IsNullOrEmpty(cssClass))
                cssClass = "active";

            var currentArea = (string)html.ViewContext.RouteData.DataTokens["area"];
            var currentAction = (string)html.ViewContext.RouteData.Values["action"];
            var currentController = (string)html.ViewContext.RouteData.Values["controller"];

            if (string.IsNullOrEmpty(area))
                area = currentArea;

            if (string.IsNullOrEmpty(controller))
                controller = currentController;

            if (string.IsNullOrEmpty(action))
                action = currentAction;

            return controller == currentController && action == currentAction && currentArea == area ?
                cssClass : String.Empty;
        }

        public static string PageClass(this IHtmlHelper html)
        {
            string currentAction = (string)html.ViewContext.RouteData.Values["action"];
            return currentAction;
        }
    }
}