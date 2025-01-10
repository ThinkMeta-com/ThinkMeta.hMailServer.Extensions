using hMailServer;
using System.Diagnostics;
using ThinkMeta.hMailServer.Events.Interface;

namespace ThinkMeta.hMailServer.Events.Gateway;

/// <summary>
/// An event handler that traces all events.
/// </summary>
internal class TraceEventHandler : IHMEventHandler
{
    public void OnAcceptMessage(IInterfaceClient client, IInterfaceMessage message, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnAcceptMessage");
    }

    public void OnBackupCompleted(IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnBackupCompleted");
    }

    public void OnBackupFailed(string reason, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnBackupFailed");
    }

    public void OnClientConnect(IInterfaceClient client, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnClientConnect");
    }

    public void OnClientLogon(IInterfaceClient client)
    {
        Trace.TraceInformation("HMEventGateway: OnClientLogon");
    }

    public void OnClientValidatePassword(IInterfaceAccount account, string password, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnClientValidatePassword");
    }

    public void OnDeliverMessage(IInterfaceMessage message, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnDeliverMessage");
    }

    public void OnDeliveryFailed(IInterfaceMessage message, string recipient, string errorMessage)
    {
        Trace.TraceInformation("HMEventGateway: OnDeliveryFailed");
    }

    public void OnDeliveryStart(IInterfaceMessage message, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnDeliveryStart");
    }

    public void OnError(int severity, int code, string source, string description)
    {
        Trace.TraceInformation("HMEventGateway: OnError");
    }

    public void OnExternalAccountDownload(IInterfaceFetchAccount fetchAccount, IInterfaceMessage message, string remoteUid, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnExternalAccountDownload");
    }

    public void OnHELO(IInterfaceClient client, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnHELO");
    }

    public void OnRecipientUnknown(IInterfaceClient client, IInterfaceMessage message)
    {
        Trace.TraceInformation("HMEventGateway: OnRecipientUnknown");
    }

    public void OnSMTPData(IInterfaceClient client, IInterfaceMessage message, IInterfaceResult result)
    {
        Trace.TraceInformation("HMEventGateway: OnSMTPData");
    }

    public void OnTooManyInvalidCommands(IInterfaceClient client, IInterfaceMessage message)
    {
        Trace.TraceInformation("HMEventGateway: OnTooManyInvalidCommands");
    }
}