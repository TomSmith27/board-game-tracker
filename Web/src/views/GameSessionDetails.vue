<template>
    <div>
        <h1>Game Session Details</h1>
        <v-progress-circular v-if="loading" :size="50" color="primary" indeterminate></v-progress-circular>
        <div v-if="!loading">
            <h1>{{session.gameName}}</h1>
            <v-data-table :headers="headers" :items="session.ratings" hide-actions class="elevation-1">
                <template slot="items" slot-scope="props">
                    <td> {{ props.item.playerName }} </td>
                    <td>
                        <star-rating :star-size="25" @rating-selected="ratingChanged(props.item.rating, props.item.playerId)" v-model="props.item.rating"></star-rating>
                    </td>
                </template>
            </v-data-table>
        </div>
    </div>
</template>

<script lang="ts">
import Vue from 'vue';
import StarRating from 'vue-star-rating';
import { boardGameService } from '@/axios-service';
export default Vue.extend({
  name: 'GameSessionDetails',
  components: {
    StarRating
  },
  props: {
    id: {
      type: Number,
      required: true
    }
  },
  data: () => ({
    loading: true,
    headers: [
      {
        text: 'Player',
        value: 'player'
      },
      {
        text: 'Rating',
        value: 'rating'
      }
    ],
    session: {}
  }),
  methods: {
    async ratingChanged(rating: number, playerId: number) {
      try {
        await boardGameService.post(`rating/gameplay-session/${this.id}/player/${playerId}`, {
          rating: rating
        });
      } catch (error) {}
    }
  },
  async mounted() {
    this.loading = true;
    try {
      this.session = (await boardGameService.get(`game-session/${this.id}`)).data;
    } catch (error) {}
    this.loading = false;
  }
});
</script>


<style>
</style>
