﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MainWindowWidth() As Long
            Get
                Return CType(Me("MainWindowWidth"),Long)
            End Get
            Set
                Me("MainWindowWidth") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MainWindowHeight() As Long
            Get
                Return CType(Me("MainWindowHeight"),Long)
            End Get
            Set
                Me("MainWindowHeight") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedConnectionModeMSI() As Boolean
            Get
                Return CType(Me("SavedConnectionModeMSI"),Boolean)
            End Get
            Set
                Me("SavedConnectionModeMSI") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedOpenWithNotepad() As Boolean
            Get
                Return CType(Me("SavedOpenWithNotepad"),Boolean)
            End Get
            Set
                Me("SavedOpenWithNotepad") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SavedServerAddress() As String
            Get
                Return CType(Me("SavedServerAddress"),String)
            End Get
            Set
                Me("SavedServerAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3389")>  _
        Public Property SavedServerPort() As Integer
            Get
                Return CType(Me("SavedServerPort"),Integer)
            End Get
            Set
                Me("SavedServerPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SavedAltServerAddress() As String
            Get
                Return CType(Me("SavedAltServerAddress"),String)
            End Get
            Set
                Me("SavedAltServerAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedUseRDGateway() As Boolean
            Get
                Return CType(Me("SavedUseRDGateway"),Boolean)
            End Get
            Set
                Me("SavedUseRDGateway") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SavedRDGatewayAddress() As String
            Get
                Return CType(Me("SavedRDGatewayAddress"),String)
            End Get
            Set
                Me("SavedRDGatewayAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedAttemptDirectRDGateway() As Boolean
            Get
                Return CType(Me("SavedAttemptDirectRDGateway"),Boolean)
            End Get
            Set
                Me("SavedAttemptDirectRDGateway") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SavedMSIShortcutDesktop() As Boolean
            Get
                Return CType(Me("SavedMSIShortcutDesktop"),Boolean)
            End Get
            Set
                Me("SavedMSIShortcutDesktop") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SavedMSIShortcutStart() As Boolean
            Get
                Return CType(Me("SavedMSIShortcutStart"),Boolean)
            End Get
            Set
                Me("SavedMSIShortcutStart") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedMSIShortcutStartTopLevel() As Boolean
            Get
                Return CType(Me("SavedMSIShortcutStartTopLevel"),Boolean)
            End Get
            Set
                Me("SavedMSIShortcutStartTopLevel") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property SavedUseShortcutTag() As Boolean
            Get
                Return CType(Me("SavedUseShortcutTag"),Boolean)
            End Get
            Set
                Me("SavedUseShortcutTag") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("remote")>  _
        Public Property SavedShortcutTag() As String
            Get
                Return CType(Me("SavedShortcutTag"),String)
            End Get
            Set
                Me("SavedShortcutTag") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedClientConnectionOptions() As Boolean
            Get
                Return CType(Me("SavedClientConnectionOptions"),Boolean)
            End Get
            Set
                Me("SavedClientConnectionOptions") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedCreateRAWebIcon() As Boolean
            Get
                Return CType(Me("SavedCreateRAWebIcon"),Boolean)
            End Get
            Set
                Me("SavedCreateRAWebIcon") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedMSIPerUser() As Boolean
            Get
                Return CType(Me("SavedMSIPerUser"),Boolean)
            End Get
            Set
                Me("SavedMSIPerUser") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedDisableFTA() As Boolean
            Get
                Return CType(Me("SavedDisableFTA"),Boolean)
            End Get
            Set
                Me("SavedDisableFTA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedSignRDP() As Boolean
            Get
                Return CType(Me("SavedSignRDP"),Boolean)
            End Get
            Set
                Me("SavedSignRDP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property SavedSignedAndUnsigned() As Boolean
            Get
                Return CType(Me("SavedSignedAndUnsigned"),Boolean)
            End Get
            Set
                Me("SavedSignedAndUnsigned") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SavedCertSelected() As Integer
            Get
                Return CType(Me("SavedCertSelected"),Integer)
            End Get
            Set
                Me("SavedCertSelected") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.RemoteApp_Tool.My.MySettings
            Get
                Return Global.RemoteApp_Tool.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
