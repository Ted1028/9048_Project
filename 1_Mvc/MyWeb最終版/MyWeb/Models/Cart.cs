using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyWeb.Models
{
    public partial class Cart
    {
        [Display(Name = "餐點名稱")]
        public string MealsName { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Display(Name = "購買人")]
        //public string Buyer_Name { get; set; }
        //[Required]
        //[StringLength(50)]
        //[Display(Name = "購買人電話")]
        //public string Buyer_Cellphone { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "餐點價格")]
        public int Meals_Price { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "餐點數量")]
        public int Meals_Count { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "總和")]
        public int Total { get { return Meals_Price * Meals_Count; } }
    
    }
}
