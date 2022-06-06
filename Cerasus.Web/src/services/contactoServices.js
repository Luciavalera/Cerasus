import {api} from './base.js'

export default {
    async getContacto(){
        return await api().get('Contacto')
    }
}