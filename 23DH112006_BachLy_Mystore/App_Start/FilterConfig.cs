﻿using System.Web;
using System.Web.Mvc;

namespace _23DH112006_BachLy_Mystore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}