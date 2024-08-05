using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatArava.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string NickName { get; set; }

        public string FollName { get; set; }

        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPassWord { get; set; }

        public List<Messege> MessegeList { get; set; }
    }
}
