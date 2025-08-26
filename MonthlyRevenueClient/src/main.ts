import { createApp } from 'vue'
import './style.css'
import App from './App.vue'
import axios from 'axios'

axios.defaults.baseURL = 'https://localhost:7138'

createApp(App).mount('#app')
