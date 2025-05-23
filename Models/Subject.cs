﻿using Microsoft.IdentityModel.Tokens;
using System.CodeDom;

namespace WebApplication1.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public bool IsDeleted { get; set; } = false;

        public bool IsEmptyName()
        {
            return SubjectName.IsNullOrEmpty() || SubjectName.Length == 0; 
        }
    }
}
