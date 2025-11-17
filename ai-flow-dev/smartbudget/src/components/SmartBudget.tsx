import React, { useState } from 'react'
import { DollarSign, PlusCircle } from 'lucide-react'
import Dashboard from './dashboard/Dashboard'
import TransactionsList from './transactions/TransactionsList'
import Insights from './insights/Insights'
import TransactionForm from './form/TransactionForm'
import '../styles/global.css'

export default function SmartBudget(){
  const [view, setView] = useState<'dashboard'|'transactions'|'insights'>('dashboard')
  const [showForm, setShowForm] = useState(false)

  return (
    <div className="container">
      <header className="header">
        <div style={{display:'flex',alignItems:'center',gap:12}}>
          <DollarSign size={32} color="#2563eb" />
          <div>
            <h1 style={{margin:0}}>SmartBudget</h1>
            <div className="small">Personal Finance Manager</div>
          </div>
        </div>
        <div style={{display:'flex',gap:8,alignItems:'center'}}>
          <div className="nav" role="navigation" aria-label="Main views">
            <button onClick={()=>setView('dashboard')} className={view==='dashboard' ? 'btn' : ''}>Dashboard</button>
            <button onClick={()=>setView('transactions')} className={view==='transactions' ? 'btn' : ''}>Transactions</button>
            <button onClick={()=>setView('insights')} className={view==='insights' ? 'btn' : ''}>Insights</button>
          </div>
          <button className="btn" onClick={()=>setShowForm(s=>!s)}>
            <PlusCircle size={16} style={{marginRight:8}}/> Add
          </button>
        </div>
      </header>

      <main style={{marginTop:16}}>
        {showForm && <TransactionForm onClose={()=>setShowForm(false)} />}
        {view === 'dashboard' && <Dashboard />}
        {view === 'transactions' && <TransactionsList />}
        {view === 'insights' && <Insights />}
      </main>
    </div>
  )
}
