import Vue from 'vue';
import Router from 'vue-router';
import Home from '../components/Home.vue';
import Login from '../components/Login.vue';
import Post from '../components/Post.vue';
import Profile from '../components/Profile.vue';
import Register from '../components/Register.vue';
import Search from '../components/Search.vue';
import session from '../modules/session';

Vue.use(Router);

const routes = [
    { path: '/', name: "home", component: Home },
    { path: '/login', name: "login", component: Login },
    { path: '/post', name: "post", component: Post, meta: { requiresAuth: true } },
    { path: '/profile', name: "profile", component: Profile, meta: { requiresAuth: true } },
    { path: '/register', name: "register", component: Register },
    { path: '/search', name: "search", component: Search },
];

let router = new Router({
    routes,
    linkExactActiveClass: "active",
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

export default router;