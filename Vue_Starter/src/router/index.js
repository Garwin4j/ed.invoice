import Vue from 'vue'
import Router from 'vue-router'

// Containers
import Full from '@/containers/Full'
import timer from '../components/learning/timer.vue'

// Views
import Dashboard from '@/views/Dashboard'

Vue.use(Router)

export default new Router({
  mode: 'hash',
  linkActiveClass: 'open active',
  scrollBehavior: () => ({ y: 0 }),
  routes: [
    {
      path: '/',
      redirect: '/dashboard',
      name: 'Home',
      component: Full,
      children: [
        {
          path: 'dashboard',
          name: 'Dashboard',
          component: Dashboard
        },
        {
          path: '/timer',
          name: 'Timer',
          component: timer
        }

      ]
    }
  ]
})
