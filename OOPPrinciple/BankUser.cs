namespace OOPPrinciple;

public class BankUser
{
    public Guid Id { get; }
    public string FullName { get; set; }
    public string Email { get; }
    public string PhoneNumber { get; private set;  }
    public decimal Balance { get; private set;  }
    private string PasswordHash;
    public bool IsVerified { get; private set; }
    public DateTime AccountCreated  { get; init; }

    public BankUser(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
        AccountCreated = DateTime.UtcNow;
        IsVerified = false;
    }

    public void UpdatePhone(string newPhone)
    {
        PhoneNumber = newPhone;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void VerifyAccount()
    {
        
    }
    
    
}