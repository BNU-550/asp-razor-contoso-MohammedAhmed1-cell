using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ASP_RazorContoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [StringLength(8)]
        [RegularExpression("[A-Z]{2}[0-9]{1}[A-Z]{3}[0-9]{1}")]
        public string CourseCode { get; set; }

        public int Credits { get; set; }

        [StringLength(30), Required, MinLength(10)]
        public string Title { get; set; }

        public string FullTitle
        {
            get { return "BSc (Hons)" + Title; }
        }

        // navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }
    
}
