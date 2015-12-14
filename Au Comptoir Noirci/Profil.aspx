<%@ Page Title="Profil" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="Au_Comptoir_Noirci.Profil" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9">
            <h2 id="nom_user" runat="server"> John Cena</h2>
            <p><h3>Adresse: </h3><span id="adresse" runat="server">WWE, Inc. <br />1241 East Main Street<br />Stamford, CT 06902<br />Etats-Unis</span></p>
            <h3>Courriel: </h3><p id="courriel" runat="server">john.cena@wwe.us</p>
            <h3>Téléphone:</h3><p id="telephone" runat="server">0606060606</p>
            <div id="boutons" class="bouton_valid" runat="server">
                <a class="menuliste list-group-item" href="Recherche.aspx?id_utilisateur=1">Voir ses annonces</a>
                <a class="menuliste list-group-item" href="Default.aspx">Retourner à l'accueil</a>
            </div>
        </div>
    </div>
</asp:Content>
