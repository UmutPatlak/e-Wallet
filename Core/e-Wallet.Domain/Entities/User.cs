using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace e_Wallet.Domain.Entities;
    


public class User : IdentityUser<Guid>
  

{
   
    
    public string FullName { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpiryTime { get; set; }

    public ICollection<Wallet> Wallets { get; set; }

   

}

