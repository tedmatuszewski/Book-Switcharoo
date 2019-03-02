<template>
    <div class="container">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-sm-5">
                    <div class="card my-5">
                        <div class="card-body">
                            <form v-on:submit.prevent="register">
                                <div v-if="error" class="alert alert-danger" role="alert">{{error}}</div>

                                <h1 class="h3 mb-3 font-weight-normal">Registration Form</h1>

                                <div class="form-group">
                                    <label>First Name</label>
                                    <input type="text" v-model="user.FirstName" class="form-control" required autofocus>
                                </div>

                                <div class="form-group">
                                    <label>Last Name</label>
                                    <input type="text" v-model="user.LastName" class="form-control" required>
                                </div>

                                <div class="form-group">
                                    <label>Email Address</label>
                                    <input type="email" v-model="user.Email" class="form-control" required>
                                </div>

                                <div class="form-group">
                                    <label>Password</label>
                                    <input type="password" v-model="user.Password" class="form-control" required>
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
    import session from '../modules/session';

    export default {
        data() {
            return {
                user: {},
                error: null
            };
        },
        methods: {
            register: function () {
                var self = this;

                self.$http.post("/api/users/register", self.user).then((response) => {
                    session.set(response.data);

                    self.$router.push({ path: "/profile" });
                });
            }
        }
    }
</script>

<style scoped>
</style>