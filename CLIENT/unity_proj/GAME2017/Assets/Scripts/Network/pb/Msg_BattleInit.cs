//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Msg_BattleInit.proto
// Note: requires additional types generated from: Dat_BattleData.proto
namespace ProtoBuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2S_BattleInit")]
  public partial class C2S_BattleInit : global::ProtoBuf.IExtensible
  {
    public C2S_BattleInit() {}
    
    private string _battleId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"battleId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string battleId
    {
      get { return _battleId; }
      set { _battleId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2C_BattleInit")]
  public partial class S2C_BattleInit : global::ProtoBuf.IExtensible
  {
    public S2C_BattleInit() {}
    
    private int _ret;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ret", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ret
    {
      get { return _ret; }
      set { _ret = value; }
    }
    private readonly global::System.Collections.Generic.List<ProtoBuf.DAT_HeroDataInBattle> _selfData = new global::System.Collections.Generic.List<ProtoBuf.DAT_HeroDataInBattle>();
    [global::ProtoBuf.ProtoMember(2, Name=@"selfData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoBuf.DAT_HeroDataInBattle> selfData
    {
      get { return _selfData; }
    }
  
    private readonly global::System.Collections.Generic.List<ProtoBuf.DAT_HeroDataInBattle> _enemyData = new global::System.Collections.Generic.List<ProtoBuf.DAT_HeroDataInBattle>();
    [global::ProtoBuf.ProtoMember(3, Name=@"enemyData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ProtoBuf.DAT_HeroDataInBattle> enemyData
    {
      get { return _enemyData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}