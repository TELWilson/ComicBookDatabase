<template>
  <section>
    <input type="submit" value="Add Book" v-on:click.prevent="addNewBook()" />
    <form>
      <div class="form-element">
        <label for="title">Title:</label>
        <input id="title" type="text" v-model.trim="newBook.title" />
      </div>
      <div class="form-element">
          <label for="author">Author:</label>
          <input id="author" type="text" v-model.trim="newBook.author" />
      </div>
      <div class="form-element">
          <label for="isbn">ISBN:</label>
          <input id="isbn" type="text" v-model.trim="newBook.isbn" />
      </div>
      
    </form>
  </section>
</template>

<script>
export default {
  name: "AddBookForm",
  data() {
    return {
      newBook: {
        title: "",
        author: "",
        isbn: "",
      },
    };
  },
  methods: {
    addNewBook() {
      this.$store.commit("ADD_BOOK", this.newBook);
      this.newBook = {
        title: "",
        author: "",
        isbn: "",
      };
    },
  },
};
</script>

<style>
</style>