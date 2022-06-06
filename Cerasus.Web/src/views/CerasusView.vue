<template>
  <div class="body">
      <div class="encabezado">

      </div>
      <div class="content-body">
         <div class="info-body">
            <div class="descripcion" v:if="info">
               {{info[0].home}} 
            </div>
            <div class="img-body">
               <img class="img" src="https://img.freepik.com/foto-gratis/mesa-decorada-celebracion-boda_181624-4606.jpg?w=900">
            </div>
         </div>
        <Formulario/>
      </div>
  </div>
</template>

<script>
import cerasusServices from '../services/cerasusServices'
import Formulario from '../components/Formulario.vue'

export default {
  data(){
    return {
      info: []
    }
  },
  mounted(){
    this.getInfos()
  },
  methods:{
    getInfos(){
      cerasusServices.getInfos().then(response => {
        this.info = response.data;
      })
    }
  },
  components: {
    Formulario
  }
}

</script>

<style>
.body{
  display: block;
  width: 100%;
  height: 1040px;
  font-family: 'Didact Gothic', sans-serif;
}

.encabezado{
  display: flex;
  height: 355px;
  width: 100%;
  background-image: url(../assets/Boda/boda2.jpg);
  background-position: center center;
  background-size: 1410px;
}

.content-body{
  display: flex;
  height: 695px;
}

.info-body {
  display: block;
  width: 55%;
  height: 645px;
}

.descripcion{
  display: flex;
  width: 100%;
  height: 200px;
  align-items: center;
  justify-content: center;
  font-size: 20px;
  text-align: center;
  padding: 40px 30px 0px;
}

.img-body{
  display: flex;
  width: 100%;
  height: 435px;
  align-items: center;
  justify-content: center;
}

.img{
  width: 80%;
}

@media (max-width:480px){
  .body{
    display: block;
    width: 100%;
    height: 1270px;
    font-family: 'Didact Gothic', sans-serif;
  }

  .encabezado{
    display: flex;
    height: 155px;
    width: 100%;
    background-image: url(../assets/Boda/boda2.jpg);
    background-position: center center;
    background-size: 550px;
  }

  .content-body{
    display: block;
    height: 1100px;
  }

  .info-body {
    display: block;
    width: 100%;
    height: 440px;
  }

  .descripcion{
    display: flex;
    width: 100%;
    height: 190px;
    align-items: center;
    justify-content: center;
    font-size: 15px;
    text-align: center;
    padding: 0px 20px 0px;
  }

  .img-body{
    display: flex;
    width: 100%;
    height: auto;
    align-items: center;
    justify-content: center;
  }
}

</style>