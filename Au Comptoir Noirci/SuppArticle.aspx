<%@ Page Title="Suppression d'article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuppArticle.aspx.cs" Inherits="Au_Comptoir_Noirci.SuppArticle" %>

<asp:Content ID='BodyContent' ContentPlaceHolderID='MainContent' runat='server'>
    <div class='container'>
        <div class='col-md-9 panelwood'>
            <h2 id='titre_article' runat='server'> Suppression de l'annonce </h2>
            <p id='question' runat="server">Voulez-vous vraiment supprimer cette annonce?</p>
            <div id='boutons' class='bouton_valid' runat='server'>
                <asp:Button class='bouton_wood bouton_asp' runat='server' onClick='supp_Annonce' Text='Je confirme'></asp:Button>
                <asp:Button class='bouton_wood bouton_asp' runat='server' onClick='retour_Annonce' Text='En fait, non.'></asp:Button>
                <a class='bouton_wood' href='Default.aspx'>Retourner à l'accueil</a>
            </div>
        </div>
    </div>
</asp:Content>
