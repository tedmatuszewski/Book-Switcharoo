<template>
    <div>
        <b-navbar toggleable="sm" type="dark" variant="info">
            <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
            <b-navbar-brand href="#">Book Swap</b-navbar-brand>
            <b-collapse is-nav id="nav_collapse">
                <b-navbar-nav>
                    <router-link class="nav-item" tag="li" to="/"><a class="nav-link" href="#">Home</a></router-link>
                    <router-link class="nav-item" tag="li" to="books"><a class="nav-link" href="#">Books</a></router-link>
                </b-navbar-nav>
            </b-collapse>
        </b-navbar>

        <div class="container-fluid">
            <router-view />

            <footer class="footer">Book Swap</footer>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'app'
    };
</script>

<style>
</style>
