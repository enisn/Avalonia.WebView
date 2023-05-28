using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Mac(10, 13)]
public struct MPSOffset
{
	public nint X;

	public nint Y;

	public nint Z;
}