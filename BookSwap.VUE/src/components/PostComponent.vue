<template>
    <div class="container">
        <div class="card mt-5">
            <div class="card-body">
                <h5 class="card-title">Post your book</h5>

                <hr />

                <div class="row">
                    <div class="col-sm-4">
                        <div class="jumbotron text-center">
                            <img :src="book.Image" class="img-fluid" style="min-height: 250px;" />
                        </div>
                    </div>
                    <div class="col-sm-8">
                        <form @submit.prevent="bookSubmit" enctype="multipart/form-data">
                            <div class="row">
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <label class="form-label">Title</label>
                                        <input v-model="book.Title" class="form-control">
                                    </div>
                                </div>
                                <div class="col-sm-6">
                                    <div class="form-group">
                                        <label class="form-label">ISBN</label>
                                        <input v-model="book.Isbn" class="form-control">
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-sm-8">
                                    <div class="form-group">
                                        <label class="form-label">University</label>
                                        <input v-model="book.University" class="form-control">
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <div class="form-group">
                                        <label class="form-label">Class</label>
                                        <input v-model="book.Class" class="form-control">
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-sm-7">
                                    <div class="form-group">
                                        <label class="form-label">Image</label>
                                        <input type="file" accept=".gif,.jpg,.jpeg,.png" ref="filePicker" v-on:change="encodeImage()" class="form-control">
                                    </div>
                                </div>
                                <div class="col-sm-5">
                                    <div class="form-group">
                                        <label class="form-label">Condition</label>
                                        <select v-model="book.Condition" class="form-control">
                                            <option value="Like New">Like New</option>
                                            <option value="Very Good">Very Good</option>
                                            <option value="Good">Good</option>
                                            <option value="Poor">Poor</option>
                                            <option value="Very Poor">Very Poor</option>
                                        </select>
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="form-label">Description of what you are looking for</label>
                                <textarea v-model="book.Description" class="form-control"></textarea>
                            </div>

                            <input type="hidden" v-model="book.Image" />
                            <input type="hidden" v-model="book.User" />

                            <div class="form-group">
                                <button class="btn btn-primary float-right" type="submit">Submit</button>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                file: null,
                book: {},
            }
        },
        methods: {
            bookSubmit() {
                var self = this;

                self.book.User = "ted";

                self.$http.post("/v1/books", self.book).then(() => {
                    self.book = {};
                    this.$refs.filePicker.value = "";
                });
            },
            encodeImage() {
                let formData = new FormData();
                let file = this.$refs.filePicker.files[0];
                let self = this;

                formData.append('file', file);
                
                this.$http.post('/v1/file', formData, {
                    headers: { 'Content-Type': 'multipart/form-data' }
                })
                .then(function (response) {
                    self.book.Image = response.data;
                })
                .catch(function () {
                });
            },
        },
        mounted() {
            
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
