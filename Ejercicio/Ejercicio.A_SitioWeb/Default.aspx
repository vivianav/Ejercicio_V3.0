<%@ Page Language="C#" AutoEventWireup="true" Masterpagefile="~/PaginaBase.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <table style="width: 100%; height: 67px;">
    <tr>
        <td>
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="txtUsuario" ErrorMessage="Campo Usuario es requerido."></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="height: 22px">
            <asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
        </td>
        <td style="height: 22px">
            <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        </td>
        <td style="height: 22px">
            <asp:RequiredFieldValidator ID="rfvClave" runat="server" ControlToValidate="txtClave" ErrorMessage="Campo Clave es requerido."></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td colspan="3" style="height: 30px">
            <asp:Button ID="btnIniciarSesion" runat="server" Text="Iniciar Sesión" OnClick="btnIniciarSesion_Click" />
        </td>
    </tr>
</table>
<div _designerregion="0">
    <asp:Label ID="lblMensajes" runat="server"></asp:Label>
</div>
</asp:Content>

