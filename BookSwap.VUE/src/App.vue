<template>
    <div>
        <b-navbar toggleable="sm" type="dark" variant="info">
            <b-navbar-toggle target="nav_collapse"></b-navbar-toggle>
            <b-navbar-brand href="/">
                <img src="../public/logo_white.png" style="max-height:40px" />
                Book Swap
            </b-navbar-brand>
            <b-collapse is-nav id="nav_collapse">
                <b-navbar-nav>
                    <router-link class="nav-item" tag="li" to="/"><a class="nav-link" href="#">Home</a></router-link>
                    <router-link class="nav-item" tag="li" to="/post"><a class="nav-link" href="#">Post</a></router-link>
                </b-navbar-nav>

                <b-navbar-nav class="ml-auto" v-if="isLoggedIn()">
                    <b-nav-item-dropdown right>
                        <template slot="button-content">
                            {{getUserDisplay()}}
                        </template>
                        <b-dropdown-item to="/profile">Profile</b-dropdown-item>
                        <b-dropdown-item v-on:click.prevent="logout" href="#">Signout</b-dropdown-item>
                    </b-nav-item-dropdown>
                </b-navbar-nav>
                <b-navbar-nav class="ml-auto" v-else>
                    <router-link class="nav-item" tag="li" to="/login"><a class="nav-link" href="#">Login</a></router-link>
                </b-navbar-nav>
                </b-collapse>
        </b-navbar>

<router-view />

        <footer class="footer mt-auto py-3">
            <div class="container">
                <span class="text-muted">Book Swap &copy; 2019</span>
            </div>
        </footer>
    </div>
</template>

<script>
    import firebase from 'firebase';
    import session from './session';

    export default {
        name: 'app',
        methods: {
            logout() {
                var self = this;

                firebase.auth().signOut()
                    .then(function () {
                        session.unset();
                        self.$router.push({ path: "/" });
                    })
                    .catch(function () {
                        // An error happened
                    });
            },
            isLoggedIn() {
                return session.isset();
            },
            getUserDisplay() {
                if (session.isset()) {
                    var user = session.get();

                    return user.email;
                } else {
                    return "";
                }
            }
        },
        mounted() {
            //if (this.$store.user != null && this.$store.user.email) {
            //    this.userDisplay = this.$store.user.email;
            //}
        }
    };
</script>

<style>
</style>
