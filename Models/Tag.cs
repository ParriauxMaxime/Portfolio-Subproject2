
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebService.Models
{
    //Entity will bind our class to the table  in the database
    //Some value could be nullable ()
    public class Tag
    {
      [Key]
      public int Id {get; set;}
      public string TagName {get; set;}
      
    }
  }