﻿<%@ Page Title="Catégories" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Au_Comptoir_Noirci.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-9">
            <h2>Catégories</h2>
            <p>Voici les différentes catégories disponibles pour les annonces. Vous pouvez cliquer sur l'une d'entre elles pour afficher les articles liés</p>
            <div id="affichage_categorie" runat="server">
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
                        <div class="caption">
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
