using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trench coat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        nurse.ShowWardrobe();
        detective.ShowWardrobe();
    }
}