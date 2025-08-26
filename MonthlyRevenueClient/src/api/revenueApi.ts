import axios from 'axios'
import type { CompanyRevenueDto } from '../types'

export const getRevenueByCompanyId = async (companyId: string) => {
  console.log('Fetching revenue data for companyId:', companyId)
  const res = await axios.get<CompanyRevenueDto[]>('/api/Revenue/GetData/', {
    params: { companyId }
  })
  return res.data
}
