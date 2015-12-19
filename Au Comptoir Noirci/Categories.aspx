<%@ Page Title='Catégories' Language='C#' MasterPageFile='~/Site.Master' AutoEventWireup='true' CodeBehind='Categories.aspx.cs' Inherits='Au_Comptoir_Noirci.Categories' %>

<asp:Content ID='BodyContent' ContentPlaceHolderID='MainContent' runat='server'>
    <div class='container'>
        <div class='col-md-9 panelwood'>
            <h2>Catégories</h2>
            <p>Voici les différentes catégories disponibles pour les annonces.</p>
            <div id='affichage_categorie' runat='server'>
                <div class='categorie panelsteel'>
                    <h3>Ferme</h3>
                    <p>Idéal pour élever des animaux, comme des ânes mignons comme tout Idéal pour élever des animaux, comme des ânes mignons comme tout Idéal pour élever des animaux, comme des ânes mignons comme tout Idéal pour élever des animaux, comme des ânes mignons c</p>
                    <div id="test" class="bouton_valid" runat="server">
                        <a class='bouton_wood' href='AddCategorie.aspx?IdCategorie=1'>Modifier la catégorie</a>
                        <a class='bouton_wood' href='SuppArticle.aspx?IdCategorie=1'>Supprimer la catégorie</a>
                        <a class='bouton_wood' href='Recherche.aspx?IdCategorie=1'>Voir les annonces</a>
                        <a class='bouton_wood' href='Default.aspx'>Retourner à l'accueil</a>
                    </div>
                </div>
                <div class='categorie panelsteel'>
                            <h3>Bois</h3>
                            <p>C'est une matière vivante, il faut donc le traiter, c'est capital!</p>
                </div>
                <div class='categorie panelsteel'>
                            <h3>Meuble</h3>
                            <p>Pour décorer ou ranger</p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
