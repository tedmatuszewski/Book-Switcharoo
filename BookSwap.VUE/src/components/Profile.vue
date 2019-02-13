<template>
    <div class="container-fluid">
        <div class="card mt-3">
            <div class="card-header">
                <ul class="nav nav-tabs card-header-tabs">
                    <li class="nav-item"><a v-bind:class="{ active: ActiveTab == 'library' }" v-on:click.prevent="tabChange('library')" class="nav-link" data-toggle="tab" href="#library" role="tab">Library</a> </li>
                    <li class="nav-item"><a v-bind:class="{ active: ActiveTab == 'message' }" v-on:click.prevent="tabChange('message')" class="nav-link" data-toggle="tab" href="#messages" role="tab">Messages</a> </li>
                </ul>
            </div>

            <div class="card-body tab-content">
                <div class="tab-pane fade" v-bind:class="{ 'active': ActiveTab == 'library', 'show': ActiveTab == 'library' }" id="library" role="tabpanel" aria-labelledby="nav-home-tab">
                    <div class="row mb-4 pb-3 border-bottom" v-for="(book, index) in Books" :key="book.Id">
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
                <div class="tab-pane fade" v-bind:class="{ 'active': ActiveTab == 'message', 'show': ActiveTab == 'message' }"  id="messages" role="tabpanel" aria-labelledby="nav-profile-tab">
                    <div class="messaging">
                        <div class="inbox_msg">
                            <div class="inbox_people">
                                <div class="headind_srch">
                                    <div class="recent_heading">
                                        <h4>Recent</h4>
                                    </div>
                                    <div class="srch_bar">
                                        <div class="stylish-input-group">
                                            <input type="text" class="search-bar" placeholder="Search">
                                            <span class="input-group-addon">
                                                <button type="button"> <i class="fa fa-search" aria-hidden="true"></i> </button>
                                            </span>
                                        </div>
                                    </div>
                                </div>
                                <div class="inbox_chat">
                                    <div class="chat_list active_chat" v-for="message in MessageList">
                                        <div class="chat_people">
                                            <div class="chat_img"> <img src="https://ptetutorials.com/images/user-profile.png" alt="sunil"> </div>
                                            <div class="chat_ib">
                                                <h5>{{message.From}} <span class="chat_date">{{message.DateAddedDisplay}}</span></h5>
                                                <p>{{message.Title}}</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="mesgs">
                                <div class="msg_history">
                                    <div class="incoming_msg">
                                        <div class="incoming_msg_img"> <img src="https://ptetutorials.com/images/user-profile.png" alt="sunil"> </div>
                                        <div class="received_msg">
                                            <div class="received_withd_msg">
                                                <p>
                                                    Test which is a new approach to have all
                                                    solutions
                                                </p>
                                                <span class="time_date"> 11:01 AM    |    June 9</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="outgoing_msg">
                                        <div class="sent_msg">
                                            <p>
                                                Test which is a new approach to have all
                                                solutions
                                            </p>
                                            <span class="time_date"> 11:01 AM    |    June 9</span>
                                        </div>
                                    </div>
                                    <div class="incoming_msg">
                                        <div class="incoming_msg_img"> <img src="https://ptetutorials.com/images/user-profile.png" alt="sunil"> </div>
                                        <div class="received_msg">
                                            <div class="received_withd_msg">
                                                <p>Test, which is a new approach to have</p>
                                                <span class="time_date"> 11:01 AM    |    Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="outgoing_msg">
                                        <div class="sent_msg">
                                            <p>Apollo University, Delhi, India Test</p>
                                            <span class="time_date"> 11:01 AM    |    Today</span>
                                        </div>
                                    </div>
                                    <div class="incoming_msg">
                                        <div class="incoming_msg_img"> <img src="https://ptetutorials.com/images/user-profile.png" alt="sunil"> </div>
                                        <div class="received_msg">
                                            <div class="received_withd_msg">
                                                <p>
                                                    We work directly with our designers and suppliers,
                                                    and sell direct to you, which means quality, exclusive
                                                    products, at a price anyone can afford.
                                                </p>
                                                <span class="time_date"> 11:01 AM    |    Today</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="type_msg">
                                    <div class="input_msg_write">
                                        <input type="text" class="write_msg" placeholder="Type a message" />
                                        <button v-on:click="send" class="msg_send_btn" type="button"><i class="fa fa-paper-plane" aria-hidden="true"></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
    import session from '../session';

    export default {
        data() {
            return {
                Books: [],
                ActiveTab: "library",
                MessageList: []
            }
        },
        methods: {
            deleteBook(book, index) {
                var self = this;

                self.$http.delete("/v1/books/" + book.Id).then(() => {
                    self.Books.splice(index, 1);
                });
            },
            tabChange(tab) {
                this.ActiveTab = tab;
            },
            send() {

            }
        },
        mounted() {
            var self = this;
            var user = session.get();

            self.$http.get("/v1/books?user=" + user.email).then((response) => {
                self.Books = response.data;
            });

            self.$http.get("/v1/messages/list?user=" + user.email).then((response) => {
                self.MessageList = response.data;
            });
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
