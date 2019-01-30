import Vue from 'vue';
import App from './App.vue';
import axios from 'axios';
import VueAxios from 'vue-axios';
import Router from 'vue-router';
import BootstrapVue from 'bootstrap-vue';
import config from "./config.json";

import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

import HomeComponent from "./components/HomeComponent.vue";
import BookComponent from "./components/BookComponent.vue";

Vue.config.productionTip = true;

axios.defaults.baseURL = config.api_url;

Vue.use(VueAxios, axios);
Vue.use(Router);
Vue.use(BootstrapVue);

let router = new Router({
    base: __dirname,
    linkExactActiveClass: "active",
    routes: [
        { path: '/', name: "home", component: HomeComponent },
        { path: '/books', name: "books", component: BookComponent }

    ]
});

new Vue({
    router: router,
    render: h => h(App)
}).$mount('#app');
