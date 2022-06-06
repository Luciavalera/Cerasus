<template>
    <div class="body-evento">
        <div class="encabezado-boda">

        </div>
        <div class="content-body-evento">
            <div class="info-body">
                <div class="descripcion">
                    {{info[0].boda}}
                </div>
                <div class="img-body">
                    <img class="img" src="../assets/Boda/boda3.jpg">
                </div>
            </div>
            <Formulario/>
        </div>
        <div class="mas-img">
            <img class="mas-img-evento" src="../assets/Boda/boda8.jpg">
            <img class="mas-img-evento" src="../assets/Boda/boda7.jpg"> 
        </div>
        <Colaboradores/>
    </div>
</template>

<script>
import bodaServices from '../services/bodaServices'
import Colaboradores from '../components/Colaboradores.vue';
import Formulario from '../components/Formulario.vue'

export default {
    data(){
        return {
            info: null
        }
    },
    mounted(){
        this.getInfos()
    },
    methods:{
        getInfos(){
            bodaServices.getInfos().then(response => {
                this.info = response.data;
            })
        }
    },
    components: {
    Colaboradores,
    Formulario
  }
}
</script>

<style>

.body-evento{
  display: block;
  width: 100%;
  height: 2160px;
  font-family: 'Didact Gothic', sans-serif;
}

.content-body-evento{
    display: flex;
    height: 695px;
}

.encabezado-boda {
  display: flex;
  height: 355px;
  width: 100%;
  background-image: url('../assets/Boda/boda1.jpg');
  background-position: center center;
  background-size: 1410px;
}

.mas-img {
    display: flex;
    width: 100%;
    height: 400px;
}

.mas-img-evento{
   width: 100%;
}

@media (max-width:480px){
    .body-evento{
        display: block;
        width: 100%;
        height: 3110px;
        font-family: 'Didact Gothic', sans-serif;
    }

    .content-body-evento{
        display: block;
        height: 1100px;
    }

    .encabezado-boda {
        display: flex;
        height: 155px;
        width: 100%;
        background-image: url('../assets/Boda/boda1.jpg');
        background-position: center center;
        background-size: 550px;
    }

    .mas-img {
        display: flex;
        width: 100%;
        height: 120px;
    }

    .mas-img-evento{
        width: 100%;
    }
}

</style>