<template>
    <div class="container">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-sm-5">
                    <div class="card mt-5">
                        <div class="card-body">
                            <form v-on:submit.prevent="register">
                                <div v-if="error" class="alert alert-danger" role="alert">
                                    {{error}}
                                </div>

                                <h1 class="h3 mb-3 font-weight-normal">Registration Form</h1>

                                <div class="form-group">
                                    <label>Email address</label>
                                    <input type="email" class="form-control" v-model="email" required="" autofocus="">
                                </div>

                                <div class="form-group">
                                    <label>Password</label>
                                    <input type="password" v-model="password" class="form-control" required="">
                                </div>

                                <button class="btn btn-lg btn-primary btn-block" type="submit">Register</button>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
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

                firebase.auth().createUserWithEmailAndPassword(self.email, self.password).then(function () {
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
