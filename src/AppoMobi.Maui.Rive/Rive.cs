using RiveSharp;
using SkiaSharp;

namespace AppoMobi.Maui.Rive
{
	// the main todo remains to create universal code, meanwhile will use models from RiveSharp 
	public class Rive
	{
		class WindowsRenderer : Renderer
		{
			public WindowsRenderer(SKCanvas skCanvas) : base(skCanvas)
			{
			}

			public static void Init()
			{
			}
		}

		public static void Init()
		{
			// windows
			WindowsRenderer.Init();

		}
	}
}