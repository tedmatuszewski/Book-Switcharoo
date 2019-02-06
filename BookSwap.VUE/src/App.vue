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
                
                <b-navbar-nav class="ml-auto">
                    <b-nav-item-dropdown right>
                        <template slot="button-content">
                            {{$store.user}}
                        </template>
                        <b-dropdown-item to="/profile">Profile</b-dropdown-item>
                        <b-dropdown-item href="#">Signout</b-dropdown-item>
                    </b-nav-item-dropdown>
                </b-navbar-nav>
            </b-collapse>
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
        store: ['user'],
        mounted() {
            //const currentUser = firebase.auth().currentUser;

            //this.$store.user = currentUser;
        }
    };
</script>

<style>
</style>
