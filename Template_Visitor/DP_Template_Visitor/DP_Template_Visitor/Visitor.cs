using System;

namespace DP_Template_Visitor
{
    class Visitor
    {
        interface IShape
        {
            void Draw();

            void Move(int x, int y);

            void Accept(IVisitor visitor);
        }

        interface IVisitor
        {
            void VisitCircle(Circle circle);
            void VisitRectangle(Rectangle rectangle);
            void VisitTriangle(Triangle triangle);
        }

        class Circle : IShape
        {
            public void Accept(IVisitor visitor)
            {
                visitor.VisitCircle(this);
            }

            public void Draw()
            {
                throw new NotImplementedException();
            }

            public void Move(int x, int y)
            {
                throw new NotImplementedException();
            }
        }

        class Rectangle : IShape
        {
            public void Accept(IVisitor visitor)
            {
                visitor.VisitRectangle(this);
            }

            public void Draw()
            {
                throw new NotImplementedException();
            }

            public void Move(int x, int y)
            {
                throw new NotImplementedException();
            }
        }

        class Triangle : IShape
        {
            public void Accept(IVisitor visitor)
            {
                visitor.VisitTriangle(this);
            }

            public void Draw()
            {
                throw new NotImplementedException();
            }

            public void Move(int x, int y)
            {
                throw new NotImplementedException();
            }
        }

        class DrawShape : IVisitor
        {
            public void VisitCircle(Circle circle)
            {
                Console.WriteLine("Drawing circle");
            }

            public void VisitRectangle(Rectangle rectangle)
            {
                Console.WriteLine("Drawing rectangle");
            }

            public void VisitTriangle(Triangle triangle)
            {
                Console.WriteLine("Drawing triangle");
            }
        }
    }
}