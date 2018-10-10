<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pages/MasterPage.Master" CodeBehind="Error.aspx.vb" Inherits="MavhaPersons._Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12 marginTop alert-danger text-center">
        <h1>Se produjo un error inesperado y la operación no pudo ser completada</h1>
        <h1>haga click en "Regresar al Listado" e intente nuevamente</h1>
    </div>
    <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12 marginTop text-center">
         <asp:Button CssClass="btn btn-dark" OnClick="btnToList_Click" ID="BackToList" runat="server" Text="Regresar al Listado" />
     </div>
</asp:Content>
