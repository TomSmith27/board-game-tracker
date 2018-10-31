import Vue from 'vue';
import Router from 'vue-router';
import Home from './views/Home.vue';
import GameList from './views/GameList.vue';
import GameSessionList from './views/GameSessionList.vue';
import GameSessionDetail from './views/GameSessionDetails.vue';
import GameSessionCreate from './views/GameSessionCreate.vue';
import LoginPage from './views/Login.vue';

Vue.use(Router);

const router = new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/games',
      name: 'games',
      component: GameList
    },
    {
      path: '/game-session',
      name: 'game-sessions',
      component: GameSessionList
    },
    {
      path: '/game-session/create/:gameId?',
      name: 'game-session-create',
      component: GameSessionCreate,
      props: true
    },
    {
      path: '/game-session/:id',
      name: 'game-session-detail',
      component: GameSessionDetail,
      props: true
    },
    {
      path: '/login',
      component: LoginPage
    }
  ]
});

export default router;

router.beforeEach((to, from, next) => {
  // redirect to login page if not logged in and trying to access a restricted page
  const publicPages = ['/login', '/register'];
  const authRequired = !publicPages.includes(to.path);
  const loggedIn = localStorage.getItem('user');
  if (authRequired && !loggedIn) {
    return next({
      path: '/login',
      query: { redirect: to.fullPath }
    });
  }

  next();
});
