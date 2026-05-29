
msbuild -restore -t:Rebuild ^
    -p:Configuration="Release"  -p:Platform=x64     ^
    WpfControlTest.NetOld.sln
