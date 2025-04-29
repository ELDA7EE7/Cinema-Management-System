# Cinema Management System

The **Cinema Management System** is a comprehensive solution designed to streamline the management of cinema operations. It provides a user-friendly interface for both customers and administrators, enabling seamless movie browsing, booking, and management. The system ensures strong security measures, including password policies and HTTPS encryption, to protect user data.

![{B6A19442-0260-4429-A957-BF282BDDA059}](https://github.com/user-attachments/assets/0219d9cb-e766-4950-b301-00de39f66f59)

## Features

- **User Registration & Login**: Secure account creation and authentication.
- **Movie Management**: Admins can add, edit, and delete movies.
- **Schedule Management**: Admins can manage movie schedules.
- **User Management**: Admins can add, edit, and delete users.
- **Search Functionality**: Customers can search for movies by title, genre, or date.
- **Reviews & Ratings**: Customers can rate and comment on movies.
- **History Tracking**: Customers can view their booking and interaction history.

## User Requirements

### Customer Requirements
- Search for movies.
- Register and log in using email and password.
- View and manage account details.
- Reset passwords and verify accounts.
- React to and comment on movies.
- View booking history.

### Admin Requirements
- Add, edit, and delete users.
- Add, edit, and delete movies.
- Add, edit, and delete schedules.

## Functional Requirements

### Customer Functions
- **Register**: Create an account using email, password, and name.
- **Login**: Authenticate using credentials.
- **Search Movies**: Filter movies by keywords or filters.
- **View History**: Display past bookings and interactions.
- **Manage Account**: Update account details.
- **Review Movies**: Add ratings and comments.
- **Verify Account**: Confirm email via a verification link.
- **Reset Password**: Recover account access via email.

### Admin Functions
- **Manage Users**: Add, edit, or delete user accounts.
- **Manage Movies**: Add, edit, or delete movie details.
- **Manage Schedules**: Add, edit, or delete movie schedules.

## Database Design

### Entity-Relationship Diagram (ERD)
```mermaid
erDiagram
    USERS ||--o{ BOOKING : "places"
    MOVIE ||--o{ BOOKING : "associated with"
    MOVIE ||--o{ MOVIE_SCHEDULE : "has"
    USERS ||--o{ ADMIN_EDITS_MOVIE : "performs"

    USERS {
        number UserID PK
        string Email
        string Password
        string Username
        string PhoneNumber
        number Age
        boolean isAdmin
    }

    MOVIE {
        number MovieID PK
        string Title
        date ReleaseDate
        text Description
        number Duration
        number Rating
        number TicketCost
        string Director
        string Genre
    }

    ADMIN_EDITS_MOVIE {
        number UserID FK
        number MovieID FK
        timestamp EditTimestamp
    }

    BOOKING {
        number BookingID PK
        number UserID FK
        number MovieID FK
        timestamp BookingDate
        number Quantity
        number TicketPrice
        number TotalAmount
    }

    MOVIE_SCHEDULE {
        number SCHEDULE_ID PK
        number MOVIEID FK
        date SCREEN_DATE
        timestamp START_TIME
        timestamp END_TIME
    }

```

### Tables
1. **Users**: Stores user information (UserID, Email, Password, Username, PhoneNumber, Age, isAdmin).
2. **Movie**: Stores movie details (MovieID, Title, ReleaseDate, Description, Duration, Rating, TicketCost, Director, Genre).
3. **AdminEditsMovie**: Tracks admin edits to movies (UserID, MovieID, EditTimestamp).
4. **Booking**: Manages customer bookings (BookingID, UserID, MovieID, BookingDate, Quantity, TicketPrice, TotalAmount).
5. **MOVIE_SCHEDULE**: Stores movie schedules (SCHEDULE_ID, MOVIEID, SCREEN_DATE, START_TIME, END_TIME).

## Screenshots


![{95E24059-584D-4725-9C15-7D661C3C039D}](https://github.com/user-attachments/assets/a8ab76e8-1462-4510-9a85-f809920f727e)




![image](https://github.com/user-attachments/assets/a2eeaee9-b897-4ca9-8a04-d6e6bcd0f88d)
![image](https://github.com/user-attachments/assets/6160fb36-5202-407b-bce3-21a4395ab3c0)  ![image](https://github.com/user-attachments/assets/533a255d-b1dd-4804-a528-03ac9c72cd22)
![image](https://github.com/user-attachments/assets/6c4fc3d8-e8f3-479e-9d46-53cfc2ad9a99)

![image](https://github.com/user-attachments/assets/4ac3d772-0b11-4f0a-b942-caea75d841e3)

