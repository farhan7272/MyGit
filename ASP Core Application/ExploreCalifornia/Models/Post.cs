using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        
        private string _key;

        public string Key
        {
            get
            {
                if (_key == null)
                {
                    _key = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _key;
            }
            set { _key = value; }
        }


        [Required]
        [StringLength(100,MinimumLength = 5,ErrorMessage ="Title name must be between 5 to 100")]
        public string Title { get; set; }
        public string Author { get; set; }
        
        [Required]
        [MinLength(100,ErrorMessage ="Minimum length of blog should be 100 characters")]
        public string Body { get; set; }
        public DateTime Posted { get; set; }
    }
}
