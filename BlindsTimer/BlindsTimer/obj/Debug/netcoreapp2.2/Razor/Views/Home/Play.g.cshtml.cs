#pragma checksum "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da189708cd4f7dd7720359fd879c146b3ba14579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Play), @"mvc.1.0.view", @"/Views/Home/Play.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Play.cshtml", typeof(AspNetCore.Views_Home_Play))]
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
#line 1 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\_ViewImports.cshtml"
using BlindsTimer;

#line default
#line hidden
#line 2 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\_ViewImports.cshtml"
using BlindsTimer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da189708cd4f7dd7720359fd879c146b3ba14579", @"/Views/Home/Play.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1249a1a96d1cdb0052bbc0a5ef5753f5346ac129", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Play : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tournament>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sounds/zapsplat_technology_cb_radio_two_way_beep_single_39804.mp3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
  
    ViewData["Title"] = "Play"; 

#line default
#line hidden
            BeginContext(60, 156, true);
            WriteLiteral("\r\n<h1>Timer</h1>\r\n<p></p>\r\n<div>\r\n    <button onclick=\"levelTimer();\">Start</button>\r\n    <button onclick=\"pauseTimer(); pauseBreakTimer();\">Pause</button> ");
            EndContext();
            BeginContext(242, 45, true);
            WriteLiteral("\r\n</div>\r\n<p></p>\r\n\r\n<audio id=\"sound\">\r\n    ");
            EndContext();
            BeginContext(287, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da189708cd4f7dd7720359fd879c146b3ba145794194", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(370, 1090, true);
            WriteLiteral(@"
</audio>


<div id=""current"" class=""box-shadow container-fluid"" style=""background-color:darkseagreen; padding:20px; margin-bottom:20px; display:flex; height:200px;"">
    <div class=""col-md-6"" style=""display:flex; flex-direction:column; justify-content: space-between;"">
        <p id=""level"" class=""maintext""></p>
        <p id=""blinds"" class=""maintext""></p>
    </div>
    <div class=""col-md-6"" style=""display:flex; flex-direction:column; align-items:center; justify-content:center"">
        <p id=""timer"" style=""font-size:500%;  font-weight:600; text-shadow:2px 2px 0 #999""></p>
    </div>
</div>

<div id=""next"" class=""container-fluid box-shadow"" style=""display:flex; padding:20px; background-color:lightgrey;"" >
    <div class=""col-md-6"" style=""display:flex; align-items:center"">
        <p style=""font-size:300%;  font-weight:600; text-shadow:2px 2px 0 #999"">Up Next:</p>
    </div>
    <div class=""col-md-6 maintext rightside"">
        <p id=""nextLevel""></p>
        <p id=""nextBlinds""></p>
    <");
            WriteLiteral("/div>\r\n    \r\n    \r\n</div>\r\n\r\n\r\n<script>\r\n\r\n    let levelMinutes = ");
            EndContext();
            BeginContext(1461, 18, false);
#line 44 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                  Write(Model.LevelMinutes);

#line default
#line hidden
            EndContext();
            BeginContext(1479, 113, true);
            WriteLiteral(";\r\n    let levelSeconds = 0;\r\n    let currentLevel = 0;\r\n    let nextLevel = 1;\r\n\r\n   \r\n\r\n    let breakMinutes = ");
            EndContext();
            BeginContext(1593, 17, false);
#line 51 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                  Write(Model.BreakLength);

#line default
#line hidden
            EndContext();
            BeginContext(1610, 59, true);
            WriteLiteral(";\r\n    let breakSeconds = 0;\r\n\r\n    const blindStructure = ");
            EndContext();
            BeginContext(1670, 76, false);
#line 54 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                      Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(@Model.BlindStructure)));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 242, true);
            WriteLiteral(";\r\n    let timerInterval;\r\n    let breakTimerInterval;\r\n\r\n    function levelTimer() {\r\n\r\n        timerInterval = setInterval(function () {\r\n            if (levelMinutes === 0 && levelSeconds === 0) {\r\n                if ((currentLevel + 2) % ");
            EndContext();
            BeginContext(1989, 20, false);
#line 62 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                                    Write(Model.BreakFrequency);

#line default
#line hidden
            EndContext();
            BeginContext(2009, 81, true);
            WriteLiteral(" === 0) {\r\n                    pauseTimer();\r\n                    breakMinutes = ");
            EndContext();
            BeginContext(2091, 17, false);
#line 64 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                              Write(Model.BreakLength);

#line default
#line hidden
            EndContext();
            BeginContext(2108, 332, true);
            WriteLiteral(@";

                    //levelSeconds = 1;
                    breakTimer();
                    displayBreak();
                    clearBlinds();
                    currentLevel++;
                    displayNextLevel();
                }
                else {
                    
                    levelMinutes = ");
            EndContext();
            BeginContext(2441, 18, false);
#line 75 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                              Write(Model.LevelMinutes);

#line default
#line hidden
            EndContext();
            BeginContext(2459, 1165, true);
            WriteLiteral(@";
                    levelSeconds = 0;
                    currentLevel++;
                    nextLevel++;
                    displayLevel();
                    displayNextLevel();
                }
            }
            if (levelMinutes === 0 && levelSeconds <= 6)
            {
                levelSeconds--;
                document.getElementById(""timer"").innerHTML = levelMinutes.toString() + ' : ' + addZero().toString();
                beep();
             }
            else {
                if (levelMinutes > 0 && levelSeconds === 0) {
                    levelMinutes -= 1;
                    levelSeconds = 60;
                    levelSeconds--;
                }
                else {
                    levelSeconds--;
                }

                document.getElementById(""timer"").innerHTML = levelMinutes.toString() + ' : ' + addZero().toString();
            }

        }, 1000);
    }
    function breakTimer() {
        breakTimerInterval = setInterval(fu");
            WriteLiteral("nction () {\r\n            if (breakMinutes === 0 && breakSeconds === 1) {\r\n                pauseBreakTimer();\r\n                levelMinutes = ");
            EndContext();
            BeginContext(3625, 18, false);
#line 108 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                          Write(Model.LevelMinutes);

#line default
#line hidden
            EndContext();
            BeginContext(3643, 206, true);
            WriteLiteral(";\r\n                nextLevel++;\r\n                displayLevel();\r\n                displayNextLevel();\r\n                levelSeconds = 0;// making this 59 causes a skip to 58\r\n                levelTimer();\r\n");
            EndContext();
            BeginContext(3905, 1099, true);
            WriteLiteral(@"                //breakSeconds = 0;
            }
            if (breakMinutes === 0 && breakSeconds <= 6) {
                if (breakSeconds === 1) {
                    document.getElementById(""timer"").innerHTML = breakMinutes.toString() + ' : ' + addBreakZero().toString();
                    beep();
                    breakSeconds--;
                }
                else {
                    breakSeconds--;
                    document.getElementById(""timer"").innerHTML = breakMinutes.toString() + ' : ' + addBreakZero().toString();
                    beep();
                }
            }
            else {
                if (breakMinutes > 0 && breakSeconds === 0) {
                    breakMinutes -= 1;
                    breakSeconds = 60;
                    breakSeconds--;
                }
                else {
                    breakSeconds--;
                }

                document.getElementById(""timer"").innerHTML = breakMinutes.toString() + ' : ' + addBreakZe");
            WriteLiteral("ro().toString();\r\n            }\r\n        }, 1000);\r\n            \r\n    }\r\n\r\n");
            EndContext();
            BeginContext(5176, 625, true);
            WriteLiteral(@"
    function pauseTimer() {
        clearInterval(timerInterval);
    }

    function pauseBreakTimer() {
        clearInterval(breakTimerInterval);
    }

    function addZero() {
        if (levelSeconds < 10) {
            let plusZero = '0' + levelSeconds;
            return plusZero;
        }
        return levelSeconds;

    }function addBreakZero() {
        if (breakSeconds < 10) {
            let plusBreakZero = '0' + breakSeconds;
            return plusBreakZero;
        }
        return breakSeconds;
    }

    function displayLevel() {
        for (var key in blindStructure) {
");
            EndContext();
            BeginContext(5997, 411, true);
            WriteLiteral(@"            /*else */if (key == currentLevel) {
                document.getElementById(""blinds"").innerHTML = 'Blinds ' + blindStructure[key].SmallBlind.toString() + ' / ' + blindStructure[key].BigBlind.toString();
                document.getElementById(""level"").innerHTML = 'Level ' + (currentLevel + 1);
            }
        }
    }
    function displayNextLevel() {
        if ((currentLevel + 2) % ");
            EndContext();
            BeginContext(6409, 20, false);
#line 187 "C:\Users\josh langer\Poker Blinds Timer\Poker-Blinds-Timer\BlindsTimer\BlindsTimer\Views\Home\Play.cshtml"
                            Write(Model.BreakFrequency);

#line default
#line hidden
            EndContext();
            BeginContext(6429, 1004, true);
            WriteLiteral(@" === 0) {
            document.getElementById(""nextBlinds"").innerHTML = '';
            document.getElementById(""nextLevel"").innerHTML = 'Break';
        }
        else {
            for (var key in blindStructure) {

                if (key == nextLevel) {
                    document.getElementById(""nextBlinds"").innerHTML = 'Blinds ' + blindStructure[key].SmallBlind.toString() + ' / ' + blindStructure[key].BigBlind.toString();
                    document.getElementById(""nextLevel"").innerHTML = 'Level ' + (nextLevel + 1); //changed from currentLevel + 2
                }
            }
        }
    }
    function displayBreak() {
        document.getElementById(""level"").innerHTML = 'Break';
    }
    function clearBlinds() {
        document.getElementById(""blinds"").innerHTML = '';
    }

    function beep() {
        const mySound = document.getElementById(""sound"");
        mySound.play();
    }
    displayLevel();
    displayNextLevel();

</script>




");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tournament> Html { get; private set; }
    }
}
#pragma warning restore 1591
