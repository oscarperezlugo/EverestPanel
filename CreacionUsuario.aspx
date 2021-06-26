<%@ Page Title="Pinturas Everest" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreacionUsuario.aspx.cs" Inherits="ReachSystem.CreacionUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="baseform">
        <p><h2>Crear Color</h2></p>
            <div class="fila col10L">
                <input class="formulario" placeholder="Nombre" id="Nombre" type="text"  runat="server"/>            
            </div>
        <div class="fila col10L">
                <input class="formulario" placeholder="Color Hexadecimal (abc096)" id="Text2" type="text"  runat="server" maxlength="6"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Rendimiento" id="Apellido" type="text"  runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Codigo" id="Correo" type="text"  runat="server"/>            
            </div>
            <%--<div class="fila col10L">
                <input class="formulario" placeholder="Télefono (555 555555)" id="Telefono" type="text" maxlength="11"  runat="server"/>            
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Dirección (Valencia, Calle Libra #55)" id="Dirección" type="text"  runat="server"/>            
            </div>--%>
            <div class="fila col10L">
                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="formulario" DataSourceID="SqlDataSource1" DataTextField="Categoria" DataValueField="Categoria">
                </asp:DropDownList>
                <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:tarragoReachConnectionString %>' SelectCommand="SELECT DISTINCT [Categoria] FROM [Colores]"></asp:SqlDataSource>
            </div>
           <%-- <div class="fila col10L">
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="formulario" >
                    <asp:ListItem>IDIOMA</asp:ListItem>
                    <asp:ListItem>Bulgarian</asp:ListItem>
                    <asp:ListItem>Dansk</asp:ListItem>
                    <asp:ListItem>Eesti keel</asp:ListItem>
                    <asp:ListItem>English</asp:ListItem>
                    <asp:ListItem>Español</asp:ListItem>
                    <asp:ListItem>Français</asp:ListItem>
                    <asp:ListItem>Deutsch</asp:ListItem>
                    <asp:ListItem>Gaeilge</asp:ListItem>
                    <asp:ListItem>Greek</asp:ListItem>
                    <asp:ListItem>Hrvatski Jezik</asp:ListItem>
                    <asp:ListItem>Italiano</asp:ListItem>
                    <asp:ListItem>Latviešu</asp:ListItem>
                    <asp:ListItem>Lietuvių</asp:ListItem>
                    <asp:ListItem>Magyar</asp:ListItem>
                    <asp:ListItem>Malti</asp:ListItem>
                    <asp:ListItem>Nederlands</asp:ListItem>
                    <asp:ListItem>Norsk</asp:ListItem>
                    <asp:ListItem>Polski</asp:ListItem>
                    <asp:ListItem>Português</asp:ListItem>
                    <asp:ListItem>Română</asp:ListItem>
                    <asp:ListItem>Russian</asp:ListItem>
                    <asp:ListItem>Slovenčina</asp:ListItem>
                    <asp:ListItem>Slovenščina</asp:ListItem>
                    <asp:ListItem>Suomi</asp:ListItem>
                    <asp:ListItem>Svenska</asp:ListItem>
                    <asp:ListItem>Türkçe</asp:ListItem>
                    <asp:ListItem>Čeština</asp:ListItem>
                </asp:DropDownList>                
            </div>--%>
            <div class="fila col10L">
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="formulario" DataSourceID="SqlDataSource2" DataTextField="Linea" DataValueField="Linea">
                </asp:DropDownList>
                <asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString='<%$ ConnectionStrings:tarragoReachConnectionString %>' SelectCommand="SELECT DISTINCT [Linea] FROM [Colores]"></asp:SqlDataSource>
            </div>
            <%--<div class="fila col10L">
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="formulario" >
                    <asp:ListItem>IDIOMA DE ORIGEN</asp:ListItem>
                    <asp:ListItem>Bulgarian</asp:ListItem>
                    <asp:ListItem>Dansk</asp:ListItem>
                    <asp:ListItem>Eesti keel</asp:ListItem>
                    <asp:ListItem>English</asp:ListItem>
                    <asp:ListItem>Español</asp:ListItem>
                    <asp:ListItem>Français</asp:ListItem>
                    <asp:ListItem>Deutsch</asp:ListItem>
                    <asp:ListItem>Gaeilge</asp:ListItem>
                    <asp:ListItem>Greek</asp:ListItem>
                    <asp:ListItem>Hrvatski Jezik</asp:ListItem>
                    <asp:ListItem>Italiano</asp:ListItem>
                    <asp:ListItem>Latviešu</asp:ListItem>
                    <asp:ListItem>Lietuvių</asp:ListItem>
                    <asp:ListItem>Magyar</asp:ListItem>
                    <asp:ListItem>Malti</asp:ListItem>
                    <asp:ListItem>Nederlands</asp:ListItem>
                    <asp:ListItem>Norsk</asp:ListItem>
                    <asp:ListItem>Polski</asp:ListItem>
                    <asp:ListItem>Português</asp:ListItem>
                    <asp:ListItem>Română</asp:ListItem>
                    <asp:ListItem>Russian</asp:ListItem>
                    <asp:ListItem>Slovenčina</asp:ListItem>
                    <asp:ListItem>Slovenščina</asp:ListItem>
                    <asp:ListItem>Suomi</asp:ListItem>
                    <asp:ListItem>Svenska</asp:ListItem>
                    <asp:ListItem>Türkçe</asp:ListItem>
                    <asp:ListItem>Čeština</asp:ListItem>
                </asp:DropDownList>                
            </div>
            <div class="fila col10L">
                <input class="formulario" placeholder="Empresa De Origen(Tarrago Brands)" id="Text1" type="text"  runat="server"/>            
            </div>--%>
            <%--<div class="fila col10L">
                <input class="formulario" placeholder="Contraseña" id="Contraseña" type="password"  runat="server"/>            
            </div>   --%>                               
            <div class="fila col10L">
                <asp:Button class="botonsubmit" value="REGISTRARME" type="submit"  runat="server" CssClass="botonsubmit"  OnClick="Unnamed1_Click"  Text="CREAR COLOR"/>            
            </div>
        </div>
            <br />
            <br />     
</asp:Content>
