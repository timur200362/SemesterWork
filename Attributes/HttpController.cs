﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2course.Attributes
{
    internal class HttpController : Attribute
    {
        public string ControllerName;
        public HttpController(string controllerName)
        {
            ControllerName = controllerName;
        }
    }
}
