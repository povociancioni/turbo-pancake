using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace crudstore.Models
{
public class Product

{
public int Idproduct { get; set; }
public string Name { get; set; }
public string Imageurl { get; set;} 
public decimal Price { get; set; }   
}
}