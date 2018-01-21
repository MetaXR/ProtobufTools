using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using protocol;
using ProtoBuf;
using System.IO;

namespace NetWorkFrame
{
public class UnPackTool
{
public static IExtensible UnPack(ENetworkMessage networkMessage, int startIndex, int length, byte[] buffer)
{
  IExtensible packet = null;

  try
{
  using (MemoryStream streamForProto = new MemoryStream(buffer, startIndex, length))
{
  switch (networkMessage)
{
case ENetworkMessage.KEEP_ALIVE_SYNC:
packet = Serializer.Deserialize<KeepAliveSync>(streamForProto);
break;
case ENetworkMessage.LOGIN_REQ:
packet = Serializer.Deserialize<LoginReq>(streamForProto);
break;
case ENetworkMessage.LOGIN_RSP:
packet = Serializer.Deserialize<LoginRsp>(streamForProto);
break;
case ENetworkMessage.GET_USERINFO_REQ:
packet = Serializer.Deserialize<GetUserinfoReq>(streamForProto);
break;
case ENetworkMessage.GET_USERINFO_RSP:
packet = Serializer.Deserialize<GetUserinfoRsp>(streamForProto);
break;
case ENetworkMessage.LOGOUT_REQ:
packet = Serializer.Deserialize<LogoutReq>(streamForProto);
break;
case ENetworkMessage.LOGOUT_RSP:
packet = Serializer.Deserialize<LogoutRsp>(streamForProto);
break;
case ENetworkMessage.OFFLINE_SYNC:
packet = Serializer.Deserialize<OfflineSync>(streamForProto);
break;
case ENetworkMessage.GET_QUESTION_INFO_REQ:
packet = Serializer.Deserialize<GetQuestionInfoReq>(streamForProto);
break;
case ENetworkMessage.GET_QUESTION_INFO_RSP:
packet = Serializer.Deserialize<GetQuestionInfoRsp>(streamForProto);
break;
default:
Log4U.LogInfo("No Such Packet, packet type is " + networkMessage);
break; 
 }
}
}
catch (System.Exception ex)
{
Log4U.LogError(ex.Message + "\n " + ex.StackTrace + "\n" + ex.Source);

}return packet;
}
}
}
