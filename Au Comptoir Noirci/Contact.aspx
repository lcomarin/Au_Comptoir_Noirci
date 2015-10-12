<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Au_Comptoir_Noirci.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <address>
        Camelot, Cadbury Hill<br />
        Glastonbury, Somerset<br /><br />
        <abbr title="Phone">Pigeons voyageurs:</abbr>
        Compagnie Aile du temps, actuellement 17 pigeons en vigueurs
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:lionel.comarin@viacesi.fr">Châtelain</a><br />
        <strong>Marketing:</strong> <a href="mailto:pierreantoine.tridon@viacesi.fr">Hobereau</a>
    </address>
</asp:Content>
