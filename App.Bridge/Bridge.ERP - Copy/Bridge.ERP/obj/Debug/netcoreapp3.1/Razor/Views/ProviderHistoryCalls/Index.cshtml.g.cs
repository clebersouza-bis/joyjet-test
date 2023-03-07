#pragma checksum "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\ProviderHistoryCalls\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03b89370107315cafc6763f286db7feeae3cdea3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProviderHistoryCalls_Index), @"mvc.1.0.view", @"/Views/ProviderHistoryCalls/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03b89370107315cafc6763f286db7feeae3cdea3", @"/Views/ProviderHistoryCalls/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91fcb07300348ed35c1a2c412214c1631435f3f", @"/Views/_ViewImports.cshtml")]
    public class Views_ProviderHistoryCalls_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CallsDashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\ProviderHistoryCalls\Index.cshtml"
  
    ViewData["Title"] = "Phone Campaigns Dashboard";
	Layout = "~/Views/Shared/_Layout.cshtml";

  var bagCampaigns= ViewBag.Campaigns;
	var campaignsList = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(bagCampaigns));
  //var callDates = ViewBag.TotalCallsByDate.Keys;
	//var totalCalls = ViewBag.TotalCallsByDate.Values;
 //   var totalConnectedCalls = ViewBag.TotalConnectedCallsByDate.Values;
 //   var totalHumanConnectedCalls = ViewBag.TotalConnectedToAgent.Values;
 //   var connectionRate = ViewBag.ConnectionRate;
 //   var connectionAgentRate = ViewBag.ConnectionAgentRate;
 //   var convertionRate = ViewBag.ConvertionRate;
 //   var dropRate = ViewBag.DropRate;
 //   var leadsCount = ViewBag.LeadsCount;
 //   var totalTalkedTime = ViewBag.TotalTalkedTime;
 //   var averageTalkedTime = 0.0;
 //   if (totalTalkedTime > 0)
 //   { 
 //       averageTalkedTime = ViewBag.AverageTalkedTime;
 //   }
 //   var agentDropRate = ViewBag.AgentDropRate;
 //   var callsToGetLead = ViewBag.CallToGetLead;
 //   var callsSystemDispositions = ViewBag.CallsSystemDispositions.Keys;
 //   var callsSystemDispositionsValues = ViewBag.CallsSystemDispositions.Values;
 //   var callsDisposition = ViewBag.CallsDisposition.Keys;
 //   var callsDispositionValues = ViewBag.CallsDisposition.Values;
 //   //var values = (ViewBag.Values as List<int>);

	//var dateSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(callDates));
	//var totalCallsSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(totalCalls));
	//var totalConnectedCallsSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(totalConnectedCalls));
	//var totalHumanConnectedCallsSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(totalHumanConnectedCalls));

	//var leadsCountSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(leadsCount));
 //   var callsSystemDispositionsSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(callsSystemDispositions));
 //   var callsSystemDispositionsValuesSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(callsSystemDispositionsValues));
 //   var callsDispositionsSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(callsDisposition));
 //   var callsDispositionsValuesSerialized = Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(callsDispositionValues));


#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03b89370107315cafc6763f286db7feeae3cdea36154", async() => {
                WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->

<div class=""content-wrapper"">
	<!-- Content Header (Page header) -->
	<div class=""content-header"">
		<div class=""container-fluid"">
			<div class=""row mb-2"">
				<div class=""col-sm-6""> 
					<h4 class=""m-0 text-dark"">Phone Campaigns Results</h4>
                </div>

				<div class=""col-sm-6"">    
					<ol class=""breadcrumb float-sm-right"">
");
                WriteLiteral(@"                  <div class=""input-group"">
                    <div>
                        <button type=""button"" class=""btn btn-primary mr-4"" data-toggle=""modal"" data-target=""#modal-default"">
                            More Filters                      
                        </button>
                    </div>
                    <div class=""input-group-prepend"">
                      <span class=""input-group-text"">
                        <i class=""far fa-calendar-alt""></i>
                      </span>
                    </div>                    
                    <label type=""text"" class=""form-control float-right"" id=""reservation"" ></label> 
                    <button type=""button"" onclick='GetChartData()' class=""btn btn-primary ml-2"" title=""Filter""><span class=""fa fa-filter""></span></button> 

                  </div>

					</ol>
				</div><!-- /.col -->
			</div><!-- /.row -->
		</div><!-- /.container-fluid -->
	</div>
	<!-- /.content-header -->

        <div class=""mod");
                WriteLiteral(@"al fade"" id=""modal-default"">
        <div class=""modal-dialog"">
          <div class=""modal-content"">
            <div class=""modal-header"">
              <h4 class=""modal-title"">More filter options</h4>
              <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
              </button>
            </div>
            <div class=""modal-body"">
              	<div class=""col-sm-12""> 
                <p>Campaigns</p>
                   <select class=""select2"" id=""campaignsList"" multiple=""multiple"" style=""width: 100%;"">

                   </select>
				</div>
            </div>
            <div class=""modal-footer justify-content-between"">
              <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
              <button type=""button"" class=""btn btn-primary"" onclick='GetChartData()' data-dismiss=""modal"">Filter</button>
            </div>
          </div>
          <!-- /.");
                WriteLiteral("modal-content -->\r\n        </div>\r\n        <!-- /.modal-dialog -->\r\n      </div>\r\n      \r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03b89370107315cafc6763f286db7feeae3cdea39166", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

</div>

<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/daterangepicker/daterangepicker.min.js""></script>

<script>
OpenModalFilters();


   $(document).ready(function () {
            //displayBusyIndicator();
            var result = ");
#nullable restore
#line 123 "F:\App.Bridge\Bridge.ERP\Bridge.ERP\Views\ProviderHistoryCalls\Index.cshtml"
                    Write(campaignsList);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
            $(""#campaignsList"").select2({
              allowClear: true,
              data: result              
            });
            GetChartData(""startingPage"");
   });

function displayBusyIndicator() {
    $('.overlay').show();
};

function hideBusyIndicator() {
    $('.overlay').hide();
};

/* $(window).on('beforeunload', function(){
    displayBusyIndicator();
    hideBusyIndicator();

}); */

function OpenModalFilters (){
  //Initialize Select2 Elements
  /* $('.select2').select2();
    $.ajax({
      url: ""/ProviderHistoryCalls/GetCampaignsList"",
      type: ""GET"",
      DataType:""json"",
      traditional: true,
      contentType: ""application/x-www-form-urlencoded; charset=UTF-8"",
      success: function(result)
      {
        debugger;
        $(""#campaignsList"").load(result);
      }    
    }); */    
");
                WriteLiteral(@"}


var start = moment().subtract(7, 'days');
var end = moment().subtract(1, 'days');

function cb(start, end) {
    $('#reservation').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
}

$('#reservation').daterangepicker({ 
    startDate: start,
    endDate: end,
    ranges: {
       'Today': [moment(), moment()],
       'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
       'Last 7 Days': [moment().subtract(6, 'days'), moment()],
       'Last 30 Days': [moment().subtract(29, 'days'), moment()],
       'This Month': [moment().startOf('month'), moment().endOf('month')],
       'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
    }
}, cb);

cb(start, end);

function formatDate(date) {
    var d = new Date(date),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) 
        month = '0' + month;");
                WriteLiteral(@"
    if (day.length < 2) 
        day = '0' + day;

    return [year, month, day].join('-');
}

function GetChartData(a){
  displayBusyIndicator();
  if (a == ""startingPage"") 
  {
    var startDate = new Date();
    startDate.setDate(startDate.getDate() - 7);
    startDate = formatDate(startDate);
    var endDate = new Date();
    endDate.setDate(endDate.getDate() - 1);
    endDate = formatDate(new Date());

    var rangeDateSelected = startDate + ""_"" + endDate;
    var campaignsList = ""All"";
  } 
  else
  {
      var startRangeDate = $('#reservation').data('daterangepicker').startDate.format(""YYYY-MM-DD"");
      var endRangeDate = $('#reservation').data('daterangepicker').endDate.format('YYYY-MM-DD');
      var rangeDateSelected = startRangeDate + ""_"" + endRangeDate;
      var campaignsList = $('#campaignsList').val();
  }

        $.ajax({
            url: ""/ProviderHistoryCalls/Index/"",
            type: ""GET"",
            DataType: 'json',
            traditional: true,
 ");
                WriteLiteral(@"           contentType: ""application/x-www-form-urlencoded; charset=UTF-8"",
            data: {rangeDate: rangeDateSelected, campaigns: campaignsList, t: ""1"" }, 
            success: function (result)
            {
              LoadChart(result);
              hideBusyIndicator();
            },
            error: function(result) {
                alert(result.statusCode);
            }
            });
}
var chartData;
  function LoadChart(data) {
    
     
      /* ChartJS
     * -------
     * Here we will create a few charts using ChartJS
     */

    //--------------
    //- AREA CHART -
    //--------------

    // Get context with jQuery - using jQuery's .get() method.
    var date = Object.keys(data[0][""item2""]);
    var calls = Object.values(data[0][""item2""]);
    var connectedCalls = Object.values(data[1][""item2""]);
    var connectedToAgent = Object.values(data[2][""item2""]);
    var connectionRate = Math.round(data[3][""item2""]) + ""%"";
    var connectionAgentRate = Ma");
                WriteLiteral(@"th.round(data[4][""item2""]) + ""%"";
    var convertionRate = (data[5][""item2""]);
    convertionRate = convertionRate.toFixed(2) + ""%"";
    var dropRate = Math.round(data[6][""item2""]) + ""%"";
    var leadsCount = data[7][""item2""];
    var totalTalkedTime = Math.round(data[8][""item2""] * 100)/100 + "" hours""
    var checkAvgTime = (data[9][""item2""]);
    if ( checkAvgTime > 0) 
    {
      var avgTalkedTime = ((data[9][""item2""]));
      avgTalkedTime = avgTalkedTime.toFixed(2);
      avgTalkedTime = (avgTalkedTime  * 100)/100 + "" minutes"";
    }
    var agentDropRate = Math.round((data[10][""item2""]) * 100)/100 + ""%"";
    var callsSystemDispositions = Object.keys(data[12][""item2""]);
    var callsSystemDispositionsValue = Object.values(data[12][""item2""]);
    var callsDispositions = Object.keys(data[13][""item2""]);
    var callsDispositionsValue = Object.values(data[13][""item2""]);

    /* Top boxes Dashboard */
    const warmLead = leadsCount[""warm lead""];
    const hotLead = leadsCount[""hot lead""]");
                WriteLiteral(@";
    let getWarmLead = warmLead ? warmLead : 0;
    let getHotLead = hotLead ? hotLead : 0;

    $('#connectionRate').text(`Total: ${connectionRate}  / Agent: ${connectionAgentRate}`);
    $('#convertionRate').text(convertionRate);
    $('#dropRate').text(dropRate);    
    $('#leadCount').text(`Warm: ${getWarmLead}  /  Hot: ${getHotLead} `);
    $('#totalTalkedTime').text(totalTalkedTime);    
    $('#averageTalkedTime').text(avgTalkedTime);    
    $('#agentDropRate').text(agentDropRate);    
    $('#callToGetLead').text(Math.round(data[11][""item2""]));
   

    //START CHARTS 
    document.querySelector(""#chartAreaReport"").innerHTML = '<canvas id=""areaChart"" height=""180"" style=""height: 220px;""></canvas>';
    
    var areaChartCanvas = $('#areaChart').get(0).getContext('2d')

    var areaChartData = {
      labels  : date,
      datasets: [
        {
          label               : 'Calls',
          backgroundColor     : 'rgba(60,141,188,0.9)',
          borderColor         : 'rgb");
                WriteLiteral(@"a(60,141,188,0.8)',
          pointRadius          : false,
          pointColor          : '#3b8bba',
          pointStrokeColor    : 'rgba(60,141,188,1)',
          pointHighlightFill  : '#fff',
          pointHighlightStroke: 'rgba(60,141,188,1)',
          data                : calls
        },
        {
          label               : 'Calls Connected',
          backgroundColor     : 'rgba(210, 214, 222, 1)',
          borderColor         : 'rgba(210, 214, 222, 1)',
          pointRadius         : false,
          pointColor          : 'rgba(210, 214, 222, 1)',
          pointStrokeColor    : '#c1c7d1',
          pointHighlightFill  : '#fff',
          pointHighlightStroke: 'rgba(220,220,220,1)',
          data                : connectedCalls
        },
        {
          label               : 'Calls Agent Connected',
          backgroundColor     : 'rgba(254, 80, 0, 1)',
          borderColor         : 'rgba(254, 80, 0, 1)',
          pointRadius         : false,
          poin");
                WriteLiteral(@"tColor          : 'rgba(210, 214, 222, 1)',
          pointStrokeColor    : '#c1c7d1',
          pointHighlightFill  : '#fff',
          pointHighlightStroke: 'rgba(220,220,220,1)',
          data                : connectedToAgent
        },
      ]
    }

   
    var areaChartOptions = {
      maintainAspectRatio : false,
      responsive : true,
      legend: {
        display: false
      },
      scales: {
        xAxes: [{
          gridLines : {
            display : false,
          }
        }],
        yAxes: [{
          gridLines : {
            display : false,
          }
        }]
      }
    }

    // This will get the first returned node in the jQuery collection.
    var rangeDate = date.length;
    var chartType = 'line';
    if (rangeDate == 1 ){
        chartType = 'bar';
    }
    
    var areaChart = new Chart(areaChartCanvas, { 
      plugins: [ChartDataLabels],
      type: chartType,
      data: areaChartData, 
      //plugins: [ChartDataLabels]");
                WriteLiteral(@",
      options: areaChartOptions
    });

    //-------------
    //- LINE CHART -
    //--------------
    //var lineChartCanvas = $('#lineChart').get(0).getContext('2d')
    //var lineChartOptions = jQuery.extend(true, {}, areaChartOptions)
    //var lineChartData = jQuery.extend(true, {}, areaChartData)
    //lineChartData.datasets[0].fill = false;
    //lineChartData.datasets[1].fill = false;
    //lineChartOptions.datasetFill = false

    //var lineChart = new Chart(lineChartCanvas, { 
    //  type: 'line',
    //  data: lineChartData, 
    //  options: lineChartOptions
    //})

    //-------------
    //- DONUT CHART -
    //-------------
    // Get context with jQuery - using jQuery's .get() method.
    document.querySelector(""#chartDonutReport"").innerHTML = '<canvas id=""donutChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>';

    var donutChartCanvas = $('#donutChart').get(0).getContext('2d')
    var donutData = {
      labels");
                WriteLiteral(@": callsSystemDispositions,
      datasets: [
        {
          data: callsSystemDispositionsValue,
          backgroundColor : ['#f56954', '#00a65a', '#f39c12', '#00c0ef', '#3c8dbc', '#d2d6de'],
        }
      ]
    }
    var donutOptions     = {
      maintainAspectRatio : false,
      responsive : true,
      plugins: {
            legend: {
                display: false,
            },
            datalabels: {
            formatter: (value, donutChartCanvas) => {
                let sum = 0;
                let dataArr = donutChartCanvas.chart.donutData.datasets[0].data;
                dataArr.map(data => {
                    sum += data;
                });
                let percentage = (value*100 / sum).toFixed(2)+""%"";
                return percentage;
            },
            color: '#fff',
        }
      }
    }
    //Create pie or douhnut chart
    // You can switch between pie and douhnut using the method below.
    var donutChart = new Chart(donutChartCan");
                WriteLiteral(@"vas, {
      type: 'doughnut',
      data: donutData,
      options: donutOptions      
    })

    //-------------
    //- PIE CHART -
    //-------------
    // Get context with jQuery - using jQuery's .get() method.
    document.querySelector(""#chartPieReport"").innerHTML = '<canvas id=""pieChart"" style=""min-height: 250px; height: 250px; max-height: 250px; max-width: 100%;""></canvas>';

    var pieChartCanvas = $('#pieChart').get(0).getContext('2d')
    var pieData  = {
      labels: callsDispositions,
      datasets: [
        {
          data: callsDispositionsValue,
          backgroundColor : ['#f56954', '#00a65a', '#f39c12', '#00c0ef', '#3c8dbc', '#d2d6de'],
        }
      ]
    }
     var pieOptions     = {
      maintainAspectRatio : false,
      responsive : true,
      plugins: {
          legend: {
            display: false,
            }
        }
    }
    //Create pie or douhnut chart
    // You can switch between pie and douhnut using the method below.
    var");
                WriteLiteral(@" pieChart = new Chart(pieChartCanvas, {
      type: 'pie',
      data: pieData,
      options: pieOptions      
    })

chartData=data;
    LoadAnychart(chartData);
  } 

function LoadAnychart(chartData) {
  anychart.onDocumentReady(function () {

    document.querySelector(""#chartFunnelReport"").innerHTML = '<div id=""funnelChart"" style=""min-height: 200px; height: 220px; max-height: 250px; max-width: 100%;""></div>';

     var calls = Object.values(chartData[0][""item2""]);
     var callsConnected = Object.values(chartData[1][""item2""]);
     var callsAgentConnected = Object.values(chartData[2][""item2""]);
     var leads = chartData[7][""item2""];
     calls = calls.reduce((a, b) => a + b, 0);
     callsConnected = callsConnected.reduce((a, b) => a + b, 0);
     callsAgentConnected = callsAgentConnected.reduce((a, b) => a + b, 0);
     var totalLeads = leads[""hot lead""] + leads[""warm lead""];
    // create data
    var data = [
      [""Total Calls"", calls],
      [""Connected"", callsConnected]");
                WriteLiteral(@",
      [""Agent Connected"", callsAgentConnected],
      [""Leads"", totalLeads]
    ];

    var chart = anychart.funnel(data);
    chart.labels().format(""{%x}: {%value}"");
    // set the container id
    chart.container(""funnelChart"");

    // initiate drawing the chart
    chart.draw();
});
}

</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
