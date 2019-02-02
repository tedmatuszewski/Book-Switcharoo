<template>
    <div class="container">
        <div class="my-5 text-center">
            <h3>You searched for <u>{{this.$route.params.term}}</u>. Click <router-link tag="a" to="/">here</router-link> to search for another book.</h3>
        </div>

        <div class="list-group">
            <a href="#" v-for="book in books" :key="book.Id" class="list-group-item list-group-item-action">
                <img style="max-height:100px;" class="align-self-start mr-3" :src="book.Image" :alt="book.Title">

                <div class="d-flex w-100 justify-content-between">
                    <h5 class="mb-1">{{book.Title}}</h5>
                    <small>{{book.Class}}</small>
                </div>
                <p class="mb-1">{{book.Description}}</p>
                <small>{{book.University}}</small>
            </a>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Book',
        props: ["term"],
        data() {
            return {
                books: []
            }
        },
        mounted() {
            var term = this.$route.params.term;
            var self = this;

            this.$http.post("/v1/search", { query: term }).then((response) => {
                self.books = response.data;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
