﻿using InputUtilitys;
namespace Ex26_27_19_Takahashi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cylinder cylinder = new Cylinder(
                InputUtility.InputFloat("円の半径"),
                InputUtility.InputFloat("円柱の高さ"));

            Sphere sphere = new Sphere(
                InputUtility.InputFloat("球の半径"));

            TriangularPrism triangularprism = new TriangularPrism(
                InputUtility.InputFloat("底辺"),
                InputUtility.InputFloat("三角形の高さ"),
                InputUtility.InputFloat("高さ"));

            Console.WriteLine($"円柱の表面積={cylinder.GetSurface()}\n円柱の体積={cylinder.GetVlueme()}");
            Console.WriteLine($"球の表面積={sphere.GetSurface()}\n球の体積={sphere.GetVlueme()}");
            Console.WriteLine($"三角柱の表面積={triangularprism.GetSurface()}\n三角柱の体積={triangularprism.GetVlueme()}");

        }
    }


    class Cylinder
    {
        float radius;
        float height;

        public Cylinder(float radius, float height)
        {
            this.radius = radius;
            this.height = height;
        }

        public float GetSurface()
        {
            return radius * radius * (float)Math.PI * 2 + radius * 2 * (float)Math.PI * height;
        }

        public float GetVlueme()
        {
            return radius * radius * (float)Math.PI * height;
        }
    }

    class Sphere
    {
        float radius;

        public Sphere(float radius)
        {
            this.radius = radius;
        }

        public float GetSurface()
        {
            return radius * radius * (float)Math.PI * 4;
        }

        public float GetVlueme()
        {
            return 4.0f / 3.0f  * (float)Math.PI * radius * radius * radius;
        }
    }

    class TriangularPrism
    {
        float bottom;
        float triangleHeigth;
        float height;

        public TriangularPrism(float bottom, float triangleHeight, float height)
        {
            this.bottom = bottom;
            this.triangleHeigth = triangleHeight;
            this.height = height;
        }

        public float GetSurface()
        {
            return bottom * triangleHeigth + (bottom + triangleHeigth + (float)Math.Sqrt(bottom * bottom + triangleHeigth * triangleHeigth)) * height;
        }

        public float GetVlueme()
        {
            return bottom * triangleHeigth / 2 * height;
        }

    }

}

