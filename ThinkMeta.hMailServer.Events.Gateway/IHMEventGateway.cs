using System.Runtime.InteropServices;

namespace ThinkMeta.hMailServer.Events.Gateway;

/// <summary>
/// 
/// </summary>
[ComVisible(true)]
[Guid("C51435F7-96F8-4181-BC1D-7BEFB4ADAB8F")]
[InterfaceType(ComInterfaceType.InterfaceIsDual)]
public interface IHMEventGateway
{
    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oClient"></param>
    /// <param name="oResult"></param>
    void OnClientConnect(object oClient, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oClient"></param>
    /// <param name="oMessage"></param>
    /// <param name="oResult"></param>
    void OnSMTPData(object oClient, object oMessage, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oClient"></param>
    /// <param name="oMessage"></param>
    /// <param name="oResult"></param>
    void OnAcceptMessage(object oClient, object oMessage, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oMessage"></param>
    /// <param name="oResult"></param>
    void OnDeliveryStart(object oMessage, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oMessage"></param>
    /// <param name="oResult"></param>
    void OnDeliverMessage(object oMessage, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="reason"></param>
    /// <param name="oResult"></param>
    void OnBackupFailed(string reason, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oResult"></param>
    void OnBackupCompleted(object oResult);

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
    /// <param name="oMessage"></param>
    /// <param name="recipient"></param>
    /// <param name="errorMessage"></param>
    void OnDeliveryFailed(object oMessage, string recipient, string errorMessage);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oFetchAccount"></param>
    /// <param name="oMessage"></param>
    /// <param name="remoteUid"></param>
    /// <param name="oResult"></param>
    void OnExternalAccountDownload(object oFetchAccount, object oMessage, string remoteUid, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oClient"></param>
    /// <param name="oResult"></param>
    void OnHELO(object oClient, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oClient"></param>
    void OnClientLogon(object oClient);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oAccount"></param>
    /// <param name="password"></param>
    /// <param name="oResult"></param>
    void OnClientValidatePassword(object oAccount, string password, object oResult);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oClient"></param>
    /// <param name="oMessage"></param>
    void OnRecipientUnknown(object oClient, object oMessage);

    /// <summary>
    /// <see cref="https://www.hmailserver.com/documentation/latest/?page=reference_scripts"/>
    /// </summary>
    /// <param name="oClient"></param>
    /// <param name="oMessage"></param>
    void OnTooManyInvalidCommands(object oClient, object oMessage);
}
