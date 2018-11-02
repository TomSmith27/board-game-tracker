<template>
  <div>
    <h1>Game Sessions</h1>
    <router-link :to="{name : 'game-session-create'}">
      <v-btn color="primary">
        New
      </v-btn>
    </router-link>

    <v-layout row wrap>
      <v-flex xs12>
        <v-card :key="game.date" v-for="game in gameSessions">
          <v-layout>
            <v-card-title primary-title>
              <div>
                <div class="headline">{{game.date | bigDate}}</div>
              </div>
            </v-card-title>
          </v-layout>
          <v-divider light></v-divider>
        </v-card>
      </v-flex>
    </v-layout>

  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import { boardGameService } from '@/axios-service';
import moment from 'moment';
export default Vue.extend({
  name: 'GameSessionList',
  data: () => ({
    gameSessions: []
  }),
  filters: {
    bigDate: (value: string) => {
      return moment(value).format('Do MMM YYYY');
    }
  },
  created() {
    boardGameService.get('game-session').then(response => {
      this.gameSessions = response.data;
    });
  }
});
</script>


<style>
</style>
