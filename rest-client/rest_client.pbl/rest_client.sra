$PBExportHeader$rest_client.sra
forward
global type rest_client from Application
end type
global Transaction sqlca
global DynamicDescriptionArea sqlda
global DynamicStagingArea sqlsa
global Error error
global Message message
end forward

global type rest_client from Application
string AppName = "rest_client"
end type
global rest_client rest_client

on rest_client.create
sqlca=create Transaction
sqlda=create DynamicDescriptionArea
sqlsa=create DynamicStagingArea
error=create Error
message=create Message
end on

on rest_client.destroy
destroy(sqlca)
destroy(sqlda)
destroy(sqlsa)
destroy(error)
destroy(message)
end on

event Open;open(w_rest_client)
end event
