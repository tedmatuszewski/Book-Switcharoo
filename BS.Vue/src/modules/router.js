import Vue from 'vue';
import Router from 'vue-router';
import Home from '../components/Home.vue';
import Login from '../components/Login.vue';
import Post from '../components/Post.vue';
import Profile from '../components/Profile.vue';
import Register from '../components/Register.vue';
import Search from '../components/Search.vue';

Vue.use(Router);

const routes = [
    { path: '/', name: "home", component: Home },
    { path: '/login', name: "login", component: Login },
    { path: '/post', name: "post", component: Post },
    { path: '/profile', name: "profile", component: Profile },
    { path: '/register', name: "register", component: Register },
    { path: '/search', name: "search", component: Search },
];

export default new Router({
    routes,
    linkExactActiveClass: "active",
    beforeEach: () => { }
});