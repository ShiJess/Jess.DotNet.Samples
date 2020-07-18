using ProtoBuf;
using System.Collections.Generic;

namespace Jess.Sample.ProtoBufNet
{
    [ProtoContract]
    public class Test
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }
    }


    [ProtoContract]
    public class TestComplex
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public string Str { get; set; }
        [ProtoMember(4, IsRequired = true)]
        public string StrReq { get; set; }

        [ProtoMember(5)]
        public bool IsTrue { get; set; }
        [ProtoMember(6, IsRequired = true)]
        public bool IsTrueReq { get; set; }

        [ProtoMember(7)]
        public TestEnumType TestEnum { get; set; }
        [ProtoMember(8, IsRequired = true)]
        public TestEnumType TestEnumReq { get; set; }

        [ProtoMember(9)]
        public List<TestItem> Items { get; set; } = new List<TestItem>();

    }


    public enum TestEnumType
    {
        First = 0,
        Second = 1,
        Third = 2,
    }

    [ProtoContract]
    public class TestItem
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string Item { get; set; }
    }

}