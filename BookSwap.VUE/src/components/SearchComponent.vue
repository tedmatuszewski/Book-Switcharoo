<template>
    <div>
        <p>{{term}}</p>
    </div>
</template>

<script>
    export default {
        name: 'Book',
        props: ["term"],
        data() {
            return {
                books: [],
                //termm: null
            }
        },
        mounted() {
            //this.termm = this.$route.params.term;
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
