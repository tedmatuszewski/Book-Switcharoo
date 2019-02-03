<template>
    <div class="container flex-grow-1">
        <form v-on:submit.prevent="register" class="form-signin">
            <div v-if="error" class="alert alert-danger" role="alert">
                {{error}}
            </div>

            <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
            <label>Email address</label>
            <input type="email" class="form-control" v-model="email" required="" autofocus="">
            <label>Password</label>
            <input type="password" v-model="password" class="form-control" placeholder="Password" required="">
            <button class="btn btn-lg btn-primary btn-block" type="submit">Register</button>
        </form>
    </div>
</template>

<script>
    import firebase from 'firebase';

    export default {
        data() {
            return {
                password: "",
                email: "",
                error: null
            }
        },
        methods: {
            register: function () {
                var self = this;

                firebase.auth().createUserWithEmailAndPassword(self.email, self.password).then(function (user) {
                    console.log(user);
                },
                function (error) {
                    self.error = error.message;
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
