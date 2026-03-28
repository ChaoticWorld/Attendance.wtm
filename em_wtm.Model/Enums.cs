using System;
using System.ComponentModel.DataAnnotations;

namespace em_wtm.Model
{

    public class RefDicNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}