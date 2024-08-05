using System.ComponentModel.DataAnnotations;

namespace ChatArava.Models
{
    public class Messege
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }

        public string Sender { get; set; }

        public DateTime SendingTime { get; set; }

    }
}
