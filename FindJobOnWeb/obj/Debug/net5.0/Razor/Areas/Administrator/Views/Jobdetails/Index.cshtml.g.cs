#pragma checksum "D:\Workspace\Donet nang cao\BTL\FindJobOnWeb\Areas\Administrator\Views\Jobdetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3a15f5ee0a7694061e76230d058f15c84e390d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Jobdetails_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Jobdetails/Index.cshtml")]
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
#line 1 "D:\Workspace\Donet nang cao\BTL\FindJobOnWeb\Areas\Administrator\Views\_ViewImports.cshtml"
using FindJobOnWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\BTL\FindJobOnWeb\Areas\Administrator\Views\_ViewImports.cshtml"
using FindJobOnWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3a15f5ee0a7694061e76230d058f15c84e390d", @"/Areas/Administrator/Views/Jobdetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d229be673c97dabebd711771259614166c6c65", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Jobdetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FindJobOnWeb.Model.Entities.JobPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\Donet nang cao\BTL\FindJobOnWeb\Areas\Administrator\Views\Jobdetails\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Administrator/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <!-- Hero Area Start-->
    <div class=""slider-area "">
        <div class=""single-slider section-overly slider-height2 d-flex align-items-center"" data-background=""assets/img/hero/about.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-12"">
                        <div class=""hero-cap text-center"">
                            <h2>VietnamWork</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Hero Area End -->
    <!-- job post company Start -->
    <div class=""job-post-company pt-120 pb-120"">
        <div class=""container"">
            <div class=""row justify-content-between"">
                <!-- Left Content -->
                <div class=""col-xl-7 col-lg-8"">
                    <!-- job single -->
                    <div class=""single-job-items mb-50 listDetails"">
                    </div>

                    <!-- ");
            WriteLiteral(@"job single End -->

                    <div class=""job-post-details"">
                        <div class=""post-details2  mb-50"">
                            <!-- Small Section Tittle -->
                            <div class=""small-section-tittle"">
                                <h4>Kiến thức, kỹ năng và khả năng cần thiết</h4>
                            </div>
                            <ul>
                                <li>Phát triển phần mềm hệ thống</li>
                                <li>Ứng dụng di động trong iOS/Android/Tizen hoặc nền tảng khác</li>
                                <li>Nghiên cứu và viết mã, thư viện, API và khung</li>
                                <li>Kiến thức vững chắc về vòng đời phát triển phần mềm</li>
                                <li>Kỹ năng giải quyết vấn đề và gỡ lỗi mạnh mẽ</li>
                            </ul>
                        </div>
                        <div class=""post-details2  mb-50"">
                            <!-- Small Section");
            WriteLiteral(@" Tittle -->
                            <div class=""small-section-tittle"">
                                <h4>Học vấn + Kinh nghiệm</h4>
                            </div>
                            <ul>
                                <li>3 năm kinh nghiệm thiết kế chuyên nghiệp trở lên</li>
                                <li>Trải nghiệm email phản hồi trực tiếp</li>
                                <li>Kinh nghiệm thiết kế website thương mại điện tử</li>
                                <li>Quen thuộc với các ứng dụng di động và web được ưu tiên</li>
                                <li>Kinh nghiệm sử dụng Invision một điểm cộng</li>
                            </ul>
                        </div>
                    </div>

                </div>
                <!-- Right Content -->
                <div class=""col-xl-4 col-lg-4 "">
                    <div class=""post-details3  mb-50 listCompany "">
                       
                    </div>
                    <div class=""post-");
            WriteLiteral(@"details4  mb-50 Company"">
                        <!-- Small Section Tittle -->
                       
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- job post company End -->

</main>

<script type=""text/javascript"">

    $(document).ready(function () {
        loadData();
        console.log(JobPostId);
    });
    var currentUrl = window.location.href;
    var JobPostId = currentUrl.substring(currentUrl.lastIndexOf('/') + 1);
    function loadData() {
        $.ajax({
            url: ""/Jobdetails/GetById"",
            data: { id: JobPostId },
            type: ""GET"",
            contentType: ""application/json;charset=utf-8"",
            success: function (result) {
                var jobTypeName = result.jobTypeName;
                var location = result.location;
                var salary = result.salary;
                var description = result.description;
                var experience = result.experience;
     ");
            WriteLiteral(@"           var skill = result.skill;
                var education = result.education;
                var idCompany = result.companyId;
                var status = result.status;
                const datetime = new Date(result.createdDate);
                const year = datetime.getFullYear();
                const month = datetime.getMonth() + 1;
                const day = datetime.getDate();
                const date = year + '-' + month + '-' + day;

                $.ajax({
                    url: '/Company/GetById',
                    data: { id: idCompany },
                    type: 'GET',
                    contentType: 'application/json;charset=utf-8',
                    success: function (result) {
                        var data = '';
                        data += '<div class=""single-job-items mb-50"">';
                        data += '<div class=""job-items"">';
                        data += '<div style = ""width: 100%""; class=""job-tittle"">';
                        d");
            WriteLiteral(@"ata += '<a href=""#"">';
                        data += '<h3 style = ""margin-bottom: 25px;"">' + jobTypeName + '</h3>';
                        data += '</a>';
                        data += '<ul>';
                        data += '<li>' + ""Tên công ty : "" + result.companyName + '</li>';
                        data += '<li><i class=""fas fa-map-marker-alt""></i>' + ""Địa điểm : "" + location + '</li>';
                        data += '<li>' + ""Lương : "" + salary + "" VND"" + '</li>';
                        data += '</ul>';
                        data += '</div>';
                        data += '<br>';
                        data += '<div style=""margin-top:25px;"" class=""post-details1 mb-50"">';
                        data += '<div class=""small-section-tittle"">';
                        data += '<h3>Miêu tả công việc</h3>';
                        data += '</div>';
                        data += '<p>' + description + '</p>';
                        data += '<h4>Các kỹ năng cần thiết</h4>';
      ");
            WriteLiteral(@"                  data += '<p>' + skill + '</p>';
                        data += '<h4>Bằng cấp hoặc chứng chỉ</h4>';
                        data += '<p>' + education + '</p>';
                        data += '<h4>Yều cầu số năm kinh nghiệm</h4>';
                        data += '<p>' + experience + '</p>';
                        data += '</div>';
                        data += '</div>';
                        $('.listDetails').html(data);

                        var datas = '';
                        datas += '<div class=""small-section-tittle"">';
                        datas += '<h4>Tổng quan về công việc</h4>';
                        datas += '</div>';
                        datas += '<ul>';
                        datas += '<li>' + ""Ngày đăng : "" + date + '</li>';
                        datas += '<li>' + ""Địa điểm : "" + location + '</li>';
                        datas += '<li>' + ""Trạng thái : "" + status + '</li>';
                        datas += '<li>' + ""Lương tháng : "" + sal");
            WriteLiteral(@"ary + "" VND"" + '</li>';
                        datas += '</ul>';
                        datas += '<div style=""text-align:center"" class=""apply-btn2"">';
                        datas += '<a href=""#"" class=""btn"">Liên hệ ngay bây giờ</a>';
                        datas += '</div>';
                        datas += '</div>';
                        $('.listCompany').html(datas);

                        var dataCompany = '';
                        dataCompany += '<h4>Thông tin của công ty</h4>';
                        dataCompany += '</div>';
                        dataCompany += '<span>' + ""Công ty : "" + result.companyName + '</span>';
                        dataCompany += '<p>' + result.description +'</p>';
                        dataCompany += '<ul>';
                        dataCompany += ' <li>' + ""Lĩnh vực : "" + result.businessStreamName + '</li>';
                        dataCompany += ' <li>'+""Email : "" +result.email+'</li>';
                        dataCompany += '</ul>';
         ");
            WriteLiteral("               $(\'.Company\').html(dataCompany);\r\n                    },\r\n                });\r\n            },\r\n        });\r\n    }\r\n    \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FindJobOnWeb.Model.Entities.JobPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
