#pragma checksum "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15117bd1d0be5abdc89ed25a6558b7560465def0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Entities.SysClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Service.SysClass;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using Max.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\_ViewImports.cshtml"
using AppFormTag;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15117bd1d0be5abdc89ed25a6558b7560465def0", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986af3a92b9908fec85e16c7dc15a974d36d81ae", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewBag.Title = "HzyAdmin .NetCore";
    ViewBag.MainPage = "/Admin/Home/Main/";
    ViewBag.LoginPage = AppConfig.LoginPageUrl;
    ViewBag.Out = "/Admin/Login/Out";

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""hzy-container"" id=""hzy-container"">
    <header class=""hzy-header-skin-blue"">
        <div class=""hzy-header-left"">
            <ul>
                <!--fas fa-indent-->
                <li class=""hzy-headerhover"" onclick=""hzy.menu.toggle();""><a href=""javascript:void(0)""><i class=""fas fa-outdent""></i></a></li>
                <li class=""hzy-headerhover hzy-logo""><a>");
#nullable restore
#line 19 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
                                                   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
            </ul>
        </div>
        <div class=""hzy-header-right d-none d-lg-block"">
            <ul>
                <li class=""hzy-headerhover""><a href=""/swagger"" target=""_blank""><i class=""fas fa-desktop""></i>&nbsp;&nbsp;进入Swagger</a></li>
                <li class=""hzy-headerhover"" onclick=""hzy.tabs.refreshActive();""><a href=""javascript:void(0)""><i class=""fas fa-undo""></i></a></li>
                <li class=""hzy-headerhover"" onclick=""$('#examplePositionSidebar').modal()""><a href=""javascript:void(0)""><i class=""fas fa-layer-group""></i></a></li>
                <!--fa fa-compress-->
                <li class=""hzy-headerhover""><a href=""javascript:void(0)"" onclick=""hzy.fullScreen.handleFullScreen(this)""><i class=""fas fa-expand""></i></a></li>
                <li class=""hzy-headerhover""><a");
            BeginWriteAttribute("href", " href=\"", 1449, "\"", 1468, 1);
#nullable restore
#line 29 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1456, ViewBag.Out, 1456, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">登录人：&nbsp;<span>");
#nullable restore
#line 29 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
                                                                              Write(ViewBag.UsreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>&nbsp;<i class=\"fas fa-sign-out-alt\"></i></a></li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"hzy-header-right d-lg-none\">\r\n            <ul>\r\n                <li class=\"hzy-headerhover\"><a");
            BeginWriteAttribute("href", " href=\"", 1711, "\"", 1730, 1);
#nullable restore
#line 34 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 1718, ViewBag.Out, 1718, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-sign-out-alt\"></i></a></li>\r\n            </ul>\r\n        </div>\r\n    </header>\r\n    <main>\r\n        <!--menu 菜单-->\r\n        <nav class=\"hzy-menu sidebar-nav sidebar-nav-max\">\r\n            ");
#nullable restore
#line 41 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
       Write(Html.Raw(ViewBag.Menus));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </nav>
        <section class=""hzy-main-right"">
            <!--tabs 选项卡-->
            <nav class=""d-none d-lg-block"">
                <div class=""hzy-left-btn"" onclick=""hzy.tabs.goLeft(this)""><i class=""fa fa-chevron-left""></i></div>
                <div class=""hzy-center-menu"">
                    <!--横向导航-->
                    <ul>
                        <li class=""selected""");
            BeginWriteAttribute("hzy-router", " hzy-router=\"", 2360, "\"", 2396, 2);
            WriteAttributeValue("", 2373, "#!首页#!", 2373, 6, true);
#nullable restore
#line 50 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
WriteAttributeValue("", 2379, ViewBag.MainPage, 2379, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">首页</li>
                    </ul>
                </div>
                <div class=""hzy-right-btn"" onclick=""hzy.tabs.goRight(this)""><i class=""fa fa-chevron-right""></i></div>
                <div class=""btn-group dropdown pull-left"" id=""hzy-tools"">
                    <button type=""button"" class=""btn btn-outline btn-default dropdown-toggle height-full hzy-navTab-more"" id=""exampleBulletDropdown2"" data-toggle=""dropdown"" aria-expanded=""false""></button>
                    <div class=""dropdown-menu dropdown-menu-bullet dropdown-menu-right"" aria-labelledby=""exampleBulletDropdown2"" role=""menu"" x-placement=""bottom-end"" style=""position: absolute; will-change: transform; top: 0px; left: 0px; transform: translate3d(-135px, 39px, 0px);"">
                        <a class=""dropdown-item"" href=""javascript:;"" role=""menuitem"" onclick=""hzy.tabs.closeOther()"">
                            <i class=""fas fa-times""></i> 关闭其他
                        </a>
                        <a class=""dropdown-item"" href=""javascript:;");
            WriteLiteral(@""" role=""menuitem"" onclick=""hzy.tabs.closeAll()"">
                            <i class=""fas fa-power-off""></i> 关闭所有
                        </a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""javascript:;"" role=""menuitem"" onclick=""hzy.tabs.refreshActive()"">
                            <i class=""fas fa-undo""></i> 刷新当前
                        </a>
                    </div>
                </div>
            </nav>
            <!--html 承载容器-->
            <content></content>
        </section>
    </main>
</div>

<!--皮肤模态框-->
<div class=""modal fade"" id=""examplePositionSidebar"" aria-hidden=""true"" aria-labelledby=""examplePositionSidebar"" role=""dialog"" tabindex=""-1"">
    <div class=""modal-dialog modal-sidebar modal-sm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h3 class=""modal-title"">皮肤设置</h3>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15117bd1d0be5abdc89ed25a6558b7560465def011220", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">顶部颜色：</label>
                        <div class=""row"">
                            <div class=""col-sm-12 hzy-skin hzy-header-skin-blue"" onclick=""hzy.header.setSkin('hzy-header-skin-blue')""></div>
                            <div class=""col-sm-12 hzy-skin hzy-header-skin-dark"" onclick=""hzy.header.setSkin('hzy-header-skin-dark')""></div>
                            <div class=""col-sm-12 hzy-skin hzy-header-skin-white"" onclick=""hzy.header.setSkin('hzy-header-skin-white')""></div>
                        </div>

                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">左侧菜单颜色：</label>
                        <div class=""row"">
                            <div class=""col-sm-12 hzy-skin hzy-skin-default"" onclick=""hzy.menu.setSkin(hzy.menu.mSkin.default)""></div>
                            <div class=""col-sm-12 hzy-skin hzy-skin-white""");
                WriteLiteral(" onclick=\"hzy.menu.setSkin(hzy.menu.mSkin.white)\"></div>\r\n                        </div>\r\n\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n    var app = {\r\n        //客户端与服务端保持长连接\r\n        connetct: function () {\r\n            admin.ajax({\r\n                url: \"");
#nullable restore
#line 115 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
                 Write(Url.Action("Connetct"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                success: function (r) {
                    console.log(r);
                }
            });
        }
    };
    //js路由初始化
    hzyRouter.init(function () {
        hzy.menu.domObject = $('#adminMenu').metisMenu();
        //admin 初始化
        hzy.settings.isIframe = true;
        hzy.init();

        //默认首页
        if (!top.window.location.hash) hzy.loadPage('");
#nullable restore
#line 130 "D:\BMax\CommonManagerSystem\Max.CommonManagerSystem\Max.Common.Admin\Areas\Admin\Views\Home\Index.cshtml"
                                                Write(ViewBag.MainPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n\r\n        app.connetct();\r\n        setInterval(function () {\r\n            app.connetct();\r\n        }, 1000 * 60);\r\n\r\n    });\r\n</script>");
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