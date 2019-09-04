using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeaponShop
{
    public class GunService
    {
        public static List<Gun> GunListCreator()
        {
            List<Gun> guns = new List<Gun>();

            for (int i = 0; i < 9; i++)
            {
                guns.Add(new Gun()
                {
                    Name = "M4A1",
                    Description = "Shitty gun really nice",
                    ImageUrl = "/StronkaSKlepy/ID2036281_A0_Rectangle_9_pattern.jpg",
                    FireRate = 600,
                    PenetrationPower = 50,
                    ClipSize = 30,
                    ReloadTime = 30,
                    Cost = 320 + i,
                });
            }
            return guns;
        }
    }
    public class Gun
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int FireRate { get; set; }
        public int PenetrationPower { get; set; }
        public int ClipSize { get; set; }
        public int ReloadTime { get; set; }
        public int Cost { get; set; }
    }
}
