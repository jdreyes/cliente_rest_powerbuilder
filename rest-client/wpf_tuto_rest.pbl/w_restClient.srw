$PBExportHeader$w_restClient.srw
forward
global type w_restClient from Window
end type
type ddlb_1 from DropDownListBox within w_restClient
end type
type ddlb_2 from DropDownListBox within w_restClient
end type
type st_1 from StaticText within w_restClient
end type
type st_2 from StaticText within w_restClient
end type
type st_3 from StaticText within w_restClient
end type
type cb_1 from CommandButton within w_restClient
end type
type p_1 from Picture within w_restClient
end type
type mle_rutas from MultiLineEdit within w_restClient
end type
end forward

global type w_restClient from Window
ddlb_1 ddlb_1
ddlb_2 ddlb_2
st_1 st_1
st_2 st_2
st_3 st_3
cb_1 cb_1
p_1 p_1
mle_rutas mle_rutas
end type
global w_restClient w_restClient

on w_restClient.create
this.ddlb_1 = create ddlb_1
this.ddlb_2 = create ddlb_2
this.st_1 = create st_1
this.st_2 = create st_2
this.st_3 = create st_3
this.cb_1 = create cb_1
this.p_1 = create p_1
this.mle_rutas = create mle_rutas
this.Control[]={this.ddlb_1,&
this.ddlb_2,&
this.st_1,&
this.st_2,&
this.st_3,&
this.cb_1,&
this.p_1,&
this.mle_rutas}
end on

on w_restClient.destroy
destroy(this.ddlb_1)
destroy(this.ddlb_2)
destroy(this.st_1)
destroy(this.st_2)
destroy(this.st_3)
destroy(this.cb_1)
destroy(this.p_1)
destroy(this.mle_rutas)
end on

type ddlb_1 from DropDownListBox within w_restClient
end type

on ddlb_1.create
end on

on ddlb_1.destroy
end on

type ddlb_2 from DropDownListBox within w_restClient
end type

on ddlb_2.create
end on

on ddlb_2.destroy
end on

type st_1 from StaticText within w_restClient
end type

on st_1.create
end on

on st_1.destroy
end on

type st_2 from StaticText within w_restClient
end type

on st_2.create
end on

on st_2.destroy
end on

type st_3 from StaticText within w_restClient
end type

on st_3.create
end on

on st_3.destroy
end on

type cb_1 from CommandButton within w_restClient
end type

on cb_1.create
end on

on cb_1.destroy
end on

event Clicked;//Variables locales
google_rest_client_directions.root l_root
google_rest_client_directions.rootItemItem legs[ ]
google_rest_client_directions.rootItemItemItem steps[ ]
integer i
string rutas

DirectionsTutoService.DirectionsTutoProxy l_proxy
l_proxy = create DirectionsTutoService.DirectionsTutoProxy

try
	l_root = l_proxy.GetMessage( )
	
	legs = l_root.routes[1].legs
	steps = legs[1].steps
	
	//Se asigna el valor del string con la lista de rutas
	if(steps.Length > 0) then
		rutas = "Distancia: " + legs[1].distance.text + "~n"
		rutas += "Tiempo estimado: " + legs[1].duration.text + "~n"
		
		for i = 1 to steps.Length
			rutas += string(i) + ".- " + steps[i].html_instructions + "~n"
		next
	
	else
		rutas = "No se ha obtenido ninguna ruta"
	end if
	
	//Se establece el texto del control
	mle_rutas.Text = rutas
	
catch (System.Exception e)
	MessageBox("Error", "Error en la consulta de datos a Google")
end try
end event

type p_1 from Picture within w_restClient
end type

on p_1.create
end on

on p_1.destroy
end on

type mle_rutas from MultiLineEdit within w_restClient
end type

on mle_rutas.create
end on

on mle_rutas.destroy
end on
