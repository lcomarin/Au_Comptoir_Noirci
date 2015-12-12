<%@ Page Title="Détail d'article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail_Article.aspx.cs" Inherits="Au_Comptoir_Noirci.Détail_Article" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9">
            <h2 id="titre_article"> Article présenté</h2>
            <div id="photo_article"><img id="presentation_article" src="content/img/target-512.png"/></div>
            <p id="pas_de_photos"><span id="photo_texte">Il n'y a actuellement aucune gravure pour cet article.</span></p>
            <p id="prix" ><span class="sous-titre">Prix: </span><span id="prix_texte">Prix à débattre</span></p>
            <p id="description"><span class="sous-titre">Description:</span><br /><span id="description_texte">Il n'y a actuellement aucune description</span></p>
            <a class="menuliste list-group-item" href="Default.aspx">Retourner à l'accueil</a>
        </div>
    </div>
</asp:Content>
