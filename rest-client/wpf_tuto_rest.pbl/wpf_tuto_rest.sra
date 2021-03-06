$PBExportHeader$wpf_tuto_rest.sra
forward
global type wpf_tuto_rest from Application
end type
global Transaction sqlca
global DynamicDescriptionArea sqlda
global DynamicStagingArea sqlsa
global Error error
global Message message
end forward

global type wpf_tuto_rest from Application
string AppName = "wpf_tuto_rest"
end type
global wpf_tuto_rest wpf_tuto_rest

on wpf_tuto_rest.create
sqlca=create Transaction
sqlda=create DynamicDescriptionArea
sqlsa=create DynamicStagingArea
error=create Error
message=create Message
end on

on wpf_tuto_rest.destroy
destroy(sqlca)
destroy(sqlda)
destroy(sqlsa)
destroy(error)
destroy(message)
end on

event Open;open(w_restClient)
end event
