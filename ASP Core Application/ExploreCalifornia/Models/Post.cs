using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ExploreCalifornia.Models
{
    public class Post
    {
        public long Id { get; set; }

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

        [Display(Name = "Post Title")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100,MinimumLength = 5,ErrorMessage ="Title name must be between 5 to 100")]
        public string Title { get; set; }
        public string Author { get; set; }
        
        [Required]
        [MinLength(100,ErrorMessage ="Minimum length of blog should be 100 characters")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        public DateTime Posted { get; set; }
    }
}
