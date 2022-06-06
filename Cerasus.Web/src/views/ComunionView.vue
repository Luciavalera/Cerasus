<template>
    <div class="body-evento">
        <div class="encabezado-comunion">

        </div>
        <div class="content-body-evento">
            <div class="info-body">
                <div class="descripcion">
                    {{info[0].comunion}}
                </div>
                <div class="img-body">
                    <img class="img" src="../assets/Comunion/comunion8.jpg">
                </div>
            </div>
            <Formulario/>
        </div>
        <div class="mas-img">
            <img class="mas-img-evento" src="../assets/Comunion/comunion1.jpg">
            <img class="mas-img-evento" src="../assets/Comunion/comunion7.jpg"> 
        </div>
        <Colaboradores/>
    </div>
</template>

<script>
import comunionServices from '../services/comunionServices'
import Colaboradores from '../components/Colaboradores.vue'
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
            comunionServices.getInfos().then(response => {
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

.encabezado-comunion {
  display: flex;
  height: 355px;
  width: 100%;
  background-image: url(../assets/Comunion/comunion5.jpg);
  background-position: center center;
  background-size: 1410px;
}

@media (max-width:480px){
    .encabezado-comunion {
    display: flex;
    height: 155px;
    width: 100%;
    background-image: url(../assets/Comunion/comunion5.jpg);
    background-position: center center;
    background-size: 550px;
    }
}

</style>