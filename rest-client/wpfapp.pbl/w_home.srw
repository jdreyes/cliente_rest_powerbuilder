$PBExportHeader$w_home.srw
forward
global type w_home from Window
end type
type cb_1 from CommandButton within w_home
end type
end forward

global type w_home from Window
cb_1 cb_1
end type
global w_home w_home

on w_home.create
this.cb_1 = create cb_1
this.Control[]={this.cb_1}
end on

on w_home.destroy
destroy(this.cb_1)
end on

type cb_1 from CommandButton within w_home
end type

on cb_1.create
end on

on cb_1.destroy
end on
