<template>
    <div class="home">
        <section class="hero-area bg-1 text-center overly">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="content-block">
                            <h1>Trade Books Near You </h1>
                            <p>Join the millions who trade books with each other <br> everyday in local universities around the world</p>
                        </div>
                        
                        <div class="advance-search">
                            <form action="#" v-on:submit.prevent="search">
                                <div class="block d-flex">
                                    <input type="text" v-model="term" class="form-control mb-2 mr-sm-2 mb-sm-0" id="search" placeholder="Search for a book">
                                    <button type="submit" class="btn btn-main">SEARCH</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <section class="popular-deals section bg-gray">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="section-title">
                            <h2>Recent Books</h2>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-sm-12 col-lg-4" v-for="book in Books">
                        <div class="product-item bg-light">
                            <div class="card">
                                <div class="thumb-content text-center">
                                    <img class="card-img-top mx-auto" :src="book.Image" alt="Book">
                                </div>
                                <div class="card-body">
                                    <h4 class="card-title">{{book.Title}}</h4>
                                    <ul class="list-inline product-meta">
                                        <li class="list-inline-item"><v-icon name="university" /> {{book.University}}</li>
                                        <li class="list-inline-item"><v-icon name="bookmark" /> {{book.Class}}</li>
                                    </ul>
                                    <p class="card-text">{{book.Description}}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        
        <section class=" section">
            <!-- Container Start -->
            <div class="container">
                <div class="row">
                    <div class="col-12">
                        <!-- Section title -->
                        <div class="section-title">
                            <h2>All Categories</h2>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Perferendis, provident!</p>
                        </div>
                        <div class="row">
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-laptop icon-bg-1"></i>
                                        <h4>Electronics</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">Laptops <span>93</span></a></li>
                                        <li><a href="category.html">Iphone <span>233</span></a></li>
                                        <li><a href="category.html">Microsoft  <span>183</span></a></li>
                                        <li><a href="category.html">Monitors <span>343</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-apple icon-bg-2"></i>
                                        <h4>Restaurants</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">Cafe <span>393</span></a></li>
                                        <li><a href="category.html">Fast food <span>23</span></a></li>
                                        <li><a href="category.html">Restaurants  <span>13</span></a></li>
                                        <li><a href="category.html">Food Track<span>43</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-home icon-bg-3"></i>
                                        <h4>Real Estate</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">Farms <span>93</span></a></li>
                                        <li><a href="category.html">Gym <span>23</span></a></li>
                                        <li><a href="category.html">Hospitals  <span>83</span></a></li>
                                        <li><a href="category.html">Parolurs <span>33</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-shopping-basket icon-bg-4"></i>
                                        <h4>Shoppings</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">Mens Wears <span>53</span></a></li>
                                        <li><a href="category.html">Accessories <span>212</span></a></li>
                                        <li><a href="category.html">Kids Wears <span>133</span></a></li>
                                        <li><a href="category.html">It & Software <span>143</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-briefcase icon-bg-5"></i>
                                        <h4>Jobs</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">It Jobs <span>93</span></a></li>
                                        <li><a href="category.html">Cleaning & Washing <span>233</span></a></li>
                                        <li><a href="category.html">Management  <span>183</span></a></li>
                                        <li><a href="category.html">Voluntary Works <span>343</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-car icon-bg-6"></i>
                                        <h4>Vehicles</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">Bus <span>193</span></a></li>
                                        <li><a href="category.html">Cars <span>23</span></a></li>
                                        <li><a href="category.html">Motobike  <span>33</span></a></li>
                                        <li><a href="category.html">Rent a car <span>73</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-paw icon-bg-7"></i>
                                        <h4>Pets</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">Cats <span>65</span></a></li>
                                        <li><a href="category.html">Dogs <span>23</span></a></li>
                                        <li><a href="category.html">Birds  <span>113</span></a></li>
                                        <li><a href="category.html">Others <span>43</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->
                            <!-- Category list -->
                            <div class="col-lg-3 offset-lg-0 col-md-5 offset-md-1 col-sm-6 col-6">
                                <div class="category-block">
                                    <div class="header">
                                        <i class="fa fa-laptop icon-bg-8"></i>
                                        <h4>Services</h4>
                                    </div>
                                    <ul class="category-list">
                                        <li><a href="category.html">Cleaning <span>93</span></a></li>
                                        <li><a href="category.html">Car Washing <span>233</span></a></li>
                                        <li><a href="category.html">Clothing  <span>183</span></a></li>
                                        <li><a href="category.html">Business <span>343</span></a></li>
                                    </ul>
                                </div>
                            </div> <!-- /Category List -->


                        </div>
                    </div>
                </div>
            </div>
            <!-- Container End -->
        </section>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                Books: [],
                term: ""
            };
        },
        methods: {
            search() {
                this.$router.push({ name: 'search', params: { term: this.term } });
            },
            viewBook(book) {
                var self = this;

                self.$http.get("/v1/books/" + book.Id).then((response) => {
                    self.bookModal = response.data;
                });

                self.isBookModalOpen = true;
            },
            message() {
                var self = this;
                var user = session.get();

                self.$http.put("/v1/threads", { BookId: self.bookModal.Id, From: user.email }).then(() => {
                    self.isBookModalOpen = false;
                });
            }
        },
        mounted() {
            var self = this;

            self.$http.get("/api/books").then((response) => {
                self.Books = response.data;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
