﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.261
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Messages
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Devv.ILMergeGUI.Messages", GetType(Messages).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Done.
        '''</summary>
        Friend Shared ReadOnly Property Done() As String
            Get
                Return ResourceManager.GetString("Done", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Can&apos;t merge the selected files. Make sure you have selected valid .NET assemblies and have permission to write on the output directory..
        '''</summary>
        Friend Shared ReadOnly Property Error_CantMerge() As String
            Get
                Return ResourceManager.GetString("Error_CantMerge", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The key file specified does not exist!.
        '''</summary>
        Friend Shared ReadOnly Property Error_KeyFileNotExists() As String
            Get
                Return ResourceManager.GetString("Error_KeyFileNotExists", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to There was a problem trying to merge. The output aseembly might not work as expected..
        '''</summary>
        Friend Shared ReadOnly Property Error_MergeException() As String
            Get
                Return ResourceManager.GetString("Error_MergeException", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please enter the output path for the merged assembly..
        '''</summary>
        Friend Shared ReadOnly Property Error_NoOutputPath() As String
            Get
                Return ResourceManager.GetString("Error_NoOutputPath", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The output assembly conflicts with one of the selected assemblies to merge. Please, choose a different filename..
        '''</summary>
        Friend Shared ReadOnly Property Error_OutputConflict() As String
            Get
                Return ResourceManager.GetString("Error_OutputConflict", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The output assembly path is already in use and could not be deleted..
        '''</summary>
        Friend Shared ReadOnly Property Error_OutputPathInUse() As String
            Get
                Return ResourceManager.GetString("Error_OutputPathInUse", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error.
        '''</summary>
        Friend Shared ReadOnly Property ErrorTerm() As String
            Get
                Return ResourceManager.GetString("ErrorTerm", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
