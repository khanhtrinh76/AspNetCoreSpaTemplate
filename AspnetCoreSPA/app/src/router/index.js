import Vue from 'vue'
import Router from 'vue-router'
import HomeView from '../views/HomeView'
import ContactView from '../views/ContactView'
import SearchView from '../views/SearchView'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      component: HomeView,
      children: [

        // Contact
        {
          path: '',
          name: 'contact',
          component: ContactView,
          children: [
          ]
        },

         // Search
         {
          path: '/search/:q?',
          name: 'search',
          component: SearchView,
          props: true,
          children: [
          ]
        }
      ]
    },

    // Default redirect
    {
      path: '*',
      redirect: '/'
    }
  ]
})
