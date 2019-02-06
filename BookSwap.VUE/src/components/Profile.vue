<template>
    <div class="container-fluid">
        <div class="row mt-4">
            <div class="col-sm-8">
                <h3>Your library</h3>

                <div class="card mb-3" v-for="(book, index) in Books" :key="book.Id">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-4 col-md-3 col-lg-2">
                                <img :src="book.Image" :alt="book.Title" class="img-fluid" style="max-height:150px;">
                            </div>
                            <div class="col-sm-8">
                                <h5 class="card-title">{{book.Title}}</h5>
                                <h6 class="card-subtitle mb-2 text-muted">{{book.Isbn}}</h6>
                                <p class="card-text">{{book.Description}}.</p>
                                <router-link class="card-link" tag="a" :to="{ name: 'editpost', params: { id: book.Id }}">Edit</router-link>
                                <a href="#" v-on:click.prevent="deleteBook(book, index)" class="card-link">Delete</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-4">

            </div>
        </div>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                Books: []
            }
        },
        methods: {
            deleteBook(book, index) {
                var self = this;

                self.$http.delete("/v1/books/" + book.Id).then(() => {
                    self.Books.splice(index, 1);
                });
            }
        },
        mounted() {
            var self = this;

            self.$http.get("/v1/books?owner=" + self.$store.user).then((response) => {
                self.Books = response.data;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
