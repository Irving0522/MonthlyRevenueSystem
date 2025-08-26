<template>
  <div class="revenue-search">
    <h2>公司營收查詢</h2>

    <div class="form">
      <input v-model="companyId" placeholder="請輸入公司代號" />
      <button @click="fetchData" :disabled="loading">查詢</button>
    </div>

    <p v-if="totalCount">共 {{ totalCount }} 筆資料</p>
    <p v-if="error" class="error">{{ error }}</p>

    <table v-if="revenues.length">
      <thead>
        <tr>
          <th>年月</th>
          <th>當月營收</th>
          <th>去年同月營收</th>
          <th>去年同月增減(%)</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in revenues" :key="item.dataYearMonth">
          <td>{{ item.dataYearMonth }}</td>
          <td>{{ item.monthlyRevenue }}</td>
          <td>{{ item.lastYearRevenue }}</td>
          <td>{{ formatPercent(item.yoYGrowthPercent) }}</td>
        </tr>
      </tbody>
    </table>

  </div>
</template>

<script setup lang="ts">
import { ref, computed } from "vue";
import { getRevenueByCompanyId } from "../api/revenueApi";
import type { CompanyRevenueDto } from "../types/index";

const companyId = ref("");
const revenues = ref<CompanyRevenueDto[]>([]);
const loading = ref(false);
const error = ref("");

const totalCount = computed(() => revenues.value.length);

const fetchData = async () => {
  if (!companyId.value) {
    error.value = "請輸入公司代號";
    return;
  }

  loading.value = true;
  error.value = "";
  try {
    revenues.value = await getRevenueByCompanyId(companyId.value);
  } catch (err: any) {
    error.value = err?.message || "查詢失敗";
  } finally {
    loading.value = false;
  }
};

const formatPercent = (val: number) => `${val}%`;
</script>

<style scoped>
.revenue-search {
  max-width: 800px;
  margin: auto;
  padding: 20px;
}
.form {
  margin-bottom: 1rem;
}
input {
  padding: 6px 10px;
  margin-right: 10px;
}
button {
  padding: 6px 16px;
}
table {
  width: 100%;
  border-collapse: collapse;
}
th,
td {
  border: 1px solid #ccc;
  padding: 8px;
}
.error {
  color: red;
}
</style>
