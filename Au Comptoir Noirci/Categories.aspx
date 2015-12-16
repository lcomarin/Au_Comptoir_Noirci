<%@ Page Title='Catégories' Language='C#' MasterPageFile='~/Site.Master' AutoEventWireup='true' CodeBehind='Categories.aspx.cs' Inherits='Au_Comptoir_Noirci.Categories' %>

<asp:Content ID='BodyContent' ContentPlaceHolderID='MainContent' runat='server'>
    <div class='container'>
        <div class='col-md-9'>
            <h2>Catégories</h2>
            <p>Voici les différentes catégories disponibles pour les annonces. Vous pouvez cliquer sur l'une d'entre elles pour afficher les articles liés</p>
            <div id='affichage_categorie' runat='server'>
                <div class='categorie'>
                    <h3>Ferme</h3>
                    <p>Idéal pour élever des animaux, comme des ânes mignons comme tout Idéal pour élever des animaux, comme des ânes mignons comme tout Idéal pour élever des animaux, comme des ânes mignons comme tout Idéal pour élever des animaux, comme des ânes mignons c</p>
                </div>
                <div class='col-md-4 categorie'>
                    <div class='thumbnail'>
                        <div class='caption'>
                            <h3>Bois</h3>
                            <p>C'est une matière vivante, il faut donc le traiter, c'est capital!</p>
                        </div>
                    </div>
                </div>
                <div class='col-md-4 categorie'>
                    <div class='thumbnail'>
                        <div class='caption'>
                            <h3>Meuble</h3>
                            <p>Pour décorer ou ranger</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
