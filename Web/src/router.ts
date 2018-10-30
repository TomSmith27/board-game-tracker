import Vue from 'vue';
import Router from 'vue-router';
import Home from './views/Home.vue';
import GameList from './views/GameList.vue';
import GameSessionList from './views/GameSessionList.vue';
import GameSessionDetail from './views/GameSessionDetails.vue';
import GameSessionCreate from './views/GameSessionCreate.vue';

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
      path: '/game-session',
      name: 'game-sessions',
      component: GameSessionList
    },
    {
      path: '/game-session/create',
      name: 'game-session-create',
      component: GameSessionCreate
    },
    {
      path: '/game-session/:id',
      name: 'game-session-detail',
      component: GameSessionDetail,
      props: true
    }
  ]
});
