using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutEngine;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
namespace TutEngine
{
    class Silla
    {
        private double x;
        private double y;
        private double tamano;
        public Silla(double x, double y, double tamano)
        {
            this.x = x/100;
            this.y = y/100;
            this.tamano = tamano/100;
            dibujarSilla();
        }

        public void dibujarSilla()
        {
            dibujarPata1();
            dibujarPata2();
            dibujarPata3();
            dibujarPata4();
            asiento();
            apoyar();
        }

        public void dibujarPata1()
        {
            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(0.0f,1.0f, 0.0f);
            GL.Vertex2(x + 0.0f * tamano , y + 0.0f * tamano);
            GL.Vertex2(x + 0.07f * tamano, y + 0.0f * tamano);
            GL.Vertex2(x + 0.0f * tamano, y - 0.5f * tamano);
            GL.Vertex2(x + 0.07f * tamano, y - 0.5f * tamano);
            GL.End();
        }
        public void dibujarPata2()
        {
            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(0.0f,1.0f, 0.0f);
            GL.Vertex2(x + 0.3f * tamano, y - 0.2f * tamano);
            GL.Vertex2(x + 0.25f * tamano, y - 0.1f * tamano);
            GL.Vertex2(x + 0.3f * tamano, y - 0.6f * tamano);
            GL.Vertex2(x + 0.25f * tamano, y - 0.6f * tamano);
            GL.End();
        }

        public void dibujarPata3()
        {
            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(0.0f, 1.0f, 0.0f);
            GL.Vertex2(x + 0.45f * tamano, y -0.15f * tamano);
            GL.Vertex2(x + 0.40f * tamano, y - 0.15f * tamano);
            GL.Vertex2(x + 0.45f * tamano, y - 0.40f * tamano);
            GL.Vertex2(x + 0.40f * tamano, y - 0.40f * tamano);
            GL.End();
        }
         
        public void dibujarPata4()
        {
            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(x + 0.0f * tamano, 1.0f, 0.0f * tamano);
            GL.Vertex2(x + 0.55f * tamano, y -0.1f * tamano);
            GL.Vertex2(x + 0.6f * tamano, y-0.1f * tamano);
            GL.Vertex2(x + 0.55f * tamano, y-0.5f * tamano);
            GL.Vertex2(x + 0.6f * tamano, y-0.5f * tamano);
            GL.End();
        }

        public void asiento()
        {
            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(x + 0.0f * tamano, y + 1.0f, 0.0f * tamano);
            GL.Vertex2(x + 0.0f * tamano, y -0.0f * tamano);
            GL.Vertex2(x + 0.4f * tamano, y + 0.05f * tamano);
            GL.Vertex2(x + 0.3f * tamano, y-0.2f * tamano);
            GL.Vertex2(x + 0.6f * tamano, y-0.1f * tamano);
            GL.End();
        }

        public void apoyar()
        {
            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(x + 0.0f * tamano, 1.0f, 0.0f * tamano);
            GL.Vertex2(x + 0.0f * tamano, y + 0.0f * tamano);
            GL.Vertex2(x + 0.07f * tamano, y + 0.0f * tamano);
            GL.Vertex2(x + 0.0f * tamano, y + 0.5f * tamano);
            GL.Vertex2(x + 0.07f * tamano, y + 0.5f * tamano);
            GL.End();

            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(x + 0.0f * tamano, 1.0f, 0.0f * tamano);
            GL.Vertex2(x + 0.4f * tamano, y + 0.05f * tamano);
            GL.Vertex2(x + 0.35f * tamano, y + 0.045f * tamano);
            GL.Vertex2(x + 0.4f * tamano, y + 0.5f * tamano);
            GL.Vertex2(x + 0.35f * tamano, y + 0.5f * tamano); 

            GL.End();

            GL.Begin(BeginMode.QuadStrip);
            GL.Color3(x + 0.0f * tamano, y + 1.0f, 0.0f * tamano);
            GL.Vertex2(x + 0.0f * tamano, y + 0.35f * tamano);
            GL.Vertex2(x + 0.0f * tamano, y + 0.4f * tamano);
            GL.Vertex2(x + 0.4f * tamano, y + 0.35f * tamano);
            GL.Vertex2(x + 0.35f * tamano, y + 0.4f * tamano); 

            GL.End();
        }
    }
}
