<%@ Page Title="Ajout d'article" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="Au_Comptoir_Noirci.AddArticle" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9 panelwood">
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
                <h3>Statut :</h3>
                <input id="statut_article" runat="server"/>
            </div>
            <div class="champ_texte">
                <h3>Description :</h3>
                <textarea rows="4" cols="50" id="description_article" runat="server"></textarea>
            </div>
            <div class="champ_texte">
                <h3>Catégories :</h3>
                <asp:TextBox ID="categories" runat="server"></asp:TextBox>
                <asp:AutoCompleteExtender ID="AutoCompleteExtender1" runat="server"
                            ServiceMethod="getCategories"
                            ServicePath="WebServiceAutoComplete.asmx"
                            MinimumPrefixLength="1"
                            CompletionInterval="100"
                            EnableCaching="true"
                            CompletionSetCount="10"
                            TargetControlID="categories" 
                            FirstRowSelected="true">
                </asp:AutoCompleteExtender>
                <asp:Button class="bouton_wood bouton_asp" runat="server" onClick="add_Categorie" Text="Ajouter la catégorie"></asp:Button>
            </div>
            <div class="champ_texte">
                <h4>Catégories ajoutées:</h4>
                <div id="categories_ajoutees" runat="server"></div>
            </div>
            <br/>
            <br/>
            <div class="bouton_valid">
                <asp:Button class="bouton_wood bouton_asp" runat="server" onClick="add_Annonce" Text="Ajouter l'annonce"></asp:Button>
                <a class="bouton_wood" href="Default.aspx">Retourner à l'accueil</a>
            </div>
        </div>
    </div>
</asp:Content>
