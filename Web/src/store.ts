import { boardGameService } from './axios-service';
import Vue from 'vue';
import Vuex from 'vuex';
import { User } from './models/User';
Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    user: {}
  },
  mutations: {
    setUser(state, user: User) {
      state.user = user;
      localStorage.setItem('user', JSON.stringify(user));
      boardGameService.defaults.headers['Authorization'] = `Bearer ${(state.user as any).token}`;
    },
    logout(state) {
      state.user = {};
      localStorage.removeItem('user');
    }
  },
  actions: {}
});
