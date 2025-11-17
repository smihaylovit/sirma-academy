import { useEffect, useState } from 'react'
import type { Transaction } from '../types/transaction'

const PREFIX = 'transaction:'

export default function useTransactions(){
  const [transactions, setTransactions] = useState<Transaction[]>([])
  const [loaded, setLoaded] = useState(false)

  useEffect(()=>{
    load()
  },[])

  async function load(){
    try{
      // try to use window.storage if available (from your previous app), otherwise use localStorage fallback
      if((window as any).storage && (window as any).storage.list){
        const result = await (window as any).storage.list(PREFIX)
        if(result && result.keys){
          const loaded = await Promise.all(result.keys.map(async (k:string) => {
            try{
              const v = await (window as any).storage.get(k)
              return v ? JSON.parse(v.value) as Transaction : null
            }catch{ return null }
          }))
          setTransactions(loaded.filter(Boolean) as Transaction[])
        }
      } else {
        // fallback to localStorage
        const keys = Object.keys(localStorage).filter(k => k.startsWith(PREFIX))
        const loaded = keys.map(k => {
          try{ return JSON.parse(localStorage.getItem(k) || '') as Transaction }catch{ return null }
        }).filter(Boolean) as Transaction[]
        setTransactions(loaded)
      }
    }catch(e){
      console.error('Failed to load transactions', e)
    }finally{
      setLoaded(true)
    }
  }

  async function save(tx: Transaction){
    try{
      if((window as any).storage && (window as any).storage.set){
        await (window as any).storage.set(PREFIX + tx.id, JSON.stringify(tx))
      } else {
        localStorage.setItem(PREFIX + tx.id, JSON.stringify(tx))
      }
      setTransactions(prev => [tx, ...prev.filter(p => p.id !== tx.id)].sort((a,b)=> b.date.localeCompare(a.date)))
    }catch(e){
      console.error('save failed', e)
    }
  }

  async function remove(id: string){
    try{
      if((window as any).storage && (window as any).storage.delete){
        await (window as any).storage.delete(PREFIX + id)
      } else {
        localStorage.removeItem(PREFIX + id)
      }
      setTransactions(prev => prev.filter(t => t.id !== id))
    }catch(e){
      console.error('delete failed', e)
    }
  }

  return { transactions, loaded, save, remove, reload: load }
}
