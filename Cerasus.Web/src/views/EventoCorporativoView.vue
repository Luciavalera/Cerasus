<template>
    <div class="body-evento">
        <div class="encabezado-corporativo">

        </div>
        <div class="content-body-evento">
            <div class="info-body">
                <div class="descripcion">
                    {{info[0].corporativo}}
                </div>
                <div class="img-body">
                    <img class="img" src="../assets/Corporativo/corporativo6.jpg">
                </div>
            </div>
            <Formulario/>
        </div>
        <div class="mas-img">
            <img class="mas-img-evento" src="../assets/Corporativo/corporativo1.jpg">
            <img class="mas-img-evento" src="../assets/Corporativo/corporativo5.jpg"> 
        </div>
        <Colaboradores/>
    </div>
</template>

<script>
import corporativoServices from '../services/corporativoServices'
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
            corporativoServices.getInfos().then(response => {
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

.encabezado-corporativo {
  display: flex;
  height: 355px;
  width: 100%;
  background-image: url(../assets/Corporativo/corporativo3.webp);
  background-position: center center;
  background-size: 1410px;
}

@media (max-width:480px){
    .encabezado-corporativo {
        display: flex;
        height: 155px;
        width: 100%;
        background-image: url(../assets/Corporativo/corporativo3.webp);
        background-position: center center;
        background-size: 550px;
    }
}

</style>