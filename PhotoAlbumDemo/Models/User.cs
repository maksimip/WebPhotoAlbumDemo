using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhotoAlbumDemo.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}