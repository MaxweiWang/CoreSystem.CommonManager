#pragma checksum "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\PowerControl\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12802ad5fc9bed76942b97f67af4e18f6a635752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Sys_PowerControl_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Sys/PowerControl/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Entities.SysClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Service.SysClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using AppFormTag;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12802ad5fc9bed76942b97f67af4e18f6a635752", @"/Areas/Admin/Views/Sys/PowerControl/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986af3a92b9908fec85e16c7dc15a974d36d81ae", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Sys_PowerControl_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\PowerControl\Index.cshtml"
 if (!string.IsNullOrEmpty(ViewData["PowerModel"].ToStr()))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script type=\"text/javascript\">\r\n        var PowerModel=");
#nullable restore
#line 4 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\PowerControl\Index.cshtml"
                  Write(Html.Raw(ViewData["PowerModel"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        var entity=PowerModel;\r\n        $(function(){\r\n            if(!entity.Have){\r\n                admin.msg(\"缺少【是否拥有该菜单的权限】！\",\"警告\");\r\n            }\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 12 "D:\max\Git\CoreSystem.CommonManager\Max.Common.Admin\Areas\Admin\Views\Sys\PowerControl\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
