<template>
  <div class="home">
      <best-seller-list/>
        <new-releases-list/>
  </div>
</template>

<script>
import NewReleasesList from "../components/NewReleasesList.vue";
import BestSellerList from "../components/BestSellerList.vue";
export default{
  components: { BestSellerList, NewReleasesList } ,
};
</script>

<style>

</style>