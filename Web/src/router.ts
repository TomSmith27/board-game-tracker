import Vue from 'vue';
import Router from 'vue-router';
import Home from './views/Home.vue';
import GameList from './views/GameList.vue';
import GameSessionList from './views/GameSessionList.vue';

Vue.use(Router);

export default new Router({
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
      path: '/game-sessions',
      name: 'game-sessions',
      component: GameSessionList
    }
  ]
});
