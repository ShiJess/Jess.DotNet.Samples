# 跳转到当前powershell脚本文件目录
$scriptpath = $PSScriptRoot
cd $scriptpath

# 获取用户目录
$userpath=$env:USERPROFILE
# 执行protoc生成类
&$userpath'\.nuget\packages\google.protobuf.tools\3.12.3\tools\windows_x64\protoc.exe' --proto_path=./protofile --csharp_out=./protoclass test.proto