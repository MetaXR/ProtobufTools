
 @rem 对该目录下每个*.prot文件 生成相应的cs文件到指定目录（需要指定自己的目录） 
 for %%j in (*.proto) do ( 
  echo %%j
 

protogen -i:"%%j" -o:D:\protoFile\CS\%%~nj.cs 

)


@echo off
del UnPackTool.cs
protoEnumParse
@rem 需要指定自己的目录
copy /y  UnPackTool.cs "D:\protoFile\UnPackTool\Unpacktool.cs"