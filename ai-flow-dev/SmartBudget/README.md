# SmartBudget - Personal Finance Manager

A modern, AI-powered personal finance management application built following the BMAD (Breakthrough Method for Agile Development) methodology.

## 🚀 Features

- ✅ Add, edit, and delete income/expense transactions
- 📊 Visual analytics with interactive charts
- 🏷️ Transaction categorization
- 💡 AI-powered budget insights and recommendations
- 📱 Responsive design for all devices
- 💾 Persistent data storage
- 📈 Monthly trend analysis
- 🎯 Real-time balance tracking

## 🛠️ Tech Stack

- **Frontend**: React 18
- **UI Components**: Lucide React (icons)
- **Charts**: Recharts
- **Styling**: Tailwind CSS
- **Storage**: Browser Persistent Storage API
- **Development**: Claude AI-assisted development

## What's included

- TypeScript + React + Vite setup
- Components split into:
  - `components/SmartBudget.tsx`
  - `components/form/TransactionForm.tsx`
  - `components/transactions/TransactionsList.tsx`
  - `components/dashboard/Dashboard.tsx`
  - `components/insights/Insights.tsx`
- `hooks/useTransactions.ts` — handles storage (supports `window.storage` or `localStorage` fallback)
- `utils/budgetCalculations.ts` — totals, category breakdown, monthly series
- Basic CSS in `src/styles/global.css`

## 📦 Installation & Setup

### Prerequisites
- Node.js (v16 or higher)
- npm or yarn

### Steps to run locally

1. **Go to the app folder**
```bash
cd SmartBudget
```

2. **Install dependencies**
```bash
npm install
```

3. **Start the development server**
```bash
npm run dev
```

4. **Open your browser**
Navigate to `http://localhost:5173`

## 📖 Usage Guide

### Adding Transactions
1. Click the "Add Transaction" button
2. Select type (Income/Expense)
3. Enter amount, category, date, and optional description
4. Click "Add Transaction" to save

### Viewing Analytics
- **Dashboard**: Overview of total income, expenses, balance, and trends
- **Transactions**: Complete transaction history with edit/delete options
- **Insights**: AI-powered budget recommendations

### Managing Transactions
- **Edit**: Click the edit icon on any transaction
- **Delete**: Click the delete icon to remove a transaction

## 🎯 BMAD Methodology

This project was developed using the BMAD methodology:
- **Analysis**: Requirements gathering and user needs assessment
- **Planning**: Architecture design and feature prioritization
- **Solutioning**: Technical implementation strategy
- **Implementation**: Iterative development with AI assistance

See the `/docs` folder for detailed BMAD phase documentation.

## 🤖 AI Assistance

This project was developed with Claude AI assistance for:
- Code generation and optimization
- Bug fixing and debugging
- Documentation creation
- Best practices implementation

## 📝 License

MIT License - feel free to use this project for learning purposes.

## 👨‍💻 Author

[Stoyan Mihaylov] - AI-First Developer

## 🙏 Acknowledgments

- Built with Claude AI (Anthropic)
- Inspired by modern personal finance applications
- BMAD methodology framework