<template>
    <div>
        <h1>GameList</h1>
        <v-container grid-list-md text-xs-center>
            <v-layout row wrap>
                <v-flex :key="game.objectId" v-for="game in games" xs4>
                    <v-card>
                        <v-container fluid grid-list-lg>
                            <v-layout row>
                                <v-flex xs5>
                                    <v-img v-if="game.thumbnail" contain :src="game.thumbnail" aspect-ratio="1"></v-img>
                                </v-flex>
                                <v-flex xs7>
                                    <div>
                                        <div class="headline">{{game.name}}</div>
                                        <div>
                                            <span>
                                                <v-icon>people</v-icon> {{game.minPlayers}} - {{game.maxPlayers}}
                                            </span>
                                        </div>
                                    </div>
                                </v-flex>

                            </v-layout>
                        </v-container>
                        <v-card-actions>
                            <v-btn @click="deleteGame(game.id)" color="error">Delete</v-btn>
                        </v-card-actions>
                    </v-card>
                </v-flex>
            </v-layout>
        </v-container>
    </div>
</template>

<script lang="ts">
import Vue from 'vue';
import { boardGameService } from '@/axios-service';
export default Vue.extend({
  name: 'GameList',
  data: () => ({
    games: null
  }),
  created() {
    this.getGames();
  },
  methods: {
    getGames() {
      boardGameService.get('games').then(response => {
        this.games = response.data;
      });
    },
    deleteGame(id: number) {
      boardGameService.delete(`games/${id}`).then(response => {
        this.getGames();
      });
    }
  }
});
</script>


<style>
</style>
