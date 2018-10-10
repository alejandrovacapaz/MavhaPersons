<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Pages/MasterPage.Master" CodeBehind="PersonIndex.aspx.vb" Inherits="MavhaPersons.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">   
        <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12 marginTop text-center">
             <asp:Button  CssClass="btn btn-success" Id="Adicionar" OnClick="btnAdd_Click" runat="server" Text="Adicionar Persona" />   
        </div>
        <div class="col-md-12 col-lg-12 col-sm-12 col-xs-12 marginTop">
            <asp:Table ID="TablePersons" CssClass="table table-bordered table-background table-striped" BackColor="White"  runat="server">
            <asp:TableHeaderRow>   
                <asp:TableCell CssClass="text-center headerCell" Width="20%">Nombre Completo</asp:TableCell>
                <asp:TableCell CssClass="text-center headerCell" Width="10%">Fecha de Nacimiento</asp:TableCell>
                <asp:TableCell CssClass="text-center headerCell" Width="10%">Edad</asp:TableCell>
                <asp:TableCell CssClass="text-center headerCell" Width="5%">Sexo</asp:TableCell>
                <asp:TableCell Width="25%" CssClass="text-center headerCell">Opciones</asp:TableCell>
            </asp:TableHeaderRow> 
            <asp:TableRow>                      
            </asp:TableRow>
           </asp:Table>        
        </div>
        <%--boton escondido para lanzar el modal--%>
        <button type="button" style="display:none;" id="btnShowModal" class="btn btn-primary"
            data-toggle="modal" data-target="#deleteModal">            
        </button>  
        <!-- Modal-->
        <div id="deleteModal" class="modal fade" data-backdrop="static" data-keyboard="false" role="dialog">
            <div class="modal-dialog">              
                <div class="modal-content">
                    <div class="modal-header">                        
                        <h4 class="modal-title"><asp:Label ID="ModalTitleLbl" runat="server" Text=""></asp:Label></h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>
                    <div class="modal-body">                                
                        <asp:Label ID="ModalBodyLbl" runat="server" style="font-weight:bold" Text=""></asp:Label>
                    </div>
                    <div class="modal-footer">
                        <asp:Button  CssClass="btn btn-danger" Id="DeletePerson" OnClick="btnDelete_Click" autofocus="autofocus" runat="server" Text="Eliminar" />   
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                    </div>
                </div>
        </div>
    </div>
</asp:Content>

