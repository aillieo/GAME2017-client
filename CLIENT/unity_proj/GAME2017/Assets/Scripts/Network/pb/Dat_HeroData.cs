//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Dat_HeroData.proto
// Note: requires additional types generated from: Dat_General.proto
namespace ProtoBuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DAT_HeroData")]
  public partial class DAT_HeroData : global::ProtoBuf.IExtensible
  {
    public DAT_HeroData() {}
    
    private string _uid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string uid
    {
      get { return _uid; }
      set { _uid = value; }
    }
    private string _id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _lv;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int lv
    {
      get { return _lv; }
      set { _lv = value; }
    }
    private int _experience;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"experience", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int experience
    {
      get { return _experience; }
      set { _experience = value; }
    }
    private int _elementType;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"elementType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int elementType
    {
      get { return _elementType; }
      set { _elementType = value; }
    }
    private int _physicalAttack;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"physicalAttack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int physicalAttack
    {
      get { return _physicalAttack; }
      set { _physicalAttack = value; }
    }
    private int _physicalDefence;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"physicalDefence", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int physicalDefence
    {
      get { return _physicalDefence; }
      set { _physicalDefence = value; }
    }
    private int _magicalAttack;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"magicalAttack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int magicalAttack
    {
      get { return _magicalAttack; }
      set { _magicalAttack = value; }
    }
    private int _magicalDefence;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"magicalDefence", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int magicalDefence
    {
      get { return _magicalDefence; }
      set { _magicalDefence = value; }
    }
    private int _absoluteAttack;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"absoluteAttack", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int absoluteAttack
    {
      get { return _absoluteAttack; }
      set { _absoluteAttack = value; }
    }
    private float _speed;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"speed", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float speed
    {
      get { return _speed; }
      set { _speed = value; }
    }
    private int _move;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"move", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int move
    {
      get { return _move; }
      set { _move = value; }
    }
    private int _attackRange;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"attackRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int attackRange
    {
      get { return _attackRange; }
      set { _attackRange = value; }
    }
    private int _hp;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"hp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hp
    {
      get { return _hp; }
      set { _hp = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _skills = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(15, Name=@"skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> skills
    {
      get { return _skills; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}