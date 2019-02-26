<template>
    <div>
        <section class="page-search">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="advance-search">
                            <form v-on:submit.prevent="search">
                                <div class="form-row">
                                    <div class="form-group col-md-10">
                                        <input type="text" v-model="Term" class="form-control" placeholder="What book are you looking for?">
                                    </div>
                                    <div class="form-group col-md-2">
                                        <button type="submit" class="btn btn-primary">Search Now</button>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section class="section-sm">
            <div class="container">
                <div class="row" v-if="TermDisplay != null">
                    <div class="col-md-12">
                        <div class="search-result bg-gray">
                            <h2>Results For "{{TermDisplay}}"</h2>
                            <p>{{Books.length}} Results on 12 December, 2017</p>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-3">
                        <div class="category-sidebar">
                            <div class="widget category-list">
                                <h4 class="widget-header">All Universities</h4>
                                <ul class="category-list">
                                    <li><a href="category.html">Laptops <span>93</span></a></li>
                                    <li><a href="category.html">Iphone <span>233</span></a></li>
                                    <li><a href="category.html">Microsoft  <span>183</span></a></li>
                                    <li><a href="category.html">Monitors <span>343</span></a></li>
                                </ul>
                            </div>

                            <div class="widget product-shorting">
                                <h4 class="widget-header">By Condition</h4>
                                <div class="form-check">
                                    <label class="form-check-label">
                                        <input class="form-check-input" type="checkbox" value="">
                                        Brand New
                                    </label>
                                </div>
                                <div class="form-check">
                                    <label class="form-check-label">
                                        <input class="form-check-input" type="checkbox" value="">
                                        Almost New
                                    </label>
                                </div>
                                <div class="form-check">
                                    <label class="form-check-label">
                                        <input class="form-check-input" type="checkbox" value="">
                                        Gently New
                                    </label>
                                </div>
                                <div class="form-check">
                                    <label class="form-check-label">
                                        <input class="form-check-input" type="checkbox" value="">
                                        Havely New
                                    </label>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class="col-md-9">
                        <div class="category-search-filter">
                            <div class="row">
                                <div class="col-md-6">
                                    <strong>Short</strong>
                                    <select>
                                        <option>Most Recent</option>
                                        <option value="1">Most Popular</option>
                                        <option value="2">Lowest Price</option>
                                        <option value="4">Highest Price</option>
                                    </select>
                                </div>
                                <div class="col-md-6">
                                    <div class="view">
                                        <strong>Views</strong>
                                        <ul class="list-inline view-switcher">
                                            <li class="list-inline-item">
                                                <a href="javascript:void(0);"><v-icon name="th-large" /></a>
                                            </li>
                                            <li class="list-inline-item">
                                                <a href="javascript:void(0);"><!--<v-icon name="reorder" />--></a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="product-grid-list">
                            <div class="row mt-30">
                                <div class="col-sm-12 col-lg-4 col-md-6" v-for="book in Books">
                                    <div class="product-item bg-light">
                                        <div class="card">
                                            <div class="thumb-content">
                                                <!-- <div class="price">$200</div> -->
                                                <a href="">
                                                    <img class="card-img-top img-fluid" :src="book.Image" alt="Card image cap">
                                                </a>
                                            </div>
                                            <div class="card-body">
                                                <h4 class="card-title"><a href="">{{book.Title}}</a></h4>
                                                <ul class="list-inline product-meta">
                                                    <li class="list-inline-item">
                                                        <a href=""><i class="fa fa-folder-open-o"></i>Electronics</a>
                                                    </li>
                                                    <li class="list-inline-item">
                                                        <a href=""><i class="fa fa-calendar"></i>26th December</a>
                                                    </li>
                                                </ul>
                                                <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Explicabo, aliquam!</p>
                                                <div class="product-ratings">
                                                    <ul class="list-inline">
                                                        <li class="list-inline-item selected"><i class="fa fa-star"></i></li>
                                                        <li class="list-inline-item selected"><i class="fa fa-star"></i></li>
                                                        <li class="list-inline-item selected"><i class="fa fa-star"></i></li>
                                                        <li class="list-inline-item selected"><i class="fa fa-star"></i></li>
                                                        <li class="list-inline-item"><i class="fa fa-star"></i></li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="pagination justify-content-center">
                            <nav aria-label="Page navigation example">
                                <ul class="pagination">
                                    <li class="page-item">
                                        <a class="page-link" href="#" aria-label="Previous">
                                            <span aria-hidden="true">&laquo;</span>
                                            <span class="sr-only">Previous</span>
                                        </a>
                                    </li>
                                    <li class="page-item"><a class="page-link" href="#">1</a></li>
                                    <li class="page-item active"><a class="page-link" href="#">2</a></li>
                                    <li class="page-item"><a class="page-link" href="#">3</a></li>
                                    <li class="page-item">
                                        <a class="page-link" href="#" aria-label="Next">
                                            <span aria-hidden="true">&raquo;</span>
                                            <span class="sr-only">Next</span>
                                        </a>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
</template>

<script>
    export default {
        props: ["term"],
        data() {
            return {
                Books: [],
                Term: null,
                TermDisplay: null
            }
        },
        methods: {
            search() {
                var self = this;

                self.TermDisplay = self.Term;

                this.$http.post("/api/search", { query: self.Term }).then((response) => {
                    self.Books = response.data;
                });
            }
        },
        mounted() {
            var self = this;

            self.Term = this.$route.params.term;
            self.TermDisplay = self.Term;

            if (self.Term == null || self.Term == "") {
                return;
            }

            this.$http.post("/api/search", { query: self.Term }).then((response) => {
                self.Books = response.data;
            });
        }
    }
</script>

<style scoped>
</style>