
using OpenToolkit;
using OpenToolkit.Graphics.OpenGL4;
using OpenToolkit.Mathematics;
using OpenToolkit.Windowing.Desktop;
using System;
using System.Diagnostics;

namespace opentoolkit_dummy
{
  public class MainWindow : GameWindow
  {
    public MainWindow() : base(GameWindowSettings.Default, NativeWindowSettings.Default)
    {
      
      Debug.WriteLine(this.Size);
      this.Size = new Vector2i(1600, 800);
      Debug.WriteLine(this.Size.X + ": " + this.Size.Y);
      
    }
    protected override void OnLoad()
    {
      //this.Size = new Vector2i(1600, 800);
      GL.Viewport(0,0,Size.X, Size.Y);
      Closed += OnClosed;
    }
    protected override void OnRenderFrame(OpenToolkit.Windowing.Common.FrameEventArgs args)
    {
      GL.ClearColor(Color4.Crimson);
      GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
      SwapBuffers();
    }
    protected override void OnResize(OpenToolkit.Windowing.Common.ResizeEventArgs e)
    {
      //base OnResize fixed the issue
      base.OnResize(e); 
      GL.Viewport(0,0,Size.X, Size.Y);
      Debug.WriteLine(Size.X + ": " + Size.Y);
    }

    private void OnClosed(object sender, System.EventArgs e)
    {
      Close();
    }
    public override void Close()
    {
      base.Close();
    }
  }
}