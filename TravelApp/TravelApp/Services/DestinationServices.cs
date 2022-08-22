using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TravelApp.Models;
using TravelApp.Resources.Images;
using Xamarin.Forms;

namespace TravelApp.Services
{
    public class DestinationServices
    {
        static DestinationServices _instance;
        public static DestinationServices Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new DestinationServices();  
                return _instance;
            }
        }

        internal List<GalleryItems> Gallery
        {
            get
            {
                return new List<GalleryItems>
                {
                    new GalleryItems
                    {
                        Id = 1,
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.japan1.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                    },
                    new GalleryItems
                    {
                        Id = 1,
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.korea1.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                    },
                    new GalleryItems{
                        Id = 1,
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.thailand.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                    },
                };
            }

        }

        public List<Destination> RecommendedDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination
                    {
                        Name="Mount Fuji Japan cherry blossom",
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.japan1.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                        Place="Shizuoka, Japan",
                        About="In Shizuoka you can enjoy a sweeping landscape of cherry blossoms with Mt. Fuji",
                        Gallery=Gallery,
                        Price=200,
                    },
                    new Destination
                    {
                        Name="South Korea",
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.korea1.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                        Place="Paju, South Korea",
                        About="Paju Book City is one of the most popular places to visit and one of the most well-known things to do in Paju",
                        Gallery=Gallery,
                        Price=1500,
                    },
                     new Destination
                    {
                        Name="Thailand",
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.thailand.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                        Place="To Koh Samui, Thailand",
                        About="a small rocky island just north of Bophut. Its golden, 12-metre-tall seated Buddha statue, which dates back to 1972, is one of Samui's most popular attractions.",
                        Gallery=Gallery,
                        Price=1000,
                    }

                };
            }
        }

        public List<Destination> TopDestination
        {
            get
            {
                return new List<Destination>
                {
                    new Destination
                    {
                        Name="Japan",
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.japan1.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                        Place="Shizuoka, Japan",
                        About="In Shizuoka you can enjoy a sweeping landscape of cherry blossoms with Mt. Fuji",
                        Gallery=Gallery,
                        Price=200,
                    },
                    new Destination
                    {
                        Name="South Korea",
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.korea1.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                        Place="Paju, South Korea",
                        About="Paju Book City is one of the most popular places to visit and one of the most well-known things to do in Paju",
                        Gallery=Gallery,
                        Price=1500,
                    },
                    new Destination
                    {
                        Name="Thailand",
                        Image = ImageSource.FromResource("TravelApp.Resources.Images.thailand.jpg", typeof(ImageResourceExtension).GetTypeInfo().Assembly),
                        Place="To Koh Samui, Thailand",
                        About="a small rocky island just north of Bophut. Its golden, 12-metre-tall seated Buddha statue, which dates back to 1972, is one of Samui's most popular attractions.",
                        Gallery=Gallery,
                        Price=1000,
                    }
                };

            }
        }
            
    }
}
