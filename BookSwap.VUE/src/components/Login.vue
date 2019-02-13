<template>
    <div class="container flex-grow-1">
        <form v-on:submit.prevent="login" class="form-signin">
            <div v-if="error" class="alert alert-danger" role="alert">
                {{error}}
            </div>

            <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
            <label for="inputEmail" class="sr-only">Email address</label>
            <input type="email" v-model="email" class="form-control" placeholder="Email address" required="" autofocus="">
            <label for="inputPassword" class="sr-only">Password</label>
            <input type="password" v-model="password" class="form-control" placeholder="Password" required="">
            <button class="btn btn-lg btn-primary btn-block" type="submit">Sign in</button>
        </form>
    </div>
</template>

<script>
    import firebase from 'firebase';
    import session from '../session';

    export default {
        props: ["redirectTo"],
        data() {
            return {
                password: "",
                email: "",
                error: null
            }
        },
        methods: {
            login: function () {
                var self = this;

                return firebase.auth().signInWithEmailAndPassword(this.email, this.password).then((response) => {
                    session.set(response);

                    if (this.$route.query.redirectTo != null) {
                        this.$router.push({ path: this.$route.query.redirectTo });
                    } else {
                        this.$router.push({ path: "/profile" });
                    }
                },
                (error) => {
                    this.error = error.message;
                });
            }
        },
        mounted() {
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
