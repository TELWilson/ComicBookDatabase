<template>
  <div>
    <reading-list />
    <nav>
        <router-link v-bind:to="{name: 'add-book'}">
            Add book to reading list
        </router-link>
    </nav>
  </div>
</template>

<script>
import ReadingList from "@/components/ReadingList.vue";

export default {
  name: "my-books",
  components: {
    ReadingList,
  },
};
</script>

<style>
</style>