# BMAD Phase 2: Planning

## Project Overview

**Project Name**: SmartBudget - Personal Finance Manager  
**Phase**: Planning  
**Date**: November 2025  
**Methodology**: BMAD (Breakthrough Method for Agile Development)

---

## 1. System Architecture

### High-Level Architecture

```
┌─────────────────────────────────────────────────────────────┐
│                     User Interface Layer                    │
│  ┌────────────┐  ┌────────────┐  ┌─────────────┐          │
│  │ Dashboard  │  │Transaction │  │  Insights   │          │
│  │   View     │  │    View    │  │    View     │          │
│  └────────────┘  └────────────┘  └─────────────┘          │
└─────────────────────────────────────────────────────────────┘
                          │
                          ▼
┌─────────────────────────────────────────────────────────────┐
│                   Application Logic Layer                   │
│  ┌────────────────────────────────────────────────────┐    │
│  │           SmartBudget Component (React)            │    │
│  │  • State Management (useState, useEffect)          │    │
│  │  • Transaction CRUD Operations                     │    │
│  │  • Data Aggregation & Calculations                 │    │
│  │  • AI Insights Algorithm                           │    │
│  └────────────────────────────────────────────────────┘    │
└─────────────────────────────────────────────────────────────┘
                          │
                          ▼
┌─────────────────────────────────────────────────────────────┐
│                    Presentation Layer                       │
│  ┌───────────┐  ┌──────────┐  ┌──────────┐                │
│  │  Recharts │  │  Lucide  │  │ Tailwind │                │
│  │  Charts   │  │   Icons  │  │   CSS    │                │
│  └───────────┘  └──────────┘  └──────────┘                │
└─────────────────────────────────────────────────────────────┘
                          │
                          ▼
┌─────────────────────────────────────────────────────────────┐
│                    Data Persistence Layer                   │
│  ┌────────────────────────────────────────────────────┐    │
│  │         Browser Persistent Storage API             │    │
│  │  • Key-Value Storage (transaction:id)              │    │
│  │  • Async Operations with Error Handling            │    │
│  └────────────────────────────────────────────────────┘    │
└─────────────────────────────────────────────────────────────┘
```

---

## 2. Component Architecture

### Component Hierarchy

```
SmartBudget (Root Component)
│
├── Header
│   ├── Logo & Title
│   └── Add Transaction Button
│
├── Navigation
│   ├── Dashboard Tab
│   ├── Transactions Tab
│   └── Insights Tab
│
├── Transaction Form (Conditional)
│   ├── Type Select
│   ├── Amount Input
│   ├── Category Select
│   ├── Date Input
│   ├── Description Input
│   └── Submit/Cancel Buttons
│
├── Dashboard View (Conditional)
│   ├── Summary Cards
│   │   ├── Total Income Card
│   │   ├── Total Expenses Card
│   │   └── Balance Card
│   ├── Monthly Trends Chart (LineChart)
│   └── Expense Breakdown Chart (PieChart)
│
├── Transactions View (Conditional)
│   └── Transaction List
│       └── Transaction Item (Multiple)
│           ├── Icon & Details
│           ├── Amount Display
│           └── Edit/Delete Buttons
│
└── Insights View (Conditional)
    ├── AI Insights Panel
    │   └── Suggestion Cards (Multiple)
    └── Spending Breakdown Chart (BarChart)
```

---

### Component Specifications

#### 1. SmartBudget (Main Component)
**Responsibility**: Root component managing all application state and logic

**State Variables**:
```javascript
- transactions: Array<Transaction>
- showAddForm: Boolean
- editingId: String | null
- activeView: 'dashboard' | 'transactions' | 'insights'
- formData: TransactionFormData
```

**Key Functions**:
- `loadTransactions()`: Load from storage on mount
- `saveTransaction()`: Persist transaction to storage
- `deleteTransaction()`: Remove transaction from storage
- `handleSubmit()`: Process form submission
- `startEdit()`: Initialize edit mode
- `cancelEdit()`: Reset form state
- `getAISuggestions()`: Generate budget insights

---

#### 2. Header Component (Inline)
**Responsibility**: Display branding and primary action

**Elements**:
- Logo (DollarSign icon)
- Title & Subtitle
- Add Transaction Button

**Interactions**:
- Button click toggles form visibility

---

#### 3. Navigation Component (Inline)
**Responsibility**: Tab navigation between views

**Elements**:
- Dashboard Tab
- Transactions Tab
- Insights Tab

**State**:
- Active view indicator (visual highlight)

---

#### 4. Transaction Form (Inline, Conditional)
**Responsibility**: Add/edit transaction data entry

**Fields**:
- Type: Select (income/expense)
- Amount: Number input (step 0.01)
- Category: Select (dynamic based on type)
- Date: Date input
- Description: Text input (optional)

**Validation**:
- Amount: Required, must be positive number
- Category: Required, must be from predefined list
- Date: Required, valid date format

**Actions**:
- Submit: Save transaction
- Cancel: Close form and reset

---

#### 5. Dashboard View
**Responsibility**: Display financial overview and trends

**Sub-components**:

##### Summary Cards (3)
- **Income Card**: Green, TrendingUp icon, total income
- **Expense Card**: Red, TrendingDown icon, total expenses
- **Balance Card**: Blue, DollarSign icon, net balance

##### Monthly Trends Chart
- **Type**: LineChart (Recharts)
- **Data**: Monthly aggregated income/expense
- **Axes**: Month (X), Amount (Y)
- **Lines**: Income (green), Expense (red)

##### Expense Breakdown Chart
- **Type**: PieChart (Recharts)
- **Data**: Category-grouped expenses
- **Colors**: 8-color palette
- **Labels**: Category names on segments

---

#### 6. Transactions View
**Responsibility**: List all transactions with edit/delete

**Display**:
- Sorted by date (newest first)
- Icon based on type (income/expense)
- Category, description, date
- Amount (color-coded)
- Edit/Delete action buttons

**Empty State**:
- Calendar icon
- "No transactions yet" message

---

#### 7. Insights View
**Responsibility**: AI recommendations and detailed analytics

**Sub-components**:

##### AI Insights Panel
- Warning cards (orange): Overspending alerts
- Info cards (blue): Optimization suggestions
- Success cards (green): Positive reinforcement

##### Spending Breakdown Chart
- **Type**: BarChart (Recharts)
- **Data**: All expense categories
- **Sorting**: Highest to lowest
- **Color**: Blue bars

---

## 3. Data Model

### Transaction Schema

```typescript
interface Transaction {
  id: string;              // Unique identifier (timestamp-based)
  type: 'income' | 'expense';
  amount: number;          // Decimal, positive value
  category: string;        // From predefined categories
  description: string;     // Optional user note
  date: string;            // ISO 8601 format (YYYY-MM-DD)
}
```

### Category Configuration

```typescript
interface Categories {
  income: string[];
  expense: string[];
}

const categories: Categories = {
  income: [
    'Salary',
    'Freelance',
    'Investment',
    'Gift',
    'Other Income'
  ],
  expense: [
    'Rent',
    'Transport',
    'Food',
    'Entertainment',
    'Healthcare',
    'Shopping',
    'Utilities',
    'Other Expense'
  ]
};
```

### Aggregated Data Structures

```typescript
// For Charts
interface MonthlyData {
  month: string;    // YYYY-MM
  income: number;
  expense: number;
}

interface CategoryData {
  name: string;     // Category name
  value: number;    // Total amount
}

// For Insights
interface Suggestion {
  type: 'warning' | 'info' | 'success';
  message: string;
}
```

---

## 4. Data Flow Diagrams

### Transaction Creation Flow

```
User Clicks "Add Transaction"
         ↓
Form Displayed (showAddForm = true)
         ↓
User Enters Data
         ↓
User Clicks "Add Transaction"
         ↓
handleSubmit() Called
         ↓
Form Validation
         ↓
Create Transaction Object (with ID)
         ↓
Update State (setTransactions)
         ↓
Persist to Storage (saveTransaction)
         ↓
Close Form (showAddForm = false)
         ↓
UI Re-renders with New Transaction
```

---

### Transaction Edit Flow

```
User Clicks Edit Icon on Transaction
         ↓
startEdit(transaction) Called
         ↓
Form Pre-filled (setFormData)
         ↓
Edit Mode Set (setEditingId)
         ↓
Form Displayed
         ↓
User Modifies Data
         ↓
User Clicks "Update Transaction"
         ↓
handleSubmit() Called
         ↓
Update Transaction in State
         ↓
Persist to Storage
         ↓
Clear Edit Mode (setEditingId = null)
         ↓
Close Form
         ↓
UI Re-renders with Updated Transaction
```

---

### Data Loading Flow

```
Component Mounts
         ↓
useEffect Hook Triggers
         ↓
loadTransactions() Called
         ↓
window.storage.list('transaction:')
         ↓
Fetch Each Transaction Key
         ↓
Parse JSON Data
         ↓
Filter Out Null Values
         ↓
Sort by Date (Newest First)
         ↓
Update State (setTransactions)
         ↓
Trigger Re-render
         ↓
Display Data in UI
```

---

### AI Insights Generation Flow

```
User Navigates to Insights View
         ↓
getAISuggestions() Called
         ↓
Calculate totalIncome, totalExpense
         ↓
Calculate Spending Ratio
         ↓
If Spending > 90% of Income
    → Create Warning Suggestion
         ↓
Identify Highest Expense Category
         ↓
If Category > 30% of Total Expenses
    → Create Info Suggestion
         ↓
Calculate Balance Ratio
         ↓
If Saving > 20% of Income
    → Create Success Suggestion
         ↓
Return Suggestions Array
         ↓
Render Suggestion Cards
```

---

## 5. Technology Stack

### Frontend Framework
- **React 18**: Component-based UI library
- **React Hooks**: useState, useEffect for state management
- **JSX**: Component templating

### UI Libraries
- **Tailwind CSS**: Utility-first styling framework
- **Lucide React**: Icon library (16KB, tree-shakeable)
- **Recharts**: Composable charting library

### Storage
- **Browser Persistent Storage API**: Key-value storage
- **JSON Serialization**: Data format for storage

### Development Tools
- **Claude AI**: Code generation and debugging
- **Create React App**: Build tooling
- **Git**: Version control
- **GitHub**: Repository hosting

---

## 6. UI/UX Design

### Design Principles
1. **Simplicity**: Clean interface, minimal cognitive load
2. **Clarity**: Clear visual hierarchy, intuitive labels
3. **Responsiveness**: Mobile-first, adaptive layouts
4. **Feedback**: Immediate visual response to all actions
5. **Consistency**: Uniform patterns across all views

---

### Color Palette

```css
/* Primary Colors */
Blue:   #3b82f6  /* Primary actions, links */
Green:  #10b981  /* Income, success, positive */
Red:    #ef4444  /* Expense, warnings, negative */
Orange: #f59e0b  /* Alerts, warnings */
Purple: #8b5cf6  /* Accents */

/* Neutral Colors */
Gray-50:  #f9fafb  /* Backgrounds */
Gray-100: #f3f4f6  /* Secondary backgrounds */
Gray-200: #e5e7eb  /* Borders */
Gray-600: #4b5563  /* Secondary text */
Gray-700: #374151  /* Body text */
Gray-800: #1f2937  /* Headings */

/* Gradients */
Background: from-blue-50 to-indigo-100
```

---

### Typography

```css
/* Headings */
H1: 3xl (30px), bold, gray-800
H2: xl (20px), bold, gray-800
H3: xl (20px), bold, gray-800

/* Body Text */
Body: base (16px), normal, gray-700
Small: sm (14px), normal, gray-600
Extra Small: xs (12px), normal, gray-500

/* Emphasis */
Bold: font-semibold or font-bold
Color Coding: Semantic colors for financial data
```

---

### Layout Specifications

#### Desktop (≥1024px)
- Max Width: 1280px (7xl)
- Grid: 2-column charts, 3-column summary cards
- Spacing: 6 units (24px) between major sections

#### Tablet (768px - 1023px)
- Grid: 2-column summary cards
- Charts: Full width, stacked
- Spacing: 4 units (16px)

#### Mobile (<768px)
- Grid: 1-column all elements
- Cards: Full width
- Font: Slightly reduced for readability
- Touch targets: Minimum 44x44px

---

### Interaction Patterns

#### Buttons
- **Primary**: Blue background, white text, rounded-lg
- **Secondary**: Gray background, gray text, rounded-lg
- **Icon Buttons**: Transparent, hover effect, rounded-lg
- **Hover**: Darker shade transition (200ms)

#### Forms
- **Inputs**: Border, focus ring (blue), rounded-lg
- **Selects**: Native styling, consistent with inputs
- **Labels**: Small, medium weight, gray-700
- **Validation**: Required fields enforced

#### Cards
- **Container**: White background, rounded-lg, shadow-lg
- **Padding**: 6 units (24px)
- **Hover**: Subtle scale or shadow transition

#### Charts
- **Container**: White card background
- **Responsive**: 100% width, fixed height
- **Tooltips**: Auto-display on hover
- **Colors**: Consistent with color palette

---

## 7. Development Timeline

### Sprint 1: Foundation (Day 1)
- ✅ Project setup (Create React App)
- ✅ Git repository initialization
- ✅ Component structure creation
- ✅ Basic UI layout with Tailwind

**Deliverable**: Empty component skeleton

---

### Sprint 2: Core Features (Day 1-2)
- ✅ Transaction form implementation
- ✅ Add transaction functionality
- ✅ State management setup
- ✅ Storage API integration
- ✅ Transaction list view

**Deliverable**: Working CRUD operations

---

### Sprint 3: Visualization (Day 2)
- ✅ Summary cards implementation
- ✅ Recharts integration
- ✅ Line chart (monthly trends)
- ✅ Pie chart (expense breakdown)
- ✅ Bar chart (spending breakdown)

**Deliverable**: Interactive data visualizations

---

### Sprint 4: Polish & Features (Day 2-3)
- ✅ Edit/delete functionality
- ✅ AI insights algorithm
- ✅ Responsive design refinement
- ✅ Error handling
- ✅ Empty states

**Deliverable**: Feature-complete application

---

### Sprint 5: Documentation (Day 3)
- ✅ README.md
- ✅ BMAD documentation
- ✅ Code comments
- ✅ prompts.md
- ✅ summary.md

**Deliverable**: Complete project documentation

---

## 8. Technical Implementation Plan

### File Structure

```
smartbudget/
├── public/
│   ├── index.html
│   └── favicon.ico
├── src/
│   ├── components/
│   │   └── SmartBudget.jsx      # Main component
│   ├── App.js                    # Root application
│   ├── index.js                  # Entry point
│   └── index.css                 # Global styles
├── docs/
│   ├── BMAD_Analysis.md
│   ├── BMAD_Planning.md          # This document
│   ├── BMAD_Solutioning.md
│   └── BMAD_Implementation.md
├── .gitignore
├── package.json
├── prompts.md
├── summary.md
└── README.md
```

---

### Storage Strategy

#### Key Naming Convention
```
transaction:{timestamp-id}
```

Example:
```
transaction:1700000000000
transaction:1700000001234
transaction:1700000002468
```

#### Storage Operations

```javascript
// Save
await window.storage.set('transaction:123', JSON.stringify(transaction));

// Load All
const result = await window.storage.list('transaction:');
const keys = result.keys;

// Get One
const data = await window.storage.get('transaction:123');
const transaction = JSON.parse(data.value);

// Delete
await window.storage.delete('transaction:123');
```

---

### State Management Strategy

#### Single Component State
All state managed in SmartBudget component (no Redux/Context needed)

```javascript
const [transactions, setTransactions] = useState([]);
const [showAddForm, setShowAddForm] = useState(false);
const [editingId, setEditingId] = useState(null);
const [activeView, setActiveView] = useState('dashboard');
const [formData, setFormData] = useState({...});
```

#### Derived State (Calculated on Render)
```javascript
// Computed values
const totalIncome = transactions.filter(...).reduce(...);
const totalExpense = transactions.filter(...).reduce(...);
const balance = totalIncome - totalExpense;
const expenseByCategory = transactions.reduce(...);
```

---

### Error Handling Strategy

#### Storage Errors
```javascript
try {
  await window.storage.set(key, value);
} catch (error) {
  console.error('Failed to save:', error);
  // Graceful degradation: app continues working
}
```

#### Data Loading Errors
```javascript
try {
  const data = await window.storage.get(key);
  return data ? JSON.parse(data.value) : null;
} catch {
  return null; // Skip corrupted data
}
```

#### Missing Data
```javascript
// Empty state handling
if (transactions.length === 0) {
  return <EmptyStateMessage />;
}
```

---

## 9. Testing Strategy

### Manual Testing Checklist

#### Functionality Tests
- ✅ Add income transaction
- ✅ Add expense transaction
- ✅ Edit transaction
- ✅ Delete transaction
- ✅ Form validation (required fields)
- ✅ Data persistence (refresh test)
- ✅ View switching
- ✅ Chart rendering
- ✅ AI insights generation

#### UI/UX Tests
- ✅ Responsive design (mobile, tablet, desktop)
- ✅ Button hover states
- ✅ Form input focus states
- ✅ Empty state displays
- ✅ Loading states
- ✅ Color-coded financial data
- ✅ Icon display
- ✅ Chart interactivity (tooltips)

#### Browser Compatibility
- ✅ Chrome/Edge (Chromium)
- ✅ Firefox
- ✅ Safari

---

## 10. Risk Mitigation Plan

### Technical Risks & Mitigations

| Risk | Mitigation |
|------|-----------|
| Storage API not supported | Detect support, show fallback message |
| Data corruption | Validate JSON before parse, skip invalid |
| Performance with large datasets | Implement pagination if needed (future) |
| Chart rendering issues | Use ResponsiveContainer, test multiple sizes |

### Project Risks & Mitigations

| Risk | Mitigation |
|------|-----------|
| Scope creep | Strict P0/P1 adherence, defer P2 features |
| AI-generated bugs | Manual code review, thorough testing |
| Timeline delays | Use AI assistance for acceleration |
| Documentation lag | Generate docs in parallel with development |

---

## 11. Success Metrics

### Development Metrics
- ✅ 100% P0 requirements implemented
- ✅ 100% P1 requirements implemented
- ✅ 0 critical bugs in production
- ✅ Code coverage for critical paths
- ✅ Cross-browser compatibility

### Performance Metrics
- ✅ Page load < 2 seconds
- ✅ Transaction add < 500ms
- ✅ Chart render < 1 second
- ✅ Storage operations < 100ms

### User Experience Metrics
- ✅ Intuitive UI (no tutorial needed)
- ✅ 3-click maximum to any feature
- ✅ Clear visual feedback
- ✅ Responsive on all devices

---

## 12. Next Steps

### Immediate Actions
1. Set up Create React App project
2. Initialize Git repository
3. Install dependencies (recharts, lucide-react)
4. Create component structure
5. Begin Sprint 1 implementation

### Phase 3 Preparation
- Review component specifications
- Prepare detailed implementation notes
- Set up development environment
- Configure Claude AI for coding assistance

---

**Document Status**: ✅ Approved  
**Next Phase**: Solutioning  
**Review Date**: November 2025