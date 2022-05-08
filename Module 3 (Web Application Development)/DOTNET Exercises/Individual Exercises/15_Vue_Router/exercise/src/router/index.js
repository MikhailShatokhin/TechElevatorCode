import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '@/views/Home';
import ReadingList from '@/views/MyBooks.vue';
import NewBookForm from '@/views/NewBook.vue';
import BookDetails from '@/views/Book.vue';
Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'home',
    component: Home,
  },
  {
    path: '/myBooks',
    name: 'myBooks',
    component: ReadingList,
  },
  {
    path: '/addBook',
    name: 'addBook',
    component: NewBookForm,
  },
  {
    path: '/book/:isbn',
    name: 'book',
    component: BookDetails,
  }

];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
