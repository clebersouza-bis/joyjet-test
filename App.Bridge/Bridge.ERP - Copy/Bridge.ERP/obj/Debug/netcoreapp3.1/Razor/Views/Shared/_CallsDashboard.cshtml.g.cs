#pragma checksum "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Shared\_CallsDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e63b41931f5eeb6c2f709aa4e07530fa3870a318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CallsDashboard), @"mvc.1.0.view", @"/Views/Shared/_CallsDashboard.cshtml")]
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
#line 1 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\_ViewImports.cshtml"
using Bridge.ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\_ViewImports.cshtml"
using Bridge.ERP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e63b41931f5eeb6c2f709aa4e07530fa3870a318", @"/Views/Shared/_CallsDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91fcb07300348ed35c1a2c412214c1631435f3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CallsDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\Shared\_CallsDashboard.cshtml"
  
	//Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"				<!-- Main content -->
				<section class=""content"">
				<section class=""content"">
					<div class=""container-fluid"">
						<!-- Info boxes -->
						<div class=""row"">
							<div class=""col-12 col-sm-6 col-md-3"">
								<div class=""info-box"">
									<span class=""info-box-icon alert-success elevation-1""><i class=""fas fa-phone-volume""></i></span>

									<div class=""info-box-content"">
										<span class=""info-box-text"">Connection Rate</span>
										<span class=""info-box-number"" id=""connectionRate"">
											<small>%</small>
										</span>
									</div>
									<!-- /.info-box-content -->
								</div>
								<!-- /.info-box -->
							</div>
							<!-- /.col -->
							<div class=""col-12 col-sm-6 col-md-3"">
								<div class=""info-box mb-3"">
									<span class=""info-box-icon alert-danger elevation-1""><i class=""fas fa-users""></i></span>

									<div class=""info-box-content"">
										<span class=""info-box-text"">Conversion Rate</span>
										<span clas");
            WriteLiteral(@"s=""info-box-number"" id=""convertionRate"">
											<small>%</small>
										</span>
									</div>
									<!-- /.info-box-content -->
								</div>
								<!-- /.info-box -->
							</div>
							<!-- /.col -->
							<!-- fix for small devices only -->
							<div class=""clearfix hidden-md-up""></div>

							<div class=""col-12 col-sm-6 col-md-3"">
								<div class=""info-box mb-3"">
									<span class=""info-box-icon alert-info elevation-1""><i class=""fas fa-phone-slash""></i></span>

									<div class=""info-box-content"">
										<span class=""info-box-text"">Drop Rate</span>
										<span class=""info-box-number"" id=""dropRate"">
											<small>%</small>
										</span>
									</div>
									<!-- /.info-box-content -->
								</div>
								<!-- /.info-box -->
							</div>
							<!-- /.col -->
							<div class=""col-12 col-sm-6 col-md-3"">
								<div class=""info-box mb-3"">
									<span class=""info-box-icon alert-primary elevation-1""><i class=""fab fa-hotjar"">");
            WriteLiteral(@"</i></span>

									<div class=""info-box-content"">
										<span class=""info-box-text"">Total Leads</span>
										<span class=""info-box-number"" id=""leadCount""></span>
									</div>
									<!-- /.info-box-content -->
								</div>
								<!-- /.info-box -->
							</div>
							<!-- /.col -->
						</div>

						<!-- *************** TESTE DE LAYOUT *********** -->

						<div class=""row"">
							<div class=""col-md-12"">
								<div class=""card"">
									<div class=""card-header"">
										<h5 class=""card-title"">Outbound Units Calls</h5>

										<div class=""card-tools"">
											<button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
												<i class=""fas fa-minus""></i>
											</button>
											<div class=""btn-group"">
												<button type=""button"" class=""btn btn-tool dropdown-toggle"" data-toggle=""dropdown"">
													<i class=""fas fa-wrench""></i>
												</button>
												<div class=""dropdown-menu dropdown-menu-right"" role=");
            WriteLiteral(@"""menu"">
													<a href=""#"" class=""dropdown-item"">Action</a>
													<a href=""#"" class=""dropdown-item"">Another action</a>
													<a href=""#"" class=""dropdown-item"">Something else here</a>
													<a class=""dropdown-divider""></a>
													<a href=""#"" class=""dropdown-item"">Separated link</a>
												</div>
											</div>
											<button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
												<i class=""fas fa-times""></i>
											</button>
										</div>
									</div>
									<!-- /.card-header -->
									<div class=""card-body"">
										<div class=""row"">
											<div class=""col-md-8"">

												<div class=""chart"" id=""chartAreaReport"">
													<!-- Sales Chart Canvas -->
													<!-- <canvas id=""areaChart"" height=""180"" style=""height: 220px;""></canvas> -->
												</div>
												<!-- /.chart-responsive -->
											</div>
											<!-- /.col -->
											<div class=""col-md-4"">
												<div cla");
            WriteLiteral("ss=\"chart\" id=\"chartFunnelReport\" >\r\n");
            WriteLiteral(@"												</div>
											</div>
											<!-- /.col -->
										</div>
										<!-- /.row -->
									</div>
									<!-- ./card-body -->
									<div class=""card-footer"">
										<div class=""row"">
											<div class=""col-sm-3 col-6"">
												<div class=""description-block border-right"">
													<span class=""description-percentage text-success""></span>
													<h5 class=""description-header"" id=""totalTalkedTime""></h5>
													<span class=""description-text"">Total Talked Time</span>
												</div>
												<!-- /.description-block -->
											</div>
											<!-- /.col -->
											<div class=""col-sm-3 col-6"">
												<div class=""description-block border-right"">
													<span class=""description-percentage text-warning""></span>
													<h5 class=""description-header"" id=""averageTalkedTime""></h5>
													<span class=""description-text"">Average Talked Time</span>
												</div>
												<!-- /.description-block -->
	");
            WriteLiteral(@"										</div>
											<!-- /.col -->
											<div class=""col-sm-3 col-6"">
												<div class=""description-block border-right"">
													<span class=""description-percentage text-success""></span>
													<h5 class=""description-header"" id=""agentDropRate""></h5>
													<span class=""description-text"">Agent Drop Rate</span>
												</div>
												<!-- /.description-block -->
											</div>
											<!-- /.col -->
											<div class=""col-sm-3 col-6"">
												<div class=""description-block"">
													<span class=""description-percentage text-danger""></span>
													<h5 class=""description-header"" id=""callToGetLead""></h5>
													<span class=""description-text"">Calls to Get a Lead</span>
												</div>
												<!-- /.description-block -->
											</div>
										</div>
										<!-- /.row -->
									</div>
									<!-- /.card-footer -->
								</div>
								<!-- /.card -->
							</div>
							<!-- /.col -->
						</d");
            WriteLiteral(@"iv>

						<!-- Row for load charts -->

						<div class=""row"">
							<div class=""col-md-6"">

								<!-- DONUT CHART -->
								<div class=""card card-light"">
									<div class=""card-header"">
										<h3 class=""card-title"">System Dispositions Stats</h3>

										<div class=""card-tools"">
											<button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
												<i class=""fas fa-minus""></i>
											</button>
											<button type=""button"" class=""btn btn-tool"" data-card-widget=""remove""><i class=""fas fa-times""></i></button>
										</div>
									</div>
									<div class=""card-body"" id=""chartDonutReport"">
");
            WriteLiteral(@"									</div>
									<!-- /.card-body -->
								</div>
								<!-- /.card -->

							</div>
							<!-- /.col (LEFT) -->
							<div class=""col-md-6"">
								<!-- PIE CHART -->
								<div class=""card card-light"">
									<div class=""card-header"">
										<h3 class=""card-title"">Calls Dispositions Stats</h3>

										<div class=""card-tools"">
											<button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
												<i class=""fas fa-minus""></i>
											</button>
											<button type=""button"" class=""btn btn-tool"" data-card-widget=""remove""><i class=""fas fa-times""></i></button>
										</div>
									</div>
									<div class=""card-body"" id=""chartPieReport"">
");
            WriteLiteral("\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<!-- /.card-body -->\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<!-- /.card -->\r\n\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<!-- /.col (RIGHT) -->\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<!-- End are for charts -->\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</section>\r\n");
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