import Vue from 'vue';
import App from './App.vue';
import axios from 'axios';
import VueAxios from 'vue-axios';
import Router from 'vue-router';
import BootstrapVue from 'bootstrap-vue';
import firebase from 'firebase';
import { VueMasonryPlugin } from 'vue-masonry';
import config from "./config.json";

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

import HomeComponent from "./components/Home.vue";
import SearchComponent from "./components/Search.vue";
import PostComponent from "./components/Post.vue";
import LoginComponent from "./components/Login.vue";
import RegisterComponent from "./components/Register.vue";

Vue.config.productionTip = true;

axios.defaults.baseURL = config.api_url;

var firebaseConfig = {
    apiKey: "AIzaSyAAOqiqMrw3utPi2e7HemDN-YXI8tOajG0",
    authDomain: "bostonplatform2018.firebaseapp.com",
    databaseURL: "https://bostonplatform2018.firebaseio.com",
    projectId: "bostonplatform2018",
    storageBucket: "bostonplatform2018.appspot.com",
    messagingSenderId: "538071414774"
};

firebase.initializeApp(firebaseConfig);

Vue.use(VueMasonryPlugin)
Vue.use(VueAxios, axios);
Vue.use(Router);
Vue.use(BootstrapVue);

let router = new Router({
    base: __dirname,
    linkExactActiveClass: "active",
    routes: [
        { path: '/', name: "home", component: HomeComponent },
        { path: '/search', name: "search", component: SearchComponent },
        { path: '/post', name: "post", component: PostComponent, meta: { requiresAuth: true } },
        { path: '/login', name: "login", component: LoginComponent },
        { path: '/register', name: 'register', component: RegisterComponent }

    ]
});

router.beforeEach((to, from, next) => {
    const currentUser = firebase.auth().currentUser;
    const requiresAuth = to.matched.some(record => record.meta.requiresAuth);
    
    if (requiresAuth && !currentUser) {
        //next('login');
        router.push({ path: '/login', query: { redirectTo: to.path } });
    } else {
        next();
    }
    //else if (!requiresAuth && currentUser) {
    //    next("home");
    //} else {
    //    next();
    //}
});

new Vue({
    router: router,
    render: h => h(App)
}).$mount('#app');
