using System;
using System.IO;

namespace Jess.Sample.ProtoBufNet
{
    public sealed class ProtoBufNetHandler
    {
        /// <summary>
        /// MemoryStream
        /// </summary>
        public static void SimplestUse()
        {
            Test test_forProtobuf = new Test();
            test_forProtobuf.ID = 1;
            test_forProtobuf.Name = "测试 protobuf-net";

            using (MemoryStream memoryStream = new MemoryStream())
            {
                ProtoBuf.Serializer.Serialize(memoryStream, test_forProtobuf);
            }
        }



        /// <summary>
        /// FileStream-Write
        /// </summary>
        public static void UseFileStreamSerialize()
        {
            Test test = new Test();
            test.ID = 1;
            test.Name = "测试protobuf-net";

            using (FileStream memoryStream = new FileStream("protobuf-net.bin", FileMode.Create))
            {
                ProtoBuf.Serializer.Serialize(memoryStream, test);
            }
        }

        /// <summary>
        /// FileStream-Read
        /// </summary>
        /// <returns></returns>
        public static string UseFileStreamDeserialize()
        {
            using (FileStream memoryStream = new FileStream("google-protobuf.bin", FileMode.Open))
            {
                Test test = ProtoBuf.Serializer.Deserialize<Test>(memoryStream);
                return test.Name;
            }
        }




        /// <summary>
        /// FileStream-Write
        /// </summary>
        public static void UseFileStreamSerialize_Complex()
        {
            TestComplex test = new TestComplex();
            test.ID = 1;
            test.Name = "测试protobuf-net";

            TestItem testItem = new TestItem()
            {
                ID = 1,
                Item = "项1"
            };
            test.Items.Add(testItem);

            using (FileStream memoryStream = new FileStream("protobuf-net-complex.bin", FileMode.Create))
            {
                ProtoBuf.Serializer.Serialize(memoryStream, test);
            }
        }

        /// <summary>
        /// FileStream-Read
        /// </summary>
        /// <returns></returns>
        public static string UseFileStreamDeserialize_Complex()
        {
            using (FileStream memoryStream = new FileStream("google-protobuf-complex.bin", FileMode.Open))
            {
                TestComplex test = ProtoBuf.Serializer.Deserialize<TestComplex>(memoryStream);
                return test.Name;
            }
        }


    }
}
