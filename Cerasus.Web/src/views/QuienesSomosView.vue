<template>
  <div class="body-quienes">
      <div class="encabezado-quienes">

      </div>
      <div class="content-quienes">
            <div class="perfil">
                <p class="title-qs"><b>EQUIPO</b></p>
                <div class="content-perfil">
                    <div class="content-perfil-foto">
                        <b>{{equipo[0].nombre}}</b>
                        <img class="foto" src="../assets/Equipo/raquelMunoz.jpeg">
                        {{equipo[0].puesto}}
                        <br>
                        <div class="lema"><i>'{{equipo[0].lema}}'</i></div>
                    </div>
                    <div class="content-perfil-foto">
                        <b>{{equipo[1].nombre}}</b>
                        <img class="foto" src="../assets/Equipo/soniaFernandez.jpg">
                        {{equipo[1].puesto}}
                        <br>
                        <div class="lema"><i>'{{equipo[1].lema}}'</i></div>
                    </div>
                    <div class="content-perfil-foto">
                        <b>{{equipo[2].nombre}}</b>
                        <img class="foto" src="../assets/Equipo/martaPardo.jpg">
                        {{equipo[2].puesto}}
                        <br>
                        <div class="lema"><i>'{{equipo[2].lema}}'</i></div>
                    </div>
                    <div class="content-perfil-foto">
                        <b>{{equipo[3].nombre}}</b>
                        <img class="foto" src="../assets/Equipo/marcosNavarro.jpg">
                        {{equipo[3].puesto}}
                        <br>
                        <div class="lema"><i>'{{equipo[3].lema}}'</i></div>
                    </div>
                </div>
            </div>
            <Colaboradores/>
            <div class="filosofia">
                <p class="title-qs"><b>NUESTRA FILOSOFÍA</b></p>
                <div class="color-fuente">{{info[0].filosofia}}</div>
            </div>
      </div>
      
  </div>
</template>

<script>
import quienesSomosServices from '../services/quienesSomosServices'
import Colaboradores from '../components/Colaboradores.vue'

export default {
    data(){
        return {
            equipo: null,
            info: null
        }
    },
    mounted(){
        this.getEquipo()
        this.getInfos()
    },
    methods:{
        getEquipo(){
            quienesSomosServices.getEquipo().then(response => {
                this.equipo = response.data;
            })
        },
        getInfos(){
            quienesSomosServices.getInfos().then(response => {
                this.info = response.data;
            })
        }
    },
    components: {
    Colaboradores
    }
}

</script>

<style>

.body-quienes{
    display: block;
    width: 100%;
    height: 1785px;
    font-family: 'Didact Gothic', sans-serif;
}

.encabezado-quienes{
    display: flex;
    height: 355px;
    width: 100%;
    background-image: url(../assets/Equipo/quienesSomos.jpg);
    background-position: center center;
    background-size: 1410px;
}

.content-quienes{
    display: block;
    text-align: center;
    width: 100%;
    height: 1465px;
}

.title-qs{
    font-size: 30px;
    color:white;
}

.perfil{
    height: 430px;
    width: 100%;
    padding-top: 30px;
    background-color: black;
}

.content-perfil{
    display: flex;
    justify-content: space-evenly;
    color: white
}

.content-perfil-foto{
    display: flex;
    flex-direction: column;
    align-items: center;
    width: 18%;
}

.foto{
    width: 90%;
    padding: 10px;
}

.lema{
    font-size: 15px;
    color: rgb(177 177 177);
}

.filosofia{ 
    display: flex;
    height: 260px;
    width: 100%;
    font-size: 20px;
    background-color: black;
    flex-direction: column;
    justify-content: center;
    padding: 0px 30px
}

.color-fuente{
    color: white;
}

@media (max-width:480px){
    .body-quienes{
        display: block;
        width: 100%;
        height: 2900px;
        font-family: 'Didact Gothic', sans-serif;
    }
    .encabezado-quienes{
        display: flex;
        height: 155px;
        width: 100%;
        background-image: url(../assets/Equipo/quienesSomos.jpg);
        background-position: center center;
        background-size: 550px;
    }

    .content-quienes{
        display: block;
        text-align: center;
        width: 100%;
        height: 2745px;
    }

    .title-qs{
        font-size: 25px;
        color:white;
    }

    .perfil{
        height: 680px;
        width: 100%;
        padding-top: 30px;
        background-color: black;
    }

    .content-perfil{
        display: flex;
        justify-content: center;
        justify-content: space-around;
        flex-wrap: wrap;
        color: white
    }

    .content-perfil-foto{
        display: flex;
        flex-direction: column;
        align-items: center;
        width: 40%;
        margin-bottom: 20px;
    }

    .filosofia{ 
        display: flex;
        height: 335px;
        width: 100%;
        font-size: 15px;
        background-color: black;
        flex-direction: column;
        justify-content: center;
    }

    .title-qs{
        font-size: 25px;
        color:white;
    }
}

</style>