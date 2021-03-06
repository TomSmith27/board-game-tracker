import Vue from 'vue';
import App from './App.vue';
import router from './router';
import store from './store';
import Vuetify from 'vuetify';
import moment from 'moment';

Vue.use(Vuetify, {
  theme: {
    primary: '#2e7d32',
    secondary: '#424242',
    accent: '#82B1FF',
    error: '#FF5252',
    info: '#2196F3',
    success: '#4CAF50',
    warning: '#FFC107'
  }
});
Vue.config.productionTip = false;

Vue.filter('date', (value: string) => {
  return moment(value).format('DD/MM/YYYY');
});

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app');
