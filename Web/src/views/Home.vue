<template>
  <div>
    <v-text-field v-model="search" append-icon="search" solo single-line placeholder="Search..."></v-text-field>
    <v-progress-circular v-if="searching" :size="50" color="primary" indeterminate></v-progress-circular>
    <v-alert :value="searchError" type="error">
      {{searchError}}
    </v-alert>
    <v-container grid-list-md text-xs-center>
      <v-layout row wrap>
        <v-flex v-for="game in boardGames" :key="game.objectid" xs6>
          <v-card>
            <v-card-title primary-title>
              <div>
                <h3 class="headline mb-0">{{game.name.text}}</h3>
              </div>
            </v-card-title>
            <v-card-text>
              <v-list-tile>
                <v-list-tile-action>
                  <v-icon>event</v-icon>
                </v-list-tile-action>
                <v-list-tile-content>
                  <v-list-tile-title>{{ game.yearpublished }}</v-list-tile-title>
                  <v-list-tile-sub-title>Year Published</v-list-tile-sub-title>
                </v-list-tile-content>
              </v-list-tile>
            </v-card-text>
          </v-card>
        </v-flex>
      </v-layout>
    </v-container>
  </div>
</template>

<script lang="ts">
import Vue from 'vue';
import HelloWorld from '@/components/HelloWorld.vue'; // @ is an alias to /src
import axios from 'axios';
import _ from 'lodash';
import { BoardGameService } from '../axios-service';
export default Vue.extend({
  name: 'home',
  components: {
    HelloWorld
  },
  data: () => ({
    search: '',
    searching: false,
    searchError: '',
    boardGames: []
  }),
  methods: {
    searchForGames: _.debounce(async function(this: any) {
      this.searching = true;
      try {
        const result = await BoardGameService.get(`search?search=${this.search}`);
        this.boardGames = result.data.boardgames;
      } catch (e) {
        if (e.message === 'Network Error') {
          this.searchError = 'Network Error';
        }
      }
      this.searching = false;
    }, 2000)
  },
  watch: {
    async search() {
      if (this.search.length > 2) {
        this.searchForGames();
      }
    }
  }
});
</script>
