import {api} from './base.js'

export default {
    async postPresupuesto(payload){
        return await api().post('Presupuestos', payload)
    }
}