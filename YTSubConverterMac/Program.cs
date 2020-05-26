using System;
using System.Reflection;
using MacApi.Posix;

[assembly: AssemblyTitle("YTSubConverterMac")]
[assembly: AssemblyProduct("YTSubConverterMac")]
[assembly: AssemblyCopyright("Copyright © 2020 edisonlee55. Fork from arcusmaximus/YTSubConverter under the MIT License.")]
[assembly: AssemblyCompany("edisonlee55")]

namespace YTSubConverterMac
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// Workaround for mono issue #12557: https://github.com/mono/mono/issues/12557
			Environment.SetEnvironmentVariable("MONO_MANAGED_WATCHER", "dummy");
			
			var code = Arc.YTSubConverter.Program.Main(args);
			LibC.exit(code);
		}
	}
}
