import React, { useState } from 'react'
import type { Transaction } from '../../types/transaction'
import useTransactions from '../../hooks/useTransactions'

const categories = {
  income: ['Salary','Freelance','Investment','Gift','Other'],
  expense: ['Rent','Transport','Food','Entertainment','Healthcare','Shopping','Utilities','Other']
}

export default function TransactionForm({ onClose }: { onClose?: ()=>void }){
  const { save } = useTransactions()
  const [form, setForm] = useState<Partial<Transaction>>({
    type: 'expense',
    amount: 0,
    category: '',
    description: '',
    date: new Date().toISOString().split('T')[0]
  })

  function update<K extends keyof Transaction>(k:K, v:any){
    setForm(prev => ({ ...prev, [k]: v }))
  }

  async function submit(e: React.FormEvent){
    e.preventDefault()
    if(!form.amount || !form.category) return alert('Amount and category required')
    const tx: Transaction = {
      id: (Date.now()).toString(),
      type: form.type as any,
      amount: Number(form.amount),
      category: form.category || 'Other',
      description: form.description || '',
      date: form.date || new Date().toISOString().split('T')[0]
    }
    await save(tx)
    if(onClose) onClose()
  }

  return (
    <div style={{marginBottom:12}} className="card">
      <form onSubmit={submit}>
        <div className="form-row">
          <select value={form.type} onChange={e=> update('type', e.target.value as any)}>
            <option value="income">Income</option>
            <option value="expense">Expense</option>
          </select>
          <input type="number" step="0.01" value={form.amount || ''} onChange={e=> update('amount', e.target.value)} placeholder="Amount" />
          <select value={form.category} onChange={e=> update('category', e.target.value)}>
            <option value="">Select category</option>
            {(categories[form.type || 'expense'] || []).map(c=> <option key={c} value={c}>{c}</option>)}
          </select>
        </div>
        <div style={{marginBottom:8}}>
          <input type="date" value={form.date} onChange={e=> update('date', e.target.value)} />
        </div>
        <div style={{marginBottom:8}}>
          <input placeholder="Description (optional)" value={form.description} onChange={e=> update('description', e.target.value)} />
        </div>
        <div className="actions">
          <button type="submit" className="btn">Save</button>
          <button type="button" onClick={()=> onClose && onClose() } style={{padding:'10px 12px',borderRadius:8}}>Cancel</button>
        </div>
      </form>
    </div>
  )
}
