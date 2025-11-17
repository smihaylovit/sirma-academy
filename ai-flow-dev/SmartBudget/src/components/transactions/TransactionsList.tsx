import React from 'react'
import useTransactions from '../../hooks/useTransactions'
import { TrendingUp, TrendingDown, Trash2, Edit2 } from 'lucide-react'
import type { Transaction } from '../../types/transaction'

export default function TransactionsList(){
  const { transactions, remove } = useTransactions()

  return (
    <div className="card">
      <h3>Transaction History</h3>
      {transactions.length === 0 ? (
        <div className="small">No transactions yet. Add one to get started.</div>
      ) : (
        <div style={{display:'grid',gap:8,marginTop:8}}>
          {transactions.map((t:Transaction)=>(
            <div key={t.id} className="transaction">
              <div style={{display:'flex',gap:12,alignItems:'center'}}>
                <div style={{width:44,height:44,display:'flex',alignItems:'center',justifyContent:'center',borderRadius:12,background:t.type==='income'?'#ecfdf5':'#fff1f2'}}>
                  {t.type === 'income' ? <TrendingUp color="#059669" /> : <TrendingDown color="#dc2626" />}
                </div>
                <div>
                  <div style={{fontWeight:600}}>{t.category}</div>
                  <div className="small">{t.description || 'No description'}</div>
                  <div className="small">{t.date}</div>
                </div>
              </div>
              <div style={{display:'flex',alignItems:'center',gap:12}}>
                <div style={{fontWeight:700, color: t.type==='income' ? '#059669' : '#dc2626'}}>
                  {t.type === 'income' ? '+' : '-'}${t.amount.toFixed(2)}
                </div>
                <div style={{display:'flex',gap:8}}>
                  <button title="Edit" aria-label="Edit"><Edit2 /></button>
                  <button onClick={()=> remove(t.id)} title="Delete" aria-label="Delete"><Trash2 /></button>
                </div>
              </div>
            </div>
          ))}
        </div>
      )}
    </div>
  )
}
