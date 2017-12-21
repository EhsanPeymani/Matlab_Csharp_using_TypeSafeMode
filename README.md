# Matlab_Csharp_using_TypeSafeMode
This C# project presents a test project to show how MATLAB .NET libraries generated by MATLAB Compiler SDK can be used in C#. Type-safe interfaces are used to avoid manual data marshaling between .NET and MATLAB. 

The marshaling data between .NET and MATLAB is not carried out by MWArray API. Instead, a type-safe interface is designed to automate data conversion between .NET and MATLAB. See http://blogs.mathworks.com/loren/2011/06/03/introducing-type-safe-apis-with-builder-ne/ for a nice discussion on type-safe APIs. 

I have explored manual data marshaling using MWArray here https://github.com/EhsanPeymani/Matlab_Csharp_using_MWArray.

MATLAB M-Code and MATLAB Compiler SDK projects are in M-Code and MCS Projects folder.

The generated MATLAB .NET Assembly is found in Matlab .NET Libraries folder.

IMPORTANT >>> Read the readme file in the 'MatlabTestWindowsForm' folder, for details of implementation and requirements.

IMPORTANT >>> MATLAB structures can be converted to C# struct, and not to C# class. If interested to convert MATLAB structures, you need to use the manual conversion approach.

The solution has two projects:

1. Presentation project which is a WinForm project. This project refers to the second project in the solution (which is the interface definition). It has also been referenced to 2 dll files that have been generated by the MATLAB Compiler SDK. 

2. Interface Class library, which holds the interface definition and type definition.

To be able to run the application, you need to have MATALAB Runtime v9.0 (64bit) installed. Get it for free from https://se.mathworks.com/supportfiles/downloads/R2015b/deployment_files/R2015b/installers/win64/MCR_R2015b_win64_installer.exe


------------------------------------
Useful links:
Do visit this website for many good blogs on deployment https://blogs.mathworks.com/loren/category/deployment/

(Old but useful) Using MATLAB Structures in C# with Builder NE
https://blogs.mathworks.com/loren/2011/07/28/using-matlab-structures-in-c-with-builder-ne/
