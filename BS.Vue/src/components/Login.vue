<template>
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-sm-5">
                <div class="card my-5">
                    <div class="card-body text-center">
                        <form v-on:submit.prevent="login" class="form-signin">
                            <div v-if="error" class="alert alert-danger" role="alert">
                                {{error}}
                            </div>

                            <h1 class="mb-3">Sign in</h1>
                            <label for="inputEmail" class="sr-only">Email address</label>
                            <input type="email" name="email" v-model="credentials.Email" class="form-control" placeholder="Email address" required="" autofocus="">
                            
                            <label for="inputPassword" class="sr-only">Password</label>
                            <input type="password" name="password" v-model="credentials.Password" class="form-control" placeholder="Password" required="">
                            
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
    import session from '../modules/session';

    export default {
        props: ["redirectTo"],
        data() {
            return {
                credentials: {},
                error: null
            }
        },
        methods: {
            login: function () {
                var vm = this;

                vm.$http.post("/api/users/login", vm.credentials).then((response) => {
                    if (response.data.success) {
                        session.set(response.data.data);

                        if (vm.$route.query.redirectTo != null) {
                            vm.$router.push({ path: vm.$route.query.redirectTo });
                        } else {
                            vm.$router.push({ path: "/profile" });
                        }
                    } else {
                        vm.error = response.data.message;
                    }
                });
            }
        }
    }
</script>

<style scoped>
</style>