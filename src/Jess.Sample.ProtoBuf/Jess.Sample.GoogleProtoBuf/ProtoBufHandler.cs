using Google.Protobuf;
using System;
using System.IO;
using System.Text;


namespace Jess.Sample.GoogleProtoBuf
{
    public sealed class ProtoBufHandler
    {
        /// <summary>
        /// byte
        /// </summary>
        public static void UseByteSerialize()
        {
            Test request_data = new Test();
            request_data.ID = 2;
            request_data.Name = "测试 Google.ProtoBuf";

            var bytes = new byte[request_data.CalculateSize()];
            var str = string.Empty;
            using (CodedOutputStream cos = new CodedOutputStream(bytes))
            {
                //序列化
                request_data.WriteTo(cos);
                str = Encoding.UTF8.GetString(bytes);
            }
        }

        #region MemoryStream
        /// <summary>
        /// MemoryStream
        /// </summary>
        /// <remarks>
        /// WriteTo内部实现其实就是封装CodedOutputStream
        /// </remarks>
        public static void SimplestUse()
        {
            Test test_forProtobuf = new Test();
            test_forProtobuf.ID = 2;
            test_forProtobuf.Name = "测试 Google.ProtoBuf";

            using (MemoryStream memoryStream = new MemoryStream())
            {
                test_forProtobuf.WriteTo(memoryStream);
            }
        }

        /// <summary>
        /// MemoryStream嵌套CodedOutputStream
        /// </summary>
        public static void MemoryNestOutputStream()
        {
            Test request_data = new Test();
            request_data.ID = 2;
            request_data.Name = "测试 Google.ProtoBuf";

            using (MemoryStream memoryStream = new MemoryStream())
            {
                //序列化
                using (CodedOutputStream cos = new CodedOutputStream(memoryStream))
                {
                    request_data.WriteTo(cos);
                }
            }
        }

        #endregion

        /// <summary>
        /// FileStream-Write
        /// </summary>
        public static void UseFileStreamSerialize()
        {
            Test request_data = new Test();
            request_data.ID = 2;
            request_data.Name = "测试Google.ProtoBuf";

            using (FileStream memoryStream = new FileStream("google-protobuf.bin", FileMode.Create))
            {
                request_data.WriteTo(memoryStream);
            }
        }

        /// <summary>
        /// FileStream-Read
        /// </summary>
        /// <returns></returns>
        public static string UseFileStreamDeserialize()
        {
            using (FileStream memoryStream = new FileStream("protobuf-net.bin", FileMode.Open))
            {
                Test t1 = Test.Parser.ParseFrom(memoryStream);
                return t1.Name;
            }
        }





        /// <summary>
        /// FileStream-Write
        /// </summary>
        public static void UseFileStreamSerialize_Complex()
        {
            TestComplex request_data = new TestComplex();
            request_data.ID = 2;
            request_data.Name = "测试Google.ProtoBuf";

            TestItem testItem = new TestItem()
            {
                ID = 1,
                Item = "项1"
            };
            request_data.Items.Add(testItem);

            using (FileStream memoryStream = new FileStream("google-protobuf-complex.bin", FileMode.Create))
            {
                request_data.WriteTo(memoryStream);
            }
        }

        /// <summary>
        /// FileStream-Read
        /// </summary>
        /// <returns></returns>
        public static string UseFileStreamDeserialize_Complex()
        {
            using (FileStream memoryStream = new FileStream("protobuf-net-complex.bin", FileMode.Open))
            {
                TestComplex t1 = TestComplex.Parser.ParseFrom(memoryStream);
                return t1.Name;
            }
        }

    }
}
