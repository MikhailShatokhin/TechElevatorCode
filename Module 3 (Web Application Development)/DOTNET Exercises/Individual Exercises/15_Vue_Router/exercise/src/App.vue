<template>
<nav>
  <div id="app">
    <div id="nav">
      <!-- <router-link v-bind:to="{name: 'Home'}">Home</router-link> | -->
      <router-link to="/">Home</router-link> |
      <router-link to="/myBooks">My Books</router-link> |
      <router-link to="/addBook">Add Book</router-link>
      </div>
      <router-view/>
  </div>
</nav>
</template>

<script>

export default {
  name: 'app'
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin: 60px;
}
</style>
