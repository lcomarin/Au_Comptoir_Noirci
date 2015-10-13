<%@ Page Title="Détail d'article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Détail_Article.aspx.cs" Inherits="Au_Comptoir_Noirci.Détail_Article" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9">
            <h2 id="titre_article"> Article présenté</h2>
            <div id="photo_article"><img id="presentation_article" src="content/img/target-512.png"/></div>
            <p id="pas_de_photos">Il n'y a actuellement aucune gravure pour cet article.</p>
            <p id="prix" <span class="sous-titre">Prix:</span> Prix à débattre</p>
        </div>
    </div>
</asp:Content>
