import axios from 'axios';
let baseURL = 'http://localhost:44331';

console.log((window as any).uri);
if ((window as any).uri) {
  baseURL = (window as any).uri;
}

export const boardGameService = axios.create({
  baseURL: `${baseURL}/api/`,
  headers: {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE,PATCH,OPTIONS'
  }
});
