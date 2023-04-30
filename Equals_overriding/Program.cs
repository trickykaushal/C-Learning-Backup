using System;

namespace Equals_overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            FullName f = new FullName();
            f.First_Name = "Kaushal";
            f.Last_Name = "Manoj";
            FullName f2 = new FullName();
            f2.First_Name = "Kaushal";
            f2.Last_Name = "Manoj";


            Console.WriteLine(f == f2);
            Console.WriteLine(f.Equals(f2));

            //Direction direction = Direction.East;
            //Direction direction1 = Direction.East;
            //Console.WriteLine(direction == direction1);
            //Console.WriteLine(direction.Equals(direction1));

          
         

    }
        public enum Direction
        {
            East = 1,
            West = 2
        };
    }
public class FullName
{
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
        public override bool Equals(object obj)
        {
            if(!(obj is FullName))
            {
                return false;
            }
            if (obj == null)
            {
                return false;
            }
            return this.First_Name == ((FullName)obj).First_Name &&
                this.Last_Name == ((FullName)obj).Last_Name;
        }

        public override int GetHashCode()
        {
            return this.First_Name.GetHashCode() ^ this.Last_Name.GetHashCode();
        }
    }
}
