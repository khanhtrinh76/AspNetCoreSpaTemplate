<template>
    <div>
      <div class="sub-title"><span>Search Results for <span class="search-term">{{q}}</span></span></div>
      <div>
        <b-table 
          mobile-cards
          narrowed
          :data="records"
          :paginated="true"
          :per-page="recordOps.pageSize"
          :current-page="recordOps.pageIndex"
          pagination-size="is-small"
          class="details-grid"
          detailed
          detail-key="firstName"
          :row-class="(row, index) => row.id === 1 && 'is-info'">>

          <template slot-scope="props">
            <b-table-column label="Name" field="name" sortable class="first">
              <span class="display-label">{{ props.row.firstName }}&nbsp;{{ props.row.lastName }}</span>
            </b-table-column>
            <b-table-column label="Company" field="company" sortable>
              <span class="display-label">{{ props.row.companyName }}</span>
            </b-table-column>
            <b-table-column label="Address" field="address" sortable>
              <span class="display-label">{{ props.row.address }},&nbsp;{{ props.row.city }},&nbsp;{{ props.row.state }},&nbsp;{{ props.row.post }}</span>
            </b-table-column>
            <b-table-column label="Email" field="email" sortable>
              <span class="display-label">{{ props.row.email }}</span>
            </b-table-column>
            <b-table-column label="Phone1" field="phone1" sortable>
              <span class="display-label">{{ props.row.phone1 }}</span>
            </b-table-column>
          </template>

          <template slot="detail" slot-scope="props">
            <article class="media">
              <div class="media-content">
                <div class="content">
                  <p><strong>{{ props.row.firstName }}&nbsp;{{ props.row.lastName }}</strong>,&nbsp;<small>{{ props.row.companyName }}</small></p>
                  <p><span class="detail-title">Phone Nos:</span>&nbsp;<span>{{ props.row.phone1 }}&nbsp;,&nbsp;{{ props.row.phone2 }}</span></p>
                  <p><span class="detail-title">Address:</span>&nbsp;<span>{{ props.row.address }},&nbsp;{{ props.row.city }},&nbsp;{{ props.row.state }}&nbsp;-&nbsp;{{ props.row.post }}</span></p>
                  <p><span class="detail-title">Emails:</span>&nbsp;<span>{{ props.row.email }}</span></p>
                  <a :href="props.row.web">{{ props.row.web }}</a> 
                </div>
              </div>
            </article>
          </template>

        </b-table>
      </div>
    </div>
</template>

<script>
import Vue from 'vue'
import VueSplitPane from 'vue-splitpane';
import Buefy from 'buefy'
import 'buefy/dist/buefy.css'
import VueResource from 'vue-resource'

Vue.use(Buefy)
Vue.use(VueResource);

export default {
  name: 'search',
  props: ['q'],
  data() {
    return {
      recordOps: {
        sortField: 'firstName',
        sortOrder: 'asc',
        pageSize: 20,
        pageIndex: 1,
      },
      records: [],
    };
  },
  created()
  {
    this.doSearch();
  },
  methods:{
    doSearch() { 
        var vm = this;
        this.$http.get('api/Customer/Search?term='+ vm.q).then(response => {
          vm.records = response.body;

        }, response => {
          // error callback
        });
     }
  },
  watch:{
     q(val) {
      if (val) {
        this.doSearch();
      }
    }
  }
};
</script>
