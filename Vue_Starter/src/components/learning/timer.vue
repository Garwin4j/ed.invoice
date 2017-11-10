<template>
  <b-container fluid="true">
      <b-row>
          <b-col sm="10">
              <h1>Timer</h1>
              <b-form-input v-model="currentTime" />
              <b-form-input v-model="time" />
          </b-col>
      </b-row>
  </b-container>
</template>

<script>
export default {
  data: function () {
    return {
      currentTime: new Date()
    }
  },
  computed: {
    time: function () {
      return Date()
    }
  }
}
</script>

<style>

</style>
