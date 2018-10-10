<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Pages/MasterPage.Master" CodeBehind="EditPerson.aspx.vb" Inherits="MavhaPersons.EditPerson" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="MainContent" runat="server">
            <div class="text-center marginTop">
                <h4>Editar Persona</h4>
            </div>
            <div class="offset-md-1 offset-lg-1 col-md-10 col-lg-10 col-sm-12 col-xs-12 marginTop form-group">
                <asp:Label CssClass="control-label required-relative" ID="NombreLbl" runat="server" Text="Nombre Completo"></asp:Label>
                <asp:TextBox CssClass="form-control col-md-8 col-lg-8 col-sm-10 col-xs-10 lettersOnly" ID="NombreTxt" runat="server"></asp:TextBox>                          
            </div>
            <div class="offset-md-1 offset-lg-1 col-md-10 col-lg-10 col-sm-12 col-xs-12 marginTop form-group">                
                <asp:Label CssClass="control-label" ID="FechaNLbl" runat="server" Text="Fecha de Nacimiento"></asp:Label>&nbsp                 
                <asp:Label CssClass="control-label alert alert-info NoPadding" ID="FechaFormat" runat="server" Text="Dia Mes Año"></asp:Label>                 
                <div class="row col-md-12 col-lg-12 col-sm-12 col-xs-12 form-group">
                    <div class="col-md-1 col-lg-1 col-sm-4 col-xs-4 NoPadding">
                        <asp:DropDownList CssClass="form-control" style="width:80% !important" ID="DayDropDownList" runat="server"></asp:DropDownList>
                    </div>  
                    <div class="col-md-1 col-lg-1 col-sm-4 col-xs-4 NoPadding">
                         <asp:DropDownList CssClass="form-control" style="width:80% !important" ID="MonthDropDownList" runat="server"></asp:DropDownList>
                    </div>  
                    <div class="col-md-2 col-lg-2 col-sm-8 col-xs-8 NoPadding">
                        <asp:DropDownList CssClass="form-control" style="width:80% !important" ID="YearDropDownList" onchange="calculateEdad(this)" runat="server"></asp:DropDownList> 
                    </div>            
                </div>                       
            </div>
            <div class="offset-md-1 offset-lg-1 col-md-10 col-lg-10 col-sm-12 col-xs-12 marginTop form-group">
                <asp:Label CssClass="control-label" ID="EdadLbl" runat="server" Text="Edad"></asp:Label>               
                <asp:TextBox CssClass="form-control col-md-1" ID="EdadTxt" ReadOnly="true" runat="server"></asp:TextBox>                                  
            </div>
            <div class="offset-md-1 offset-lg-1 col-md-10 col-lg-10 col-sm-12 col-xs-12 marginTop form-group">
                <asp:Label CssClass="control-label" ID="SexoLbl" runat="server" Text="Sexo"></asp:Label>
                <asp:DropDownList CssClass="form-control col-md-2" ID="SexDropDownList" runat="server">
                    <asp:ListItem Text="Masculino" Value="M" />
                    <asp:ListItem Text="Femenino" Value="F" />
                </asp:DropDownList>  
            </div>
            <div class="offset-md-1 offset-lg-1 col-md-10 col-lg-10 col-sm-12 col-xs-12 marginTop form-group">
                <asp:Label CssClass="control-label alert-danger" ID="ErrorLabel" runat="server" Text=""></asp:Label>                
            </div>
            <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12 marginTop text-center">
                <asp:Button CssClass="btn btn-primary" OnClick="btnEditPerson_Click" ID="AddPerson" runat="server" Text="Editar" />
            </div>
            <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12 marginTop text-right">
                <asp:Button CssClass="btn btn-dark" OnClick="btnToList_Click" ID="BackToList" runat="server" Text="Regresar al Listado" />
            </div>
</asp:Content>
