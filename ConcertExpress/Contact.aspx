<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ConcertExpress.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        BCIT<br />
        555 Seymour St, Vancouver<br />
        <abbr title="Phone">P:</abbr>
        604-000-0001
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">agilec@icloud.com</a><br />
    </address>
</asp:Content>
