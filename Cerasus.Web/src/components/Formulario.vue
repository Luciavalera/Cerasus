<template>
  <div class="formulario">
    <form class="presupuesto" action="#" method="get" name="formulario">
      <p class="presupuetso-title"><b>CREA TU PRESUPUESTO</b></p>
      <label for="nombre-apellido">Nombre y Apellidos</label>
      <input
        v-model="formulario.NombreApellidos"
        type="text"
        name="nombre"
        id="nombre"
        placeholder="Escribe tu nombre y apellidos"
        required
      />

      <label for="evento">Evento</label>
      <select
        v-model="formulario.Evento"
        type="text"
        name="evento"
        id="evento"
        require
      >
        <option selected="selected" disabled>Elige una opción</option>
        <option>Boda</option>
        <option>Comunión</option>
        <option>Evento Corporativo</option>
      </select>

      <label for="invitados">Invitados</label>
      <input
        v-model="formulario.Invitados"
        type="text"
        name="invitados"
        id="invitados"
        placeholder="Invitados para el evento"
        required
      />

      <label for="Comida">Comida</label>
      <select
        v-model="formulario.Comida"
        type="text"
        name="invitados"
        id="invitados"
        placeholder="Elige una opción"
        required
      >
        <option selected="selected">Elige una opción</option>
        <option v-for="(comida, index) in comidas" :key="index">
          {{ comida.nombre }}
        </option>
      </select>

      <label for="Lugar">Lugar de celebración</label>
      <select
        v-model="formulario.Lugar"
        type="text"
        name="lugar"
        id="lugar"
        placeholder="Elige una opción"
        required
      >
        <option selected="selected">Elige una opción</option>
        <option v-for="(lugar, index) in lugares" :key="index">
          {{ lugar.nombre }}
        </option>
      </select>

      <label for="mensaje">Mensaje (opcional)</label>
      <textarea
        v-model="formulario.Mensaje"
        name="mensaje"
        for="mensaje"
        placeholder="Puedes escribir hasta 500 caracteres"
      ></textarea>
      <div class="reset">
        <label v-if="showPresupuesto" class="estimacion">Tu presupuesto estimado es {{ precio }} €</label>
        <button v-if="showPresupuesto" v-on:click="resetFormulario()" class="reset-estimacion">Nuevo presupuesto</button>
      </div>
      <input
        v-if="!showPresupuesto"
        class="submit"
        name="enviar"
        value="Presupuesto estimado"
        v-on:click="enviarFormulario()"
      />
    </form>
  </div>
</template>

<script>
import formularioServices from "../services/formularioServices";
import presupuestoServices from "../services/presupuestoServices"

export default {
  name: "Formulario",
  data() {
    return {
      formulario: {
        NombreApellidos: "",
        Evento: null,
        Invitados: "",
        Comida: "",
        Lugar: "",
        Mensaje: ""
      },
      comidas: [],
      lugares: [],
      presupuesto: {
        formulario: {

        } 
      },
      showPresupuesto: false,
      precio: "",
    }
  },
  mounted(){
    this.getComida()
    this.getLugar()
  },
  methods: {
    enviarFormulario() {
      formularioServices.createFormulario(this.formulario).then((response) => {
        
     })
     this.presupuesto.formulario = this.formulario
     presupuestoServices.postPresupuesto(this.presupuesto).then((response) => {
       this.precio = response.data.total;
       this.showPresupuesto = true;
     })
    },
    getComida(){
      formularioServices.getComida().then(response => {
        this.comidas = response.data;
      })
    },
    getLugar(){
      formularioServices.getLugar().then(response => {
        this.lugares = response.data;
      })
    },
    resetFormulario() {
      this.formulario.NombreApellidos = "";
      this.formulario.Evento = "";
      this.formulario.Invitados = "";
      this.formulario.Comida = "";
      this.formulario.Lugar = "";
      this.formulario.Mensaje = "";
      this.showPresupuesto = false;
    }
  }
}
</script>

<style>
.formulario {
  display: flex;
  width: 55%;
  height: 695px;
  font-family: "Didact Gothic", sans-serif;
}

.presupuesto {
  display: flex;
  flex-direction: column;
  width: 90%;
  height: 600px;
  margin: auto;
  padding: 24px;
  border-radius: 10px;
  background-color: rgb(241 230 249);
}

.presupuetso-title {
  text-align: center;
  font-size: 20px;
}

form label {
  display: block;
  font-weight: bold;
  margin-bottom: 5px;
}

form select[type="text"],
form input[type="text"] {
  padding: 0 10px;
  border: none;
  border-radius: 3px;
  background-color: #ffffff;
  margin-bottom: 10px;
  height: 35px;
}

form input[class="submit"] {
  width: 100%;
  padding: 8px 16px;
  margin-top: 32px;
  border: 1px solid #000;
  border-radius: 5px;
  color: rgb(255, 255, 255);
  background-color: #000;
  cursor: pointer;
  text-align: center;
}

textarea {
  width: 100%;
  height: 70px;
  padding: 3px 10px;
  border: 1px solid #ffffff;
  border-radius: 3px;
  background-color: #ffffff;
  margin: 3px 0;
}

.reset{
  display: flex;
  width: 100%;
  padding-top: 15px;
  justify-content: space-around;
  align-items: center;
}

.estimacion{
  width: 50%;
  text-align: center;
  font-size: 19px;
}

.reset-estimacion{
  width: 50%;
  width: 40%;
  padding: 8px 16px;
  border: 1px solid #000;
  border-radius: 5px;
  color: rgb(255, 255, 255);
  background-color: #000;
  cursor: pointer;
  text-align: center;
}

@media (max-width:480px){
  .formulario {
    display: flex;
    width: 100%;
    height: 675px;
    font-family: "Didact Gothic", sans-serif;
  }
}
</style>