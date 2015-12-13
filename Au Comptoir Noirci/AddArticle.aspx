<%@ Page Title="Ajout d'article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="Au_Comptoir_Noirci.AddArticle" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9">
            <h2> Ajout d'article</h2>
            <div class="champ_texte">
                <h3>Titre :</h3>
                <input id="titre_article" runat="server"/>
            </div>
            <div class="champ_texte">
                <h3>Image :</h3>
                <input id="image_article" runat="server" />
            </div>
            <div class="champ_texte">
                <h3>Prix :</h3>
                <input id="prix_article" runat="server"/>
            </div>
            <div class="champ_texte">
                <h3>Description :</h3>
                <textarea rows="4" cols="50" id="description_article" runat="server"></textarea>
            </div>
            <br/>
            <br/>
            <div class="bouton_valid">
                <a class="menuliste list-group-item" href="Default.aspx">Ajouter l'annonce</a>
                <a class="menuliste list-group-item" href="Default.aspx">Retourner à l'accueil</a>
            </div>
        </div>
    </div>
</asp:Content>
