import Vue from 'vue';
import App from './App.vue';
import axios from 'axios';
import VueAxios from 'vue-axios';
import Router from 'vue-router';
import BootstrapVue from 'bootstrap-vue';
import firebase from 'firebase';
import { VueMasonryPlugin } from 'vue-masonry';
import config from "./config.json";
import session from "./session";

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

import HomeComponent from "./components/Home.vue";
import SearchComponent from "./components/Search.vue";
import PostComponent from "./components/Post.vue";
import LoginComponent from "./components/Login.vue";
import RegisterComponent from "./components/Register.vue";
import ProfileComponent from "./components/Profile.vue";

Vue.config.productionTip = true;

axios.defaults.baseURL = config.api_url;

var firebaseConfig = {
    apiKey: "AIzaSyC-vQIqz2ESYm0cuF9UswndGcXokxC2PGE",
    authDomain: "bookswap633.firebaseapp.com",
    databaseURL: "https://bookswap633.firebaseio.com",
    projectId: "bookswap633",
    storageBucket: "",
    messagingSenderId: "95979622512"
};

firebase.initializeApp(firebaseConfig);

Vue.use(VueMasonryPlugin);
Vue.use(VueAxios, axios);
Vue.use(Router);
Vue.use(BootstrapVue);

let router = new Router({
    base: __dirname,
    linkExactActiveClass: "active",
    routes: [
        { path: '/', name: "home", component: HomeComponent },
        { path: '/search', name: "search", component: SearchComponent },
        { path: '/post/:id', name: "editpost", component: PostComponent, meta: { requiresAuth: true } },
        { path: '/post', name: "createpost", component: PostComponent, meta: { requiresAuth: true } },
        { path: '/login', name: "login", component: LoginComponent },
        { path: '/register', name: 'register', component: RegisterComponent },
        { path: '/profile', name: 'profile', component: ProfileComponent, meta: { requiresAuth: true } }
    ]
});

router.beforeEach((to, from, next) => {
    const loggedIn = session.isset();
    const requiresAuth = to.matched.some(record => record.meta.requiresAuth);
    
    if (requiresAuth && !loggedIn) {
        router.push({ path: '/login', query: { redirectTo: to.path } });
    } else {
        next();
    }
});

new Vue({
    router: router,
    data: {
        store: { }
    },
    created() {
        //var self = this;
        //var session = JSON.parse(localStorage.getItem("user"));

        //firebase.auth().onAuthStateChanged((response) => {
        //    if (response) {
        //        var user = {
        //            displayName: response.displayName,
        //            email: response.email,
        //            emailVerified: response.emailVerified,
        //            phoneNumber: response.phoneNumber,
        //            photoURL: response.photoURL
        //        };

        //        localStorage.setItem("user", JSON.stringify(user));
        //    } else {
        //        localStorage.removeItem("user");
        //    }
        //});
    },
    render: h => h(App)
}).$mount('#app');
