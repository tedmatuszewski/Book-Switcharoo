<template>
    <div class="container-fluid">
        <div class="mt-5 text-center">
            <h3>You searched for <u>{{this.$route.params.term}}</u>. Click <router-link tag="a" to="/">here</router-link> to search for another book.</h3>
        </div>

        <div v-masonry transition-duration="0.5s" item-selector=".card" gutter="20" fit-width="false" class="mx-auto">
            <div v-masonry-tile class="card book" v-for="book in books" :key="book.Id" style="width: 20rem;">
                <img src="http://via.placeholder.com/350x250" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">{{book.Title}}</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">View</a>
                </div>
            </div>
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
