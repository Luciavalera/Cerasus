<template>
  <div>
      <table>
            <tr class="titulo-cabecera">
              <th>ID</th>
              <th>Evento</th>
              <th>Comida</th>
              <th>Invitados</th>
              <th>Lugar</th>
              <th>NombreApellidos</th>
              <th>Mensaje</th>
            </tr>
            <tr class="info-presupuesto" v-for="(presupuesto, index) in listaFormulario" :key="index">
                <td>{{ presupuesto.id }}</td>
                <td>{{ presupuesto.evento }}</td>
                <td>{{ presupuesto.comida }}</td>
                <td>{{ presupuesto.invitados }}</td>
                <td>{{ presupuesto.lugar }}</td>
                <td>{{ presupuesto.NombreApellidos }}</td>
                <td>{{ presupuesto.mensaje }}</td>
            </tr>
      </table>
  </div>
</template>

<script>
import formularioServices from '../services/formularioServices.js'

export default {
  data(){
    return {
      listaFormulario: []
    }
  },
  mounted(){
    this.getFormInfo()
  },
  methods:{
    getFormInfo(){
      formularioServices.getFormInfo().then(response => {
          console.log(response.data)
        this.listaFormulario = response.data;
      })
    }
  },
}
</script>

<style>

table{
    margin: 0 auto;
}

.titulo-cabecera{
    border: 1px black solid;
}

</style>