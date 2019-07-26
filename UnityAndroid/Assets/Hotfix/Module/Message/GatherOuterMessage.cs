// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GatherOuterMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace ETHotfix {

  #region Messages
  /// <summary>
  ///服务器进行热更
  /// </summary>
  public partial class C2M_Reload : pb::IMessage {
    private static readonly pb::MessageParser<C2M_Reload> _parser = new pb::MessageParser<C2M_Reload>(() => (C2M_Reload)MessagePool.Instance.Fetch(typeof(C2M_Reload)));
    public static pb::MessageParser<C2M_Reload> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private string account_ = "";
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string password_ = "";
    public string Password {
      get { return password_; }
      set {
        password_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Account.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Account);
      }
      if (Password.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Password);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Password.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Password);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      account_ = "";
      password_ = "";
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Account = input.ReadString();
            break;
          }
          case 18: {
            Password = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class M2C_Reload : pb::IMessage {
    private static readonly pb::MessageParser<M2C_Reload> _parser = new pb::MessageParser<M2C_Reload>(() => (M2C_Reload)MessagePool.Instance.Fetch(typeof(M2C_Reload)));
    public static pb::MessageParser<M2C_Reload> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///这个应该是测试用的协议
  /// </summary>
  public partial class C2R_Ping : pb::IMessage {
    private static readonly pb::MessageParser<C2R_Ping> _parser = new pb::MessageParser<C2R_Ping>(() => (C2R_Ping)MessagePool.Instance.Fetch(typeof(C2R_Ping)));
    public static pb::MessageParser<C2R_Ping> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class R2C_Ping : pb::IMessage {
    private static readonly pb::MessageParser<R2C_Ping> _parser = new pb::MessageParser<R2C_Ping>(() => (R2C_Ping)MessagePool.Instance.Fetch(typeof(R2C_Ping)));
    public static pb::MessageParser<R2C_Ping> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///去验证验证账号 请求秘钥
  /// </summary>
  public partial class C2R_CommonLogin : pb::IMessage {
    private static readonly pb::MessageParser<C2R_CommonLogin> _parser = new pb::MessageParser<C2R_CommonLogin>(() => (C2R_CommonLogin)MessagePool.Instance.Fetch(typeof(C2R_CommonLogin)));
    public static pb::MessageParser<C2R_CommonLogin> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int loginType_;
    /// <summary>
    /// 登陆方式1.编辑状态2.游客3.微信
    /// </summary>
    public int LoginType {
      get { return loginType_; }
      set {
        loginType_ = value;
      }
    }

    private int platformType_;
    /// <summary>
    ///平台类型1.安卓2.IOS 3.PC
    /// </summary>
    public int PlatformType {
      get { return platformType_; }
      set {
        platformType_ = value;
      }
    }

    private string dataStr_ = "";
    /// <summary>
    /// 登对信息对象
    /// </summary>
    public string DataStr {
      get { return dataStr_; }
      set {
        dataStr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (LoginType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(LoginType);
      }
      if (PlatformType != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PlatformType);
      }
      if (DataStr.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DataStr);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (LoginType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LoginType);
      }
      if (PlatformType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PlatformType);
      }
      if (DataStr.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DataStr);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      loginType_ = 0;
      platformType_ = 0;
      dataStr_ = "";
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            LoginType = input.ReadInt32();
            break;
          }
          case 16: {
            PlatformType = input.ReadInt32();
            break;
          }
          case 26: {
            DataStr = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class R2C_CommonLogin : pb::IMessage {
    private static readonly pb::MessageParser<R2C_CommonLogin> _parser = new pb::MessageParser<R2C_CommonLogin>(() => (R2C_CommonLogin)MessagePool.Instance.Fetch(typeof(R2C_CommonLogin)));
    public static pb::MessageParser<R2C_CommonLogin> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string address_ = "";
    /// <summary>
    ///网关端口
    /// </summary>
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private long key_;
    /// <summary>
    /// 秘钥
    /// </summary>
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    private string loginVoucher_ = "";
    /// <summary>
    ///登陆凭证 下次可直接用这个登陆
    /// </summary>
    public string LoginVoucher {
      get { return loginVoucher_; }
      set {
        loginVoucher_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Key != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Key);
      }
      if (LoginVoucher.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(LoginVoucher);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      if (LoginVoucher.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LoginVoucher);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      address_ = "";
      key_ = 0;
      loginVoucher_ = "";
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Address = input.ReadString();
            break;
          }
          case 16: {
            Key = input.ReadInt64();
            break;
          }
          case 26: {
            LoginVoucher = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///拿着秘钥去登陆
  /// </summary>
  public partial class C2G_GateLogin : pb::IMessage {
    private static readonly pb::MessageParser<C2G_GateLogin> _parser = new pb::MessageParser<C2G_GateLogin>(() => (C2G_GateLogin)MessagePool.Instance.Fetch(typeof(C2G_GateLogin)));
    public static pb::MessageParser<C2G_GateLogin> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long key_;
    /// <summary>
    /// 秘钥
    /// </summary>
    public long Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Key != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Key);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Key != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Key);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      key_ = 0;
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Key = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class G2C_GateLogin : pb::IMessage {
    private static readonly pb::MessageParser<G2C_GateLogin> _parser = new pb::MessageParser<G2C_GateLogin>(() => (G2C_GateLogin)MessagePool.Instance.Fetch(typeof(G2C_GateLogin)));
    public static pb::MessageParser<G2C_GateLogin> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private global::ETHotfix.User user_;
    public global::ETHotfix.User User {
      get { return user_; }
      set {
        user_ = value;
      }
    }

    private long serverTime_;
    public long ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (user_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(User);
      }
      if (ServerTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ServerTime);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (user_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(User);
      }
      if (ServerTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerTime);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      if (user_ != null) MessagePool.Instance.Recycle(user_); user_ = null;
      serverTime_ = 0;
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (user_ == null) {
              user_ = new global::ETHotfix.User();
            }
            input.ReadMessage(user_);
            break;
          }
          case 16: {
            ServerTime = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///通知玩家得到了物品
  /// </summary>
  public partial class Actor_UserGetGoods : pb::IMessage {
    private static readonly pb::MessageParser<Actor_UserGetGoods> _parser = new pb::MessageParser<Actor_UserGetGoods>(() => (Actor_UserGetGoods)MessagePool.Instance.Fetch(typeof(Actor_UserGetGoods)));
    public static pb::MessageParser<Actor_UserGetGoods> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private bool isShowHintPanel_;
    /// <summary>
    ///是否显示提示面板
    /// </summary>
    public bool IsShowHintPanel {
      get { return isShowHintPanel_; }
      set {
        isShowHintPanel_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::ETHotfix.GetGoodsOne> _repeated_getGoodsList_codec
        = pb::FieldCodec.ForMessage(18, global::ETHotfix.GetGoodsOne.Parser);
    private pbc::RepeatedField<global::ETHotfix.GetGoodsOne> getGoodsList_ = new pbc::RepeatedField<global::ETHotfix.GetGoodsOne>();
    public pbc::RepeatedField<global::ETHotfix.GetGoodsOne> GetGoodsList {
      get { return getGoodsList_; }
      set { getGoodsList_ = value; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (IsShowHintPanel != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsShowHintPanel);
      }
      getGoodsList_.WriteTo(output, _repeated_getGoodsList_codec);
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(240, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (IsShowHintPanel != false) {
        size += 1 + 1;
      }
      size += getGoodsList_.CalculateSize(_repeated_getGoodsList_codec);
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      isShowHintPanel_ = false;
      for (int i = 0; i < getGoodsList_.Count; i++) { MessagePool.Instance.Recycle(getGoodsList_[i]); }
      getGoodsList_.Clear();
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            IsShowHintPanel = input.ReadBool();
            break;
          }
          case 18: {
            getGoodsList_.AddEntriesFrom(input, _repeated_getGoodsList_codec);
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 752: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///通知某个玩家上线
  /// </summary>
  public partial class Actor_UserOnLine : pb::IMessage {
    private static readonly pb::MessageParser<Actor_UserOnLine> _parser = new pb::MessageParser<Actor_UserOnLine>(() => (Actor_UserOnLine)MessagePool.Instance.Fetch(typeof(Actor_UserOnLine)));
    public static pb::MessageParser<Actor_UserOnLine> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private long userId_;
    /// <summary>
    ///上线玩家ID
    /// </summary>
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    private long sessionActorId_;
    /// <summary>
    ///上线玩家网关Session的ID
    /// </summary>
    public long SessionActorId {
      get { return sessionActorId_; }
      set {
        sessionActorId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
      if (SessionActorId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SessionActorId);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(240, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (SessionActorId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SessionActorId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      userId_ = 0;
      sessionActorId_ = 0;
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt64();
            break;
          }
          case 16: {
            SessionActorId = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 752: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///通知某个玩家下线
  /// </summary>
  public partial class Actor_UserOffline : pb::IMessage {
    private static readonly pb::MessageParser<Actor_UserOffline> _parser = new pb::MessageParser<Actor_UserOffline>(() => (Actor_UserOffline)MessagePool.Instance.Fetch(typeof(Actor_UserOffline)));
    public static pb::MessageParser<Actor_UserOffline> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private long userId_;
    /// <summary>
    ///下线玩家ID
    /// </summary>
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(240, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      userId_ = 0;
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt64();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 752: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///通知客户端被挤号了
  /// </summary>
  public partial class Actor_CompelAccount : pb::IMessage {
    private static readonly pb::MessageParser<Actor_CompelAccount> _parser = new pb::MessageParser<Actor_CompelAccount>(() => (Actor_CompelAccount)MessagePool.Instance.Fetch(typeof(Actor_CompelAccount)));
    public static pb::MessageParser<Actor_CompelAccount> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long actorId_;
    public long ActorId {
      get { return actorId_; }
      set {
        actorId_ = value;
      }
    }

    private string message_ = "";
    /// <summary>
    /// </summary>
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (ActorId != 0L) {
        output.WriteRawTag(240, 5);
        output.WriteInt64(ActorId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (ActorId != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(ActorId);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      message_ = "";
      rpcId_ = 0;
      actorId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 752: {
            ActorId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///上传定位和IP信息
  /// </summary>
  public partial class C2G_UploadingLocationIp : pb::IMessage {
    private static readonly pb::MessageParser<C2G_UploadingLocationIp> _parser = new pb::MessageParser<C2G_UploadingLocationIp>(() => (C2G_UploadingLocationIp)MessagePool.Instance.Fetch(typeof(C2G_UploadingLocationIp)));
    public static pb::MessageParser<C2G_UploadingLocationIp> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private string location_ = "";
    /// <summary>
    ///定位信息
    /// </summary>
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Location.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Location);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      location_ = "";
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Location = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class G2U_UploadingLocationIp : pb::IMessage {
    private static readonly pb::MessageParser<G2U_UploadingLocationIp> _parser = new pb::MessageParser<G2U_UploadingLocationIp>(() => (G2U_UploadingLocationIp)MessagePool.Instance.Fetch(typeof(G2U_UploadingLocationIp)));
    public static pb::MessageParser<G2U_UploadingLocationIp> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private long userId_;
    /// <summary>
    ///UserId
    /// </summary>
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    private string location_ = "";
    /// <summary>
    ///定位信息
    /// </summary>
    public string Location {
      get { return location_; }
      set {
        location_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string ip_ = "";
    /// <summary>
    ///Ip信息
    /// </summary>
    public string Ip {
      get { return ip_; }
      set {
        ip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
      if (Location.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Location);
      }
      if (Ip.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ip);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (Location.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Location);
      }
      if (Ip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ip);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      userId_ = 0;
      location_ = "";
      ip_ = "";
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt64();
            break;
          }
          case 18: {
            Location = input.ReadString();
            break;
          }
          case 26: {
            Ip = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public partial class S2C_UploadingLocationIp : pb::IMessage {
    private static readonly pb::MessageParser<S2C_UploadingLocationIp> _parser = new pb::MessageParser<S2C_UploadingLocationIp>(() => (S2C_UploadingLocationIp)MessagePool.Instance.Fetch(typeof(S2C_UploadingLocationIp)));
    public static pb::MessageParser<S2C_UploadingLocationIp> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    private int error_;
    public int Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string ip_ = "";
    /// <summary>
    ///Ip信息
    /// </summary>
    public string Ip {
      get { return ip_; }
      set {
        ip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Ip.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Ip);
      }
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
      if (Error != 0) {
        output.WriteRawTag(216, 5);
        output.WriteInt32(Error);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(226, 5);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      if (Error != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Error);
      }
      if (Message.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Ip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ip);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      ip_ = "";
      rpcId_ = 0;
      error_ = 0;
      message_ = "";
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Ip = input.ReadString();
            break;
          }
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
          case 728: {
            Error = input.ReadInt32();
            break;
          }
          case 738: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///心跳消息
  /// </summary>
  public partial class C2G_Heartbeat : pb::IMessage {
    private static readonly pb::MessageParser<C2G_Heartbeat> _parser = new pb::MessageParser<C2G_Heartbeat>(() => (C2G_Heartbeat)MessagePool.Instance.Fetch(typeof(C2G_Heartbeat)));
    public static pb::MessageParser<C2G_Heartbeat> Parser { get { return _parser; } }

    private int rpcId_;
    public int RpcId {
      get { return rpcId_; }
      set {
        rpcId_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RpcId != 0) {
        output.WriteRawTag(208, 5);
        output.WriteInt32(RpcId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RpcId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RpcId);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      rpcId_ = 0;
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 720: {
            RpcId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
