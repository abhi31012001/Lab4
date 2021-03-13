﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab4.Models
{
    public class Student
    {
        [Required]
        public int ID
        { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName 
        { get; set; }


        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName
        { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate 
        { get; set; }

        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }
        public ICollection<CommunityMembership> CommunityMemberships
        { get; set; }

        public IEnumerable<Community> Communities 
        { get; internal set; }

    }
}