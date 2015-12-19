<%@ Page Title="Ajout de catégorie" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCategorie.aspx.cs" Inherits="Au_Comptoir_Noirci.AddCategorie" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9 panelwood">
            <h2> Ajout de catégorie</h2>
            <div class="champ_texte">
                <h3>Libellé :</h3>
                <input id="libelle_categorie" runat="server"/>
            </div>
            <div class="champ_texte">
                <h3>Description :</h3>
                <textarea rows="4" cols="50" id="description_categorie" runat="server"></textarea>
            </div>
            <br/>
            <br/>
            <div class="bouton_valid">
                <asp:Button id='bouton_add' CssClass="bouton_wood bouton_asp" runat="server" onClick="Add_Categorie" Text="Ajouter la catégorie"></asp:Button>
                <a class="bouton_wood" href="Default.aspx">Retourner à l'accueil</a>
            </div>
        </div>
    </div>
</asp:Content>

