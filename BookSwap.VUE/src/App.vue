<template>
    <div class="d-flex flex-column h-100">
        <header>
            <nav class="navbar navbar-expand-md navbar-dark bg-info">
                <router-link to="/"><a class="navbar-brand" href="#">
                    <img src="../public/logo_white.png" style="max-height:29px" />
                    Book Swap
                </a></router-link>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarCollapse">
                    <ul class="navbar-nav mr-auto">
                        <router-link class="nav-item" tag="li" to="/"><a class="nav-link" href="#">Home</a></router-link>
                        <router-link class="nav-item" tag="li" to="/post"><a class="nav-link" href="#">Post</a></router-link>
                    </ul>
                    <ul class="navbar-nav ml-auto" v-if="isLoggedIn()">
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle" href="#" data-toggle="dropdown">{{getUserDisplay()}}</a>
                            <div class="dropdown-menu" style="margin-top:0; right:0;width: 200px;">
                                <router-link class="dropdown-item" tag="a" to="/profile">Profile</router-link>
                                <a class="dropdown-item" href="#" v-on:click.prevent="logout">Signout</a>
                            </div>
                        </li>
                    </ul>
                    <ul class="navbar-nav ml-auto" v-else>
                        <router-link class="nav-item" tag="li" to="/login"><a class="nav-link" href="#">Login</a></router-link>
                    </ul>
                </div>
            </nav>
        </header>

        <main role="main" class="flex-shrink-0">
            <router-view />
        </main>

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
