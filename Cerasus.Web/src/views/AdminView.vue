<template>
  <div class="body-table">
      <table>
            <tr class="titulo-cabecera">
              <th class="id">ID</th>
              <th class="evento">Evento</th>
              <th class="comida">Comida</th>
              <th class="invitados">Invitados</th>
              <th class="lugar">Lugar</th>
              <th class="nombre">NombreApellidos</th>
              <th class="mensaje">Mensaje</th>
            </tr>
            <tr class="info-presupuesto" v-for="(presupuesto, index) in listaFormulario" :key="index">
                <td class="border-info">{{ presupuesto.id }}</td>
                <td class="border-info">{{ presupuesto.evento }}</td>
                <td class="border-info">{{ presupuesto.comida }}</td>
                <td class="border-info">{{ presupuesto.invitados }}</td>
                <td class="border-info">{{ presupuesto.lugar }}</td>
                <td class="border-info">{{ presupuesto.nombreApellidos }}</td>
                <td class="border-info">{{ presupuesto.mensaje }}</td>
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

.body-table{
    height: auto;
    margin-bottom: 50px;
}

table{
    margin: 0 auto;
}

.titulo-cabecera{
  background-color: black;
  color: white;
  border-style: 1px black solid;
}

th.id{
  width: 50px;
}

th.evento{
  width: 170px;
}

th.comida{
  width: 100px;
}

th.invitados{
  width: 100px;
}

th.lugar{
  width: 200px;
}

th.nombre{
  width: 150px;
}

th.mensaje{
  width: 220px;
}

.border-info{
  border: 1px black solid;
}

</style>