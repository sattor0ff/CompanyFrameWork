using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class UserService
{
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
        _context = context;
    }

    public List<User> GetUsers()
    {
        return _context.Users.ToList();
    }
    
    public User GetUser(int id)
    {
        return _context.Users.FirstOrDefault(x => x.Id == id);
    }
    
    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}