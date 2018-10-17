import axios from 'axios';

export const BoardGameService = axios.create({
  baseURL: `https://localhost:44331/api/bgg`,
  headers: {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE,PATCH,OPTIONS'
  }
});
