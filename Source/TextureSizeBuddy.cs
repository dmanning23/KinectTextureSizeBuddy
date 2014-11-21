using Microsoft.Kinect;

namespace KinectTextureSizeBuddy
{
	/// <summary>
	/// All this thing does is get the width and height of different kinect video streams.
	/// </summary>
	public static class TextureSizeBuddy
	{
		public static void VideoSize(ColorImageFormat format, out int width, out int height)
		{
			switch (format)
			{
				case ColorImageFormat.RgbResolution1280x960Fps12:
				case ColorImageFormat.RawBayerResolution1280x960Fps12:
				{
					width = 1280;
					height = 960;
				}
				break;
				default:
				{
					width = 640;
					height = 480;
				}
				break;
			}
		}

		public static void VideoSize(DepthImageFormat format, out int width, out int height)
		{
			switch (format)
			{
				case DepthImageFormat.Resolution320x240Fps30:
				{
					width = 320;
					height = 240;
				}
				break;
				case DepthImageFormat.Resolution80x60Fps30:
				{
					width = 80;
					height = 60;
				}
				break;
				default:
				{
					width = 640;
					height = 480;
				}
				break;
			}
		}
	}
}