<template>
  <div id="app">
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link
      href="https://fonts.googleapis.com/css2?family=Didact+Gothic&display=swap"
      rel="stylesheet"
    />
    <link
      rel="stylesheet"
      href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css"
    />
    <header>
      <div class="logo">
        <router-link :to="{ name: 'Cerasus-Home' }">
          <img class="cerasus" src="./assets/cerasusLogo.png" />
        </router-link>
      </div>
      <div class="desplegable">
        <div class="menu">
          <div class="despliegue">
            <button class="btn">CELEBRACIONES</button>
            <div class="content">
              <div class="column">
                <router-link :to="{ name: 'boda' }" class="btn-a">
                  Bodas
                </router-link>
                <router-link :to="{ name: 'comunion' }" class="btn-a">
                  Comuniones
                </router-link>
                <router-link :to="{ name: 'evento-corporativo' }" class="btn-a">
                  Eventos Corporativos
                </router-link>
              </div>
            </div>
          </div>
          <router-link :to="{ name: 'quienes-somos' }" class="btn">
            QUIENES SOMOS
          </router-link>
          <router-link :to="{ name: 'contacto' }" class="btn">
            CONTACTO
          </router-link>
        </div>
      </div>
    </header>
    <router-view />
    <div class="newsletter">
      <div class="newsletter-title">
        <p>
          <b>NEWSLETTER</b><br />
          Subscribete a nuestra newsletter y te mandaremos nuevas noticias
        </p>
      </div>
      <form class="newsletter-form" name="newsletter">
        <input type="text" id="search" placeholder="Email" required v-model="newsletter.correo" />
        <button id="button" v-on:click="enviarNewsletter()">Enviar</button>
      </form>
    </div>
    <div class="footer">
      <div class="politica">
        <p>Politica de privacidad</p>
      </div>
      <div class="logo-footer">
        <router-link :to="{ name: 'Cerasus-Home' }">
          <img class="size-logo-footer" src="./assets/cerasusLogo.png" />
        </router-link>
      </div>
      <div class="redes">
        <a
          target="_blank"
          title="Cerasus-Instagram"
          href="https://www.instagram.com/cerasus_eventos/"
          ><img class="size-logo" src="./assets/redesSociales/inst.png"
        /></a>
        <a
          target="_blank"
          title="Cerasus-Pinterest"
          href="https://www.pinterest.es/cerasuseventos/_saved/"
          ><img class="size-logo" src="./assets/redesSociales/pinterest.png"
        /></a>
      </div>
    </div>
  </div>
</template>

<script>
import newsletterServices from "./services/newsletterServices";

export default {
  data() {
    return {
      newsletter: {
        correo: ""
      }
    }
  },
  methods: {
    enviarNewsletter() {
      newsletterServices.getNewsletter(this.newsletter).then((response) => {
        console.log(response);
      });
    },
  }
};
</script>

<style>

#app{
  font-family: "Didact Gothic", sans-serif;
}

header {
  display: flex !important;
  width: 100%;
  height: 140px;
}

.logo {
  display: flex;
  width: 30%;
  align-items: center;
  justify-content: center;
}

img.cerasus {
  width: 280px;
  cursor: pointer;
}

.desplegable {
  width: 70%;
  justify-content: center;
  display: flex;
  align-items: center;
}

.menu a {
  float: left;
  font-size: 16px;
  color: white;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
}

.menu {
  display: flex;
  align-items: center;
}

.despliegue .btn-a {
  text-decoration: none;
  color: black;
}

.menu .btn {
  color: black;
  font-size: 20px;
  padding: 10px 20px;
}

.content {
  display: none;
  position: absolute;
  background-color: #f9f9f9;
  width: 185px;
  box-shadow: 0px 8px 16px 0px rgba(0, 0, 0, 0.2);
}

.despliegue:hover .content {
  display: block;
}

.column {
  height: 168px;
}

.column a {
  float: none;
  color: black;
  padding: 16px;
  text-decoration: none;
  display: block;
  cursor: pointer;
}

.column a:hover {
  background-color: #f1e6f9;
}

.newsletter {
  display: block;
  width: 100%;
  height: 195px;
  background-color: rgb(241 230 249);
}

.newsletter-title {
  display: flex;
  justify-content: center;
  text-align: center;
  padding-top: 30px;
  font-size: 20px;
}

.newsletter-form {
  display: flex;
  justify-content: center;
}

#search {
  width: 400px;
  height: 40px;
  background: white;
  border: none;
  font-size: 15px;
  padding-left: 10px;
  border-radius: 5px 0px 0px 5px;
}

#button {
  width: 90px;
  height: 40px;
  border: none;
  background: black;
  font-size: 15px;
  color: white;
  border-radius: 0px 5px 5px 0px;
}

.footer {
  display: flex;
  width: 100%;
  height: 110px;
  align-items: center;
  justify-content: center;
}

.politica {
  display: flex;
  width: 35%;
  height: 100px;
  text-align: center;
  align-items: center;
  margin-left: 20px;
}

.logo-footer {
  display: flex;
  justify-content: center;
  width: 30%;
}

.size-logo-footer {
  width: 65%;
}

.redes {
  display: flex;
  justify-content: flex-end;
  margin-right: 20px;
  width: 25%;
}

.size-logo {
  width: 55px;
  padding: 10px;
}

@media (max-width:480px){

  header {
    display: flex !important;
    width: 100%;
    height: 70px;
  }

  .logo {
    display: flex;
    width: 30%;
    align-items: center;
    justify-content: center;
  }

  img.cerasus {
    width: 105px;
    cursor: pointer;
  }

  .desplegable {
    width: 70%;
    justify-content: center;
    display: flex;
    align-items: center;
  }

  .menu a {
    float: left;
    font-size: 10px;
    color: white;
    text-align: center;
    padding: 0px 5px;
    text-decoration: none;
  }

  .menu .btn {
    color: black;
    font-size: 10px;
    padding: 10px 5px;
  }

  .content {
    display: none;
    position: absolute;
    background-color: #f9f9f9;
    width: 90px;
    box-shadow: 0px 8px 16px 0px rgba(0, 0, 0, 0.2);
  }

  .column {
    height: 120px;
  }

  .column a {
    float: none;
    color: black;
    padding: 10px;
    text-decoration: none;
    display: block;
    cursor: pointer;
  }

  .newsletter-title {
    display: flex;
    justify-content: center;
    text-align: center;
    padding: 30px 30px 0px 30px;
    font-size: 18px;
  }

  #search {
    width: 220px;
    height: 40px;
    background: white;
    border: none;
    font-size: 15px;
    padding-left: 10px;
    border-radius: 5px 0px 0px 5px;
  }

  #button {
    width: 70px;
    height: 40px;
    border: none;
    background: black;
    font-size: 15px;
    color: white;
    border-radius: 0px 5px 5px 0px;
  }

  .footer {
    display: flex;
    width: 100%;
    height: 90px;
    align-items: center;
    justify-content: center;
  }

  .politica {
    display: flex;
    width: 33%;
    text-align: center;
    margin: 20px 0px 0px 0px;
    align-items: center;
    font-size: 12px;
    justify-content: center;
  }

  .logo-footer {
    display: flex;
    justify-content: center;
    width: 33%;
  }

  .size-logo-footer {
    width: 100%;
  }

  .redes {
    display: flex;
    justify-content: center;
    margin: 0px 0px 0px 0px;
    width: 33%;
  }

  .size-logo {
    width: 45px;
    padding: 10px;
  }
}
</style>
