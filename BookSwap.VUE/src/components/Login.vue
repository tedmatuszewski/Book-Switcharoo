<template>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-sm-5">
                <div class="card mt-5">
                    <div class="card-body text-center">
                        <form v-on:submit.prevent="login" class="form-signin">
                            <div v-if="error" class="alert alert-danger" role="alert">
                                {{error}}
                            </div>

                            <h1 class="mb-3">Sign in</h1>
                            <label for="inputEmail" class="sr-only">Email address</label>
                            <input type="email" v-model="email" class="form-control" placeholder="Email address" required="" autofocus="">
                            <label for="inputPassword" class="sr-only">Password</label>
                            <input type="password" v-model="password" class="form-control" placeholder="Password" required="">
                            <button class="btn btn-lg btn-primary btn-block" type="submit">Sign in</button>

                            <hr />

                            or <router-link tag="a" to="/register">sign up</router-link>
                        </form>
                    </div>
                </div>
            </div>
        </div>
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
    .form-control:focus {
        -webkit-box-shadow: none;
        box-shadow: none;
        border: 1px solid #ced4da;
    }
</style>
