﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3620
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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Bomberman.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property bomb() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomb", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomb_explode() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomb explode", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomb_powerup() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomb powerup", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Bomberman() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bomberman", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_1_down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman 1 down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_1_left() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman_1_left", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_1_right() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman_1_right", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_1_up() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman_1_up", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_2_down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman_2_down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_2_left() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman_2_left", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_2_right() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman_2_right", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_2_up() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman 2 up", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_block() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman block", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_brick() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman brick", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property bomberman_fire() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bomberman fire", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property Bomberman1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Bomberman1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property explode_left_right() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("explode left right", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property explode_up_down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("explode up down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
