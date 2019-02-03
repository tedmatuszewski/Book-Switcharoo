<template>
    <div class="home">
        <div class="poster-container">
            <img class="img-fluid" src="/book-stack.jpg" />
            <div class="poster-search-container">
                <div class="poster-search">
                    <div class="input-group">
                        <input type="text" v-model="term" placeholder="Enter a title..." class="form-control form-control-lg">
                        <div class="input-group-append">
                            <button v-on:click="search" class="btn-poster-search btn btn-secondary" type="button">Search</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="container-fluid">
            <div v-masonry transition-duration="0.5s" item-selector=".card" gutter="20" fit-width="false" class="mx-auto">
                <div v-masonry-tile class="card book" v-for="book in books" :key="book.Id" style="width: 20rem;">
                    <img :src="book.Image" class="card-img-top" :alt="book.Title">
                    <div class="card-body">
                        <h5 class="card-title">{{book.Title}}</h5>
                        <p class="card-text">{{book.Description}}</p>
                        <a href="#" class="btn btn-primary">View</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Home',
        data() {
            return {
                books: [],
                term: ""
            }
        },
        methods: {
            search() {
                this.$router.push({ name: 'search', params: { term: this.term } });
            }
        },
        mounted() {
            var self = this;

            self.$http.get("v1/books").then((response) => {
                self.books = response.data;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
