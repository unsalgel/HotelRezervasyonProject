#pragma checksum "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad684da5ec65ec557229a10d1d2211c9fdac6a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingAdmin_BookingDetail), @"mvc.1.0.view", @"/Views/BookingAdmin/BookingDetail.cshtml")]
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
#line 1 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Models.StaffModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Models.TestimonialModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.RoomDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.SubscribeDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.BookingDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.GuestDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\_ViewImports.cshtml"
using HotelRezervasyon.WebUI.Dtos.SendMessageDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad684da5ec65ec557229a10d1d2211c9fdac6a3", @"/Views/BookingAdmin/BookingDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6854ee2c1a8d833335b72b96a0d9163f0016388", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BookingAdmin_BookingDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UpdateBookingDto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("BookingID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString("readonly"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("checkin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("adultcount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("childcount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("roomcount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("specialrequest"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
  
    ViewData["Title"] = "BookingDetail";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Rezervasyon Güncelle</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a311554", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 9 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookingID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>İsim & Soyisim</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a313538", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 11 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>Mail Adresi</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a315743", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 13 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mail);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>Giriş Tarihi</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a317949", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 15 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CheckIn);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>Çıkış Tarihi</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a320158", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 17 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CheckOut);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>Yetişkin Sayısı</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a322371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 19 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AdultCount);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>Çocuk Sayısı</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a324583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 21 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ChildCount);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>Oda Sayısı</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3ad684da5ec65ec557229a10d1d2211c9fdac6a326793", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 23 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomCount);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<label>Özel İstek</label>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad684da5ec65ec557229a10d1d2211c9fdac6a329003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 25 "C:\Users\ÜNSAL\Desktop\ASP. NET MVC  DERSLERİ\HotelRezervasyonProject\Frontend\HotelRezervasyon.WebUI\Views\BookingAdmin\BookingDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SpecialRequest);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<br />

<button type=""button"" class=""btn btn-outline-primary"" id=""btnupdate"">Rezervasyonu Onayla</button>
<button type=""button"" class=""btn btn-outline-warning"" id=""btncancel"">Rezervasyonu iptal et</button>
<button type=""button"" class=""btn btn-outline-dark"" id=""btnwait"">Rezervasyonu Beklet</button>
 






<!--Scriptler-->
<!-- Moment.js -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.29.1/moment.min.js""></script>

<!-- Bootstrap JS ve Popper.js -->
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx"" crossorigin=""anonymous""></script>
<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>

<!-- Bootstrap DateTimePicker CSS -->
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/cs");
            WriteLiteral(@"s/bootstrap-datetimepicker.min.css"">
<!-- Bootstrap DateTimePicker JS -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/js/bootstrap-datetimepicker.min.js""></script>
<!-- Bildirim paneli için -->
<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/sweetalert2@10.16.6/dist/sweetalert2.min.css"">
<script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10.16.6/dist/sweetalert2.min.js""></script>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>



<script>
    // Onaylandığında olacaklar
    $(""#btnupdate"").click(function () {
        let values = {
            BookingID: $(""#BookingID"").val(),
            Name: $(""#name"").val(),
            Mail: $(""#mail"").val(),
            CheckIn: $(""#checkin"").val(),
            CheckOut: $(""#checkout"").val(),
            AdultCount: $(""#adultcount"").val(),
            ChildCount: $(""#childcount"").val(),
            RoomCount: $(""#roomcount"").val(),
            SpecialRequ");
            WriteLiteral(@"est: $(""#specialrequest"").val(),
            Status: ""Onaylandı""
        };
        $.ajax({
            type: ""POST"",
            url: ""/BookingAdmin/Reservationstatus"",
            data: values,
            success: function (fnk5) {
                Swal.fire({
                    icon: 'info',
                    title: 'Rezervasyon Durumu',
                    text: 'Rezervasyon Onaylandı.'
                });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(""Hata: "" + errorThrown);
            }
        });
    });


    //iptal edildiğinde olacaklar
    $(""#btncancel"").click(function () {
        let values = {
            BookingID: $(""#BookingID"").val(),
            Name: $(""#name"").val(),
            Mail: $(""#mail"").val(),
            CheckIn: $(""#checkin"").val(),
            CheckOut: $(""#checkout"").val(),
            AdultCount: $(""#adultcount"").val(),
            ChildCount: $(""#childcount"").val(),
            RoomC");
            WriteLiteral(@"ount: $(""#roomcount"").val(),
            SpecialRequest: $(""#specialrequest"").val(),
            Status: ""iptal edildi""
        };
        $.ajax({
            type: ""POST"",
            url: ""/BookingAdmin/Reservationstatus"",
            data: values,
            success: function (fnk5) {
                Swal.fire({
                    icon: 'info',
                    title: 'Rezervasyon Durumu',
                    text: 'Rezervasyon iptal edildi.'
                });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(""Hata: "" + errorThrown);
            }
        });
    });

    //Beklemeye alındıgında olacaklar
    $(""#btnwait"").click(function () {
        let values = {
            BookingID: $(""#BookingID"").val(),
            Name: $(""#name"").val(),
            Mail: $(""#mail"").val(),
            CheckIn: $(""#checkin"").val(),
            CheckOut: $(""#checkout"").val(),
            AdultCount: $(""#adultcount"").val(),
       ");
            WriteLiteral(@"     ChildCount: $(""#childcount"").val(),
            RoomCount: $(""#roomcount"").val(),
            SpecialRequest: $(""#specialrequest"").val(),
            Status: ""Beklemede""
        };
        $.ajax({
            type: ""POST"",
            url: ""/BookingAdmin/Reservationstatus"",
            data: values,
            success: function (fnk5) {
                Swal.fire({
                    icon: 'info',
                    title: 'Rezervasyon Durumu',
                    text: 'Rezervasyon Beklemeye alındı.'
                });
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert(""Hata: "" + errorThrown);
            }
        });
    });
</script>


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpdateBookingDto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
