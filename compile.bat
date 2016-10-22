csc /t:module Computer.cs
csc /t:module Radio.cs
csc /t:library /addmodule:Radio.netmodule,Computer.netmodule /out:Devices.dll TVset.cs
csc /r:Devices.dll Client.cs
sn -k keypair.snk
csc /t:library /addmodule:Computer.netmodule,Radio.netmodule /keyfile:keypair.snk /out:DevicesS.dll TVset.cs