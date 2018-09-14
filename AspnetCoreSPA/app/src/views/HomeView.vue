<template>
  <div class="container">
    <div class="level">
      <div class="level-item has-text-centered">
        <router-link :to="{name: 'contact'}" >
          <span>Acme Contact Management</span>
        </router-link>
      </div>
      <div class="level-right">
        <b-field>
          <b-input placeholder="Type and press Enter..."
            icon="magnify"
            type="search"
            v-model="searchTerm"
            rounded
             @keypress.native.enter="search">
          </b-input >
        </b-field>
      </div>
    </div>
    <div>
        <router-view/>
      </div> 
  </div>
</template>

<script>

import Vue from 'vue'

export default {
  components: {
    [ContactList.name]: ContactList,
  },
  data() {
    return {
      searchTerm: null,
    };
  },
  methods:{
    search() {
      location.href = `#/search/${this.searchTerm || ''}`;
    },
  }
  
};
</script>
