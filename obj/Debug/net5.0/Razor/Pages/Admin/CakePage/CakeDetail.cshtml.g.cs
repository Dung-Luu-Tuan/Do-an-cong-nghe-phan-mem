#pragma checksum "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dfebcfaeb4582f1e6d14e165d3da9132e39439d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Bakery.Pages.User.Admin.CakePage.Pages_Admin_CakePage_CakeDetail), @"mvc.1.0.razor-page", @"/Pages/Admin/CakePage/CakeDetail.cshtml")]
namespace Bakery.Pages.User.Admin.CakePage
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
#line 1 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\_ViewImports.cshtml"
using Bakery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dfebcfaeb4582f1e6d14e165d3da9132e39439d", @"/Pages/Admin/CakePage/CakeDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0195fb53b5fb7e307846aeaefd18f2e19cf4de76", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_CakePage_CakeDetail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-sm-9 font-weight-bold font-italic text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/CartPage/Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "buynow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
  
    Layout = "_Layout2";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"background-color: skyblue; width: 100%; margin-left: 3%; margin-bottom: 2%;\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dfebcfaeb4582f1e6d14e165d3da9132e39439d5062", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" > <a class=\"font-weight-bold font-italic text-decoration-none\" href=\"/Admin/CakePage/Category/?category=null\">Sản phẩm</a> > <a class=\"text-decoration-none font-weight-bold font-italic\"");
            BeginWriteAttribute("href", " href=\"", 472, "\"", 537, 2);
            WriteAttributeValue("", 479, "/Admin/CakePage/Category/?category=", 479, 35, true);
#nullable restore
#line 6 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
WriteAttributeValue("", 514, Model.Product.Category, 514, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.Product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dfebcfaeb4582f1e6d14e165d3da9132e39439d7639", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""/css/details.css"">
    <meta charset=""UTF-8"">
    <title>Chi tiết sản phẩm</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""/css/bootstrap.css"">
    <link rel=""stylesheet"" href=""/css/layout.css"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n<div class=\"container\" id=\"details-container\">\r\n    <div class=\"row\" id=\"details-row\">\r\n        <div class=\"col-sm-6\" >  \r\n            <img");
            BeginWriteAttribute("src", " src=\"", 1228, "\"", 1275, 2);
            WriteAttributeValue("", 1234, "/images/Products/", 1234, 17, true);
#nullable restore
#line 20 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
WriteAttributeValue("", 1251, Model.Product.ImageName, 1251, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"details-img\">\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            <h3>");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
           Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p class=\"price-item\"><strong>Giá:</strong> \r\n                            <strong class=\"price\">");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
                                             Write(string.Format("{0:#,##0}", @Model.Product.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</strong></p>\r\n            <p><strong>Mô tả sản phẩm:</strong></p>\r\n            <div class=\"box-description\" id=\"details-content\">  ");
#nullable restore
#line 27 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
                                                           Write(Model.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </div>  \r\n            <div style=\"padding-top: 3%;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dfebcfaeb4582f1e6d14e165d3da9132e39439d11006", async() => {
                WriteLiteral("Thêm vào giỏ hàng");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
                                                                             WriteLiteral(Model.Product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1904, "Thêm", 1904, 4, true);
#nullable restore
#line 29 "C:\Users\Admin\Desktop\RazorPages\BakeryProj\Pages\Admin\CakePage\CakeDetail.cshtml"
AddHtmlAttributeValue(" ", 1908, Model.Product.Name, 1909, 19, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue(" ", 1928, "vào", 1929, 4, true);
            AddHtmlAttributeValue(" ", 1932, "giỏ", 1933, 4, true);
            AddHtmlAttributeValue(" ", 1936, "hàng", 1937, 5, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"  
            </div>            
        </div>
    </div>

    <div class=""details-row2"">
            <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                    <a class=""btn btn-success"" id=""home-tab"" data-toggle=""tab"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Tổng quan sản phẩm</a>
            </ul>
            <div class=""tab-content"" id=""myTabContent"">
                    <div class=""content-tab"">
                    <div>Bảo quản ở nhiệt độ phòng, tránh ánh nắng trực tiếp</div>
                    <div>Nhiệt độ: 26°C-28°C</div>
            </div>
    </div>
 </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BakeryProj.Pages.Admin.CakePage.CakeDetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BakeryProj.Pages.Admin.CakePage.CakeDetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BakeryProj.Pages.Admin.CakePage.CakeDetailModel>)PageContext?.ViewData;
        public BakeryProj.Pages.Admin.CakePage.CakeDetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
