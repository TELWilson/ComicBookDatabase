<template>
  <table id="tblUsers">
    <thead>
      <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Username</th>
        <th>Email Address</th>
        <th>Status</th>
      </tr>
    </thead>
    <tbody>
      <tr>
        <td><input type="text" id="firstNameFilter" v-model="filt.firstName"/></td>
        <td><input type="text" id="lastNameFilter" v-model="filt.lastName"/></td>
        <td><input type="text" id="usernameFilter" v-model="filt.username"/></td>
        <td><input type="text" id="emailFilter" v-model="filt.emailAddress"/></td>
        <td>
          <select id="statusFilter" v-model="filt.status">
            <option value="">Show All</option>
            <option value="Active">Active</option>
            <option value="Disabled">Disabled</option>
          </select>
        </td>
      </tr>
      <tr v-for="user of filterUsers" v-bind:key="user.username"
      v-bind:class="{disabled: user.status === 'Disabled'}">
        <td>{{user.firstName}}</td>
        <td>{{user.lastName}}</td>
        <td>{{user.username}}</td>
        <td>{{user.emailAddress}}</td>
        <td>{{user.status}}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
export default {
  name: 'user-list',
  computed: {
    filterUsers(){
      let user = this.users;

      if(this.filt.firstName){
        user = user.filter(n => n.firstName.toLowerCase().includes(this.filt.firstName.toLowerCase()));
      }

      if(this.filt.lastName){
        user = user.filter(n => n.lastName.toLowerCase().includes(this.filt.lastName.toLowerCase()));
      }

      if(this.filt.username){
        user = user.filter(n => n.username.toLowerCase().includes(this.filt.username.toLowerCase()));
      }

      if(this.filt.emailAddress){
        user = user.filter(n => n.emailAddress.toLowerCase().includes(this.filt.emailAddress.toLowerCase()));
      }

      if(this.filt.status){
        user = user.filter(n => n.status ===this.filt.status);
      }
      
      return user;
    },
  },
  data() {
    return {
      filt: {
        firstName: '',
        lastName: '',
        username: '',
        emailAddress: '',
        status: '',
      },
      users: [
        { firstName: 'John', lastName: 'Smith', username: 'jsmith', emailAddress: 'jsmith@gmail.com', status: 'Active' },
        { firstName: 'Anna', lastName: 'Bell', username: 'abell', emailAddress: 'abell@yahoo.com', status: 'Active' },
        { firstName: 'George', lastName: 'Best', username: 'gbest', emailAddress: 'gbest@gmail.com', status: 'Disabled' },
        { firstName: 'Ben', lastName: 'Carter', username: 'bcarter', emailAddress: 'bcarter@gmail.com', status: 'Active' },
        { firstName: 'Katie', lastName: 'Jackson', username: 'kjackson', emailAddress: 'kjackson@yahoo.com', status: 'Active' },
        { firstName: 'Mark', lastName: 'Smith', username: 'msmith', emailAddress: 'msmith@foo.com', status: 'Disabled' }
      ]
    }
  }
}
</script>

<style scoped>
table {
  margin-top: 20px;
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen,
    Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
}
th {
  text-transform: uppercase;
}
td {
  padding: 10px;
}
tr.disabled {
  color: red;
}
input,
select {
  font-size: 16px;
}
</style>
