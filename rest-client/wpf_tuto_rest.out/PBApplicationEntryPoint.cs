//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\wpf_tuto_rest.pbl\\wpf_tuto_rest.pblx\\wpf_tuto_rest.sra"
#line hidden
public class PBApplicationEntryPoint
{

	[System.Diagnostics.DebuggerStepThrough]
	[System.STAThread]
	static void Main()
	{
		c__wpf_tuto_rest.ApplicationName = "wpf_tuto_rest";
		Sybase.PowerBuilder.PBSessionBase.HasPBExtensions = false;
		Sybase.PowerBuilder.PBSessionBase.MainAssembly = System.Reflection.Assembly.GetExecutingAssembly();
		Sybase.PowerBuilder.WPF.PBSession.AssemblyList = @"wpf_tuto_rest.resource.dll";
		Sybase.PowerBuilder.WPF.PBSession session = Sybase.PowerBuilder.WPF.PBSession.CreateSession(
			typeof(c__wpf_tuto_rest), 
			@"wpf_tuto_rest.pblx;l_rest_client.pblx");
		c__wpf_tuto_rest.GetCurrentApplication().wpf_tuto_rest = c__wpf_tuto_rest.GetCurrentApplication();
		InitAssemblyInfo();
		PBGlobalDefinitions_wpf_tuto_rest.InitUninitVariables();
		session.RunWPFApp();
	}

	public static void InitAssemblyInfo()
	{
		
	}
}
 