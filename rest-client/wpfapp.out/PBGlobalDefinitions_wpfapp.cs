[Sybase.PowerBuilder.PBGroupAttribute("pbglobaldefinitions_wpfapp", Sybase.PowerBuilder.PBGroupType.Unknown,"","", null,"wpfapp")]
[Sybase.PowerBuilder.PBTargetAttribute("c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\wpfapp.pbtx", "c__wpfapp")]
[System.Diagnostics.DebuggerStepThrough]
public class PBGlobalDefinitions_wpfapp
{
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kGroupVar, "w_home", null, "w_home", "", "c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\wpfapp.pbl\\wpfapp.pblx",null, null, "w_home")]
	public c__w_home w_home = null;

	public static PBGlobalDefinitions_wpfapp _instance = null;

	public static PBGlobalDefinitions_wpfapp GetInstance()
	{
		if (_instance == null)
			_instance = new PBGlobalDefinitions_wpfapp();

		return _instance;
	}
	public static void InitUninitVariables()
	{
		GetInstance().Init();
	}

	public void Init()
	{

	}
} 