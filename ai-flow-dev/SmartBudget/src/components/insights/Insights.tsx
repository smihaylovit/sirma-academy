import React from 'react'
import useTransactions from '../../hooks/useTransactions'
import { totals, expenseByCategory } from '../../utils/budgetCalculations'

export default function Insights(){
  const { transactions } = useTransactions()
  const { totalIncome, totalExpense, balance } = totals(transactions)
  const byCat = expenseByCategory(transactions)
  const suggestions: string[] = []

  if(totalIncome > 0 && totalExpense > totalIncome * 0.9){
    suggestions.push(`High spending: you're using ${(totalExpense/totalIncome*100).toFixed(0)}% of income.`)
  }
  const biggest = Object.entries(byCat).sort((a,b)=> b[1]-a[1])[0]
  if(biggest && biggest[1] > totalExpense * 0.3){
    suggestions.push(`${biggest[0]} is your largest expense (${((biggest[1]/totalExpense)*100).toFixed(0)}%).`)
  }
  if(balance > totalIncome * 0.2){
    suggestions.push(`Good: you're saving ${((balance/totalIncome)*100).toFixed(0)}% of income.`)
  }

  return (
    <div className="card">
      <h3>AI Budget Insights</h3>
      {suggestions.length === 0 ? <div className="small">Add more transactions to receive insights.</div> : (
        <div style={{display:'grid',gap:8}}>
          {suggestions.map((s, i)=> <div key={i} style={{padding:12, borderRadius:8, background:'#f8fafc'}}>{s}</div>)}
        </div>
      )}
    </div>
  )
}
