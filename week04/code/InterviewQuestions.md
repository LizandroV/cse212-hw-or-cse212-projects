## 📚 Stack (LIFO – Last In, First Out)

A **stack** follows the **LIFO** principle — _Last In, First Out_.

- Internally implemented using a **linked list**.
- The **head** of the list represents the **top** of the stack.

### 📌 Structure:

Top → [30]
↓
[20]
↓
[10]
↓
null

markdown
Copy
Edit

### ⏱ Time Complexity

| Operation | Description           | Time |
| --------- | --------------------- | ---- |
| `Push`    | Insert at head        | O(1) |
| `Pop`     | Remove from head      | O(1) |
| `GetTop`  | Access head           | O(1) |
| `IsEmpty` | Check if head is null | O(1) |

---

## 🚶‍♂️ Queue (FIFO – First In, First Out)

A **queue** follows the **FIFO** principle — _First In, First Out_.

- Internally implemented using a **linked list**.
- Use the **head** as the **front** and the **tail** as the **rear**.

### 📌 Structure:

┌────────┐ ┌────────┐ ┌────────┐
│ 10 │ → │ 20 │ → │ 30 │ → null
└────────┘ └────────┘ └────────┘
↑ ↑
Front Rear (Tail)

### ⏱ Time Complexity

| Operation | Description           | Time |
| --------- | --------------------- | ---- |
| `Enqueue` | Insert at tail        | O(1) |
| `Dequeue` | Remove from head      | O(1) |
| `Size`    | Return count          | O(1) |
| `IsEmpty` | Check if head is null | O(1) |
