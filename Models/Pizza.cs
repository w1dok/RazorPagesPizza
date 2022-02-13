using System.ComponentModel.DataAnnotations;

namespace RazorPagesPizza;

public class Pizza 
{
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }
    public PizzaSize Size { get; set; }
    public bool IsGlutenFree { get; set; }
}

public enum PizzaSize { Small, Medium, Large }