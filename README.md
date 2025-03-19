# Library Management System (Console Application)

## Project Overview
The **Library Management System** is a console-based application developed in **C#** that allows users to manage books and borrowing operations efficiently. It provides functionalities for adding books, registering users, borrowing books, and viewing library records.

## Features
1. **Add a Book** – Allows users to input book details (ID, name, and total quantity) and store them in a list.  
2. **Search Books by Prefix** – Enables searching for books based on a given name prefix.  
3. **View Borrowers by Book Name** – Displays users who have borrowed a specific book.  
4. **Print Library by ID** – Lists all books sorted by their ID.  
5. **Print Library by Name** – Lists all books sorted alphabetically.  
6. **Register a User** – Allows users to register with their name and national ID.  
7. **Borrow a Book** – Users can borrow books by providing their name and the book’s name. Availability is checked before borrowing.  
8. **Return a Book** – Users can return borrowed books, making them available for others.  
9. **View Registered Users** – Displays all registered users.  
10. **Exit the System** – Ends the program execution.  

## Technical Implementation
### Data Storage:
- **Books:** Stored as a list of tuples containing `(ID, name, total quantity)`.
- **Users:** Stored in a dictionary with the national ID as the key and the name as the value.
- **Borrowed Books:** Tracked using a dictionary where the key is the book ID, and the value is the number of borrowed copies.

### Error Handling:
- Input validation to ensure correct data formats.
- Checks to prevent duplicate user registrations.
- Ensures books are available before allowing borrowing.

## Future Enhancements
- Implement a database for persistent storage.
- Introduce a graphical user interface (GUI) for better user experience.
- Add authentication for user security.

This project serves as a foundational system for learning **C#**, data structures, and user interaction through console applications. 🚀


