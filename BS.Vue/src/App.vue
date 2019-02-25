<template>
    <div>
        <section>
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <nav class="navbar navbar-expand-lg  navigation">
                            <router-link class="navbar-brand" tag="a" to="/">
                                <img src="./assets/logo.png" alt="">
                            </router-link>
                            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                                <span class="navbar-toggler-icon"></span>
                            </button>
                            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                                <ul class="navbar-nav ml-auto main-nav ">
                                    <router-link class="nav-item" tag="li" to="/"><a class="nav-link" href="#">Home</a></router-link>
                                    <router-link class="nav-item" tag="li" to="/profile"><a class="nav-link" href="#">Profile</a></router-link>
                                </ul>
                                <ul class="navbar-nav ml-auto mt-10">
                                    <router-link class="nav-item" tag="li" to="/login"><a class="nav-link login-button" href="index.html">Login</a></router-link>
                                    <router-link class="nav-item" tag="li" to="/post"><a class="nav-link add-button" href="#"><v-icon name="plus-circle" /> Add Book</a></router-link>
                                </ul>
                            </div>
                        </nav>
                    </div>
                </div>
            </div>
        </section>

        <router-view />

        <footer class="footer section section-sm">
            <!-- Container Start -->
            <div class="container">
                <div class="row">
                    <div class="col-lg-3 col-md-7 offset-md-1 offset-lg-0">
                        <!-- About -->
                        <div class="block about">
                            <!-- footer logo -->
                            <img src="images/logo-footer.png" alt="">
                            <!-- description -->
                            <p class="alt-color">Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                        </div>
                    </div>
                    <!-- Link list -->
                    <div class="col-lg-2 offset-lg-1 col-md-3">
                        <div class="block">
                            <h4>Site Pages</h4>
                            <ul>
                                <li><a href="#">Boston</a></li>
                                <li><a href="#">How It works</a></li>
                                <li><a href="#">Deals & Coupons</a></li>
                                <li><a href="#">Articls & Tips</a></li>
                                <li><a href="#">Terms of Services</a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- Link list -->
                    <div class="col-lg-2 col-md-3 offset-md-1 offset-lg-0">
                        <div class="block">
                            <h4>Admin Pages</h4>
                            <ul>
                                <li><a href="#">Boston</a></li>
                                <li><a href="#">How It works</a></li>
                                <li><a href="#">Deals & Coupons</a></li>
                                <li><a href="#">Articls & Tips</a></li>
                                <li><a href="#">Terms of Services</a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- Promotion -->
                    <div class="col-lg-4 col-md-7">
                        <!-- App promotion -->
                        <div class="block-2 app-promotion">
                            <a href="">
                                <!-- Icon -->
                                <img src="images/footer/phone-icon.png" alt="mobile-icon">
                            </a>
                            <p>Get the Dealsy Mobile App and Save more</p>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Container End -->
        </footer>

        <footer class="footer-bottom">
            <!-- Container Start -->
            <div class="container">
                <div class="row">
                    <div class="col-sm-6 col-12">
                        <!-- Copyright -->
                        <div class="copyright">
                            <p>Copyright © 2016. All Rights Reserved</p>
                        </div>
                    </div>
                    <div class="col-sm-6 col-12">
                        <!-- Social Icons -->
                        <ul class="social-media-icons text-right">
                            <li><a class="fa fa-facebook" href=""></a></li>
                            <li><a class="fa fa-twitter" href=""></a></li>
                            <li><a class="fa fa-pinterest-p" href=""></a></li>
                            <li><a class="fa fa-vimeo" href=""></a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- Container End -->
            <!-- To Top -->
            <div class="top-to">
                <a id="top" class="" href=""><i class="fa fa-angle-up"></i></a>
            </div>
        </footer>
    </div>
</template>

<script>
    export default {
    };
</script>

<style>
    .navbar-brand img {
        height: 38px;
    }
</style>
