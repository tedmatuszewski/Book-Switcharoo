import Vue from 'vue';
import App from './App.vue';
import BootstrapVue from 'bootstrap-vue';
import { VueMasonryPlugin } from 'vue-masonry';
import VueChatScroll from 'vue-chat-scroll';
import Notify from 'vue2-notify';
import axios from 'axios';
import VueAxios from 'vue-axios';
import Router from 'vue-router';
import router from './modules/router';
import Icon from 'vue-awesome/components/Icon';
import config from "./config.json";

import 'bootstrap/dist/css/bootstrap.css';
import 'bootstrap-vue/dist/bootstrap-vue.css';
import 'vue-awesome/icons';
import './assets/site.css';

Vue.use(Router);
Vue.use(VueAxios, axios);
Vue.use(Notify);
Vue.use(VueChatScroll);
Vue.use(VueMasonryPlugin);
Vue.use(BootstrapVue);

axios.defaults.baseURL = config.api_url;

Vue.component('v-icon', Icon)

Vue.config.productionTip = true;

new Vue({
    router: router,
    render: h => h(App)
}).$mount('#app');
