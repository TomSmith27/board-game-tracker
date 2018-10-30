<template>
    <div>
        <h1>Game Sessions</h1>
        <template>
            <v-data-table :headers="headers" :items="gameSessions" hide-actions class="elevation-1">
                <template slot="items" slot-scope="props">
                    <td>{{ props.item.gameName }}</td>
                    <td>{{ props.item.date | date}}</td>
                    <td>{{ props.item.ratings.length }}</td>
                </template>
            </v-data-table>
        </template>
    </div>
</template>

<script lang="ts">
import Vue from 'vue';
import { boardGameService } from '@/axios-service';
export default Vue.extend({
  name: 'GameSessionList',
  data: () => ({
    headers: [
      {
        text: 'Game',
        value: 'game'
      },
      { text: 'Date', value: 'date' },
      { text: 'Num of Players', value: 'players' }
    ],
    gameSessions: []
  }),
  created() {
    boardGameService.get('game-session').then(response => {
      this.gameSessions = response.data;
    });
  }
});
</script>


<style>
</style>
