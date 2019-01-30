<template>
    <div class="home">
        <h3>Books for trade</h3>

        <div v-for="book in books" :key="book.Id" class="card">
            <!--<img src="..." class="card-img-top" alt="...">-->
            <div class="card-body">
                <h5 class="card-title">{{book.Title}}</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <a href="#" class="btn btn-primary">View</a>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'Book',
        data() {
            return {
                books: []
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
