
 @rem �Ը�Ŀ¼��ÿ��*.prot�ļ� ������Ӧ��cs�ļ���ָ��Ŀ¼����Ҫָ���Լ���Ŀ¼�� 
 for %%j in (*.proto) do ( 
  echo %%j
 

protogen -i:"%%j" -o:D:\protoFile\CS\%%~nj.cs 

)


@echo off
del UnPackTool.cs
protoEnumParse
@rem ��Ҫָ���Լ���Ŀ¼
copy /y  UnPackTool.cs "D:\protoFile\UnPackTool\Unpacktool.cs"