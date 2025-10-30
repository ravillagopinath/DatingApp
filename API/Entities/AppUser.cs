// using System;

namespace API.Entities;

public class AppUser
{
    public String Id { get; set; } = Guid.NewGuid().ToString();
    public required String DisplayName { get; set; }
    public required String Email { get; set; }

    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }

    
}



// Use DatingAppdb;

// INSERT INTO Users (Id, DisplayName, Email)
// VALUES
// (NEWID(), 'Gopi', 'gopi@example.com'),
// (NEWID(), 'Ravi', 'ravi@example.com'),
// (NEWID(), 'Sita', 'sita@example.com'),
// (NEWID(), 'Kiran', 'kiran@example.com'),
// (NEWID(), 'Priya', 'priya@example.com');

// select * from users;

// USE DatingAppdb;
// DELETE FROM Users;

// USE DatingAppdb;

// INSERT INTO Users (Id, DisplayName, Email)
// VALUES
// ('DATING' + RIGHT('0000' + CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR(4)), 4), 'Gopi', 'gopi@example.com'),
// ('DATING' + RIGHT('0000' + CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR(4)), 4), 'Ravi', 'ravi@example.com'),
// ('DATING' + RIGHT('0000' + CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR(4)), 4), 'Sita', 'sita@example.com'),
// ('DATING' + RIGHT('0000' + CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR(4)), 4), 'Kiran', 'kiran@example.com'),
// ('DATING' + RIGHT('0000' + CAST(CAST(RAND() * 10000 AS INT) AS VARCHAR(4)), 4), 'Priya', 'priya@example.com');

