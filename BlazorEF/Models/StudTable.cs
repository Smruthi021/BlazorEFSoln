using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorEF.Models;

public partial class StudTable
{
   
    public string Name { get; set; } = null!;
    
    public int Age { get; set; }
}
