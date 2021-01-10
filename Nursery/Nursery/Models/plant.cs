using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Nursery.Models
{
    public class plant
    {

        [Key]
        public int plantID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string plantName { get; set; }

        [Required(ErrorMessage = "Scientific Name is required")]
        public string ScientificName { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public string plantAge { get; set; }


        [Required(ErrorMessage = "Price is required")]
        public string plantPrice { get; set; }

        //[Required(ErrorMessage = "this is required")]
        public string plantPicture { get; set; }



    }
}