import Vue from 'vue';
import App from './App.vue';
import config from "./config.json";

Vue.config.productionTip = true;

config.config.api_url;

new Vue({
    render: h => h(App)
}).$mount('#app');
