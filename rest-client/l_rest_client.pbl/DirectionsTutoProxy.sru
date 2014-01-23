namespace
namespace DirectionsTutoService
end namespace
forward
global type DirectionsTutoProxy from nonvisualobject
end type
end forward

global type DirectionsTutoProxy from nonvisualobject
end type
global DirectionsTutoProxy DirectionsTutoProxy

type variables
    //Instance of REST Service
    private PBWebHttp.RestService m_service
    //Instance of  Connection Object
    public PBWebHttp.WebConnection restConnectionObject
end variables

forward prototypes
public function google_rest_client_directions.root GetMessage( )
end prototypes

public function google_rest_client_directions.root GetMessage( );
    // Update Connection Object
    m_service.ConnectionObject = restConnectionObject

    PBWebHttp.WebMessage msg
    //Invocation
    msg = m_service.GetMessage()

    //Convert the message to PowerBuilder data
    System.Object results[]
    results = msg.ToPBData("google_rest_client_directions.root")
    google_rest_client_directions.root result
    result = results[1]
    return result

end function
on DirectionsTutoProxy.create
call super::create
TriggerEvent( this, "constructor" )
end on

event constructor;
    m_service = create PBWebHttp.RestService("http://maps.googleapis.com/maps/api/directions/json?origin=Madrid,%20ES&destination=Barcelona,%20ES&region=es&sensor=false", PBWebHttp.WebMessageFormat.Json!)
    // Connection Object
    restConnectionObject = create PBWebHttp.WebConnection
    restConnectionObject.Endpoint = "http://maps.googleapis.com/maps/api/directions/json?origin=Madrid,%20ES&destination=Barcelona,%20ES&region=es&sensor=false"
    restConnectionObject.ResponseMessageFormat = PBWebHttp.WebMessageFormat.Json!

end event


on DirectionsTutoProxy.destroy
TriggerEvent( this, "destructor" )
call super::destroy
end on

event destructor;
    destroy m_service
end event
