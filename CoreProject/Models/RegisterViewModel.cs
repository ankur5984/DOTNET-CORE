
using System.ComponentModel.DataAnnotations;

namespace  OnlineShopingApplication.Models
{
    public class RegisterViewModel{

        [Required, MaxLength(50)]
        public string UserName{get;set;}
        [Required, DataType(DataType.Password)]
        public string Password{get;set;}
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword{set;get;}

    }
}