<%@ Page Title="Erreur" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Erreur.aspx.cs" Inherits="Au_Comptoir_Noirci.Erreur" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9 panelwood">
            <h2 id="nom_user"> Page d'erreur</h2>
            <h3>C'est pas faux.</h3>
            <div class="photo"><span id="photo_annonce"></span><img id="img_erreur" src="content/img/Img_erreur.jpg"/></div>
            <p id="consigne" runat="server"></p>
            <div id="boutons" class="bouton_valid" runat="server">
                <a class="menuliste list-group-item" href="Recherche.aspx?id_utilisateur=1">Prévenir le roi</a>
                <a class="menuliste list-group-item" href="Default.aspx">Retourner à l'accueil</a>
            </div>
        </div>
    </div>
</asp:Content>
