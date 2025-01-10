# ThinkMeta.hMailServer.Extensions

Enables processing hMailServer events using .NET or COM.

# Build

## Environment

* Visual Studio 2022 Community Edition with .NET workload
* hMailServer.tlb registered in the Windows registry
  * The easiest way is to just install hMailServer on the development machine.

## Building

* Open the solution in Visual Studio and built it.
* The predefined target frameworks .NET 4.8 and 9 are configured in Directory.Build.props.

## Installation

* Open cmd.exe in the output directory in admin mode and run the following commands:

<pre>
C:\Windows\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe ThinkMeta.hMailServer.Events.Gateway.dll /tlb /codebase
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\RegAsm.exe ThinkMeta.hMailServer.Events.Gateway.dll /tlb /codebase
</pre>

* Copy the file "EventHandlers.vbs" to "C:\Program Files (x86)\hMailServer\Events".
* Reload the script in "hMailServer Administrator".
