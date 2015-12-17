<%@ Page Title="Suppression d'article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuppArticle.aspx.cs" Inherits="Au_Comptoir_Noirci.SuppArticle" %>

<asp:Content ID='BodyContent' ContentPlaceHolderID='MainContent' runat='server'>
    <div class='container'>
        <div class='col-md-9 panelwood'>
            <h2 id='titre_article' runat='server'> Suppression de l'article </h2>
            <p>Voulez-vous vraiment supprimer cet article?</p>
            <asp:Button class='bouton_wood bouton_asp' runat='server' onClick='supp_Annonce' Text='Supprimer l''annonce'></asp:Button>
            <div id='boutons' class='bouton_valid' runat='server'>
            </div>
        </div>
    </div>
</asp:Content>
