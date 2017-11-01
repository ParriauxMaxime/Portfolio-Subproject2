
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebService.Models
{
    //Entity will bind our class to the table  in the database
    //Some value could be nullable ()
    public class PostType
    {
      [Key]
      public int TypeId {get; set;}
      public string Type {get; set;}
      
    }
  }