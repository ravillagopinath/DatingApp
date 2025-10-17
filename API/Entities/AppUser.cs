// using System;

namespace API.Entities;

public class AppUser
{
    public String Id { get; set; } = Guid.NewGuid().ToString();
    public required String DisplayName { get; set; }
    public required String Email { get; set; }

    
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