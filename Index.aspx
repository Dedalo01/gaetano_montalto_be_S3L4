<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="eserS3L4.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <asp:DropDownList ID="CarsDropDown" runat="server" AutoPostBack="true">
        <asp:ListItem>Nessuna</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Image ID="CarImage" runat="server" Width="150px" />

   
</asp:Content>
