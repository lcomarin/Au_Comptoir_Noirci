<%@ Page Title="Détail d'article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detail_Article.aspx.cs" Inherits="Au_Comptoir_Noirci.Détail_Article" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9">
            <h2 id="titre_article" runat="server"> Article présenté</h2>
            <p> Posté par <span id="utilisateur" runat="server">John Cena</span> - Le <span id="date" runat="server">12-12-1212</span> - <span id="statut" runat="server"></span></p>
            <div class="photo"><span id="photo_article"></span><img id="presentation_article" src="content/img/target-512.png"/></div>
            <p id="pas_de_photos"><span id="photo_texte" runat="server">Il n'y a actuellement aucune gravure pour cet article.</span></p>
            <h3>Prix: </h3><p id="prix" runat="server">Prix à débattre</p>
            <h3>Description:</h3><p id="description_texte" runat="server">Il n'y a actuellement aucune description</p>
            <div id="boutons" class="bouton_valid" runat="server">
                <a class="menuliste list-group-item" href="Default.aspx">Contacter l'annonceur</a>
                <a class="menuliste list-group-item" href="Default.aspx">Retourner à l'accueil</a>
            </div>
        </div>
    </div>
</asp:Content>
