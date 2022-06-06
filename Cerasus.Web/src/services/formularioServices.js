import {api} from './base.js'

export default {
    async createFormulario(formulario){
        return await api().post('Formularios', formulario)
    },
    async getComida(){
        return await api().get('Comida')
    },
    async getLugar(){
        return await api().get('Lugar')
    },
    async getFormInfo(){
        return await api().get('Formularios')
    },
}