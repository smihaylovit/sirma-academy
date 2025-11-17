import React from 'react'
import useTransactions from '../../hooks/useTransactions'
import { totals, monthlySeries, expenseByCategory } from '../../utils/budgetCalculations'
import { LineChart, Line, CartesianGrid, XAxis, YAxis, Tooltip, Legend, ResponsiveContainer, PieChart, Pie, Cell } from 'recharts'

const COLORS = ['#3b82f6', '#10b981', '#f59e0b', '#ef4444', '#8b5cf6', '#ec4899', '#14b8a6', '#f97316']

export default function Dashboard(){
  const { transactions } = useTransactions()
  const { totalIncome, totalExpense, balance } = totals(transactions)
  const chartData = monthlySeries(transactions)
  const expenseMap = expenseByCategory(transactions)
  const pieData = Object.entries(expenseMap).map(([name,value])=>({ name, value }))

  return (
    <div style={{display:'grid',gap:16}}>
      <div className="grid cols-3">
        <div className="card">
          <div className="small">Total Income</div>
          <div style={{fontSize:24,fontWeight:700,color:'#059669'}}>${totalIncome.toFixed(2)}</div>
        </div>
        <div className="card">
          <div className="small">Total Expenses</div>
          <div style={{fontSize:24,fontWeight:700,color:'#dc2626'}}>${totalExpense.toFixed(2)}</div>
        </div>
        <div className="card">
          <div className="small">Balance</div>
          <div style={{fontSize:24,fontWeight:700,color:'#2563eb'}}>${balance.toFixed(2)}</div>
        </div>
      </div>

      <div style={{display:'grid',gridTemplateColumns:'1fr 1fr',gap:16}}>
        <div className="card">
          <h4>Monthly Trends</h4>
          <div style={{height:280}}>
            <ResponsiveContainer width="100%" height="100%">
              <LineChart data={chartData}>
                <CartesianGrid strokeDasharray="3 3" />
                <XAxis dataKey="month" />
                <YAxis />
                <Tooltip />
                <Legend />
                <Line type="monotone" dataKey="income" stroke="#10b981" strokeWidth={2}/>
                <Line type="monotone" dataKey="expense" stroke="#ef4444" strokeWidth={2}/>
              </LineChart>
            </ResponsiveContainer>
          </div>
        </div>

        <div className="card">
          <h4>Expenses by Category</h4>
          <div style={{height:280}}>
            <ResponsiveContainer width="100%" height="100%">
              <PieChart>
                <Pie data={pieData} dataKey="value" outerRadius={80} label>
                  {pieData.map((entry, idx)=> <Cell key={idx} fill={COLORS[idx % COLORS.length]} />)}
                </Pie>
              </PieChart>
            </ResponsiveContainer>
          </div>
        </div>
      </div>
    </div>
  )
}
