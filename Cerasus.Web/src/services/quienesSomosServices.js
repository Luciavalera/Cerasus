import {api} from './base.js'

export default {
    async getEquipo(){
        return await api().get('Equipo')
    },
    async getColaborador(){
        return await api().get('Colaborador')
    },
    async getInfos(){
        return await api().get('Infos')
    }
}