import {api} from './base.js'

export default {
    async getNewsletter(payload){
        return await api().post('Suscriptor', payload)
    }
}