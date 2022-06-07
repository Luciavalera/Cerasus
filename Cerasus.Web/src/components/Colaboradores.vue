<template>
              <div class="colab">
                <p class="title-qs-colab"><b>NUESTROS COLABORADORES</b></p>
                <div class="colab-box">
                    <div class="colab-box-content-lu"> 
                        <p class="colab-title"><b>Lugares:</b></p>
                        <div class="colab-box-logo-content">
                            <div class="colab-box-logo">
                                <a target="_blank" title="Bonavia-Web" href="https://www.castillobonavia.es/"><img class="colab-logo" src="../assets/Colaboradores/Lugar/Bonavia.jpg"/></a>
                                {{colaborador[3].nombre}}
                            </div>
                            <div class="colab-box-logo">
                                <a target="_blank" title="Cachirulo-Web" href="https://elcachirulo.es/"><img class="colab-logo" src="../assets/Colaboradores/Lugar/Cachirulo.jpg"/></a>
                                {{colaborador[4].nombre}}
                            </div>
                            <div class="colab-box-logo">
                                <a target="_blank" title="Sella-Web" href="https://habitatsella.com/"><img class="colab-logo" src="../assets/Colaboradores/Lugar/HabitatSella.jpg"></a>
                                {{colaborador[5].nombre}}
                            </div>
                            <div class="colab-box-logo">
                                <a target="_blank" title="LaBastilla-Web" href="https://www.labastilla.com/"><img class="colab-logo" src="../assets/Colaboradores/Lugar/LaBastilla.jpg"></a>
                                {{colaborador[6].nombre}}
                            </div>
                            <div class="colab-box-logo">
                                <a target="_blank" title="SantaAna-Web" href="https://www.villasantaana.com/"><img class="colab-logo" src="../assets/Colaboradores/Lugar/VillaSantaAna.jpg"></a>
                                {{colaborador[7].nombre}}
                            </div>
                        </div>
                    </div>
                    <div class="colab-box-content-ca">
                        <p class="colab-title"><b>Catering:</b></p>
                        <div class="colab-box-logo-content">
                            <div class="colab-box-logo">
                                <a target="_blank" title="Guian-Web" href="https://www.guian.es/"><img class="colab-logo" src="../assets/Colaboradores/Catering/Guian.jpg"/></a>
                                {{colaborador[0].nombre}}
                            </div>
                            <div class="colab-box-logo">
                                <a target="_blank" title="Cuoco-Web" href="https://cuococatering.com/"><img class="colab-logo" src="../assets/Colaboradores/Catering/Cuoco.jpg"/></a>
                                {{colaborador[8].nombre}}
                            </div>
                            <div class="colab-box-logo">
                                <a target="_blank" title="LaBastilla-Web" href="https://www.labastilla.com/"><img class="colab-logo" src="../assets/Colaboradores/Catering/LaBastilla.jpg"/></a>
                                {{colaborador[1].nombre}}
                            </div>
                        </div>
                    </div>
                    <div class="colab-box-content-de"> 
                        <p class="colab-title"><b>Decoración:</b></p>
                        <div class="colab-box-logo-content">
                            <div class="colab-box-logo">
                                <img class="colab-logo" src="../assets/Colaboradores/Decoracion/Jara.png">
                                {{colaborador[2].nombre}}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
</template>

<script>
import colaboradorServices from '../services/colaboradorServices'

export default {
    name: 'Colaboradores',
    data(){
        return {
            colaborador: null
        }
    },
    mounted(){
        this.getColaborador()
    },
    methods:{
        getColaborador(){
            colaboradorServices.getColaborador().then(response => {
                this.colaborador = response.data;
            })
        }
    }
}
</script>

<style>

.colab{
    height: 740px;
    width: 100%;
    padding: 20px 25px
}

.title-qs-colab{
    font-size: 30px;
    color: black;
    text-align: center;
}

.colab-box{
    display: flex;
    width: 100%;
    height: 630px;
    flex-direction: column;
    justify-content: center;    
    padding: 0px 65px;
    align-items: flex-start;
}

.colab-box-content-lu{
    height: 210px;
    width: 100%;
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 10px;
}

.colab-box-content-ca{
    height: 210px;
    width: 100%;
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 10px;
}

.colab-box-content-de{
    height: 210px;
    width: 100%;
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 10px;
}

.colab-title{
    height: 20px;
    font-size: 20px;
}

.colab-box-logo-content{
    display: flex;
    align-items: center;
    height: 200px;
    width: 100%;
}

.colab-box-logo{
    display: flex;
    width: 100%;
    flex-direction: column;
    align-items: center;
}

.colab-logo{
    width: 150px;
    padding: 5px 5px;
    box-shadow: 0px 0px 5px 0px #bdbcbc;
}

@media (max-width:480px){

    .colab{
        height: 1730px;
        width: 100%;
        padding: 20px 25px
    }

    .title-qs-colab{
        font-size: 20px;
        color: black;
        text-align: center;
    }

    .colab-box{
        display: flex;
        width: 100%;
        height: 1640px;
        flex-direction: column;
        justify-content: center;    
        padding: 0px 65px;
        align-items: flex-start;
    }

    .colab-box-content-lu{
        height: 1000px;
        width: 100%;
        display: flex;
        flex-direction: column;
        align-items: center;
        padding: 10px;
    }

    .colab-box-content-ca{
        height: 620px;
        width: 100%;
        display: flex;
        flex-direction: column;
        align-items: center;
        padding: 10px;
    }

    .colab-box-content-de{
        height: 210px;
        width: 100%;
        display: flex;
        flex-direction: column;
        align-items: center;
        padding: 10px;
    }

    .colab-box-logo-content{
        display: flex;
        align-items: center;
        height: 200px;
        width: 100%;
        flex-direction: column;
    }

    .colab-box-logo{
        display: flex;
        padding: 10px;
        width: 100%;
        flex-direction: column;
        align-items: center;
    }
}

</style>