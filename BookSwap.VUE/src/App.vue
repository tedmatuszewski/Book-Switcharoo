<template>
    <div>
        <b-navbar toggleable="sm" type="dark" variant="info">
            <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
            <b-navbar-brand href="#">Book Swap</b-navbar-brand>
            <b-collapse is-nav id="nav_collapse">
                <b-navbar-nav>
                    <router-link class="nav-item" tag="li" to="/"><a class="nav-link" href="#">Home</a></router-link>
                    <router-link class="nav-item" tag="li" to="/post"><a class="nav-link" href="#">Post</a></router-link>
                </b-navbar-nav>
            </b-collapse>

            <span>{{email}}</span>
        </b-navbar>

        <router-view />

        <footer class="footer mt-auto py-3">
            <div class="container">
                <span class="text-muted">Book Swap 2019</span>
            </div>
        </footer>
    </div>
</template>

<script>
    export default {
        name: 'app',
        data() {
            return {
                email: ""
            }
        },
        mounted() {
            this.email = firebase.auth().currentUser.email;
        }
    };
</script>

<style>
</style>
