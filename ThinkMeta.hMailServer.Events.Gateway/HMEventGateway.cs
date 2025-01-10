using hMailServer;
using System.Runtime.InteropServices;
using ThinkMeta.hMailServer.Events.Interface;

namespace ThinkMeta.hMailServer.Events.Gateway;

/// <summary>
/// Implements a COM object that is callable from EventHandlers.vbs.
/// 
/// The object receives the calls from the script, casts the parameters
/// to their specific types and forwards them to the actual event handler.
/// </summary>
[ComVisible(true)]
[Guid("25E76BE4-C600-4341-B476-05C407896D42")]
[ProgId("ThinkMeta.hMailServerEventsGateway")]
[ClassInterface(ClassInterfaceType.None)]
public class HMEventGateway : IHMEventGateway
{
    /// <inheritdoc/>
    public void OnClientConnect(object oClient, object oResult) => GetEventHandler()?.OnClientConnect((IInterfaceClient)oClient, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnAcceptMessage(object oClient, object oMessage, object oResult) => GetEventHandler()?.OnAcceptMessage((IInterfaceClient)oClient, (IInterfaceMessage)oMessage, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnBackupCompleted(object oResult) => GetEventHandler()?.OnBackupCompleted((IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnBackupFailed(string reason, object oResult) => GetEventHandler()?.OnBackupFailed(reason, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnClientLogon(object oClient) => GetEventHandler()?.OnClientLogon((IInterfaceClient)oClient);

    /// <inheritdoc/>
    public void OnClientValidatePassword(object oAccount, string password, object oResult) => GetEventHandler()?.OnClientValidatePassword((IInterfaceAccount)oAccount, password, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnDeliverMessage(object oMessage, object oResult) => GetEventHandler()?.OnDeliverMessage((IInterfaceMessage)oMessage, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnDeliveryFailed(object oMessage, string recipient, string errorMessage) => GetEventHandler()?.OnDeliveryFailed((IInterfaceMessage)oMessage, recipient, errorMessage);

    /// <inheritdoc/>
    public void OnDeliveryStart(object oMessage, object oResult) => GetEventHandler()?.OnDeliveryStart((IInterfaceMessage)oMessage, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnError(int severity, int code, string source, string description) => GetEventHandler()?.OnError(severity, code, source, description);

    /// <inheritdoc/>
    public void OnExternalAccountDownload(object oFetchAccount, object oMessage, string remoteUid, object oResult) => GetEventHandler()?.OnExternalAccountDownload((IInterfaceFetchAccount)oFetchAccount, (IInterfaceMessage)oMessage, remoteUid, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnHELO(object oClient, object oResult) => GetEventHandler()?.OnHELO((IInterfaceClient)oClient, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnRecipientUnknown(object oClient, object oMessage) => GetEventHandler()?.OnRecipientUnknown((IInterfaceClient)oClient, (IInterfaceMessage)oMessage);

    /// <inheritdoc/>
    public void OnSMTPData(object oClient, object oMessage, object oResult) => GetEventHandler()?.OnSMTPData((IInterfaceClient)oClient, (IInterfaceMessage)oMessage, (IInterfaceResult)oResult);

    /// <inheritdoc/>
    public void OnTooManyInvalidCommands(object oClient, object oMessage) => GetEventHandler()?.OnTooManyInvalidCommands((IInterfaceClient)oClient, (IInterfaceMessage)oMessage);

    /// <summary>
    /// Implement the creation/retrieval of your event handler object here.
    /// </summary>
    /// <returns>The event handler object.</returns>
    private static IHMEventHandler? GetEventHandler() => new TraceEventHandler();
}
