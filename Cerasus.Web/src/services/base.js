import axios from 'axios';

export const api = () => {
    return axios.create({
        baseURL: 'https://localhost:44303/api/',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        }
    })
}