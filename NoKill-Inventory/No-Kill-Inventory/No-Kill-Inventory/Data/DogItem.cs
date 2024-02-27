using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace No_Kill_Inventory.Data;
public class DogItem
{
    [Key]
    public int ItemID { get; set; }
    
    public String Type { get; set; }
    
    public int Weight { get; set; }
}