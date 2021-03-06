$PBExportHeader$wpfapp.sra
forward
global type wpfapp from Application
end type
global Transaction sqlca
global DynamicDescriptionArea sqlda
global DynamicStagingArea sqlsa
global Error error
global Message message
end forward

global type wpfapp from Application
string AppName = "wpfapp"
end type
global wpfapp wpfapp

on wpfapp.create
sqlca=create Transaction
sqlda=create DynamicDescriptionArea
sqlsa=create DynamicStagingArea
error=create Error
message=create Message
end on

on wpfapp.destroy
destroy(sqlca)
destroy(sqlda)
destroy(sqlsa)
destroy(error)
destroy(message)
end on

event Open;open(w_home)
end event
