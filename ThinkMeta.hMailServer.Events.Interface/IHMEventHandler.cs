using hMailServer;
using System.Runtime.InteropServices;

namespace ThinkMeta.hMailServer.Events.Interface;

/// <summary>
/// Event handler interface. Can be use for .NET or COM classes.
/// </summary>
[ComVisible(true)]
[Guid("45E5C5FD-DCEF-4331-AFDA-0059FC07A87C")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IHMEventHandler
{
    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="client"></param>
    /// <param name="result"></param>
    void OnClientConnect(IInterfaceClient client, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="client"></param>
    /// <param name="message"></param>
    /// <param name="result"></param>
    void OnSMTPData(IInterfaceClient client, IInterfaceMessage message, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="client"></param>
    /// <param name="message"></param>
    /// <param name="result"></param>
    void OnAcceptMessage(IInterfaceClient client, IInterfaceMessage message, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="message"></param>
    /// <param name="result"></param>
    void OnDeliveryStart(IInterfaceMessage message, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="message"></param>
    /// <param name="result"></param>
    void OnDeliverMessage(IInterfaceMessage message, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="reason"></param>
    /// <param name="result"></param>
    void OnBackupFailed(string reason, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="result"></param>
    void OnBackupCompleted(IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="severity"></param>
    /// <param name="code"></param>
    /// <param name="source"></param>
    /// <param name="description"></param>
    void OnError(int severity, int code, string source, string description);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="message"></param>
    /// <param name="recipient"></param>
    /// <param name="errorMessage"></param>
    void OnDeliveryFailed(IInterfaceMessage message, string recipient, string errorMessage);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="fetchAccount"></param>
    /// <param name="message"></param>
    /// <param name="remoteUid"></param>
    /// <param name="result"></param>
    void OnExternalAccountDownload(IInterfaceFetchAccount fetchAccount, IInterfaceMessage message, string remoteUid, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="client"></param>
    /// <param name="result"></param>
    void OnHELO(IInterfaceClient client, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="client"></param>
    void OnClientLogon(IInterfaceClient client);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="account"></param>
    /// <param name="password"></param>
    /// <param name="result"></param>
    void OnClientValidatePassword(IInterfaceAccount account, string password, IInterfaceResult result);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="client"></param>
    /// <param name="message"></param>
    void OnRecipientUnknown(IInterfaceClient client, IInterfaceMessage message);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="client"></param>
    /// <param name="message"></param>
    void OnTooManyInvalidCommands(IInterfaceClient client, IInterfaceMessage message);
}
