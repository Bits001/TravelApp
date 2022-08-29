using System;
using System.Collections.Generic;
using System.Text;

namespace TravelApp.Models
{
    public class GalleryItems
    {
        public int Id { get; set; }
        public object Image { get; set; }
    }

    public class Destination
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public object Image { get; set; }
        public double Price { get; set; }
        public string About { get; set; }
        public List<GalleryItems> Gallery { get; set; }

    }

   
}
