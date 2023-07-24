using Fuse8_ByteMinds.SummerSchool.PublicApi;
using Microsoft.AspNetCore;

var webHost = WebHost
	.CreateDefaultBuilder(args)
	.UseStartup<Startup>()
	.Build();

await webHost.RunAsync();