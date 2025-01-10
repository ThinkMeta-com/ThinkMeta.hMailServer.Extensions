Sub OnAcceptMessage(oClient, oMessage)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnAcceptMessage oClient, oMessage, Result
Set Gateway = Nothing
End Sub

Sub OnBackupCompleted()
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnBackupCompleted Result
Set Gateway = Nothing
End Sub

Sub OnBackupFailed(sReason)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnBackupFailed sReason, Result
Set Gateway = Nothing
End Sub

Sub OnClientConnect(oClient)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnClientConnect oClient, Result
Set Gateway = Nothing
End Sub

Sub OnClientLogon(oClient)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnClientLogon oClient
Set Gateway = Nothing
End Sub

Sub OnClientValidatePassword(oAccount, sPassword)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnClientValidatePassword oAccount, sPassword, Result
Set Gateway = Nothing
End Sub

Sub OnDeliverMessage(oMessage)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnDeliverMessage oMessage, Result
Set Gateway = Nothing
End Sub

Sub OnDeliveryFailed(oMessage, sRecipient, sErrorMessage)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnDeliveryFailed oMessage, sRecipient, sErrorMessage
Set Gateway = Nothing
End Sub

Sub OnDeliveryStart(oMessage)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnDeliveryStart oMessage, Result
Set Gateway = Nothing
End Sub

Sub OnError(iSeverity, iCode, sSource, sDescription)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnError iSeverity, iCode, sSource, sDescription
Set Gateway = Nothing
End Sub

Sub OnExternalAccountDownload(oFetchAccount, oMessage, sRemoteUid)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnExternalAccountDownload oFetchAccount, oMessage, sRemoteUid, Result
Set Gateway = Nothing
End Sub

Sub OnHELO(oClient)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnHELO oClient, Result
Set Gateway = Nothing
End Sub

Sub OnRecipientUnknown(oClient, oMessage)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnRecipientUnknown oClient, oMessage
Set Gateway = Nothing
End Sub

Sub OnSMTPData(oClient, oMessage)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnSMTPData oClient, oMessage, Result
Set Gateway = Nothing
End Sub

Sub OnTooManyInvalidCommands(oClient, oMessage)
Set Gateway = CreateObject("ThinkMeta.hMailServerEventsGateway")
Gateway.OnTooManyInvalidCommands oClient, oMessage
Set Gateway = Nothing
End Sub
