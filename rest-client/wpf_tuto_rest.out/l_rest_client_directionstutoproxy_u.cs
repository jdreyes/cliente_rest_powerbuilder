//**************************************************************************
//
//                        Sybase Inc. 
//
//    THIS IS A TEMPORARY FILE GENERATED BY POWERBUILDER. IF YOU MODIFY 
//    THIS FILE, YOU DO SO AT YOUR OWN RISK. SYBASE DOES NOT PROVIDE 
//    SUPPORT FOR .NET ASSEMBLIES BUILT WITH USER-MODIFIED CS FILES. 
//
//**************************************************************************

#line 1 "c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\l_rest_client.pbl\\l_rest_client.pblx\\directionstutoproxy.sru"
#line hidden
namespace directionstutoservice
{
	#line 1 "directionstutoproxy"
	#line hidden
	[Sybase.PowerBuilder.PBGroupAttribute("directionstutoproxy",Sybase.PowerBuilder.PBGroupType.UserObject,"","c:\\documents and settings\\usuario\\mis documentos\\workspaces\\rest-client\\l_rest_client.pbl\\l_rest_client.pblx",null,"wpf_tuto_rest")]
	[Sybase.PowerBuilder.PBCaseNameAttribute("DirectionsTutoProxy")]
	[System.Diagnostics.DebuggerDisplay("",Type="directionstutoproxy")]
	public class c__directionstutoproxy : Sybase.PowerBuilder.PBNonVisualObject
	{
		#line hidden
		[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "m_service", null, "DirectionsTutoProxy", null, null, Sybase.PowerBuilder.PBModifier.Private, "")]
		protected PBWebHttp.RestService m_service = null;
		[Sybase.PowerBuilder.PBVariableAttribute(Sybase.PowerBuilder.VariableTypeKind.kInstanceVar, "restconnectionobject", null, "DirectionsTutoProxy", null, null, Sybase.PowerBuilder.PBModifier.Public, "")]
		public PBWebHttp.WebConnection restconnectionobject = null;

		#line 1 "{directionstutoservice}directionstutoproxy.getmessage(Cgoogle_rest_client_directions+root.)"
		#line hidden
		[Sybase.PowerBuilder.PBFunctionAttribute("getmessage", new string[]{}, Sybase.PowerBuilder.PBModifier.Public, Sybase.PowerBuilder.PBFunctionType.kPowerscriptFunction)]
		public virtual google_rest_client_directions.root getmessage()
		{
			#line hidden
			PBWebHttp.WebMessage msg = null;
			Sybase.PowerBuilder.PBArray results = new Sybase.PowerBuilder.PBUnboundedArray(typeof(System.Object));
			google_rest_client_directions.root result = null;
			#line 3
			m_service.ConnectionObject = restconnectionobject;
			#line hidden
			#line 7
			msg = m_service.GetMessage();
			#line hidden
			#line 11
			results.AssignFrom((Sybase.PowerBuilder.PBArray)ToPBData_2_webmessage_webmessa115595(msg, new Sybase.PowerBuilder.PBString("google_rest_client_directions.root")));
			#line hidden
			#line 13
			result = (google_rest_client_directions.root)(((System.Object)results[(Sybase.PowerBuilder.PBLong)(new Sybase.PowerBuilder.PBInt(1))]));
			#line hidden
			#line 14
			return result;
			#line hidden
		}

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("create")]
		public override void create()
		{
			#line hidden
			#line hidden
			base.create();
			#line hidden
			#line hidden
			;
			#line hidden
		}

		#line 1 "{directionstutoservice}directionstutoproxy.constructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("constructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_constructor)]
		public override Sybase.PowerBuilder.PBLong constructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 2
			m_service =  new PBWebHttp.RestService(new Sybase.PowerBuilder.PBString("http://maps.googleapis.com/maps/api/directions/json?origin=Madrid,%20ES&destination=Barcelona,%20ES&region=es&sensor=false"), PBWebHttp.WebMessageFormat.Json);
			#line hidden
			#line 4
			restconnectionobject =  new PBWebHttp.WebConnection();
			#line hidden
			#line 5
			restconnectionobject.Endpoint = new Sybase.PowerBuilder.PBString("http://maps.googleapis.com/maps/api/directions/json?origin=Madrid,%20ES&destination=Barcelona,%20ES&region=es&sensor=false");
			#line hidden
			#line 6
			restconnectionobject.ResponseMessageFormat = PBWebHttp.WebMessageFormat.Json;
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("destroy")]
		public override void destroy()
		{
			#line hidden
			#line hidden
			this.TriggerEvent(new Sybase.PowerBuilder.PBString("destructor"));
			#line hidden
			#line hidden
			base.destroy();
			#line hidden
		}

		#line 1 "{directionstutoservice}directionstutoproxy.destructor"
		#line hidden
		[Sybase.PowerBuilder.PBEventAttribute("destructor")]
		[Sybase.PowerBuilder.PBEventToken(Sybase.PowerBuilder.PBEventTokens.pbm_destructor)]
		public override Sybase.PowerBuilder.PBLong destructor()
		{
			#line hidden
			Sybase.PowerBuilder.PBLong ancestorreturnvalue = Sybase.PowerBuilder.PBLong.DefaultValue;
			#line 2
			Sybase.PowerBuilder.WPF.PBSession.CurrentSession.DestroyObject(m_service);
			#line hidden
			return new Sybase.PowerBuilder.PBLong(0);
		}

	public Sybase.PowerBuilder.PBBoundedArray ToPBData_2_webmessage_webmessa115595(PBWebHttp.WebMessage this__object, params Sybase.PowerBuilder.PBString[] type)
	{
		string[] type_4DotNetWrap = new string[type.Length];

		{
			int __pbTempRankLen__0 = type == null ? 0 : type.Length;
			for (int __pbTempCount__0 = 0; __pbTempCount__0 < __pbTempRankLen__0; __pbTempCount__0++)
			{
				type_4DotNetWrap[__pbTempCount__0] = (string)((string)type[__pbTempCount__0]);
			}
		}
		System.Object[] return_value_4DotNetWrap = this__object.ToPBData(type_4DotNetWrap);
		Sybase.PowerBuilder.PBBoundedArray return_value = (Sybase.PowerBuilder.PBBoundedArray)Sybase.PowerBuilder.PBArray.ToPBArray(return_value_4DotNetWrap, true);
		return return_value;
	}


		void _init()
		{
			this.CreateEvent += new Sybase.PowerBuilder.PBEventHandler(this.create);
			this.ConstructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.constructor);
			this.DestroyEvent += new Sybase.PowerBuilder.PBEventHandler(this.destroy);
			this.DestructorEvent += new Sybase.PowerBuilder.PBM_EventHandler(this.destructor);
		}

		public c__directionstutoproxy()
		{
			_init();
		}


		public static explicit operator c__directionstutoproxy(Sybase.PowerBuilder.PBAny v)
		{
			if (v.Value is Sybase.PowerBuilder.PBUnboundedAnyArray)
			{
				Sybase.PowerBuilder.PBUnboundedAnyArray a = (Sybase.PowerBuilder.PBUnboundedAnyArray)v.Value;
				c__directionstutoproxy vv = new c__directionstutoproxy();
				if (vv.FromUnboundedAnyArray(a) > 0)
				{
					return vv;
				}
				else
				{
					return null;
				}
			}
			else
			{
				return (c__directionstutoproxy) v.Value;
			}
		}
	}
}
 