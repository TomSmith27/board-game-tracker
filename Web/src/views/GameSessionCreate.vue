<template>
    <div>
        <h1>Game Create</h1>
        <v-progress-circular v-if="isLoading" :size="50" color="primary" indeterminate></v-progress-circular>
        <v-form v-else v-model="valid">
            <v-autocomplete v-model="selectedGame" :items="games" item-value="id" item-text="name" label="Game"></v-autocomplete>
            <v-date-picker v-model="date" :landscape="true"></v-date-picker>
            <v-combobox v-model="selectedPlayers" :items="players" label="Players" multiple item-text="name" item-value="name"></v-combobox>
            <v-btn @click="submit" color="primary"> Save </v-btn>
        </v-form>
    </div>
</template>

<script lang="ts">
import Vue from 'vue';
import { boardGameService } from '@/axios-service';
export default Vue.extend({
  name: 'GameSessionCreate',
  data: () => ({
    isLoading: true,
    games: [],
    players: [],
    selectedGame: 0,
    selectedPlayers: [],
    date: new Date().toISOString().substr(0, 10)
  }),
  async created() {
    this.isLoading = true;
    try {
      this.games = (await boardGameService.get('games')).data;
      this.players = (await boardGameService.get('player')).data;
    } catch (error) {}
    this.isLoading = false;
  },
  methods: {
    async submit() {
      try {
        const sessionId = (await boardGameService.post('game-session', {
          gameId: this.selectedGame,
          date: this.date,
          players: this.selectedPlayers.map((p: any) => p.id)
        })).data;
        this.$router.push({ name: 'game-session-detail', params: { id: sessionId } });
      } catch (error) {}
    }
  }
});
</script>


<style>
</style>
