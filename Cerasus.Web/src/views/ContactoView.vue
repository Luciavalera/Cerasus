<template>
    <div class="body-contacto">
        <div class="content-body-contacto">
            <div class="info-contacto">
                <div class="descripcion-contacto">
                    <p>{{contacto[0].descripcion}}</p>
                    <p><b>Teléfono:</b> {{contacto[0].telefono}}</p>
                    <p><b>E-mail:</b> {{contacto[0].correo}}</p>
                    <p>Tambien puedes venir a visitarnos a nuestra oficina en <br><b>{{contacto[0].direccion}}</b></p>
                </div>
                <div class="maps">
                    <iframe class="maps-direccion" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2981.2521762331844!2d-0.8807162!3d41.6502932!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd5914eedfba33db%3A0x3cc35fc955f2c2f1!2sC.%20Isaac%20Peral%2C%203%2C%2050001%20Zaragoza!5e0!3m2!1ses!2ses!4v1654069054740!5m2!1ses!2ses"></iframe>
                </div>
            </div>
            <Formulario/>
        </div>
    </div>      
</template>

<script>
import contactoServices from '../services/contactoServices'
import Formulario from '../components/Formulario.vue'

export default {
    data(){
        return {
            contacto: null
        }
    },
    mounted(){
        this.getContacto()
    },
    methods:{
        getContacto(){
            contactoServices.getContacto().then(response => {
                this.contacto = response.data;
            })
        }
    },
    components: {
        Formulario
    }
}

</script>

<style>

.body-contacto{
    width: 100%;
    height: 700px;
}

.content-body-contacto{
    display: flex;
    height: 695px;
}

.info-contacto{
    display: block;
    width: 55%;
    height: 645px;
}

.descripcion-contacto{
  display: block;
  width: 100%;
  height: 250px;
  font-size: 20px;
  font-family: 'Didact Gothic', sans-serif;
  padding: 40px 0px 0px 40px;
}

.maps{
    width: 100%;
    height: 395px;
}

.maps-direccion{
    width: 695px;
    height: 395px;
    align-items: center;
    border: none;
    padding: 10px 20px 0px 40px;
}

@media (max-width:480px){
    .body-contacto{
        width: 100%;
        height: 1290px;
    }

    .content-body-contacto{
        display: block;
        height: 1270px;
    }

    .info-contacto{
        display: block;
        width: 100%;
        height: 595px;
    }

    .descripcion-contacto{
        display: block;
        width: 100%;
        height: 195px;
        font-size: 15px;
        font-family: 'Didact Gothic', sans-serif;
        padding: 15px 0px 0px 30px;
    }

    .descripcion-contacto p:first-of-type{
        font-size: 17px;
    }

    .maps-direccion{
        width: 100%;
        height: 395px;
        align-items: center;
        border: none;
        padding: 10px 30px 0px 30px;
    }
}

</style>