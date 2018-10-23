import axios from 'axios';

export const boardGameService = axios.create({
  baseURL: `https://localhost:44331/api/`,
  headers: {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE,PATCH,OPTIONS'
  }
});
