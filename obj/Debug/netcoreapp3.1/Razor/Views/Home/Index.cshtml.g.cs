#pragma checksum "C:\Users\GEDO\Desktop\Visual Studio Code\Gerenciamento-Eventos\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fe93f0b84410ca43b92a4fb6c14b2fb8fa09676"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\GEDO\Desktop\Visual Studio Code\Gerenciamento-Eventos\Views\_ViewImports.cshtml"
using GerenciamentoEvento;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GEDO\Desktop\Visual Studio Code\Gerenciamento-Eventos\Views\_ViewImports.cshtml"
using GerenciamentoEvento.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fe93f0b84410ca43b92a4fb6c14b2fb8fa09676", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1435e56c1244cb33300ae70b23830410025bde35", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\GEDO\Desktop\Visual Studio Code\Gerenciamento-Eventos\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

.card-title{font-style:italic;}
#icon{
  align-content: center;
  width: 150px;
  height: 150px; margin-left: 25%; margin-top: 5%
}


</style>

<script>
    $('.carousel').carousel({
  interval: 200
})
</script>

<!----Body-->

<div class=""jumbotron jumbotron-fluid"" style=""background-color: #6E3667; color:white;"">
  <div class=""container"">
    <h1 class=""display-4"" id=""titulo"">Eventos.com</h1>
   
    <p class=""lead""> Encontre sua nova experiência musical!</p>
  </div>
</div>

<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
  <ol class=""carousel-indicators"">
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
  </ol>

  <div class=""carousel-inner mw-100"" >

    <div class=""carousel-item active"" id=""slider"">
      <img class=""d-block mw-100 img-fluid"" src=""https://cdn.wegow.com/media/events");
            WriteLiteral(@"/los-alamos-beach-festival-2019/los-alamos-beach-festival-2019-1540199838.49.2560x1440.jpg"" alt=""Primeiro Slide"">
    </div>

    <div class=""carousel-item mw-100"" id=""slider"">
      <img class=""d-block mw-100 img-fluid"" src=""https://abrilexame.files.wordpress.com/2018/10/l121.jpg"" alt=""Segundo Slide"">
    </div>

    <div class=""carousel-item mw-100"" id=""slider"">
      <img class=""d-block mw-100 img-fluid"" src=""https://abrilveja.files.wordpress.com/2019/09/10159926-high.jpeg"" alt=""Terceiro Slide"">
    </div>

  </div>
  <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Anterior</span>
  </a>
  <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Próximo</span>
  </a>
</div>

<div class=""accordion"" id=""accordionExample"">
");
            WriteLiteral(@"  <div class=""card"" style=""background-color: #6E3667; color:white;"">
    <div class=""card-header"" id=""headingOne"">
      <h5 class=""mb-0"">
        <button class=""btn btn-link"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
         Saiba mais!
        </button>
      </h5>
    </div>
  <div id=""collapseOne"" class=""collapse hide"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
      <div class=""card-body""  style=""background-color: whitesmoke; color: black;"">
        A Eventos.com é um site de compra de ingressos. Aqui você pode pode adquirir tickets capazes de conceder experiências que jamais sairão da sua cabeça,igual
         aquela música chiclete do último carnaval.
      </div>
    </div>
  </div>
  <div class=""card""  style=""background-color: #6E3667; color:white;"">
    <div class=""card-header"" id=""headingTwo"">
      <h5 class=""mb-0"">
        <button class=""btn btn-link collapsed"" type=""button"" data-toggle=""collapse"" data-tar");
            WriteLiteral(@"get=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
</div>
</div>

<div class=""row"" style=""text-align: justify"">
<div class=""card col-md-4"" style=""width: 18rem;"" style=""display:flex;justify-content:center;align-items:center;width:4px;"">
  <img class=""card-img-top img-fluid"" id=""icon"" src=""https://image.flaticon.com/icons/svg/1067/1067090.svg""  >
  <div class=""card-body"">
    <h5 class=""card-title"">Descura sua nova experiência musical!</h5>
    <p class=""card-text""><p>Confira a lista de shows, seus locais e preços.</p>
    <a href=""/Eventos/Home"" class=""btn btn-dark btn-lg"" style=""background-color: #6E3667 ;"">Shows!</a>
  </div>
</div>
<div class=""card col-md-4"" style=""width: 18rem;"" >
  <img class=""card-img-top img-fluid"" id=""icon"" src=""https://image.flaticon.com/icons/svg/812/812520.svg"" >
  <div class=""card-body"">
    <h5 class=""card-title"">Crie sua Conta!</h5>
    <p class=""card-text"">Crie sua conta e receba as últimas atualizações sobre todos os show de sua região, além de descontos excl");
            WriteLiteral(@"usivos.</p>
    <a href=""/Identity/Account/Login"" class=""btn btn-dark btn-lg"" style=""background-color:#88D317;"">Cadastre-se! </a>
  </div>
</div>
<div class=""card col-md-4"" style=""width: 18rem;"">
  <img class=""card-img-top img-fluid"" id=""icon"" src=""https://image.flaticon.com/icons/svg/2445/2445641.svg"" >
  <div class=""card-body"">
    <h5 class=""card-title"">Ingressos</h5>
    <p class=""card-text"">Aqui você encontra ingressos exclusivos dos eventos mais balados do momento. Finalize sua compra e garanta seu espaço no próximo momento épico de sua vida.</p>
    <a href=""#"" class=""btn btn-dark btn-lg"" style=""background-color:#535353;"" >Carrinho >> </a>
  </div>
</div>
");
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
