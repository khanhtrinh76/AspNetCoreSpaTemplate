<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

.container .level .level-item.has-text-centered span
{
  font-size: 36px;
  font-weight: bold;
  color: darkcyan;
}

.sub-title
{
  font-size: 24px;
  text-align: left;
}

.sub-title span{
  font-weight: bold
}

.media .media-content .content a{
  font-style: italic;
  color:darkcyan;
}

input[type=search]:focus
{
   border-color: darkcyan;
}

tr.detail .media .media-content .content .detail-title
{
  font-style: italic;
  color: lightgrey;

}

table thead th{
  background-color: darkcyan;
  border: none;
}

table thead th .th-wrap{
  color:white;
}

table tbody tr:nth-child(odd) {
    background: white;
    border: none;
}

table tbody tr:nth-child(even) {
    background: rgb(248, 247, 247);
    border: none;
}

table tbody tr td{
  border: none !important;
}

.pagination ul li a.is-current{
  background-color: darkcyan;
  border-color: darkcyan;
}

table tbody tr td:first-child{
  border: none !important;
}

.name
{
  width: 12%;
}

.company
{
  width: 20%;
}

.address
{
  width: 35%;
}

.email
{
  width: 20%;
}

.phone1
{
  width: 9%;
}

.b-table .table tr.detail{
  background-color: white;
  box-shadow: inset 0 1px 3px darkcyan;
  font-size: 14px;
}

.search-term
{
  font-style: italic;
  font-weight: 100 !important;
}

tr.is-info {
        background: #167df0;
        color: #fff;
    }
</style>
