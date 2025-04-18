-- Create Entities with Oracle-compatible syntax
CREATE TABLE Admins (
    AdminID NUMBER UNIQUE NOT NULL,
    Email VARCHAR2(255) UNIQUE NOT NULL,
    Password VARCHAR2(255) NOT NULL,
    Name VARCHAR2(255) NOT NULL,
    PhoneNumber VARCHAR2(15),
    Age NUMBER
);

CREATE TABLE Users (
    UserID NUMBER UNIQUE NOT NULL,
    Email VARCHAR2(255) UNIQUE NOT NULL,
    Password VARCHAR2(255) NOT NULL,
    Username VARCHAR2(255) UNIQUE NOT NULL,
    PhoneNumber VARCHAR2(15),
    Age NUMBER
);

CREATE TABLE Movie (
    MovieID NUMBER UNIQUE NOT NULL,
    Title VARCHAR2(255) NOT NULL,
    ReleaseDate DATE NOT NULL,
    Description CLOB,
    Duration NUMBER NOT NULL,
    Rating NUMBER(2,1),
    TicketCost NUMBER(10,2) NOT NULL,
    Director VARCHAR2(255) NOT NULL,
    Genre VARCHAR2(255)
);

-- Create Relationships
CREATE TABLE AdminEditsMovie (
    AdminID NUMBER,
    MovieID NUMBER,
    EditTimestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (AdminID, MovieID),
    FOREIGN KEY (AdminID) REFERENCES Admins(AdminID),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID)
);

CREATE TABLE AdminManagesUser (
    AdminID NUMBER,
    UserID NUMBER,
    PRIMARY KEY (AdminID, UserID),
    FOREIGN KEY (AdminID) REFERENCES Admins(AdminID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

CREATE TABLE Booking (
    BookingID NUMBER UNIQUE NOT NULL,
    UserID NUMBER NOT NULL,
    MovieID NUMBER NOT NULL,
    BookingDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    Quantity NUMBER DEFAULT 1 NOT NULL,
    TicketPrice NUMBER(10,2) NOT NULL,
    TotalAmount NUMBER(10,2) GENERATED ALWAYS AS (Quantity * TicketPrice) VIRTUAL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (MovieID) REFERENCES Movie(MovieID)
);