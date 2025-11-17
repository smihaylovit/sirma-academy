import type { Transaction } from '../types/transaction'

export function totals(transactions: Transaction[]){
  const totalIncome = transactions.filter(t=>t.type==='income').reduce((s,t)=>s + t.amount,0)
  const totalExpense = transactions.filter(t=>t.type==='expense').reduce((s,t)=>s + t.amount,0)
  return { totalIncome, totalExpense, balance: totalIncome - totalExpense }
}

export function expenseByCategory(transactions: Transaction[]){
  return transactions.filter(t=>t.type==='expense').reduce<Record<string,number>>((acc,t)=>{
    acc[t.category] = (acc[t.category] || 0) + t.amount
    return acc
  }, {})
}

export function monthlySeries(transactions: Transaction[]){
  const map: Record<string,{month:string,income:number,expense:number}> = {}
  transactions.forEach(t=>{
    const month = t.date.substring(0,7)
    if(!map[month]) map[month] = { month, income:0, expense:0 }
    if(t.type === 'income') map[month].income += t.amount
    else map[month].expense += t.amount
  })
  return Object.values(map).sort((a,b)=> a.month.localeCompare(b.month))
}
