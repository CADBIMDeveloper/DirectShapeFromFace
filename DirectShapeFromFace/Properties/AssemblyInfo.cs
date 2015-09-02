using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "DirectShapeFromFace" )]
[assembly: AssemblyDescription( "Revit Add-In Description for DirectShapeFromFace" )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Autodesk Inc." )]
[assembly: AssemblyProduct( "DirectShapeFromFace Revit Add-In" )]
[assembly: AssemblyCopyright( "Copyright 2015 � Jeremy Tammik Autodesk Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "321044f7-b0b2-4b1c-af18-e71a19252be0" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//
// 2015-08-31 2016.0.0.0 initial commit using offset works for some columns
// 2015-09-01 2016.0.0.1 display original geometry location using model lines and existing sketch planes
// 2015-09-01 2016.0.0.2 started exploring geometry instance transformations
// 2015-09-01 2016.0.0.2 implemented GetTransformStackForObject to no avail
// 2015-09-01 2016.0.0.2 applied FamilyInstance.GetTransform
// 2015-09-02 2016.0.0.3 applied FamilyInstance.GetTotalTransform
//
[assembly: AssemblyVersion( "2016.0.0.3" )]
[assembly: AssemblyFileVersion( "2016.0.0.3" )]
