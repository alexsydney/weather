<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="indexTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    function getWeather() {
        var URL = "/Weather/GetWeather/" + $("#Location").val();      
        $.get(URL, function(data) {
        $("#Result").html(data);
               }); 
    }
  </script>
    <div>
    <input type="text" id="Location" style="width: 325px" /> 
    <input type="button" id="btnSubmit" value="Get Weather" onclick="javascript:getWeather();" /> 
    <br /> <br />
    <div id="Result"></div>
    </div>
</asp:Content>
