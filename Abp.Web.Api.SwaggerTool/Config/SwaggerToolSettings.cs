﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.Web.Api.SwaggerTool.Config
{
   public class SwaggerToolSettings
    {
        public SwaggerToolSettings()
        {
            version = "v1";
            title = "default api";
            CSharpGen = new CSharpGen() { ClassName = "ApiClient", Namespace="ApiServices" };
            TypeScriptGen = new TypeScriptGen() { ClassName = "Client", ModuleName = "ApiSerivces" };
            PostmanGen = new PostmanGen() { name = "ApiServices" };
        }

        public string version { get; set; }
        public string title { get; set; }
        public CSharpGen CSharpGen { get; set; }
        public TypeScriptGen TypeScriptGen { get; set; }
        public PostmanGen PostmanGen { get; set; }


    }

    public class PostmanGen
    {
        public string name { get; set; }
        public string headers { get; set; }
    }

    public class CSharpGen
    {
        public string ClassName { get; set; }
        public string Namespace { get; set; }
    }

    public class TypeScriptGen
    {
        public string ClassName { get; set; }
        public string ModuleName { get; set; }
    }
}
