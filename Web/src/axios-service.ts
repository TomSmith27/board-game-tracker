import axios from 'axios';

export const boardGameService = axios.create({
  baseURL: `https://192.168.0.18:5001/api/`,
  headers: {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE,PATCH,OPTIONS'
  }
});
