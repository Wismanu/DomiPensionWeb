<%@ Page Title="" Language="C#" MasterPageFile="~/views/MasterHome.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DomiPension.views.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero_area">
        <section class="fondo-home slider_section position-relative">
            <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <div class="slider_item-box layout_padding2">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="img-box">
                                            <div>
                                                <img src="../img/Home Img/slider-img.jpg" alt="" class="" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="detail-box">
                                            <div>
                                                <h1>DomiPension
                                                <br>
                                                    Estamos bajo
                                                <br>
                                                    <span>Mantenimiento
                                                    </span>
                                                </h1>
                                                <p>
                                                    Estamos realizando mejoras en nuestra plataforma para brindarte un mejor servicio. Volveremos pronto. Gracias por tu paciencia.
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="carousel-item ">
                        <div class="slider_item-box layout_padding2">
                            <div class="container">
                                <div class="row">
                                    <div class="col-md-6">
                                        <div class="img-box">
                                            <div>
                                                <img src="../img/Home Img/slider-img.jpg" alt="" class="" />
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="detail-box">
                                            <div>
                                                <h1>DomiPension
                                                <br>
                                                    Un Hogar para
                                                <br>
                                                    <span>Estudiantes
                                                    </span>
                                                </h1>
                                                <p>
                                                    DomiPension es la solución ideal para estudiantes foráneos que buscan un lugar cómodo y seguro donde vivir mientras completan sus estudios. Ofrecemos un ambiente familiar, con servicios diseñados para tu tranquilidad.
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="slider_nav-box">
                    <div class="btn-box">
                        <a href="">Read More
                        </a>
                        <hr>
                    </div>
                    <div class="custom_carousel-control">
                        <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                </div>
            </div>
        </section>
    </div>

    <!-- about section -->
    <section class="about_section layout_padding">
        <div class="container">
            <div class="custom_heading-container">
                <h3 class=" ">ABOUT OUR COMPANY
                </h3>
            </div>
            <p class="layout_padding2-top">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
          magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco
            </p>
            <div class="img-box layout_padding2">
                <img src="../img/Home Img/about-img.jpg" alt="">
            </div>
            <p class="layout_padding2-bottom">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore
          magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco
            </p>
        </div>
        <div class="container">
            <div class="btn-box">
                <a href="">Read More
                </a>
                <hr>
            </div>
        </div>
    </section>
    <!-- end about section -->
</asp:Content>
