<%@ Page Title="Recherche" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Recherche.aspx.cs" Inherits="Au_Comptoir_Noirci.Recherche" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9 panelwood">
            <h2 id="titre" runat="server">Tous les annonces</h2>
            <div id="resultat_recherche" runat="server">
                <div class="col-md-4 categorie">
                    <div class="thumbnail">
                        <div class="caption">
                            <h4><a href="Recherche.aspx?id_categorie=3">Ferme</a>
                            </h4>
                            <p>Idéal pour élever des animaux, comme des ânes mignon comme tout</p>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 categorie">
                    <div class="thumbnail">
                        <div class="caption" height='200'>
                            <h4><a href="Recherche.aspx?id_categorie=2">Bois</a>
                            </h4>
                            <p>C'est une matière vivante, il faut donc le traiter, c'est capital!</p>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 categorie">
                    <div class="thumbnail">
                        <div class="caption">
                            <h4><a href="Recherche.aspx?id_categorie=1">Meuble</a>
                            </h4>
                            <p>Pour décorer ou ranger</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
