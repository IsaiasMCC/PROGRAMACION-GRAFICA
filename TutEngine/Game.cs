using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace TutEngine
{
    public class Game : GameWindow
    {
        private Silla silla1;
        private Silla silla2;
        private Silla silla3;
        private Silla silla4;

       
        public Game(int width, int height, string title)
        {
            this.Width = width;
            this.Height = height;
            this.Title = title;
            instanciar();
            this.Run();
          
       
        }
        public void dibujar()
        {
            silla1.dibujarSilla();
            silla2.dibujarSilla();
            silla3.dibujarSilla();
            silla4.dibujarSilla();
        }
        public void instanciar()
        {
            silla1 = new Silla(-50, -10, 35);
            silla2 = new Silla(-60, 30, 25);
            silla3 = new Silla(-35, -80, 25);
            silla4 = new Silla(60, -40, 25);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();
            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
            base.OnUpdateFrame(e);         
        }

        protected override void OnLoad(EventArgs e) //CArgar
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e) 
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            dibujar();
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e) //Redimencion
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
        protected override void OnUnload(EventArgs e)
        {
            base.OnUnload(e);
        }


    }


}
