[Sybase.PowerBuilder.PBGroupAttribute("pbglobaldefinitions_wpf_tuto_rest", Sybase.PowerBuilder.PBGroupType.Unknown,"","", null,"wpf_tuto_rest")]
[Sybase.PowerBuilder.PBTargetAttribute("c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\wpf_tuto_rest.pbtx", "")]
[System.Diagnostics.DebuggerStepThrough]
public class PBGlobalDefinitions_wpf_tuto_rest
{
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kGlobalVar, "w_restclient", null, "w_restClient", "", "c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\wpf_tuto_rest.pbl\\wpf_tuto_rest.pblx",null, null, "w_restclient")]
	public c__w_restclient w_restclient = null;
	[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kGlobalVar, "directionstutoproxy", null, "DirectionsTutoProxy", "directionstutoservice", "c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\l_rest_client.pbl\\l_rest_client.pblx",null, null, "directionstutoproxy")]
	[Sybase.PowerBuilder.PBVarDeclNameAttribute("directionstutoservice.directionstutoproxy","directionstutoproxy")]
	public directionstutoservice.c__directionstutoproxy directionstutoservice_directionstutoproxy = null;

	public static PBGlobalDefinitions_wpf_tuto_rest _instance = null;

	public static PBGlobalDefinitions_wpf_tuto_rest GetInstance()
	{
		if (_instance == null)
			_instance = new PBGlobalDefinitions_wpf_tuto_rest();

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