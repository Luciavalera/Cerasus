import {api} from './base.js'

export default {
    async getColaborador(){
        return await api().get('Colaborador')
    }
}
