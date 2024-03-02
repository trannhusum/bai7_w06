using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_w06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle hinhtron= new Circle("lam",10);
            Console.WriteLine(hinhtron);
            Console.WriteLine("Dien tich cua hinh tru mau " + hinhtron.getColor() + ", banh kinh " + hinhtron.getRadius() + " la:" + hinhtron.getArea());
            Cylinder hinhtru =new Cylinder(5,"xanh",5);
            Console.WriteLine(hinhtru);
            Console.WriteLine("The tich cua hinh tru mau "+hinhtru.getColor()+", chieu cao "+hinhtru.getHeight()+", banh kinh "+hinhtru.getRadius()+" la:"+hinhtru.getVolume());
            Console.ReadKey();
        }
    }
}
