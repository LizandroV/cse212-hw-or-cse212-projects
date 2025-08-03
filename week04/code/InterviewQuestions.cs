// A stack follows the LIFO principle — Last In, First Out.

//  head = top of the stack

//     Top -> [30]
//             ↓
//            [20]
//             ↓
//            [10]
//             ↓
//            null

// Time Complexity:
// Operation	Description	            Time
// Push	        Insert at head	        O(1)
// Pop	        Remove from head	    O(1)
// GetTop	    Access head	            O(1)
// IsEmpty	    Check if head is null	O(1)



// A QUEUE follows the FIFO principle — First In, First Out.

// ┌────────┐   ┌────────┐   ┌────────┐
// │  10    │→→│  20    │→→│  30    │→→ null
// └────────┘   └────────┘   └────────┘
//     ↑                         ↑
//   Front                   Rear/Tail

// Operation	Description	            Time
// Enqueue	    Insert at tail	        O(1)
// Dequeue	    Remove from head	    O(1)
// Size	        Return count	        O(1)
// IsEmpty	    Check if head is null	O(1)