﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AdminPanelMVC.Utilities
{
    public static class Utilities
    {
        public static string IsActive(this HtmlHelper html,
                                      string control,
                                      string action)
        {
            var routeData = html.ViewContext.RouteData;

            var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            var returnActive = control == routeControl &&
                               action == routeAction;

            return returnActive ? "active" : "";
        }

        public static string IsControllerActive(this HtmlHelper html, string[] control)
        {
            var routeData = html.ViewContext.RouteData;
            bool returnActive=false;
            int flag = 0;
            //var routeAction = (string)routeData.Values["action"];
            var routeControl = (string)routeData.Values["controller"];

            // both must match
            foreach (var aControl in control)
            {
                 returnActive = aControl == routeControl;
                if (returnActive)
                {
                    flag++;
                }
            }

            if (flag > 0)
            {
                return "active";
            }

            return "";
            //return returnActive ? "active" : "";
        }
        //public static string IsSelected(this HtmlHelper html, string controllers = "", string actions = "", string cssClass = "active")
        //{
        //    ViewContext viewContext = html.ViewContext;
        //    bool isChildAction = viewContext.Controller.ControllerContext.IsChildAction;

        //    if (isChildAction)
        //        viewContext = html.ViewContext.ParentActionViewContext;

        //    RouteValueDictionary routeValues = viewContext.RouteData.Values;
        //    string currentAction = routeValues["action"].ToString();
        //    string currentController = routeValues["controller"].ToString();

        //    if (String.IsNullOrEmpty(actions))
        //        actions = currentAction;

        //    if (String.IsNullOrEmpty(controllers))
        //        controllers = currentController;

        //    string[] acceptedActions = actions.Trim().Split(',').Distinct().ToArray();
        //    string[] acceptedControllers = controllers.Trim().Split(',').Distinct().ToArray();

        //    return acceptedActions.Contains(currentAction) && acceptedControllers.Contains(currentController) ?
        //        cssClass : String.Empty;
        //}
    }
}