Clean Dot Net Sample Solution
=============================

This is a sample .net solution that shows how to use in an integrated and ci-friendly way a common set of tools:

* NUnit
* OpenCover
* MsBuild

At a certain point the only relevant files in this repository are the packages.config files, 
that declare the dependencies and the _CleanSample.build_ script that glue the different tools. 
This build script depends on NuGet to be installed in the machine.

So, to use the approach proposed here you should:

1. Install NuGet
2. Add MsBuild to the path
3. Update the CleanSample.build script to point to your nuget installation
4. Run the command _msbuild CleanSample.build /t:TestWithCoverage_

Note: before using OpenCover, it should be registered in the system by running the command: _regsvr32 .\OpenCover.Profiler.dll_