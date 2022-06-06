import {api} from './base.js'

export default {
    async getInfos(){
        return await api().get('Infos')
    }
}