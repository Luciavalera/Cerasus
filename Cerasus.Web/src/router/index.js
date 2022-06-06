import Vue from 'vue'
import VueRouter from 'vue-router'
import CerasusView from '../views/CerasusView.vue'
import BodaView from '../views/BodaView.vue'
import ComunionView from '../views/ComunionView.vue'
import EventoCorporativoView from '../views/EventoCorporativoView.vue'
import QuienesSomosView from '../views/QuienesSomosView.vue'
import ContactoView from '../views/ContactoView.vue'
import AdminView from '../views/AdminView.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    redirect: {
      name: 'Cerasus-Home'
    }
  },
  {
    path: '/home',
    name: 'Cerasus-Home',
    component: CerasusView
  },
  {
    path: '/boda',
    name: 'boda',
    component: BodaView
  },
  {
    path: '/comunion',
    name: 'comunion',
    component: ComunionView
  }, 
  {
    path: '/evento-corporativo',
    name: 'evento-corporativo',
    component: EventoCorporativoView
  }, 
  {
    path: '/quienes-somos',
    name: 'quienes-somos',
    component: QuienesSomosView
  }, 
  {
    path: '/contacto',
    name: 'contacto',
    component: ContactoView
  }, 
  {
    path: '/admin',
    name: 'admin',
    component: AdminView
  }
]

const router = new VueRouter({
  mode:'history',
  routes
})

export default router
