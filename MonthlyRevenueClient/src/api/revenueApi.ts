import axios from 'axios'
import type { CompanyRevenueDto } from '../types'

export const getRevenueByCompanyId = async (companyId: string) => {
  const res = await axios.get<CompanyRevenueDto[]>('/api/Revenue/GetData/' + companyId)
  return res.data
}
