﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.7.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Fonctionnalité Enregistrement automatique My.Settings"
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
         Global.System.Configuration.DefaultSettingValueAttribute("Username")>  _
        Public Property Username() As String
            Get
                Return CType(Me("Username"),String)
            End Get
            Set
                Me("Username") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0000000")>  _
        Public Property Password() As String
            Get
                Return CType(Me("Password"),String)
            End Get
            Set
                Me("Password") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FREE")>  _
        Public Property License() As String
            Get
                Return CType(Me("License"),String)
            End Get
            Set
                Me("License") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server")>  _
        Public Property server() As String
            Get
                Return CType(Me("server"),String)
            End Get
            Set
                Me("server") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property UserAccounts() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("UserAccounts"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("UserAccounts") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("E")>  _
        Public Property RexActive() As String
            Get
                Return CType(Me("RexActive"),String)
            End Get
            Set
                Me("RexActive") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("R")>  _
        Public Property GuardKey() As String
            Get
                Return CType(Me("GuardKey"),String)
            End Get
            Set
                Me("GuardKey") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property AutoLogin() As Boolean
            Get
                Return CType(Me("AutoLogin"),Boolean)
            End Get
            Set
                Me("AutoLogin") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Profil 1")>  _
        Public Property AutoLoginCombobox() As String
            Get
                Return CType(Me("AutoLoginCombobox"),String)
            End Get
            Set
                Me("AutoLoginCombobox") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property LaunchGameatprogramstart() As Boolean
            Get
                Return CType(Me("LaunchGameatprogramstart"),Boolean)
            End Get
            Set
                Me("LaunchGameatprogramstart") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Auto login with :")>  _
        Public Property AutoLogin1() As String
            Get
                Return CType(Me("AutoLogin1"),String)
            End Get
            Set
                Me("AutoLogin1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property AutoLogin2() As Boolean
            Get
                Return CType(Me("AutoLogin2"),Boolean)
            End Get
            Set
                Me("AutoLogin2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property AutoLaunchGameAuto() As Boolean
            Get
                Return CType(Me("AutoLaunchGameAuto"),Boolean)
            End Get
            Set
                Me("AutoLaunchGameAuto") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property ActivatedRex() As Boolean
            Get
                Return CType(Me("ActivatedRex"),Boolean)
            End Get
            Set
                Me("ActivatedRex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("E")>  _
        Public Property UseRex() As String
            Get
                Return CType(Me("UseRex"),String)
            End Get
            Set
                Me("UseRex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("R")>  _
        Public Property GuardKey1() As String
            Get
                Return CType(Me("GuardKey1"),String)
            End Get
            Set
                Me("GuardKey1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("30")>  _
        Public Property RefreshGametick() As String
            Get
                Return CType(Me("RefreshGametick"),String)
            End Get
            Set
                Me("RefreshGametick") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property RefreshGameAuto() As Boolean
            Get
                Return CType(Me("RefreshGameAuto"),Boolean)
            End Get
            Set
                Me("RefreshGameAuto") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MCB25() As String
            Get
                Return CType(Me("MCB25"),String)
            End Get
            Set
                Me("MCB25") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MCB50() As String
            Get
                Return CType(Me("MCB50"),String)
            End Get
            Set
                Me("MCB50") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property UCB100() As String
            Get
                Return CType(Me("UCB100"),String)
            End Get
            Set
                Me("UCB100") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SAB50() As String
            Get
                Return CType(Me("SAB50"),String)
            End Get
            Set
                Me("SAB50") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property PLT21() As String
            Get
                Return CType(Me("PLT21"),String)
            End Get
            Set
                Me("PLT21") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Xenomit() As String
            Get
                Return CType(Me("Xenomit"),String)
            End Get
            Set
                Me("Xenomit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Mine() As String
            Get
                Return CType(Me("Mine"),String)
            End Get
            Set
                Me("Mine") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Nanohull() As String
            Get
                Return CType(Me("Nanohull"),String)
            End Get
            Set
                Me("Nanohull") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Part() As String
            Get
                Return CType(Me("Part"),String)
            End Get
            Set
                Me("Part") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Logfile() As String
            Get
                Return CType(Me("Logfile"),String)
            End Get
            Set
                Me("Logfile") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property AutoUpdate() As Boolean
            Get
                Return CType(Me("AutoUpdate"),Boolean)
            End Get
            Set
                Me("AutoUpdate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Password")>  _
        Public Property Password2() As String
            Get
                Return CType(Me("Password2"),String)
            End Get
            Set
                Me("Password2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Username")>  _
        Public Property Username1() As String
            Get
                Return CType(Me("Username1"),String)
            End Get
            Set
                Me("Username1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Username")>  _
        Public Property Username2() As String
            Get
                Return CType(Me("Username2"),String)
            End Get
            Set
                Me("Username2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Password")>  _
        Public Property Password3() As String
            Get
                Return CType(Me("Password3"),String)
            End Get
            Set
                Me("Password3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Password4() As String
            Get
                Return CType(Me("Password4"),String)
            End Get
            Set
                Me("Password4") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Password")>  _
        Public Property Password1() As String
            Get
                Return CType(Me("Password1"),String)
            End Get
            Set
                Me("Password1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Username")>  _
        Public Property Username3() As String
            Get
                Return CType(Me("Username3"),String)
            End Get
            Set
                Me("Username3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Saved_Earned_stats() As Boolean
            Get
                Return CType(Me("Saved_Earned_stats"),Boolean)
            End Get
            Set
                Me("Saved_Earned_stats") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Uridium_Earned_Visual() As String
            Get
                Return CType(Me("Uridium_Earned_Visual"),String)
            End Get
            Set
                Me("Uridium_Earned_Visual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Credit_Earned_Visual() As String
            Get
                Return CType(Me("Credit_Earned_Visual"),String)
            End Get
            Set
                Me("Credit_Earned_Visual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Honor_Earned_Visual() As String
            Get
                Return CType(Me("Honor_Earned_Visual"),String)
            End Get
            Set
                Me("Honor_Earned_Visual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Experience_Earned_Visual() As String
            Get
                Return CType(Me("Experience_Earned_Visual"),String)
            End Get
            Set
                Me("Experience_Earned_Visual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property RP_Earned_Visual() As String
            Get
                Return CType(Me("RP_Earned_Visual"),String)
            End Get
            Set
                Me("RP_Earned_Visual") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Visible_Account_Valid() As Boolean
            Get
                Return CType(Me("Visible_Account_Valid"),Boolean)
            End Get
            Set
                Me("Visible_Account_Valid") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Visible_Account_Valid2() As Boolean
            Get
                Return CType(Me("Visible_Account_Valid2"),Boolean)
            End Get
            Set
                Me("Visible_Account_Valid2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Visible_Account_Valid3() As Boolean
            Get
                Return CType(Me("Visible_Account_Valid3"),Boolean)
            End Get
            Set
                Me("Visible_Account_Valid3") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("15; 91")>  _
        Public Property CollectPalladiumticks() As String
            Get
                Return CType(Me("CollectPalladiumticks"),String)
            End Get
            Set
                Me("CollectPalladiumticks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("850")>  _
        Public Property collectbonusboxticks() As String
            Get
                Return CType(Me("collectbonusboxticks"),String)
            End Get
            Set
                Me("collectbonusboxticks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("850")>  _
        Public Property collectcargosboxticks() As String
            Get
                Return CType(Me("collectcargosboxticks"),String)
            End Get
            Set
                Me("collectcargosboxticks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property prioritypalladium() As String
            Get
                Return CType(Me("prioritypalladium"),String)
            End Get
            Set
                Me("prioritypalladium") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1")>  _
        Public Property prioritybonusbox() As String
            Get
                Return CType(Me("prioritybonusbox"),String)
            End Get
            Set
                Me("prioritybonusbox") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2")>  _
        Public Property prioritycargobox() As String
            Get
                Return CType(Me("prioritycargobox"),String)
            End Get
            Set
                Me("prioritycargobox") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property checkbox_palladium() As Boolean
            Get
                Return CType(Me("checkbox_palladium"),Boolean)
            End Get
            Set
                Me("checkbox_palladium") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("H")>  _
        Public Property Desactive_all_formkey() As String
            Get
                Return CType(Me("Desactive_all_formkey"),String)
            End Get
            Set
                Me("Desactive_all_formkey") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Passive")>  _
        Public Property PET_Selection() As String
            Get
                Return CType(Me("PET_Selection"),String)
            End Get
            Set
                Me("PET_Selection") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property use_pet() As Boolean
            Get
                Return CType(Me("use_pet"),Boolean)
            End Get
            Set
                Me("use_pet") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property repair_pet_auto() As Boolean
            Get
                Return CType(Me("repair_pet_auto"),Boolean)
            End Get
            Set
                Me("repair_pet_auto") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Maximum_pet_death() As Boolean
            Get
                Return CType(Me("Maximum_pet_death"),Boolean)
            End Get
            Set
                Me("Maximum_pet_death") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("99")>  _
        Public Property Maximum_pet_death_box() As String
            Get
                Return CType(Me("Maximum_pet_death_box"),String)
            End Get
            Set
                Me("Maximum_pet_death_box") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property revive_after_x_death_pet() As Boolean
            Get
                Return CType(Me("revive_after_x_death_pet"),Boolean)
            End Get
            Set
                Me("revive_after_x_death_pet") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("999")>  _
        Public Property revive_pet_x_seconds() As String
            Get
                Return CType(Me("revive_pet_x_seconds"),String)
            End Get
            Set
                Me("revive_pet_x_seconds") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("J")>  _
        Public Property jump_key() As String
            Get
                Return CType(Me("jump_key"),String)
            End Get
            Set
                Me("jump_key") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property map_to_travel() As String
            Get
                Return CType(Me("map_to_travel"),String)
            End Get
            Set
                Me("map_to_travel") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NONE")>  _
        Public Property FIRME() As String
            Get
                Return CType(Me("FIRME"),String)
            End Get
            Set
                Me("FIRME") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Rex_dead() As String
            Get
                Return CType(Me("Rex_dead"),String)
            End Get
            Set
                Me("Rex_dead") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Repair() As String
            Get
                Return CType(Me("Repair"),String)
            End Get
            Set
                Me("Repair") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Your license here")>  _
        Public Property License_check() As String
            Get
                Return CType(Me("License_check"),String)
            End Get
            Set
                Me("License_check") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Hangar 1")>  _
        Public Property PalladiumBASE() As String
            Get
                Return CType(Me("PalladiumBASE"),String)
            End Get
            Set
                Me("PalladiumBASE") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Hangar 1")>  _
        Public Property palladiumCOLLECT() As String
            Get
                Return CType(Me("palladiumCOLLECT"),String)
            End Get
            Set
                Me("palladiumCOLLECT") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property useHANGAR_changer() As Boolean
            Get
                Return CType(Me("useHANGAR_changer"),Boolean)
            End Get
            Set
                Me("useHANGAR_changer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property Use_Changer() As Boolean
            Get
                Return CType(Me("Use_Changer"),Boolean)
            End Get
            Set
                Me("Use_Changer") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Hangar 1")>  _
        Public Property palladium53() As String
            Get
                Return CType(Me("palladium53"),String)
            End Get
            Set
                Me("palladium53") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Email")>  _
        Public Property email_license() As String
            Get
                Return CType(Me("email_license"),String)
            End Get
            Set
                Me("email_license") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Your Password")>  _
        Public Property password_license() As String
            Get
                Return CType(Me("password_license"),String)
            End Get
            Set
                Me("password_license") = value
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
        Friend ReadOnly Property Settings() As Global.DarkorbitBot.My.MySettings
            Get
                Return Global.DarkorbitBot.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
