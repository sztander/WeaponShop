using System;

namespace WeaponApi
{
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
