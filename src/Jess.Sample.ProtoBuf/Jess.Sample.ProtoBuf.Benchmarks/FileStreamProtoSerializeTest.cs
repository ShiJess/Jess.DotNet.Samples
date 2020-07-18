using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Google.Protobuf;
using Jess.Sample.GoogleProtoBuf;
using Jess.Sample.ProtoBufNet;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Jess.Sample.ProtoBuf.Benchmarks
{
    //[ClrJob(baseline: true)]
    //[RPlotExporter, RankColumn]
    //[PlainExporter]

    //[SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    //[SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [MarkdownExporterAttribute.GitHub, RankColumn]
    public class FileStreamProtoSerializeTest
    {

        [Fact]
        [Benchmark(Description = "Google.ProtoBuf使用FileStream")]
        public void te()
        {
            ProtoBufHandler.UseFileStreamSerialize();
        }

        [Fact]
        [Benchmark(Description = "protobuf-net使用FileStream")]
        public void b1()
        {
            ProtoBufNetHandler.UseFileStreamSerialize();
        }

    }
}
