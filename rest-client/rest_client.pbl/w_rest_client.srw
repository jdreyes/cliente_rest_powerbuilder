$PBExportHeader$w_rest_client.srw
forward
global type w_rest_client from Window
end type
type cb_1 from CommandButton within w_rest_client
end type
end forward

global type w_rest_client from Window
cb_1 cb_1
end type
global w_rest_client w_rest_client

on w_rest_client.create
this.cb_1 = create cb_1
this.Control[]={this.cb_1}
end on

on w_rest_client.destroy
destroy(this.cb_1)
end on

type cb_1 from CommandButton within w_rest_client
end type

on cb_1.create
end on

on cb_1.destroy
end on
