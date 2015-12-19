<%@ Page Title='Home Page' Language='C#' MasterPageFile='~/Site.Master' AutoEventWireup='true' CodeBehind='Default.aspx.cs' Inherits='Au_Comptoir_Noirci._Default' %>

<asp:Content ID='BodyContent' ContentPlaceHolderID='MainContent' runat='server'>
    <div class='container'>

        <div class='col-md-9'>

            <div class='row carousel-holder' id='caroussel_main'>
                <div class="cadre">
                    <div class="interieur_cadre">
                        <div class='col-md-12'>
                            <div id='carousel-example-generic' class='carousel slide' data-ride='carousel'>
                                <ol class='carousel-indicators'>
                                    <li data-target='#carousel-example-generic' data-slide-to='0' class='active'></li>
                                    <li data-target='#carousel-example-generic' data-slide-to='1'></li>
                                    <li data-target='#carousel-example-generic' data-slide-to='2'></li>
                                </ol>
                                <div class='carousel-inner'>
                                    <div class='item active'>
                                        <img class='slide-image' src='Content/img/Slide_1.jpg' alt='' width='880'>
                                    </div>
                                    <div class='item'>
                                        <img class='slide-image' src='Content/img/Slide_2.png' alt='' width='880'>
                                    </div>
                                    <div class='item'>
                                        <img class='slide-image' src='Content/img/Slide_3.png' alt='' width='880'>
                                    </div>
                                </div>
                                <a class='left carousel-control' href='#carousel-example-generic' data-slide='prev'>
                                    <span class='glyphicon glyphicon-chevron-left'></span>
                                </a>
                                <a class='right carousel-control' href='#carousel-example-generic' data-slide='next'>
                                    <span class='glyphicon glyphicon-chevron-right'></span>
                                </a>
                            </div>
                        </div>
                     </div>
                </div>
            </div>

            <div class='row'>
                <h3>Les dernières annonces</h3>
                <div class='col-sm-4 col-lg-4 col-md-4 annonce'>
                    <div class='thumbnail'>
                        <img src='http://www.salers-tourisme.fr/sites/www.salers-tourisme.fr/files/styles/imgfiche640x530/public/activite-culturelle/11251-1-ferme-moyen-age-batisse-small.jpg?itok=OB41EJaI' alt=''>
                        <div class='caption'>
                            <h4><a href='Detail_Article.aspx'>First Product</a></h4>
                            <p class='pull-right'>En vente</p>
                            <p'>$24.99</p>
                            <p>12-12-2012</p>
                        </div>
                    </div>
                </div>

                <div class='col-sm-4 col-lg-4 col-md-4 annonce'>
                    <div class='thumbnail'>
                        <img src='http://placehold.it/320x150' alt=''>
                        <div class='caption'>
                            <h4><a href='Detail_Article.aspx'>First Product</a></h4>
                            <p class='pull-right'>En vente</p>
                            <p>$24.99</p>
                            <p>12-12-2012</p>
                        </div>
                    </div>
                </div>

                <div class='col-sm-4 col-lg-4 col-md-4 annonce'>
                    <div class='thumbnail'>
                        <img src='http://placehold.it/320x150' alt=''>
                        <div class='caption'>
                            <h4><a href='Detail_Article.aspx'>First Product</a></h4>
                            <p class='pull-right'>En vente</p>
                            <p>$24.99</p>
                            <p>12-12-2012</p>
                        </div>
                    </div>
                </div>

                <div class='col-sm-4 col-lg-4 col-md-4 annonce'>
                    <div class='thumbnail'>
                        <img src='http://placehold.it/320x150' alt=''>
                        <div class='caption'>
                            <h4><a href='Detail_Article.aspx'>First Product</a></h4>
                            <p class='pull-right'>En vente</p>
                            <p>$24.99</p>
                            <p>12-12-2012</p>
                        </div>
                    </div>
                </div>

                <div class='col-sm-4 col-lg-4 col-md-4 annonce'>
                    <div class='thumbnail'>
                        <img src='http://placehold.it/320x150' alt=''>
                        <div class='caption'>
                            <h4><a href='Detail_Article.aspx'>First Product</a></h4>
                            <p class='pull-right'>En vente</p>
                            <p>$24.99</p>
                            <p>12-12-2012</p>
                        </div>
                    </div>
                </div>

                <div class='col-sm-4 col-lg-4 col-md-4 annonce'>
                    <div class='thumbnail'>
                        <img src='http://placehold.it/320x150' alt=''>
                        <div class='caption'>
                            <h4><a href='Detail_Article.aspx'>First Product</a></h4>
                            <p class='pull-right'>En vente</p>
                            <p>$24.99</p>
                            <p>12-12-2012</p>
                        </div>
                    </div>
                </div>

            </div>

        </div>


    </div>

</asp:Content>
